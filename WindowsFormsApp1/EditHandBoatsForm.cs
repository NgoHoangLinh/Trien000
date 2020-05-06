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
            HandBoat a;
            int k = 0;
            float f = 0.0f, waterline = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out i) && Int32.TryParse(weightTextBox.Text, out weight)
                && Int32.TryParse(quantityPaddlesTextBox.Text, out paddles) && float.TryParse(waterlineTextBox.Text, out waterline))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport("HandBoat");
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
                                ProjectContainer.instance.putNewTransports("HandBoat", a.getList());
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
                a = new HandBoat(boatNameTextBox.Text, paddles, i, weight, waterline);
                a.transportBitmap = (Bitmap)boatPictureBox.Image;
                a._bitmapPath = bitmapPath;
                ProjectContainer.instance.putNewTransports("HandBoat", a.getList());
                form.Enabled = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect one or more boat parameters");
            }
        }

        private void EditHandBoatsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ProjectContainer.currentTransport != null)
            {
                HandBoat a = (HandBoat)ProjectContainer.currentTransport;
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
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "JSON files|*.json|Binary files|*.binar|Special files|*.special";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    string[] st = openFileDialog.FileName.Split('.');

                    ISerializer serializer;
                    ProjectContainer.serializers.TryGetValue(st[st.Length - 1], out serializer);

                    List<HandBoat> a = serializer.Deserialize<HandBoat>(openFileDialog.FileName);

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
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            boatPictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
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
                        MessageBox.Show("Can not get hand boats from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of hand boats was added");
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
