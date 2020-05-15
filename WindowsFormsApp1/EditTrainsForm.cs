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
    public partial class EditTrainsForm : Form
    {
        Form form;
        string bitmapPath = "";
        bool transportAddedShowEnabled = false;
        public EditTrainsForm(Form formSender)
        {
            InitializeComponent();
            form = formSender;
        }


        private void openPhotosDialog_FileOk(object sender, CancelEventArgs e)
        {
            trainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            trainPictureBox.Image = new Bitmap(openPhotosDialog.FileName);
            bitmapPath = openPhotosDialog.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int i = 0, weight = 0, carriageNum = 0;
            Train a = new Train();
            int k = 0;
            float f = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out i) && Int32.TryParse(weightTextBox.Text, out weight) &&
                Int32.TryParse(carriageTextBox.Text, out carriageNum))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport(a.GetType().Name);
                if (t != null)
                {
                    foreach (Transport tr in t)
                    {
                        if (tr.getTransportName() == routeTextBox.Text)
                        {
                            try
                            {
                                a = (Train)tr;
                                a.capacity = i;
                                a.transportBitmap = (Bitmap)trainPictureBox.Image;
                                a._bitmapPath = bitmapPath; //TODO bitmapPath <-- пустой
                                a._weight = weight;
                                a.numCarriage = carriageNum;
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
                if (Int32.TryParse(quantityWheelsTextBox.Text, out k) && (float.TryParse(diameterWheelsTextBox.Text, out f)))
                {

                    Wheels wheels = new Wheels(k, f, tireWheelsTextBox.Text);
                    a = new Train(routeTextBox.Text, bitmapPath, i, weight, carriageNum, wheels);
                    a.transportBitmap = (Bitmap)trainPictureBox.Image;
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
                MessageBox.Show("Incorrect passengers number or weight or number of carriages!");
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            openPhotosDialog.ShowDialog();
        }

        private void EditTrainsForm_VisibleChanged(object sender, EventArgs e)
        {
            Transport tr = ProjectContainer.instance.getCurrentTransport();
            if (tr != null)
            {
                Train a = (Train)tr;
                routeTextBox.Text = a.getTransportName();
                routeTextBox.ReadOnly = true;
                trainPictureBox.Image = a.getTransportBitmap();
                capacityTextBox.Text = a.capacity.ToString();
                quantityWheelsTextBox.Text = a._wheels._quantity.ToString();
                diameterWheelsTextBox.Text = a._wheels._diameter.ToString();
                tireWheelsTextBox.Text = a._wheels._typeTire.ToString();
                weightTextBox.Text = a._weight.ToString();
                carriageTextBox.Text = a.numCarriage.ToString();
            }
            else
            {
                routeTextBox.Text = "";
                routeTextBox.ReadOnly = false;
                trainPictureBox.Image = null;
                capacityTextBox.Text = "";
                quantityWheelsTextBox.Text = "";
                diameterWheelsTextBox.Text = "";
                tireWheelsTextBox.Text = "";
                weightTextBox.Text = "";
                carriageTextBox.Text = "";
            }
        }
        private void loadTransportButton_Click(object sender, EventArgs e)
        {
            Train train = new Train();
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

                    List<Train> a;

                    //null - если используется плагин
                    if (serializer == null)
                    {
                        Tuple<ISerializer, IPlugin> tuple = ProjectContainer.instance.GetPluginTuple(st[st.Length - 1]);
                        serializer = tuple.Item1;
                        IPlugin plug = tuple.Item2;

                        a = serializer.Deserialize<Train>(openFileDialog.FileName, plug);
                    }
                    else
                    {
                        a = serializer.Deserialize<Train>(openFileDialog.FileName);
                    }

                    if (a != null)
                    {
                        foreach (Train au in a)
                        {
                            bool isAdd = true;
                            foreach (Transport transport in Train.trains)
                            {
                                if (au.getTransportName() == transport.getTransportName())
                                {
                                    isAdd = false;
                                }
                            }
                            if (isAdd)
                            {
                                Train.trains.Add(au);
                            }
                        }

                        List<Transport> transports = new List<Transport>(a);
                        ProjectContainer.instance.putNewTransports(train.GetType().Name, Train.trains);

                        routeTextBox.Text = a[a.Count - 1].getTransportName();
                        routeTextBox.ReadOnly = false;
                        for (int i = 0; i < a.Count; i++)
                        {
                            if (a[i]._bitmapPath != "")
                            {
                                a[i].transportBitmap = new Bitmap(a[i]._bitmapPath);
                            }
                        }
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            trainPictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
                            bitmapPath = a[a.Count - 1]._bitmapPath;
                        }
                        else
                        {
                            trainPictureBox.Image = null;
                        }
                        capacityTextBox.Text = a[a.Count - 1]._capasity.ToString();
                        quantityWheelsTextBox.Text = a[a.Count - 1]._wheels._quantity.ToString();
                        diameterWheelsTextBox.Text = a[a.Count - 1]._wheels._diameter.ToString();
                        tireWheelsTextBox.Text = a[a.Count - 1]._wheels._typeTire.ToString();
                        weightTextBox.Text = a[a.Count - 1]._weight.ToString();
                        carriageTextBox.Text = a[a.Count - 1]._numCarriage.ToString();
                        transportAddedShowEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Can not get " + train.GetType().Name + " from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of " + train.GetType().Name + " was added");
            }
        }

        private void EditTrainsForm_FormClosing(object sender, FormClosingEventArgs e)
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
