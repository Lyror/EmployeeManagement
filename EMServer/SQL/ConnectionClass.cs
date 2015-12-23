using acadGraph.Libs.ConnectionConfig;
using acadGraph.Libs.DBConnection.Connections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	class ConnectionClass
	{
		/// <summary>
		/// open a connection from the udl file.
		/// if database is mdb and model is x64 and provider is ms jet,
		/// provider will mapped to ace, if available
		/// </summary>
		/// <param name="udlFileName">Connection String</param>
		/// <returns>a open connection</returns>
		/// <exception cref="System.Exception">ace not installed</exception>
		/// <exception cref="System.Exception">config is null</exception>
		public CustomConnection CreateConnection(string udlFileName, bool isUDLFile)
		{
			var udl = new AdoUdl();
			if (isUDLFile)
				udl.Load(acadGraph.Libs.Lib.GIPath.Combine(udlFileName, "DB", GetProjectName(Path.GetFileName(udlFileName)) + ".udl"));
			else
				udl.SetConfigFromConnectionString(udlFileName);

			// mapping for mdb and x64
			if (IntPtr.Size == 8 && udl.ConnectionConfig.DBType == DBTypes.Access)
			{
				string connectionString = udl.ConnectionConfig.ConnectionString;
				string signature = AdoUdl.SignatureFromConnectionString(connectionString);

				// jet, try mapping to ace
				if (AdoUdl.GetProviderFromSignature(signature) == AdoUdl.ProvType.acessJet)
				{
					if (!IsAceInstalled(true))
						throw new Exception("Ace Driver is not installed");
					string acesignature = AdoUdl.GetSignatureFromProvider(AdoUdl.ProvType.accessAce);
					connectionString = connectionString.Replace(signature, acesignature);
					udl.SetConfigFromConnectionString(connectionString);
				}
			}

			// get config
			var config = udl.ConnectionConfig;
			if (config == null)
				throw new Exception("Connection Config is null");
			var connection = ConnectionFactory.CreateConnection(config);

			// open the connection
			ConnectionString = config.ConnectionString;
			return connection;
		}

		public String ConnectionString { get; private set; }

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyExW", SetLastError = true)]
		static extern int RegOpenKeyExW(UIntPtr hKey, string subKey, uint options, int sam, out UIntPtr phkResult);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegEnumKeyW")]
		static extern int RegEnumKeyW(UIntPtr keyBase, int index, StringBuilder nameBuffer, int bufferLength);

		[DllImport("Advapi32.dll")]
		static extern uint RegCloseKey(UIntPtr hKey);

		[DllImport("advapi32.dll", EntryPoint = "RegQueryFolderValueEx")]
		static extern int RegQueryFolderValueEx(
			UIntPtr hKey, string lpFolderValueName,
			int lpReserved,
			ref uint lpType,
			System.Text.StringBuilder lpData,
			ref uint lpcbData);
		/// <summary>
		/// check for installed Ace Driver in the registry, for x32 or x64
		/// </summary>
		/// <param name="for64Bit">for 32 Bit or for 64 Bit</param>
		/// <returns>true, if Driver installed, otherwise false</returns>
		private bool IsAceInstalled(bool for64Bit)
		{
			UIntPtr HKEY_ROOT = new UIntPtr(0x80000000u);
			const int KEY_READ = 0x20019;
			const int KEY_WOW64_64KEY = 0x0100;
			const int KEY_WOW64_32KEY = 0x0200;
			const int Success = 0;
			const string CLSID = "CLSID";
			const string PROVIDER = "OLE DB Provider";

			bool found = false;

			UIntPtr regKeyHandle = UIntPtr.Zero;
			int keyBase = for64Bit ? KEY_WOW64_64KEY : KEY_WOW64_32KEY;
			if (RegOpenKeyExW(HKEY_ROOT, CLSID, 0, KEY_READ | keyBase, out regKeyHandle) != Success)
				return false;
			try
			{
				StringBuilder buffer = new StringBuilder(2048);
				for (int i = 1; true || found; i++)
				{
					buffer.Length = 0;
					int result = RegEnumKeyW(regKeyHandle, i, buffer, buffer.Capacity);
					if (result == Success)
					{
						string clsSubKeyName = CLSID + "\\" + buffer.ToString();
						UIntPtr clsSubKey;
						if (RegOpenKeyExW(HKEY_ROOT, clsSubKeyName, 0, KEY_READ | keyBase, out clsSubKey) == Success)
						{
							try
							{
								StringBuilder buffer1 = new StringBuilder(2048);
								for (int j = 0; true || found; j++)
								{
									buffer1.Length = 0;
									int result1 = RegEnumKeyW(clsSubKey, j, buffer1, buffer1.Capacity);
									if (result1 == Success)
									{
										if (String.Compare(buffer1.ToString(), PROVIDER, true) == 0)
										{
											uint lpType = 0;
											uint lpcbData = 1024;
											StringBuilder buffer2 = new StringBuilder(1024);
											RegQueryFolderValueEx(clsSubKey, "", 0, ref lpType, buffer2, ref lpcbData);
											if (String.Compare(buffer2.ToString(), "Microsoft.ACE.OLEDB.12.0", true) == 0)
												found = true;
										}
									}
									else
										break;
								}
							}
							finally
							{
								RegCloseKey(clsSubKey);
							}

						}
						else
							break;
					}
					else
						break;
				}

			}
			finally
			{
				RegCloseKey(regKeyHandle);
			}


			return found;
		}

		private String GetProjectName(string projectPath)
		{
			string[] parts = projectPath.Split('.');
			return parts[parts.Length - 1];
		}
	}
}
