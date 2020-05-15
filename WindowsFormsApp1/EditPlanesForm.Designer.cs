namespace WindowsFormsApp1
{
    partial class EditPlanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlanesForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.planePanel = new System.Windows.Forms.Panel();
            this.numWingsTextBox = new System.Windows.Forms.TextBox();
            this.numWingsLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.planeNameTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.planeNameLabel = new System.Windows.Forms.Label();
            this.planePictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotosDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTransportButton = new System.Windows.Forms.Button();
            this.planePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(742, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 52);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // planePanel
            // 
            this.planePanel.Controls.Add(this.numWingsTextBox);
            this.planePanel.Controls.Add(this.numWingsLabel);
            this.planePanel.Controls.Add(this.heightTextBox);
            this.planePanel.Controls.Add(this.heightLabel);
            this.planePanel.Controls.Add(this.weightTextBox);
            this.planePanel.Controls.Add(this.weightLabel);
            this.planePanel.Controls.Add(this.uploadPhotoButton);
            this.planePanel.Controls.Add(this.capacityTextBox);
            this.planePanel.Controls.Add(this.planeNameTextBox);
            this.planePanel.Controls.Add(this.capacityLabel);
            this.planePanel.Controls.Add(this.planeNameLabel);
            this.planePanel.Controls.Add(this.planePictureBox);
            this.planePanel.Location = new System.Drawing.Point(12, 10);
            this.planePanel.Name = "planePanel";
            this.planePanel.Size = new System.Drawing.Size(688, 267);
            this.planePanel.TabIndex = 2;
            // 
            // numWingsTextBox
            // 
            this.numWingsTextBox.Location = new System.Drawing.Point(477, 209);
            this.numWingsTextBox.Name = "numWingsTextBox";
            this.numWingsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numWingsTextBox.TabIndex = 16;
            // 
            // numWingsLabel
            // 
            this.numWingsLabel.AutoSize = true;
            this.numWingsLabel.Location = new System.Drawing.Point(480, 178);
            this.numWingsLabel.Name = "numWingsLabel";
            this.numWingsLabel.Size = new System.Drawing.Size(86, 13);
            this.numWingsLabel.TabIndex = 15;
            this.numWingsLabel.Text = "Number of wings";
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
            // planeNameTextBox
            // 
            this.planeNameTextBox.Location = new System.Drawing.Point(23, 209);
            this.planeNameTextBox.Name = "planeNameTextBox";
            this.planeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.planeNameTextBox.TabIndex = 3;
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
            // planeNameLabel
            // 
            this.planeNameLabel.AutoSize = true;
            this.planeNameLabel.Location = new System.Drawing.Point(48, 178);
            this.planeNameLabel.Name = "planeNameLabel";
            this.planeNameLabel.Size = new System.Drawing.Size(63, 13);
            this.planeNameLabel.TabIndex = 1;
            this.planeNameLabel.Text = "Plane name";
            // 
            // planePictureBox
            // 
            this.planePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("planePictureBox.Image")));
            this.planePictureBox.Location = new System.Drawing.Point(3, 3);
            this.planePictureBox.Name = "planePictureBox";
            this.planePictureBox.Size = new System.Drawing.Size(258, 154);
            this.planePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planePictureBox.TabIndex = 0;
            this.planePictureBox.TabStop = false;
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
            this.loadTransportButton.Location = new System.Drawing.Point(769, 133);
            this.loadTransportButton.Name = "loadTransportButton";
            this.loadTransportButton.Size = new System.Drawing.Size(95, 34);
            this.loadTransportButton.TabIndex = 3;
            this.loadTransportButton.Text = "Load plane";
            this.loadTransportButton.UseVisualStyleBackColor = true;
            this.loadTransportButton.Click += new System.EventHandler(this.loadTransportButton_Click);
            // 
            // EditPlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 312);
            this.Controls.Add(this.loadTransportButton);
            this.Controls.Add(this.planePanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditPlanesForm";
            this.Text = "EditPlanesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPlanesForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EditPlanesForm_VisibleChanged);
            this.planePanel.ResumeLayout(false);
            this.planePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel planePanel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox planeNameTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label planeNameLabel;
        private System.Windows.Forms.PictureBox planePictureBox;
        private System.Windows.Forms.TextBox numWingsTextBox;
        private System.Windows.Forms.Label numWingsLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.OpenFileDialog openPhotosDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadTransportButton;
    }
}