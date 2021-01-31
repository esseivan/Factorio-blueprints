using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueprintLibrary
{
	public class Blueprint
	{
		public char version;
		public string jsonData;

		public static Blueprint CreateFromFile(string filePath)
		{
			return CreateFromData(File.ReadAllText(filePath));
		}

		public static Blueprint CreateFromData(string encodedData)
		{
			Blueprint bp = new Blueprint
			{
				jsonData = BlueprintCoding.Decode(encodedData, out char ver),
				version = ver
			};
			return bp;
		}

		public static Blueprint CreateFromJson(string jsonData, char version)
		{
			Blueprint bp = new Blueprint
			{
				jsonData = jsonData,
				version = version
			};
			return bp;
		}

	}
}
