namespace WindowsFormsApp1
{
    partial class EditHelicoptersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHelicoptersForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.helicopterPanel = new System.Windows.Forms.Panel();
            this.numBladesTextBox = new System.Windows.Forms.TextBox();
            this.numBladesLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.helicopterPictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.helicopterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helicopterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(750, 221);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 52);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // helicopterPanel
            // 
            this.helicopterPanel.Controls.Add(this.numBladesTextBox);
            this.helicopterPanel.Controls.Add(this.numBladesLabel);
            this.helicopterPanel.Controls.Add(this.heightTextBox);
            this.helicopterPanel.Controls.Add(this.heightLabel);
            this.helicopterPanel.Controls.Add(this.weightTextBox);
            this.helicopterPanel.Controls.Add(this.weightLabel);
            this.helicopterPanel.Controls.Add(this.uploadPhotoButton);
            this.helicopterPanel.Controls.Add(this.capacityTextBox);
            this.helicopterPanel.Controls.Add(this.nameTextBox);
            this.helicopterPanel.Controls.Add(this.capacityLabel);
            this.helicopterPanel.Controls.Add(this.nameLabel);
            this.helicopterPanel.Controls.Add(this.helicopterPictureBox);
            this.helicopterPanel.Location = new System.Drawing.Point(12, 12);
            this.helicopterPanel.Name = "helicopterPanel";
            this.helicopterPanel.Size = new System.Drawing.Size(688, 267);
            this.helicopterPanel.TabIndex = 4;
            // 
            // numBladesTextBox
            // 
            this.numBladesTextBox.Location = new System.Drawing.Point(477, 209);
            this.numBladesTextBox.Name = "numBladesTextBox";
            this.numBladesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numBladesTextBox.TabIndex = 16;
            // 
            // numBladesLabel
            // 
            this.numBladesLabel.AutoSize = true;
            this.numBladesLabel.Location = new System.Drawing.Point(480, 178);
            this.numBladesLabel.Name = "numBladesLabel";
            this.numBladesLabel.Size = new System.Drawing.Size(86, 13);
            this.numBladesLabel.TabIndex = 15;
            this.numBladesLabel.Text = "Number of wings";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(371, 209);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 14;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(391, 178);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(61, 13);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Height ( m )";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(257, 209);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(277, 178);
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
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(136, 209);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(23, 209);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(156, 178);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(48, 13);
            this.capacityLabel.TabIndex = 2;
            this.capacityLabel.Text = "Capacity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 178);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Helicopter name";
            // 
            // helicopterPictureBox
            // 
            this.helicopterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("helicopterPictureBox.Image")));
            this.helicopterPictureBox.Location = new System.Drawing.Point(3, 3);
            this.helicopterPictureBox.Name = "helicopterPictureBox";
            this.helicopterPictureBox.Size = new System.Drawing.Size(258, 154);
            this.helicopterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helicopterPictureBox.TabIndex = 0;
            this.helicopterPictureBox.TabStop = false;
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
            this.loadTransportButton.Location = new System.Drawing.Point(766, 135);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(95, 34);
            this.loadTransportButton.TabIndex = 5;
            this.loadTransportButton.Text = "Load helicopters";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // EditHelicoptersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 298);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.helicopterPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditHelicoptersForm";
            this.Text = "EditHelicoptersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditHelicoptersForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditHelicoptersForm_VisibleChanged);
            this.helicopterPanel.ResumeLayout(false);
            this.helicopterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helicopterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel helicopterPanel;
        private System.Windows.Forms.TextBox numBladesTextBox;
        private System.Windows.Forms.Label numBladesLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox helicopterPictureBox;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadTransportButton;
    }
}