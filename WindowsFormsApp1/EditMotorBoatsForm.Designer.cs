namespace WindowsFormsApp1
{
    partial class EditMotorBoatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMotorBoatsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.motorBoatPanel = new System.Windows.Forms.Panel();
            this.waterlineTextBox = new System.Windows.Forms.TextBox();
            this.waterlineLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.motorPowerTextBox = new System.Windows.Forms.TextBox();
            this.motorPowerLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.boatNameTextBox = new System.Windows.Forms.TextBox();
            this.motorBoatCapacityLabel = new System.Windows.Forms.Label();
            this.boatNameLabel = new System.Windows.Forms.Label();
            this.boatPictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.motorBoatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(719, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 39);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // motorBoatPanel
            // 
            this.motorBoatPanel.Controls.Add(this.waterlineTextBox);
            this.motorBoatPanel.Controls.Add(this.waterlineLabel);
            this.motorBoatPanel.Controls.Add(this.weightTextBox);
            this.motorBoatPanel.Controls.Add(this.weightLabel);
            this.motorBoatPanel.Controls.Add(this.uploadPhotoButton);
            this.motorBoatPanel.Controls.Add(this.motorPowerTextBox);
            this.motorBoatPanel.Controls.Add(this.motorPowerLabel);
            this.motorBoatPanel.Controls.Add(this.capacityTextBox);
            this.motorBoatPanel.Controls.Add(this.boatNameTextBox);
            this.motorBoatPanel.Controls.Add(this.motorBoatCapacityLabel);
            this.motorBoatPanel.Controls.Add(this.boatNameLabel);
            this.motorBoatPanel.Controls.Add(this.boatPictureBox);
            this.motorBoatPanel.Location = new System.Drawing.Point(12, 12);
            this.motorBoatPanel.Name = "motorBoatPanel";
            this.motorBoatPanel.Size = new System.Drawing.Size(698, 310);
            this.motorBoatPanel.TabIndex = 7;
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
            // motorPowerTextBox
            // 
            this.motorPowerTextBox.Location = new System.Drawing.Point(362, 236);
            this.motorPowerTextBox.Name = "motorPowerTextBox";
            this.motorPowerTextBox.Size = new System.Drawing.Size(100, 20);
            this.motorPowerTextBox.TabIndex = 8;
            // 
            // motorPowerLabel
            // 
            this.motorPowerLabel.AutoSize = true;
            this.motorPowerLabel.Location = new System.Drawing.Point(366, 205);
            this.motorPowerLabel.Name = "motorPowerLabel";
            this.motorPowerLabel.Size = new System.Drawing.Size(66, 13);
            this.motorPowerLabel.TabIndex = 5;
            this.motorPowerLabel.Text = "Motor power";
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
            // motorBoatCapacityLabel
            // 
            this.motorBoatCapacityLabel.AutoSize = true;
            this.motorBoatCapacityLabel.Location = new System.Drawing.Point(151, 205);
            this.motorBoatCapacityLabel.Name = "motorBoatCapacityLabel";
            this.motorBoatCapacityLabel.Size = new System.Drawing.Size(48, 13);
            this.motorBoatCapacityLabel.TabIndex = 2;
            this.motorBoatCapacityLabel.Text = "Capacity";
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // loadTransportButton
            // 
            this.loadTransportButton.Location = new System.Drawing.Point(719, 196);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(110, 34);
            this.loadTransportButton.TabIndex = 8;
            this.loadTransportButton.Text = "Load motor boats";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // EditMotorBoatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 342);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.motorBoatPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditMotorBoatsForm";
            this.Text = "EditMotorBoats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMotorBoatsForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditMotorBoatsForm_VisibleChanged);
            this.motorBoatPanel.ResumeLayout(false);
            this.motorBoatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel motorBoatPanel;
        private System.Windows.Forms.TextBox waterlineTextBox;
        private System.Windows.Forms.Label waterlineLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.TextBox motorPowerTextBox;
        private System.Windows.Forms.Label motorPowerLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox boatNameTextBox;
        private System.Windows.Forms.Label motorBoatCapacityLabel;
        private System.Windows.Forms.Label boatNameLabel;
        private System.Windows.Forms.PictureBox boatPictureBox;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadTransportButton;
    }
}