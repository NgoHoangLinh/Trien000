using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace WindowsFormsApp1
{
    class ProjectContainer
    {
        public static ProjectContainer instance;
        private Dictionary<string, Form> transportDictionary = new Dictionary<string, Form>();
        private Dictionary<string, List<Transport>> transports = new Dictionary<string, List<Transport>>();
        private Dictionary<string, ISerializer> serializers = new Dictionary<string, ISerializer>();
        private Dictionary<string, Tuple<ISerializer, IPlugin>> plugins = new Dictionary<string, Tuple<ISerializer, IPlugin>>();
        private Transport currentTransport = null;

        public ProjectContainer()
        {
            instance = this;
        }

        public void putNewForm(string transportType, Form form)
        {
            if (getExistingForms(transportType) == null)
            {
                transportDictionary.Add(transportType, form);
            }
        }

        public Form getExistingForms(string transportType)
        {
            Form existingForm = null;
            if (transportDictionary.TryGetValue(transportType, out existingForm))
            {
                return existingForm;
            }
            else
            {
                return null;
            }
        }

        public void putNewSerializer(ISerializer serializer)
        {
            if (!serializers.ContainsKey(serializer.GetExtention()))
            {
                serializers.Add(serializer.GetExtention(), serializer);
            }
            else
            {
                serializers[serializer.GetExtention()] = serializer;
            }
        }

        public ISerializer getSerializer(string serial)
        {
            ISerializer serializer = null;
            if (serializers.TryGetValue(serial, out serializer))
            {
                return serializer;
            }
            else
            {
                return null;
            }
        }

        public ISerializer[] GetSerializersArray()
        {
            return serializers.Values.ToArray();
        }

        public void putNewTransports(string transportType, List<Transport> transports)
        {
            if (this.transports.ContainsKey(transportType))
            {
                this.transports[transportType] = transports;
            }
            else
            {
                this.transports.Add(transportType, transports);
            }

        }

        public List<Transport> getExistingTransport(string transportType)
        {
            List<Transport> existingTransports = null;
            if (this.transports.TryGetValue(transportType, out existingTransports))
            {
                return existingTransports;
            }
            else
            {
                return null;
            }


        }

        public void putCurrentTransport(Transport transport)
        {
            currentTransport = transport;
        }

        public Transport getCurrentTransport()
        {
            return currentTransport;
        }

        public void putNewPlugin(string key, Tuple<ISerializer, IPlugin> tuple)
        {
            if (plugins.ContainsKey(key))
            {
                plugins[key] = tuple;
            }
            else
            {
                plugins.Add(key, tuple);
            }
        }

        public Tuple<ISerializer, IPlugin> GetPluginTuple(string key)
        {
            Tuple<ISerializer, IPlugin> tuple = null;
            if (plugins.TryGetValue(key, out tuple))
            {
                return tuple;
            }
            else
            {
                return null;
            }
        }

        public Tuple<ISerializer, IPlugin>[] GetPluginTuplesArray()
        {
            return plugins.Values.ToArray();
        }
    }
}
