using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;

namespace Base64Plugin
{
    public class Base64PluginClass : IPlugin
    {
        public void doSome()
        {

        }

        public string Encode(string input)
        {
            string base64;
            try
            {
                base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base64Encode" + exception.Message);
            }
            return base64;
        }

        public string Encode(byte[] inputBytes)
        {
            string base64;
            try
            {
                base64 = Convert.ToBase64String(inputBytes);
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base64Encode" + exception.Message);
            }
            return base64;
        }

        public string Decode(string[] encodedStrings)
        {
            byte[] data = Convert.FromBase64String(encodedStrings[0]);
            string decodedString = Encoding.UTF8.GetString(data);

            return decodedString;
        }

        public byte[] DecodeToBytes(string[] encodedStrings)
        {
            byte[] data = Convert.FromBase64String(encodedStrings[0]);

            return data;
        }


        public string GetExtention()
        {
            return "64";
        }
    }
}
