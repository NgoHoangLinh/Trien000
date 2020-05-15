using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class EditPlanesForm : Form
    {
        Form form;
        string bitmapPath = "";
        bool transportAddedShowEnabled = false;
        public EditPlanesForm(Form formSender)
        {
            InitializeComponent();
            form = formSender;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int capacity = 0, weight = 0, numWings = 0;
            Plane a = new Plane();
            float height = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out capacity) && Int32.TryParse(weightTextBox.Text, out weight) &&
                Int32.TryParse(numWingsTextBox.Text, out numWings) && float.TryParse(heightTextBox.Text, out height))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport(a.GetType().Name);
                if (t != null)
                {
                    foreach (Transport tr in t)
                    {
                        if (tr.getTransportName() == planeNameTextBox.Text)
                        {
                            try
                            {
                                a = (Plane)tr;
                                a.capacity = capacity;
                                a.transportBitmap = (Bitmap)planePictureBox.Image;
                                a._bitmapPath = bitmapPath;
                                a._weight = weight;
                                a._height = height;
                                a._numWings = numWings;
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
                a = new Plane(bitmapPath, planeNameTextBox.Text, capacity, weight, numWings, height);
                a.transportBitmap = (Bitmap)planePictureBox.Image;
                ProjectContainer.instance.putNewTransports(a.GetType().Name, a.getList());
                form.Enabled = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect parameters!");
            }
        }

        private void EditPlanesForm_VisibleChanged(object sender, EventArgs e)
        {
            Transport tr = ProjectContainer.instance.getCurrentTransport();
            if (tr != null)
            {
                Plane a = (Plane)tr;
                planeNameTextBox.Text = a.getTransportName();
                planeNameTextBox.ReadOnly = true;
                planePictureBox.Image = a.getTransportBitmap();
                capacityTextBox.Text = a.capacity.ToString();
                numWingsTextBox.Text = a._numWings.ToString();
                heightTextBox.Text = a._height.ToString();
                weightTextBox.Text = a._weight.ToString();
            }
            else
            {
                planeNameTextBox.Text = "";
                planeNameTextBox.ReadOnly = false;
                planePictureBox.Image = null;
                capacityTextBox.Text = "";
                numWingsTextBox.Text = "";
                heightTextBox.Text = "";
                weightTextBox.Text = "";
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            openPhotosDialog.ShowDialog();
        }

        private void openPhotosDialog_FileOk(object sender, CancelEventArgs e)
        {
            planePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            planePictureBox.Image = new Bitmap(openPhotosDialog.FileName);
            bitmapPath = openPhotosDialog.FileName;
        }

        private void loadTransportButton_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            openFileDialog.Title = "Open Text File";

            Tuple<ISerializer, IPlugin>[] plugins = ProjectContainer.instance.GetPluginTuplesArray();
            string s2 = "";
            foreach (Tuple<ISerializer, IPlugin> tuple in plugins)
            {
                s2 += "|" + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() + " files (*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() +
                    ")|*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention();
            }

            openFileDialog.Filter = "JSON files|*.json|Binary files|*.binar|Special files|*.special";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    string[] st = openFileDialog.FileName.Split('.');

                    ISerializer serializer = ProjectContainer.instance.getSerializer(st[st.Length - 1]);

                    List<Plane> a;

                    //null - если используется плагин
                    if (serializer == null)
                    {
                        Tuple<ISerializer, IPlugin> tuple = ProjectContainer.instance.GetPluginTuple(st[st.Length - 1]);
                        serializer = tuple.Item1;
                        IPlugin plug = tuple.Item2;

                        a = serializer.Deserialize<Plane>(openFileDialog.FileName, plug);
                    }
                    else
                    {
                        a = serializer.Deserialize<Plane>(openFileDialog.FileName);
                    }

                    if (a != null)
                    {
                        foreach (Plane au in a)
                        {
                            bool isAdd = true;
                            foreach (Transport transport in Plane.planes)
                            {
                                if (au.getTransportName() == transport.getTransportName())
                                {
                                    isAdd = false;
                                }
                            }
                            if (isAdd)
                            {
                                Plane.planes.Add(au);
                            }
                        }

                        List<Transport> transports = new List<Transport>(a);
                        ProjectContainer.instance.putNewTransports(plane.GetType().Name, Plane.planes);

                        planeNameTextBox.Text = a[a.Count - 1].getTransportName();
                        planeNameTextBox.ReadOnly = false;
                        for (int i = 0; i < a.Count; i++)
                        {
                            if (a[i]._bitmapPath != "")
                            {
                                a[i].transportBitmap = new Bitmap(a[i]._bitmapPath);
                            }
                        }
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            planePictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
                            bitmapPath = a[a.Count - 1]._bitmapPath;
                        }
                        else
                        {
                            planePictureBox.Image = null;
                        }
                        capacityTextBox.Text = a[a.Count - 1]._capasity.ToString();
                        heightTextBox.Text = a[a.Count - 1]._height.ToString();
                        numWingsTextBox.Text = a[a.Count - 1]._numWings.ToString();
                        weightTextBox.Text = a[a.Count - 1]._weight.ToString();
                        transportAddedShowEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Can not get " + plane.GetType().Name + " from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of " + plane.GetType().Name + " was added");
            }
        }

        private void EditPlanesForm_FormClosing(object sender, FormClosingEventArgs e)
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
