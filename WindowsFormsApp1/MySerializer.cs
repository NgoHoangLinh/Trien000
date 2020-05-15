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

        public void Serialize(List<object> o, Stream stream, IPlugin plugin = null)
        {

            StreamWriter sw = new StreamWriter(stream);
            string serialText = "";

            for (int i = 0; i < o.Count; i++)
            {
                string strObject = "";
                formObjectLine(o[i], "", ref strObject);
                serialText += strObject;
            }

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
            }

            if(plug != null)
            {
                str1 = plug.Decode(st.ToArray());
            }
            else
            {
                str1 = File.ReadAllText(str);
            }

            StringReader sr = new StringReader(str1);
            string strr;

            T obj = (T)Activator.CreateInstance(typeof(T));
            Type ObjType = obj.GetType();

            
            while ((strr = sr.ReadLine()) != null)
            {
                string lineName = "";
                string lineVal = "";

                if (strr.Contains(">") && !strr.Contains("\'"))
                {
                    lineName = strr.Replace("\t", "");
                    lineName = lineName.Replace(" ", "");
                    lineName = lineName.Replace(">", "");
                }

                if (strr.Contains(":"))
                {
                    string[] s = strr.Split(':');

                    lineName = s[0].Replace("\t", "");
                    lineName = lineName.Replace(" ", "");

                    if (s[1].Contains("\'"))
                    {
                        lineVal = strr.Split('\'')[1];
                    }
                    else
                    {
                        lineVal = s[1].Replace("\t", "");
                        lineVal = lineVal.Replace(" ", "");
                    }
                }

                if (strr.Contains("<") && !strr.Contains("\'"))
                {
                    lineName = strr.Replace("\t", "");
                    lineName = lineName.Replace(" ", "");
                    lineName = lineName.Replace("<", "");
                    if (lineName == ObjType.Name)
                    {
                        l.Add(obj);
                        obj = (T)Activator.CreateInstance(typeof(T));
                        continue;
                    }
                }

                if (lineName == ObjType.Name)
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
                            if (p.Name == lineName)
                            {
                                if (p.PropertyType.Name == "String")
                                {
                                    p.SetValue(obj, lineVal, null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Single")
                                {
                                    p.SetValue(obj, float.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Int32")
                                {
                                    p.SetValue(obj, Int32.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Int64")
                                {
                                    p.SetValue(obj, Int64.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Long")
                                {
                                    p.SetValue(obj, long.Parse(lineVal), null);
                                    break;
                                }
                            }

                        }
                        else if (lineName == p.PropertyType.Name)
                        {
                            doFind<T>(ref obj, ref sr, strr, p);
                        }
                    }
                }
            }

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

        void formObjectLine(object ob, string offset, ref string str)
        {
            Type t = ob.GetType();

            PropertyInfo[] pi = t.GetProperties();

            str += offset + Begin(t.Name);
            //Store all props
            foreach (PropertyInfo p in pi)
            {
                if (p.PropertyType.IsPrimitive || p.PropertyType == typeof(string))
                {
                    if(p.PropertyType == typeof(string))
                    {
                        str += offset + FormStringLine(p.Name, p.GetValue(ob, null).ToString());
                    }
                    else
                    {
                        str += offset + FormLine(p.Name, p.GetValue(ob, null).ToString());
                    }
                    
                }
                else
                {
                    object ob2 = p.GetValue(ob, null);
                    formObjectLine(ob2, (offset + "\t"), ref str);
                }
            }

            str += offset + End(t.Name);
        }

        string Begin(string name)
        {
            return name + " >\n";
        }

        string End(string name)
        {
            return name + " <\n";
        }

        string FormLine(string name, string value)
        {
            string s = "\t" + name + " : " + value + "\n";
            return s;
        }

        string FormStringLine(string name, string value)
        {
            string s = "\t" + name + " : '" + value + "'\n";
            return s;
        }

        void doFind<T>(ref T o, ref StringReader reader, string currentLine, PropertyInfo propInfo)
        {
            object obj = Activator.CreateInstance(propInfo.PropertyType);
            Type innerObjType = propInfo.PropertyType;
            string strr = currentLine;
            do
            {
                string lineName = "";
                string lineVal = "";
                
                if (strr.Contains(">") && !strr.Contains("\'"))
                {
                    lineName = strr.Replace("\t", "");
                    lineName = lineName.Replace(" ", "");
                    lineName = lineName.Replace(">", "");
                }

                if (strr.Contains(":"))
                {
                    string[] s = strr.Split(':');

                    lineName = s[0].Replace("\t", "");
                    lineName = lineName.Replace(" ", "");

                    if (s[1].Contains("\'"))
                    {
                        lineVal = strr.Split('\'')[1];
                    }
                    else
                    {
                        lineVal = s[1].Replace("\t", "");
                        lineVal = lineVal.Replace(" ", "");
                    }
                    
                }

                if (strr.Contains("<") && !strr.Contains("\'"))
                {
                    lineName = strr.Replace("\t", "");
                    lineName = lineName.Replace(" ", "");
                    lineName = lineName.Replace("<", "");
                    if (lineName == innerObjType.Name)
                    {
                        propInfo.SetValue(o, obj, null);
                        return;
                    }
                }

                if (lineName == innerObjType.Name)
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
                            if (p.Name == lineName)
                            {
                                if (p.PropertyType.Name == "String")
                                {
                                    p.SetValue(obj, lineVal, null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Single")
                                {
                                    p.SetValue(obj, float.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Int32")
                                {
                                    p.SetValue(obj, Int32.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Int64")
                                {
                                    p.SetValue(obj, Int64.Parse(lineVal), null);
                                    break;
                                }
                                if (p.PropertyType.Name == "Long")
                                {
                                    p.SetValue(obj, long.Parse(lineVal), null);
                                    break;
                                }
                            }

                        }
                        else if (lineName == p.PropertyType.Name)
                        {
                            doFind<object>(ref obj, ref reader, strr, p);
                        }
                    }
                }

            } while ((strr = reader.ReadLine()) != null);
            
        }

        public string GetExtention()
        {
            return "special";
        }

    }
}
