using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using PluginInterface;

namespace WindowsFormsApp1
{
    class JSONSerializer : ISerializer
    {

        public void Serialize(List<object> o, Stream stream, IPlugin plugin = null)
        {
                       
            FileStream fs = (FileStream)stream;
            string jsonString = "";

            for (int i = 0; i < o.Count; i++)
            {
                jsonString += JsonConvert.SerializeObject(o[i], Formatting.Indented);
                if (i < o.Count - 1)
                {
                    jsonString += "$";
                }
            }

            //string encryptedString = encodeStr(jsonString);

            if(plugin == null)
            {
                fs.Write(Encoding.ASCII.GetBytes(jsonString), 0, jsonString.Length);
            }
            else
            {
                string encodedString = plugin.Encode(jsonString);
                fs.Write(Encoding.ASCII.GetBytes(encodedString), 0, encodedString.Length);
            }
            fs.Close();
        }
        public List<T> Deserialize<T>(string st, IPlugin plug = null)
        {
            string str = File.ReadAllText(st);
            List<string> lines = new List<string>();
            string s3;
            using (StreamReader streamReader = File.OpenText(st))
            {
                while ((s3 = streamReader.ReadLine()) != null)
                {
                    lines.Add(s3);
                }
            }

            if (plug != null)
            {
                str = plug.Decode(lines.ToArray());

            }
            string[] strs = str.Split('$');

            try
            {
                List<T> tList = new List<T>();

                foreach (string s in strs)
                {
                    T t = JsonConvert.DeserializeObject<T>(s);

                    tList.Add(t);
                }

                return tList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION! " + ex.Message);
                return default(List<T>);
            }

        }

        public string GetExtention()
        {
            return "json";
        }
    }
}
