using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlueprintLibrary
{
	public class Blueprint
	{
		public char version;
		public XmlDocument doc;

		public static Blueprint CreateFromFile(string filePath)
		{
			return CreateFromData(File.ReadAllText(filePath));
		}

		public static Blueprint CreateFromData(string encodedData)
		{
			Blueprint bp = new Blueprint
			{
				doc = BlueprintCoding.GetDocument(BlueprintCoding.Decode(encodedData, out char ver)),
				version = ver
			};
			return bp;
		}

		public static Blueprint CreateFromJson(string jsonData, char version)
		{
			Blueprint bp = new Blueprint
			{
				doc = BlueprintCoding.GetDocument(jsonData),
				version = version
			};
			return bp;
		}

		public void Compress()
		{
			var bpNode = doc.FirstChild;
			var entities = bpNode.SelectNodes("entities");

			List<XmlElement> combinators = new List<XmlElement>();
			foreach (XmlElement entity in entities)
			{
				var name = entity.SelectSingleNode("name");
				if (name.InnerText.Contains("combinator"))
					combinators.Add(entity);
			}

			Console.WriteLine(string.Join("\n", combinators.Select((x) => x.SelectSingleNode("name").InnerText)));

			// Set all directions to 2
			combinators.ForEach((x) => x.SelectSingleNode("direction").InnerText = "1");


		}
	}
}
