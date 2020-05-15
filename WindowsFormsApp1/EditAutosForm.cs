using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PluginInterface;

namespace WindowsFormsApp1
{
    public partial class EditAutosForm : Form
    {
        Form form;
        string bitmapPath = "";
        bool transportAddedShowEnabled = false;
        public EditAutosForm(Form formSender)
        {
            InitializeComponent();
            form = formSender;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int i = 0, weight = 0;
            Auto a = new Auto();
            int k = 0;
            float f = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out i) && Int32.TryParse(weightTextBox.Text, out weight))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport(a.GetType().Name);
                if (t != null)
                {
                    foreach (Transport tr in t)
                    {
                        if (tr.getTransportName() == brandTextBox.Text)
                        {
                            try
                            {
                                a = (Auto)tr;
                                a.capacity = i;
                                a.transportBitmap = (Bitmap)autoPictureBox.Image;
                                a._bitmapPath = bitmapPath;
                                a._weight = weight;
                                if (Int32.TryParse(quantityWheelsTextBox.Text, out k) && (float.TryParse(diameterWheelsTextBox.Text, out f)))
                                {
                                    a.SetWheels(k, f, tireWheelsTextBox.Text);
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect wheels input parameters!!");
                                    return;
                                }
                                ProjectContainer.instance.putNewTransports(a.GetType().Name, a.getList());
                                form.Enabled = true;
                                this.Visible = false;
                                return;
                            }
                            catch (Exception exc)
                            {
                                exc.ToString();
                                MessageBox.Show("The form does not suit!");
                            }

                        }
                    }

                }
                if (Int32.TryParse(quantityWheelsTextBox.Text, out k) && (float.TryParse(diameterWheelsTextBox.Text, out f))) {
                    Wheels wheels = new Wheels(k, f, tireWheelsTextBox.Text);
                    a = new Auto(brandTextBox.Text, i, bitmapPath, weight, wheels);
                    a.transportBitmap = (Bitmap)autoPictureBox.Image;
                    ProjectContainer.instance.putNewTransports(a.GetType().Name, a.getList());
                    form.Enabled = true;
                    this.Visible = false;
                }
                else 
                {
                    MessageBox.Show("Incorrect wheels input parameters!!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect passengers number or auto weight");
            }
        }

        private void EditAutosForm_VisibleChanged(object sender, EventArgs e)
        {
            Transport tr = ProjectContainer.instance.getCurrentTransport();
            if (tr != null)
            {
                Auto a = (Auto)tr;
                brandTextBox.Text = a.getTransportName();
                brandTextBox.ReadOnly = true;
                autoPictureBox.Image = a.getTransportBitmap();
                capacityTextBox.Text = a.capacity.ToString();
                quantityWheelsTextBox.Text = a._wheels._quantity.ToString();
                diameterWheelsTextBox.Text = a._wheels._diameter.ToString();
                tireWheelsTextBox.Text = a._wheels._typeTire.ToString();
                weightTextBox.Text = a._weight.ToString();
                loadTransportButton.Enabled = false;
            }
            else
            {
                brandTextBox.Text = "";
                brandTextBox.ReadOnly = false;
                autoPictureBox.Image = null;
                capacityTextBox.Text = "";
                quantityWheelsTextBox.Text = "";
                diameterWheelsTextBox.Text = "";
                tireWheelsTextBox.Text = "";
                weightTextBox.Text = "";
                loadTransportButton.Enabled = true;
            }

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            openPhotosDialog.ShowDialog();
        }

        private void openPhotosDialog_FileOk(object sender, CancelEventArgs e)
        {
            autoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            autoPictureBox.Image = new Bitmap(openPhotosDialog.FileName);
            bitmapPath = openPhotosDialog.FileName;
        }

        private void loadTransportButton_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            openFileDialog.Title = "Open Text File";

            Tuple<ISerializer, IPlugin>[] plugins = ProjectContainer.instance.GetPluginTuplesArray();
            string s2 = "";
            foreach (Tuple<ISerializer, IPlugin> tuple in plugins)
            {
                s2 += "|" + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() + " files (*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() +
                    ")|*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention();
            }

            openFileDialog.Filter = "JSON files|*.json|Binary files|*.binar|Special files|*.special" + s2;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    string[] st = openFileDialog.FileName.Split('.');
                    List<Auto> a;
                    ISerializer serializer = ProjectContainer.instance.getSerializer(st[st.Length - 1]);

                    //null - если используется плагин
                    if (serializer == null) 
                    {
                        Tuple<ISerializer, IPlugin> tuple = ProjectContainer.instance.GetPluginTuple(st[st.Length - 1]);
                        serializer = tuple.Item1;
                        IPlugin plug = tuple.Item2;

                        a = serializer.Deserialize<Auto>(openFileDialog.FileName, plug);
                    }
                    else
                    {
                        a = serializer.Deserialize<Auto>(openFileDialog.FileName);
                    }
                    

                    if (a != null)
                    {
                        foreach (Auto au in a)
                        {
                            bool isAdd = true;
                            foreach (Transport transport in Auto.autos)
                            {
                                if(au.getTransportName() == transport.getTransportName())
                                {
                                    isAdd = false;
                                }
                            }
                            if (isAdd)
                            {
                                Auto.autos.Add(au);
                            }
                        }

                        List<Transport> transports = new List<Transport>(a);
                        ProjectContainer.instance.putNewTransports(auto.GetType().Name, Auto.autos);

                        brandTextBox.Text = a[a.Count - 1].getTransportName();
                        brandTextBox.ReadOnly = false;
                        for(int i = 0; i < a.Count; i++)
                        {
                            if (a[i]._bitmapPath != "")
                            {
                                a[i].transportBitmap = new Bitmap(a[i]._bitmapPath);
                            }
                        }
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            autoPictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
                            bitmapPath = a[a.Count - 1]._bitmapPath;
                        }
                        else
                        {
                            autoPictureBox.Image = null;
                        }
                        capacityTextBox.Text = a[a.Count - 1]._capasity.ToString();
                        quantityWheelsTextBox.Text = a[a.Count - 1]._wheels._quantity.ToString();
                        diameterWheelsTextBox.Text = a[a.Count - 1]._wheels._diameter.ToString();
                        tireWheelsTextBox.Text = a[a.Count - 1]._wheels._typeTire.ToString();
                        weightTextBox.Text = a[a.Count - 1]._weight.ToString();
                        transportAddedShowEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Can not get " + auto.GetType().Name + " from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of " + auto.GetType().Name + " was added");
            }

        }

        private void EditAutosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Enabled = true;
                Hide();
            }
        }
    }
}
