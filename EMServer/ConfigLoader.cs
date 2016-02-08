using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EMServer
{
	internal static class ConfigLoader
	{
		private static readonly string ConfigPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Config.xml");

		internal static string LoadConnectionString()
		{
			return GetFile().Root.Element("ConnectionString").Value;
		}

		private static XDocument GetFile()
		{
			return File.Exists(ConfigPath) ? XDocument.Load(ConfigPath) : null;
		}

		internal static void Save(string connectionString)
		{
			XDocument doc = new XDocument(new XElement("Config"));
			doc.Root.Add(new XElement("ConnectionString", connectionString));
			doc.Save(ConfigPath);
		}
	}
}
