using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueprintLibrary
{
	public class BlueprintCoding
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

        public static string Encode(string data, char version)
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


	}
}
