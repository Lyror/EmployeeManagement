﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EMLib
{
	public static class Serialize
	{
		public static string ToBase64(object classObject)
		{
			using (var ms = new MemoryStream())
			{
				new BinaryFormatter().Serialize(ms, classObject);
				ms.Seek(0, SeekOrigin.Begin);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		public static T FromBase64<T>(String str)
		{
			using (var ms = new MemoryStream(Convert.FromBase64String(str)))
			{
				ms.Seek(0, SeekOrigin.Begin);
				return (T)new BinaryFormatter().Deserialize(ms);
			}
		}
	}
}
