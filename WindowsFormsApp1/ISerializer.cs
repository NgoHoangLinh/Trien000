using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface ISerializer
    {
        void Serialize(List<object> o, Stream stream, IPlugin plugin = null);
        List<T> Deserialize<T>(string str, IPlugin plug = null);
        string GetExtention();
    }
}
