namespace WindowsFormsApp1
{
    partial class EditAutosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAutosForm));
            this.autoPanel = new System.Windows.Forms.Panel();
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
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.autoCapacityLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.autoPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.autoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // autoPanel
            // 
            this.autoPanel.Controls.Add(this.weightTextBox);
            this.autoPanel.Controls.Add(this.weightLabel);
            this.autoPanel.Controls.Add(this.uploadPhotoButton);
            this.autoPanel.Controls.Add(this.tireWheelsTextBox);
            this.autoPanel.Controls.Add(this.diameterWheelsTextBox);
            this.autoPanel.Controls.Add(this.quantityWheelsTextBox);
            this.autoPanel.Controls.Add(this.tireTypeLabel);
            this.autoPanel.Controls.Add(this.diameterLabel);
            this.autoPanel.Controls.Add(this.quantityWheelsLabel);
            this.autoPanel.Controls.Add(this.wheelsLabel);
            this.autoPanel.Controls.Add(this.capacityTextBox);
            this.autoPanel.Controls.Add(this.brandTextBox);
            this.autoPanel.Controls.Add(this.autoCapacityLabel);
            this.autoPanel.Controls.Add(this.brandLabel);
            this.autoPanel.Controls.Add(this.autoPictureBox);
            this.autoPanel.Location = new System.Drawing.Point(12, 24);
            this.autoPanel.Name = "autoPanel";
            this.autoPanel.Size = new System.Drawing.Size(753, 267);
            this.autoPanel.TabIndex = 0;
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
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(23, 209);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 3;
            // 
            // autoCapacityLabel
            // 
            this.autoCapacityLabel.AutoSize = true;
            this.autoCapacityLabel.Location = new System.Drawing.Point(181, 178);
            this.autoCapacityLabel.Name = "autoCapacityLabel";
            this.autoCapacityLabel.Size = new System.Drawing.Size(48, 13);
            this.autoCapacityLabel.TabIndex = 2;
            this.autoCapacityLabel.Text = "Capacity";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(48, 178);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Brand";
            // 
            // autoPictureBox
            // 
            this.autoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("autoPictureBox.Image")));
            this.autoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.autoPictureBox.Name = "autoPictureBox";
            this.autoPictureBox.Size = new System.Drawing.Size(258, 154);
            this.autoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.autoPictureBox.TabIndex = 0;
            this.autoPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(782, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openPhotosDialog
            // 
            this.openPhotosDialog.FileName = "openFileDialog1";
            this.openPhotosDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPhotosDialog_FileOk);
            // 
            // loadTransportButton
            // 
            this.loadTransportButton.Location = new System.Drawing.Point(790, 175);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(95, 34);
            this.loadTransportButton.TabIndex = 2;
            this.loadTransportButton.Text = "Load auto";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // EditAutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 341);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.autoPanel);
            this.Name = "EditAutosForm";
            this.Text = "EditAutosForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAutosForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditAutosForm_VisibleChanged);
            this.autoPanel.ResumeLayout(false);
            this.autoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel autoPanel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.PictureBox autoPictureBox;
        private System.Windows.Forms.Label autoCapacityLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox tireWheelsTextBox;
        private System.Windows.Forms.TextBox diameterWheelsTextBox;
        private System.Windows.Forms.TextBox quantityWheelsTextBox;
        private System.Windows.Forms.Label tireTypeLabel;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label quantityWheelsLabel;
        private System.Windows.Forms.Label wheelsLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button loadTransportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}