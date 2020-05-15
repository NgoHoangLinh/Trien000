namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transportFieldsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Label();
            this.transportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.transportCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.typeOfTransportLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.loadPluginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(288, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(377, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.transportFieldsListBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Location = new System.Drawing.Point(471, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 397);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // transportFieldsListBox
            // 
            this.transportFieldsListBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.transportFieldsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportFieldsListBox.FormattingEnabled = true;
            this.transportFieldsListBox.ItemHeight = 16;
            this.transportFieldsListBox.Location = new System.Drawing.Point(19, 213);
            this.transportFieldsListBox.Name = "transportFieldsListBox";
            this.transportFieldsListBox.Size = new System.Drawing.Size(265, 164);
            this.transportFieldsListBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(284, 8);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 27);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTitle.Location = new System.Drawing.Point(60, 15);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(224, 20);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.Text = "Title";
            this.panelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transportTypeComboBox
            // 
            this.transportTypeComboBox.FormattingEnabled = true;
            this.transportTypeComboBox.Location = new System.Drawing.Point(12, 50);
            this.transportTypeComboBox.Name = "transportTypeComboBox";
            this.transportTypeComboBox.Size = new System.Drawing.Size(172, 21);
            this.transportTypeComboBox.TabIndex = 8;
            this.transportTypeComboBox.Text = "...";
            this.transportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.transportTypeComboBox_SelectedIndexChanged);
            // 
            // transportCheckedListBox
            // 
            this.transportCheckedListBox.FormattingEnabled = true;
            this.transportCheckedListBox.Location = new System.Drawing.Point(202, 50);
            this.transportCheckedListBox.Name = "transportCheckedListBox";
            this.transportCheckedListBox.Size = new System.Drawing.Size(235, 109);
            this.transportCheckedListBox.TabIndex = 9;
            this.transportCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.transportCheckedListBox_ItemCheck);
            this.transportCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.transportCheckedListBox_SelectedIndexChanged);
            // 
            // typeOfTransportLabel
            // 
            this.typeOfTransportLabel.AutoSize = true;
            this.typeOfTransportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfTransportLabel.Location = new System.Drawing.Point(12, 12);
            this.typeOfTransportLabel.Name = "typeOfTransportLabel";
            this.typeOfTransportLabel.Size = new System.Drawing.Size(138, 15);
            this.typeOfTransportLabel.TabIndex = 10;
            this.typeOfTransportLabel.Text = "Choose type of transport";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(202, 165);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(205, 27);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(69, 17);
            this.selectAllCheckBox.TabIndex = 16;
            this.selectAllCheckBox.Text = "Select all";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // loadPluginButton
            // 
            this.loadPluginButton.Location = new System.Drawing.Point(15, 165);
            this.loadPluginButton.Name = "loadPluginButton";
            this.loadPluginButton.Size = new System.Drawing.Size(75, 23);
            this.loadPluginButton.TabIndex = 17;
            this.loadPluginButton.Text = "Load Plugin";
            this.loadPluginButton.UseVisualStyleBackColor = true;
            this.loadPluginButton.Click += new System.EventHandler(this.loadPluginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 415);
            this.Controls.Add(this.loadPluginButton);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeOfTransportLabel);
            this.Controls.Add(this.transportCheckedListBox);
            this.Controls.Add(this.transportTypeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label panelTitle;
        private System.Windows.Forms.ComboBox transportTypeComboBox;
        private System.Windows.Forms.CheckedListBox transportCheckedListBox;
        private System.Windows.Forms.ListBox transportFieldsListBox;
        private System.Windows.Forms.Label typeOfTransportLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button loadPluginButton;
    }
}

