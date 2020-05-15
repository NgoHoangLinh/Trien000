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
    public partial class EditHandBoatsForm : Form
    {
        Form form;
        string bitmapPath = "";
        bool transportAddedShowEnabled = false;
        public EditHandBoatsForm(Form formSender)
        {
            InitializeComponent();
            form = formSender;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int i = 0, weight = 0, paddles = 0;
            HandBoat a = new HandBoat();
            float waterline = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out i) && Int32.TryParse(weightTextBox.Text, out weight)
                && Int32.TryParse(quantityPaddlesTextBox.Text, out paddles) && float.TryParse(waterlineTextBox.Text, out waterline))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport(a.GetType().Name);
                if (t != null)
                {
                    foreach (Transport tr in t)
                    {
                        if (tr.getTransportName() == boatNameTextBox.Text)
                        {
                            try
                            {
                                a = (HandBoat)tr;
                                a.capacity = i;
                                a.transportBitmap = (Bitmap)boatPictureBox.Image;
                                a._bitmapPath = bitmapPath;
                                a._weight = weight;
                                a._waterline = waterline;
                                a._paddles = paddles;
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
                a = new HandBoat(boatNameTextBox.Text, paddles, bitmapPath, i, weight, waterline);
                a.transportBitmap = (Bitmap)boatPictureBox.Image;
                ProjectContainer.instance.putNewTransports(a.GetType().Name, a.getList());
                form.Enabled = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect one or more parameters");
            }
        }

        private void EditHandBoatsForm_VisibleChanged(object sender, EventArgs e)
        {
            Transport tr = ProjectContainer.instance.getCurrentTransport();
            if (tr != null)
            {
                HandBoat a = (HandBoat)tr;
                boatNameTextBox.Text = a.getTransportName();
                boatNameTextBox.ReadOnly = true;
                boatPictureBox.Image = a.getTransportBitmap();
                capacityTextBox.Text = a.capacity.ToString();
                quantityPaddlesTextBox.Text = a._paddles.ToString();
                weightTextBox.Text = a._weight.ToString();
                waterlineTextBox.Text = a._waterline.ToString();
            }
            else
            {
                boatNameTextBox.Text = "";
                boatNameTextBox.ReadOnly = false;
                boatPictureBox.Image = null;
                capacityTextBox.Text = "";
                quantityPaddlesTextBox.Text = "";
                weightTextBox.Text = "";
                waterlineTextBox.Text = "";
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            openPhotosDialog.ShowDialog();
        }

        private void openPhotosDialog_FileOk(object sender, CancelEventArgs e)
        {
            boatPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            boatPictureBox.Image = new Bitmap(openPhotosDialog.FileName);
            bitmapPath = openPhotosDialog.FileName;
        }

        private void loadTransportButton_Click(object sender, EventArgs e)
        {
            HandBoat handBoat = new HandBoat();
            openFileDialog.Title = "Open Text File";

            Tuple<ISerializer, IPlugin>[] plugins = ProjectContainer.instance.GetPluginTuplesArray();
            string s2 = "";
            foreach (Tuple<ISerializer, IPlugin> tuple in plugins)
            {
                s2 += "|" + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() + " files (*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention() +
                    ")|*." + tuple.Item1.GetExtention() + tuple.Item2.GetExtention();
            }

            openFileDialog.Filter = "JSON files|*.json|Binary files|*.binar|Special files|*.special" + s2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    string[] st = openFileDialog.FileName.Split('.');
                    List<HandBoat> a;
                    ISerializer serializer = ProjectContainer.instance.getSerializer(st[st.Length - 1]);

                    //null - если используется плагин
                    if (serializer == null)
                    {
                        Tuple<ISerializer, IPlugin> tuple = ProjectContainer.instance.GetPluginTuple(st[st.Length - 1]);
                        serializer = tuple.Item1;
                        IPlugin plug = tuple.Item2;

                        a = serializer.Deserialize<HandBoat>(openFileDialog.FileName, plug);
                    }
                    else
                    {
                        a = serializer.Deserialize<HandBoat>(openFileDialog.FileName);
                    }

                    if (a != null)
                    {
                        foreach (HandBoat au in a)
                        {
                            bool isAdd = true;
                            foreach (Transport transport in HandBoat.handBoats)
                            {
                                if (au.getTransportName() == transport.getTransportName())
                                {
                                    isAdd = false;
                                }
                            }
                            if (isAdd)
                            {
                                HandBoat.handBoats.Add(au);
                            }
                        }

                        List<Transport> transports = new List<Transport>(a);
                        ProjectContainer.instance.putNewTransports("HandBoat", HandBoat.handBoats);

                        boatNameTextBox.Text = a[a.Count - 1].getTransportName();
                        boatNameTextBox.ReadOnly = false;
                        for (int i = 0; i < a.Count; i++)
                        {
                            if (a[i]._bitmapPath != "")
                            {
                                a[i].transportBitmap = new Bitmap(a[i]._bitmapPath);
                            }
                        }
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            boatPictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
                            bitmapPath = a[a.Count - 1]._bitmapPath;
                        }
                        else
                        {
                            boatPictureBox.Image = null;
                        }
                        capacityTextBox.Text = a[a.Count - 1]._capasity.ToString();
                        weightTextBox.Text = a[a.Count - 1]._weight.ToString();
                        quantityPaddlesTextBox.Text = a[a.Count - 1]._paddles.ToString();
                        waterlineTextBox.Text = a[a.Count - 1]._waterline.ToString();
                        transportAddedShowEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Can not get " + handBoat.GetType().Name + " from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of " + handBoat.GetType().Name + " was added");
            }
        }

        private void EditHandBoatsForm_FormClosing(object sender, FormClosingEventArgs e)
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
