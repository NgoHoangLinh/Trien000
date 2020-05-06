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
        public static Dictionary<string, Form> transportDictionary = new Dictionary<string, Form>();
        public static Dictionary<string, List<Transport>> transports = new Dictionary<string, List<Transport>>();
        public static Dictionary<string, ISerializer> serializers = new Dictionary<string, ISerializer>();
        public static Dictionary<string, Tuple<ISerializer, IPlugin>> plugins = new Dictionary<string, Tuple<ISerializer, IPlugin>>();
        public static Transport currentTransport = null;

        public ProjectContainer()
        {
            instance = this;
        }

        public void putNewForm(string transportType, Form form)
        {
            ProjectContainer.transportDictionary.Add(transportType, form);
        }

        public Form getExistingForms(string transportType)
        {
            Form existingForm = null;
            if (ProjectContainer.transportDictionary.TryGetValue(transportType, out existingForm))
            {
                return existingForm;
            }
            else
            {
                return null;
            }


        }

        public void putNewTransports(string transportType, List<Transport> transports)
        {
            if (ProjectContainer.transports.ContainsKey(transportType))
            {
                ProjectContainer.transports[transportType] = transports;
            }
            else
            {
                ProjectContainer.transports.Add(transportType, transports);
            }

        }

        public List<Transport> getExistingTransport(string transportType)
        {
            List<Transport> existingTransports = null;
            if (ProjectContainer.transports.TryGetValue(transportType, out existingTransports))
            {
                return existingTransports;
            }
            else
            {
                return null;
            }


        }
    }
}
