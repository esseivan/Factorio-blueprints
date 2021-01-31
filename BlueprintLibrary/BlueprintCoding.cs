using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlueprintLibrary
{
	public abstract class BlueprintCoding
	{
		public static string Decode(string data, out char versionTag)
		{
			versionTag = '\0';
			try
			{
				versionTag = data[0];
				return Ionic.Zlib.ZlibStream.UncompressString(Convert.FromBase64String(data.Substring(1, data.Length - 1)));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return string.Empty;
			}
		}

		public static string Encode(string data, char version = '0')
		{
			try
			{
				if (!(version >= '0' && version <= '9'))
				{
					version = '0';
				}

				return version + Convert.ToBase64String(Ionic.Zlib.ZlibStream.CompressString(data));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return string.Empty;
			}
		}

		public static XmlDocument GetDocument(string json)
		{
			return JsonConvert.DeserializeXmlNode(json);
		}

		public static string GetJson(XmlDocument document)
		{
			return JsonConvert.SerializeXmlNode(document);
		}

		public static string GetPrettyJson(string json)
		{
			return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Newtonsoft.Json.Formatting.Indented);
		}
	}
}
