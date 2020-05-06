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
    public partial class EditHelicoptersForm : Form
    {
        Form form;
        string bitmapPath = "";
        bool transportAddedShowEnabled = false;
        public EditHelicoptersForm(Form formSender)
        {
            InitializeComponent();
            form = formSender;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int capacity = 0, weight = 0, numBlades = 0;
            Helicopter a;
            int k = 0;
            float height = 0.0f;
            if (Int32.TryParse(capacityTextBox.Text, out capacity) && Int32.TryParse(weightTextBox.Text, out weight) &&
                Int32.TryParse(numBladesTextBox.Text, out numBlades) && float.TryParse(heightTextBox.Text, out height))
            {
                List<Transport> t = ProjectContainer.instance.getExistingTransport("Helicopter");
                if (t != null)
                {
                    foreach (Transport tr in t)
                    {
                        if (tr.getTransportName() == nameTextBox.Text)
                        {
                            try
                            {
                                a = (Helicopter)tr;
                                a.capacity = capacity;
                                a.transportBitmap = (Bitmap)helicopterPictureBox.Image;
                                a._bitmapPath = bitmapPath;
                                a._weight = weight;
                                a._height = height;
                                a._numBlades = numBlades;
                                ProjectContainer.instance.putNewTransports("Helicopter", a.getList());
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
                a = new Helicopter(nameTextBox.Text, capacity, weight, numBlades, height);
                a.transportBitmap = (Bitmap)helicopterPictureBox.Image;
                a._bitmapPath = bitmapPath;
                ProjectContainer.instance.putNewTransports("Helicopter", a.getList());
                form.Enabled = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect parameters!");
            }
        }

        private void EditHelicoptersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ProjectContainer.currentTransport != null)
            {
                Helicopter a = (Helicopter)ProjectContainer.currentTransport;
                nameTextBox.Text = a.getTransportName();
                nameTextBox.ReadOnly = true;
                helicopterPictureBox.Image = a.getTransportBitmap();
                capacityTextBox.Text = a.capacity.ToString();
                numBladesTextBox.Text = a._numBlades.ToString();
                heightTextBox.Text = a._height.ToString();
                weightTextBox.Text = a._weight.ToString();
            }
            else
            {
                nameTextBox.Text = "";
                nameTextBox.ReadOnly = false;
                helicopterPictureBox.Image = null;
                capacityTextBox.Text = "";
                numBladesTextBox.Text = "";
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
            helicopterPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            helicopterPictureBox.Image = new Bitmap(openPhotosDialog.FileName);
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

                    List<Helicopter> a = serializer.Deserialize<Helicopter>(openFileDialog.FileName);

                    if (a != null)
                    {
                        foreach (Helicopter au in a)
                        {
                            bool isAdd = true;
                            foreach (Transport transport in Helicopter.helicopters)
                            {
                                if (au.getTransportName() == transport.getTransportName())
                                {
                                    isAdd = false;
                                }
                            }
                            if (isAdd)
                            {
                                Helicopter.helicopters.Add(au);
                            }
                        }

                        List<Transport> transports = new List<Transport>(a);
                        ProjectContainer.instance.putNewTransports("Helicopter", Helicopter.helicopters);

                        nameTextBox.Text = a[a.Count - 1].getTransportName();
                        nameTextBox.ReadOnly = false;
                        if (a[a.Count - 1]._bitmapPath != "")
                        {
                            helicopterPictureBox.Image = new Bitmap(a[a.Count - 1]._bitmapPath);
                        }
                        else
                        {
                            helicopterPictureBox.Image = null;
                        }
                        capacityTextBox.Text = a[a.Count - 1]._capasity.ToString();
                        heightTextBox.Text = a[a.Count - 1]._height.ToString();
                        numBladesTextBox.Text = a[a.Count - 1]._numBlades.ToString();
                        weightTextBox.Text = a[a.Count - 1]._weight.ToString();
                        transportAddedShowEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Can not get helicopter from file");
                    }
                }
            }
            if (transportAddedShowEnabled)
            {
                transportAddedShowEnabled = false;
                MessageBox.Show("List of helicopters was added");
            }
        }

        private void EditHelicoptersForm_FormClosing(object sender, FormClosingEventArgs e)
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
