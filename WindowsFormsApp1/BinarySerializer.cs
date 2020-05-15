using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using PluginInterface;

namespace WindowsFormsApp1
{
    class BinarySerializer : ISerializer
    {

        public void Serialize(List<object> o, Stream stream, IPlugin plugin = null)
        {
            object[] objs = o.ToArray();
            
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = (FileStream)stream;

            if (plugin != null)
            {
                var memoryStream = new MemoryStream();
                using (memoryStream)
                {
                    formatter.Serialize(memoryStream, objs);
                }
                string encodedString = plugin.Encode(memoryStream.ToArray());

                fs.Write(Encoding.ASCII.GetBytes(encodedString), 0, encodedString.Length);
            }
            else
            {
                formatter.Serialize(fs, objs);
            }

            fs.Close();
        }
        public List<T> Deserialize<T>(string str, IPlugin plug = null)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                List<T> tList = new List<T>();
                object[] objs;

                using (FileStream fs = new FileStream(str, FileMode.OpenOrCreate))
                {
                    if(plug != null)
                    {
                        List<string> fileContents = new List<string>();
                        string s3;
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            while ((s3 = reader.ReadLine()) != null)
                            {
                                fileContents.Add(s3);
                            }
                        }
                        byte[] data = plug.DecodeToBytes(fileContents.ToArray());
                        Stream stream = new MemoryStream(data);
                        objs = (object[])formatter.Deserialize(stream);
                    }
                    else
                    {
                        objs = (object[])formatter.Deserialize(fs);
                    }
                }

                foreach(object ob in objs)
                {
                    tList.Add((T)ob);
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
            return "binar";
        }
    }
}
