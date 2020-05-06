namespace WindowsFormsApp1
{
    partial class EditTrainsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrainsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.AutoPanel = new System.Windows.Forms.Panel();
            this.carriageTextBox = new System.Windows.Forms.TextBox();
            this.carriageLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.tireWheelsTextBox = new System.Windows.Forms.TextBox();
            this.diameterWheelsTextBox = new System.Windows.Forms.TextBox();
            this.quantityWheelsTextBox = new System.Windows.Forms.TextBox();
            this.tireTypeLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.quantityWheelsLabel = new System.Windows.Forms.Label();
            this.wheelsLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.routeTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.routeLabel = new System.Windows.Forms.Label();
            this.trainPictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.AutoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(782, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 45);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AutoPanel
            // 
            this.AutoPanel.Controls.Add(this.carriageTextBox);
            this.AutoPanel.Controls.Add(this.carriageLabel);
            this.AutoPanel.Controls.Add(this.weightTextBox);
            this.AutoPanel.Controls.Add(this.weightLabel);
            this.AutoPanel.Controls.Add(this.uploadPhotoButton);
            this.AutoPanel.Controls.Add(this.tireWheelsTextBox);
            this.AutoPanel.Controls.Add(this.diameterWheelsTextBox);
            this.AutoPanel.Controls.Add(this.quantityWheelsTextBox);
            this.AutoPanel.Controls.Add(this.tireTypeLabel);
            this.AutoPanel.Controls.Add(this.diameterLabel);
            this.AutoPanel.Controls.Add(this.quantityWheelsLabel);
            this.AutoPanel.Controls.Add(this.wheelsLabel);
            this.AutoPanel.Controls.Add(this.capacityTextBox);
            this.AutoPanel.Controls.Add(this.routeTextBox);
            this.AutoPanel.Controls.Add(this.capacityLabel);
            this.AutoPanel.Controls.Add(this.routeLabel);
            this.AutoPanel.Controls.Add(this.trainPictureBox);
            this.AutoPanel.Location = new System.Drawing.Point(12, 12);
            this.AutoPanel.Name = "AutoPanel";
            this.AutoPanel.Size = new System.Drawing.Size(753, 267);
            this.AutoPanel.TabIndex = 2;
            // 
            // carriageTextBox
            // 
            this.carriageTextBox.Location = new System.Drawing.Point(508, 209);
            this.carriageTextBox.Name = "carriageTextBox";
            this.carriageTextBox.Size = new System.Drawing.Size(114, 20);
            this.carriageTextBox.TabIndex = 14;
            // 
            // carriageLabel
            // 
            this.carriageLabel.AutoSize = true;
            this.carriageLabel.Location = new System.Drawing.Point(505, 178);
            this.carriageLabel.Name = "carriageLabel";
            this.carriageLabel.Size = new System.Drawing.Size(101, 13);
            this.carriageLabel.TabIndex = 13;
            this.carriageLabel.Text = "Carriages ( number )";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(306, 209);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(326, 178);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(68, 13);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Weight ( kg )";
            // 
            // uploadPhotoButton
            // 
            this.uploadPhotoButton.Location = new System.Drawing.Point(280, 109);
            this.uploadPhotoButton.Name = "uploadPhotoButton";
            this.uploadPhotoButton.Size = new System.Drawing.Size(126, 46);
            this.uploadPhotoButton.TabIndex = 2;
            this.uploadPhotoButton.Text = "Upload photo";
            this.uploadPhotoButton.UseVisualStyleBackColor = true;
            this.uploadPhotoButton.Click += new System.EventHandler(this.uploadPhotoButton_Click);
            // 
            // tireWheelsTextBox
            // 
            this.tireWheelsTextBox.Location = new System.Drawing.Point(549, 135);
            this.tireWheelsTextBox.Name = "tireWheelsTextBox";
            this.tireWheelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.tireWheelsTextBox.TabIndex = 10;
            // 
            // diameterWheelsTextBox
            // 
            this.diameterWheelsTextBox.Location = new System.Drawing.Point(549, 87);
            this.diameterWheelsTextBox.Name = "diameterWheelsTextBox";
            this.diameterWheelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.diameterWheelsTextBox.TabIndex = 9;
            // 
            // quantityWheelsTextBox
            // 
            this.quantityWheelsTextBox.Location = new System.Drawing.Point(549, 43);
            this.quantityWheelsTextBox.Name = "quantityWheelsTextBox";
            this.quantityWheelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityWheelsTextBox.TabIndex = 8;
            // 
            // tireTypeLabel
            // 
            this.tireTypeLabel.AutoSize = true;
            this.tireTypeLabel.Location = new System.Drawing.Point(433, 132);
            this.tireTypeLabel.Name = "tireTypeLabel";
            this.tireTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.tireTypeLabel.TabIndex = 7;
            this.tireTypeLabel.Text = "Type of tire";
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(433, 90);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 6;
            this.diameterLabel.Text = "Diameter";
            // 
            // quantityWheelsLabel
            // 
            this.quantityWheelsLabel.AutoSize = true;
            this.quantityWheelsLabel.Location = new System.Drawing.Point(433, 50);
            this.quantityWheelsLabel.Name = "quantityWheelsLabel";
            this.quantityWheelsLabel.Size = new System.Drawing.Size(92, 13);
            this.quantityWheelsLabel.TabIndex = 5;
            this.quantityWheelsLabel.Text = "Number of wheels";
            // 
            // wheelsLabel
            // 
            this.wheelsLabel.AutoSize = true;
            this.wheelsLabel.Location = new System.Drawing.Point(521, 12);
            this.wheelsLabel.Name = "wheelsLabel";
            this.wheelsLabel.Size = new System.Drawing.Size(43, 13);
            this.wheelsLabel.TabIndex = 2;
            this.wheelsLabel.Text = "Wheels";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(161, 209);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
            // 
            // routeTextBox
            // 
            this.routeTextBox.Location = new System.Drawing.Point(23, 209);
            this.routeTextBox.Name = "routeTextBox";
            this.routeTextBox.Size = new System.Drawing.Size(100, 20);
            this.routeTextBox.TabIndex = 3;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(181, 178);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(48, 13);
            this.capacityLabel.TabIndex = 2;
            this.capacityLabel.Text = "Capacity";
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(48, 178);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(36, 13);
            this.routeLabel.TabIndex = 1;
            this.routeLabel.Text = "Route";
            // 
            // trainPictureBox
            // 
            this.trainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("trainPictureBox.Image")));
            this.trainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.trainPictureBox.Name = "trainPictureBox";
            this.trainPictureBox.Size = new System.Drawing.Size(258, 154);
            this.trainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trainPictureBox.TabIndex = 0;
            this.trainPictureBox.TabStop = false;
            // 
            // openPhotosDialog
            // 
            this.openPhotosDialog.FileName = "openFileDialog1";
            this.openPhotosDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPhotosDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // loadTransportButton
            // 
            this.loadTransportButton.Location = new System.Drawing.Point(801, 147);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(95, 34);
            this.loadTransportButton.TabIndex = 4;
            this.loadTransportButton.Text = "Load train";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // EditTrainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 321);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.AutoPanel);
            this.Name = "EditTrainsForm";
            this.Text = "EditTrainsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTrainsForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditTrainsForm_VisibleChanged);
            this.AutoPanel.ResumeLayout(false);
            this.AutoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel AutoPanel;
        private System.Windows.Forms.TextBox carriageTextBox;
        private System.Windows.Forms.Label carriageLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.TextBox tireWheelsTextBox;
        private System.Windows.Forms.TextBox diameterWheelsTextBox;
        private System.Windows.Forms.TextBox quantityWheelsTextBox;
        private System.Windows.Forms.Label tireTypeLabel;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label quantityWheelsLabel;
        private System.Windows.Forms.Label wheelsLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox routeTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.PictureBox trainPictureBox;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadTransportButton;
    }
}