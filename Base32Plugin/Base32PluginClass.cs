using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;
using Wiry.Base32;

namespace Base32Plugin
{
    public class Base32PluginClass : IPlugin
    {

        public string Encode(string input)
        {
            string base32;
            try
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                base32 = Base32Encoding.Standard.GetString(inputBytes);
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base32Encode" + exception.Message);
            }
            return base32;
        }

        public string Encode(byte[] inputBytes)
        {
            string base32;
            try
            {
                base32 = Base32Encoding.Standard.GetString(inputBytes);
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base32Encode" + exception.Message);
            }
            return base32;
        }

        public string Decode(string[] s)
        {

            byte[] decodedBase32 = Base32Encoding.Standard.ToBytes(s[0]);
            string decodedString = Encoding.UTF8.GetString(decodedBase32);

            return decodedString;
        }

        public byte[] DecodeToBytes(string[] encodedStrings)
        {
            byte[] decodedBase32 = Base32Encoding.Standard.ToBytes(encodedStrings[0]);

            return decodedBase32;
        }

        public string GetExtention()
        {
            return "32";
        }
    }
}
