using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PluginInterface;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance = null;
        private readonly string pluginPath = Path.Combine(Directory.GetCurrentDirectory(),"Plugins");

        public Form1()
        {
            instance = this;
            new ProjectContainer();

            ProjectContainer.instance.putNewSerializer(new JSONSerializer());
            ProjectContainer.instance.putNewSerializer(new BinarySerializer());
            ProjectContainer.instance.putNewSerializer(new MySerializer());

            RefreshPlugins();

            InitializeComponent();

            transportTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            InitTransport(new Auto().GetType().Name, new EditAutosForm(this));
            InitTransport(new Train().GetType().Name, new EditTrainsForm(this));
            InitTransport(new HandBoat().GetType().Name, new EditHandBoatsForm(this));
            InitTransport(new MotorBoat().GetType().Name, new EditMotorBoatsForm(this));
            InitTransport(new Plane().GetType().Name, new EditPlanesForm(this));
            InitTransport(new Helicopter().GetType().Name, new EditHelicoptersForm(this));

        }

        private void InitTransport(string transportType, Form transportForm)
        {
            ProjectContainer.instance.putNewForm(transportType, transportForm);
            transportTypeComboBox.Items.Add(transportType);
        }

        private void transportCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (transportCheckedListBox.SelectedItem != null)
            {
                panelTitle.Text = transportCheckedListBox.SelectedItem.ToString();
                List<Transport> transports = ProjectContainer.instance.getExistingTransport(transportTypeComboBox.SelectedItem.ToString());
                
                if (transports != null)
                {
                    foreach (Transport tr in transports)
                    {
                        if (tr.getTransportName() == transportCheckedListBox.SelectedItem.ToString())
                        {
                            ProjectContainer.instance.putCurrentTransport(tr);
                            pictureBox1.Image = tr.getTransportBitmap();
                            transportFieldsListBox.Items.Clear();
                            transportFieldsListBox.Items.AddRange(tr.getAllFieldsAsStringList().ToArray());
                            break;
                        }
                    }
                }
                panel1.Visible = true;
            }
        }

        private void transportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transportCheckedListBox.Items.Clear();
            addButton.Enabled = true;
            panel1.Visible = false;

            List<Transport> transports = ProjectContainer.instance.getExistingTransport(transportTypeComboBox.SelectedItem.ToString());

            if (transports != null)
            {
                foreach (Transport tr in transports)
                {
                    transportCheckedListBox.Items.Add(tr.getTransportName());
                }
            }
            ProjectContainer.instance.putCurrentTransport(null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProjectContainer.instance.putCurrentTransport(null);
            Form f = ProjectContainer.instance.getExistingForms(transportTypeComboBox.SelectedItem.ToString());
            
            if (f != null)
            {
                f.Visible = true;
                Enabled = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form f = ProjectContainer.instance.getExistingForms(transportTypeComboBox.SelectedItem.ToString());
            if (f != null)
            {
                f.Visible = true;
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Form does not exists!");
            }
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            transportCheckedListBox.Items.Clear();
            panel1.Visible = false;

            List<Transport> transports = ProjectContainer.instance.getExistingTransport(transportTypeComboBox.SelectedItem.ToString());

            if (transports != null)
            {
                foreach (Transport tr in transports)
                {
                    transportCheckedListBox.Items.Add(tr.getTransportName());
                }
            }

            saveButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedTransports = transportCheckedListBox.CheckedItems;

            if (checkedTransports != null && checkedTransports.Count > 0) {
                panel1.Visible = false;
                List<Transport> newTransports = new List<Transport>();
                string transportType = transportTypeComboBox.SelectedItem.ToString();
                foreach (object obj in checkedTransports)
                {
                    deleteCheckedTransport(transportType, obj.ToString());
                }

                transportCheckedListBox.Items.Clear();
                newTransports = ProjectContainer.instance.getExistingTransport(transportType);
                foreach (Transport tran in newTransports)
                {
                    transportCheckedListBox.Items.Add(tran.getTransportName());
                }
                ProjectContainer.instance.putCurrentTransport(null);
            }
            if (transportCheckedListBox.CheckedItems.Count == 0)
            {
                saveButton.Enabled = false;
            }

        }
        void deleteCheckedTransport(string transportType, string transportName)
        {
            List<Transport> transports = ProjectContainer.instance.getExistingTransport(transportType);
            List<Transport> newTransports = new List<Transport>();

            if (transports != null)
            {
                foreach (Transport tr in transports)
                {
                    if (tr.getTransportName() == transportName)
                    {
                        tr.removeTransportFromList(tr.getTransportName());
                        continue;
                    }
                    else
                    {
                        newTransports.Add(tr);
                    }
                }
                ProjectContainer.instance.putNewTransports(transportType, newTransports);
                
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<Transport> transports = null;
            List<object> checkedTransport = new List<object>();
            List<string> checkedTransportNames = new List<string>();
            
            for(int i = 0; i < transportCheckedListBox.CheckedItems.Count; i++)
            {
                checkedTransportNames.Add(transportCheckedListBox.CheckedItems[i].ToString());
            }

            transports = ProjectContainer.instance.getExistingTransport(transportTypeComboBox.SelectedItem.ToString());
            
            if(transports != null)
            {
                foreach (Transport tr in transports)
                {
                    if (checkedTransportNames.Contains(tr.getTransportName()))
                    {
                        checkedTransport.Add(tr);
                    }
                }
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            /*
            (JSONSerializer, Base64Plugin) --> tuple1
            (BinarySerializer, Base64Plugin) --> tuple2
            (MySerializer, Base64Plugin) --> tuple3
            */
            Tuple<ISerializer, IPlugin>[] tuples = ProjectContainer.instance.GetPluginTuplesArray();
            string s2 = "";

            // "|json64 files (*.json64)|*.json64"
            foreach(Tuple<ISerializer, IPlugin> tuple in tuples)
            {
                s2 += "|" + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() + " files (*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() + 
                    ")|*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention();
            }

            saveFileDialog1.Filter = "JSON files (*.json)|*.json|Binary files (*.binar)|*.binar|Special files (*.special)|*.special" + s2;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string ext = Path.GetExtension(saveFileDialog1.FileName);
                string[] ext2 = ext.Split('.');
                ISerializer serializer = ProjectContainer.instance.getSerializer(ext2[ext2.Length - 1]);

                if (serializer != null)
                {
                    Stream myStream;
                    if ((myStream = saveFileDialog1.OpenFile()) != null &&
                        saveFileDialog1.FileName != "" &&
                        checkedTransport.Count != 0)
                    {
                        serializer.Serialize(checkedTransport, myStream);
                    }
                }
                else
                {
                    Tuple<ISerializer, IPlugin> tuple = ProjectContainer.instance.GetPluginTuple(ext2[ext2.Length - 1]);
                    ISerializer serial = tuple.Item1;
                    IPlugin plug = tuple.Item2;

                    Stream myStream;
                    if ((myStream = saveFileDialog1.OpenFile()) != null &&
                        saveFileDialog1.FileName != "" &&
                        checkedTransport.Count != 0)
                    {
                        serial.Serialize(checkedTransport, myStream, plug);
                    }
                }
            }
            
        }

        
        private void transportCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                saveButton.Enabled = true;
            }
            else if(transportCheckedListBox.CheckedItems.Count == 1)
            {
                saveButton.Enabled = false;
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < transportCheckedListBox.Items.Count; i++)
            {
                transportCheckedListBox.SetItemChecked(i, selectAllCheckBox.Checked);
            }
        }

        private void RefreshPlugins()
        {
            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();

            //берем из директории все файлы с расширением .dll      
            var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                //загружаем сборку
                Assembly asm = Assembly.LoadFrom(file);
                //ищем типы, имплементирующие наш интерфейс IPlugin,
                //чтобы не захватить лишнего
                var types = asm.GetTypes().
                                Where(t => t.GetInterfaces().
                                Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as IPlugin;

                    ISerializer[] serials = ProjectContainer.instance.GetSerializersArray();
                    foreach(ISerializer se in serials)
                    {
                        ProjectContainer.instance.putNewPlugin(se.GetExtention() + plugin.GetExtention(), new Tuple<ISerializer, IPlugin>(se, plugin));
                    }
                }
            }
        }

        private void loadPluginButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open plugin file";
            openFileDialog.Filter = "Plugin files|*.dll";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Assembly asm = Assembly.LoadFrom(openFileDialog.FileName);

                //ищем типы, имплементирующие наш интерфейс IPlugin,
                //чтобы не захватить лишнего
                var types = asm.GetTypes().
                                Where(t => t.GetInterfaces().
                                Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as IPlugin;

                    ISerializer[] serials = ProjectContainer.instance.GetSerializersArray();
                    foreach (ISerializer se in serials)
                    {
                        ProjectContainer.instance.putNewPlugin(se.GetExtention() + plugin.GetExtention(), new Tuple<ISerializer, IPlugin>(se, plugin));
                    }
                }
            }
        }
    }
}
