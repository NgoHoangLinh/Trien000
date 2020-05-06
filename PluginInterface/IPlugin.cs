using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Encode(string input);

        string Encode(byte[] inputBytes);

        string Decode(string[] s);

        byte[] DecodeToBytes(string[] s);

        string GetExtention();
    }
}
