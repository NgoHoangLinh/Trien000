using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    class MySerializer : ISerializer
    {
        public MySerializer()
        {
            if (!ProjectContainer.serializers.ContainsKey(ToString()))
            {
                ProjectContainer.serializers.Add(ToString(), this);
            }

        }

        public void Serialize(List<object> o, Stream stream, IPlugin plugin = null)
        {

            StreamWriter sw = new StreamWriter(stream);
            string serialText = "";
            serialText += "<List>\n";

            for (int i = 0; i < o.Count; i++)
            {
                string strObject = "";
                formLine(o[i], "\t", ref strObject);
                serialText += strObject;
            }

            serialText += "</List>";

            if(plugin != null)
            {
                sw.WriteLine(plugin.Encode(serialText));
            }
            else
            {
                sw.WriteLine(serialText);
            }

            sw.Close();

        }
        public List<T> Deserialize<T>(string str, IPlugin plug = null)
        {
            bool isCorrectType = false;
            List<T> l = new List<T>();
            List<string> st = new List<string>();
            string s3;
            string str1;
            using (StreamReader streamReader = File.OpenText(str))
            {
                while((s3 = streamReader.ReadLine()) != null)
                {
                    st.Add(s3);
                }
                //если читать весь файл, то Base32 ломается, т.к. читается и переход на новую строку
            }//НО! если обработчику нужно будет больше одной строки, то всё СЛОМАЕТСЯ! Поэтому считываем по одной линии и формируем массив

            if(plug != null)
            {
                str1 = plug.Decode(st.ToArray());
            }
            else
            {
                str1 = File.ReadAllText(str);
            }

            StringReader sr = new StringReader(str1);

            XmlReader reader = XmlReader.Create(sr);

            T obj = (T)Activator.CreateInstance(typeof(T));
            Type ObjType = obj.GetType();

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == ObjType.Name)
                    {
                        isCorrectType = true;
                    }
                    else
                    {
                        PropertyInfo[] pi = ObjType.GetProperties();
                        foreach (PropertyInfo p in pi)
                        {
                            if ((p.PropertyType.IsPrimitive || p.PropertyType.Name == "String" ||
                                p.PropertyType.Name == "Int32" || p.PropertyType.Name == "Int64" ||
                                p.PropertyType.Name == "Long" || p.PropertyType.Name == "Single"))
                            {
                                if (p.Name == reader.Name)
                                {
                                    reader.Read();
                                    //Read the text content of the element.

                                    if (p.PropertyType.Name == "String")
                                    {
                                        p.SetValue(obj, reader.ReadString(), null);
                                    }
                                    if (p.PropertyType.Name == "Single")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsFloat(), null);
                                    }
                                    if (p.PropertyType.Name == "Int32")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsInt(), null);
                                    }
                                    if (p.PropertyType.Name == "Int64")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsInt(), null);
                                    }
                                    if (p.PropertyType.Name == "Long")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsLong(), null);
                                    }
                                }
                                
                            }
                            else if(reader.Name == p.PropertyType.Name)
                            {
                                doFind<T>(ref obj, ref reader, p);
                                reader.Read();
                            }
                        }
                    }
                }
                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == ObjType.Name)
                {
                    l.Add(obj);

                    obj = (T)Activator.CreateInstance(typeof(T));
                    ObjType = obj.GetType();
                }
            }
            reader.Close();
            sr.Close();

            if (isCorrectType)
            {
                return l;
            }
            else
            {
                return default(List<T>);
            }
        }

        void formLine(object ob, string offset, ref string str)
        {
            Type t = ob.GetType();

            PropertyInfo[] pi = t.GetProperties();

            str += offset + Begin(t.Name);
            //Store all props
            foreach (PropertyInfo p in pi)
            {
                if (p.PropertyType.IsPrimitive || p.PropertyType == typeof(string))
                {
                    str += offset + FormXmlLine(p.Name, p.GetValue(ob, null).ToString());
                }
                else
                {
                    object ob2 = p.GetValue(ob, null);
                    formLine(ob2, (offset + "\t"), ref str);
                }
            }

            str += offset + End(t.Name);
        }

        string Begin(string name)
        {
            return "<" + name + ">\n";
        }

        string End(string name)
        {
            return "</" +name + ">\n";
        }

        string FormXmlLine(string name, string value)
        {
            string s = "\t<" + name + ">" + value + "</" + name + ">\n";
            return s;
        }

        List<string> getInnerTypes<T>()
        {
            T obj = (T)Activator.CreateInstance(typeof(T));
            Type ObjType = obj.GetType();
            List<string> innerTypes = new List<string>();

            PropertyInfo[] pi = ObjType.GetProperties();

            foreach(PropertyInfo p in pi)
            {
                if (!p.PropertyType.IsPrimitive || p.PropertyType.Name == "String")
                {
                    innerTypes.Add(p.PropertyType.Name);
                }
            }

            return innerTypes;
        }

        void doFind<T>(ref T o, ref XmlReader reader, PropertyInfo propInfo)
        {
            object obj = Activator.CreateInstance(propInfo.PropertyType);
            Type innerObjType = propInfo.PropertyType;

            do
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == innerObjType.Name)
                    {

                    }
                    else
                    {
                        PropertyInfo[] pi = innerObjType.GetProperties();
                        foreach (PropertyInfo p in pi)
                        {
                            if ((p.PropertyType.IsPrimitive || p.PropertyType.Name == "String" ||
                                p.PropertyType.Name == "Int32" || p.PropertyType.Name == "Int64" ||
                                p.PropertyType.Name == "Long" || p.PropertyType.Name == "Single")
                                )
                            {
                                if (p.Name == reader.Name)
                                {
                                    reader.Read();
                                    //Read the text content of the element.

                                    if (p.PropertyType.Name == "String")
                                    {
                                        p.SetValue(obj, reader.ReadString(), null);
                                    }
                                    if (p.PropertyType.Name == "Single")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsFloat(), null);
                                    }
                                    if (p.PropertyType.Name == "Int32")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsInt(), null);
                                    }
                                    if (p.PropertyType.Name == "Int64")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsInt(), null);
                                    }
                                    if (p.PropertyType.Name == "Long")
                                    {
                                        p.SetValue(obj, reader.ReadContentAsLong(), null);
                                    }
                                }
                                
                            }
                            else if (reader.Name == p.PropertyType.Name)
                            {
                                doFind<object>(ref obj, ref reader, p);
                            }
                        }
                    }
                }
                if(reader.NodeType == XmlNodeType.EndElement && reader.Name == innerObjType.Name)
                {
                    propInfo.SetValue(o, obj, null);
                    return;
                }
            } while (reader.Read());
            
        }

        public override string ToString()
        {
            return "special";
        }

    }
}
