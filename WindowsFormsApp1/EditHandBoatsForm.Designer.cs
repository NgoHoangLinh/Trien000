namespace WindowsFormsApp1
{
    partial class EditHandBoatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHandBoatsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.boatPanel = new System.Windows.Forms.Panel();
            this.waterlineTextBox = new System.Windows.Forms.TextBox();
            this.waterlineLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.quantityPaddlesTextBox = new System.Windows.Forms.TextBox();
            this.quantityPaddlesLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.boatNameTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.boatNameLabel = new System.Windows.Forms.Label();
            this.boatPictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.boatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(729, 270);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 52);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // boatPanel
            // 
            this.boatPanel.Controls.Add(this.waterlineTextBox);
            this.boatPanel.Controls.Add(this.waterlineLabel);
            this.boatPanel.Controls.Add(this.weightTextBox);
            this.boatPanel.Controls.Add(this.weightLabel);
            this.boatPanel.Controls.Add(this.uploadPhotoButton);
            this.boatPanel.Controls.Add(this.quantityPaddlesTextBox);
            this.boatPanel.Controls.Add(this.quantityPaddlesLabel);
            this.boatPanel.Controls.Add(this.capacityTextBox);
            this.boatPanel.Controls.Add(this.boatNameTextBox);
            this.boatPanel.Controls.Add(this.capacityLabel);
            this.boatPanel.Controls.Add(this.boatNameLabel);
            this.boatPanel.Controls.Add(this.boatPictureBox);
            this.boatPanel.Location = new System.Drawing.Point(12, 12);
            this.boatPanel.Name = "boatPanel";
            this.boatPanel.Size = new System.Drawing.Size(698, 310);
            this.boatPanel.TabIndex = 6;
            // 
            // waterlineTextBox
            // 
            this.waterlineTextBox.Location = new System.Drawing.Point(508, 236);
            this.waterlineTextBox.Name = "waterlineTextBox";
            this.waterlineTextBox.Size = new System.Drawing.Size(100, 20);
            this.waterlineTextBox.TabIndex = 14;
            // 
            // waterlineLabel
            // 
            this.waterlineLabel.AutoSize = true;
            this.waterlineLabel.Location = new System.Drawing.Point(512, 205);
            this.waterlineLabel.Name = "waterlineLabel";
            this.waterlineLabel.Size = new System.Drawing.Size(52, 13);
            this.waterlineLabel.TabIndex = 13;
            this.waterlineLabel.Text = "Waterline";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(244, 236);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(264, 205);
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
            // quantityPaddlesTextBox
            // 
            this.quantityPaddlesTextBox.Location = new System.Drawing.Point(362, 236);
            this.quantityPaddlesTextBox.Name = "quantityPaddlesTextBox";
            this.quantityPaddlesTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityPaddlesTextBox.TabIndex = 8;
            // 
            // quantityPaddlesLabel
            // 
            this.quantityPaddlesLabel.AutoSize = true;
            this.quantityPaddlesLabel.Location = new System.Drawing.Point(366, 205);
            this.quantityPaddlesLabel.Name = "quantityPaddlesLabel";
            this.quantityPaddlesLabel.Size = new System.Drawing.Size(96, 13);
            this.quantityPaddlesLabel.TabIndex = 5;
            this.quantityPaddlesLabel.Text = "Number of paddles";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(131, 236);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
            // 
            // boatNameTextBox
            // 
            this.boatNameTextBox.Location = new System.Drawing.Point(17, 236);
            this.boatNameTextBox.Name = "boatNameTextBox";
            this.boatNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.boatNameTextBox.TabIndex = 3;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(151, 205);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(48, 13);
            this.capacityLabel.TabIndex = 2;
            this.capacityLabel.Text = "Capacity";
            // 
            // boatNameLabel
            // 
            this.boatNameLabel.AutoSize = true;
            this.boatNameLabel.Location = new System.Drawing.Point(31, 205);
            this.boatNameLabel.Name = "boatNameLabel";
            this.boatNameLabel.Size = new System.Drawing.Size(58, 13);
            this.boatNameLabel.TabIndex = 1;
            this.boatNameLabel.Text = "Boat name";
            // 
            // boatPictureBox
            // 
            this.boatPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.boatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("boatPictureBox.Image")));
            this.boatPictureBox.Location = new System.Drawing.Point(3, 3);
            this.boatPictureBox.Name = "boatPictureBox";
            this.boatPictureBox.Size = new System.Drawing.Size(258, 154);
            this.boatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boatPictureBox.TabIndex = 0;
            this.boatPictureBox.TabStop = false;
            // 
            // openPhotosDialog
            // 
            this.openPhotosDialog.FileName = "openFileDialog1";
            this.openPhotosDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPhotosDialog_FileOk);
            // 
            // loadTransportButton
            // 
            this.loadTransportButton.Location = new System.Drawing.Point(752, 196);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(95, 34);
            this.loadTransportButton.TabIndex = 7;
            this.loadTransportButton.Text = "Load hand boats";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // EditHandBoatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 349);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.boatPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditHandBoatsForm";
            this.Text = "EditHandBoatsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditHandBoatsForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditHandBoatsForm_VisibleChanged);
            this.boatPanel.ResumeLayout(false);
            this.boatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel boatPanel;
        private System.Windows.Forms.TextBox waterlineTextBox;
        private System.Windows.Forms.Label waterlineLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.TextBox quantityPaddlesTextBox;
        private System.Windows.Forms.Label quantityPaddlesLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox boatNameTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label boatNameLabel;
        private System.Windows.Forms.PictureBox boatPictureBox;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.Button loadTransportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}