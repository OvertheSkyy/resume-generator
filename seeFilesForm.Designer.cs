namespace contact_tracing
{
    partial class seeFilesForm
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
            this.generateQRCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generatedQRPictureBox = new System.Windows.Forms.PictureBox();
            this.seePersonInfoComboBox = new System.Windows.Forms.ComboBox();
            this.JSONFileLabel = new System.Windows.Forms.Label();
            this.savedInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.saveAsPDF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generatedQRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateQRCode
            // 
            this.generateQRCode.BackColor = System.Drawing.Color.Transparent;
            this.generateQRCode.FlatAppearance.BorderSize = 0;
            this.generateQRCode.Location = new System.Drawing.Point(440, 580);
            this.generateQRCode.Name = "generateQRCode";
            this.generateQRCode.Size = new System.Drawing.Size(111, 23);
            this.generateQRCode.TabIndex = 13;
            this.generateQRCode.Text = "Generate QR Code";
            this.generateQRCode.UseVisualStyleBackColor = false;
            this.generateQRCode.Click += new System.EventHandler(this.generateQRCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(437, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "GENERATE QR";
            // 
            // generatedQRPictureBox
            // 
            this.generatedQRPictureBox.BackColor = System.Drawing.Color.White;
            this.generatedQRPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generatedQRPictureBox.Location = new System.Drawing.Point(296, 158);
            this.generatedQRPictureBox.Name = "generatedQRPictureBox";
            this.generatedQRPictureBox.Size = new System.Drawing.Size(378, 407);
            this.generatedQRPictureBox.TabIndex = 21;
            this.generatedQRPictureBox.TabStop = false;
            // 
            // seePersonInfoComboBox
            // 
            this.seePersonInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfoComboBox.FormattingEnabled = true;
            this.seePersonInfoComboBox.Items.AddRange(new object[] {
            ""});
            this.seePersonInfoComboBox.Location = new System.Drawing.Point(105, 97);
            this.seePersonInfoComboBox.Name = "seePersonInfoComboBox";
            this.seePersonInfoComboBox.Size = new System.Drawing.Size(567, 21);
            this.seePersonInfoComboBox.TabIndex = 24;
            this.seePersonInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.seePersonInfoComboBox_SelectedIndexChanged);
            // 
            // JSONFileLabel
            // 
            this.JSONFileLabel.AutoSize = true;
            this.JSONFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.JSONFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONFileLabel.Location = new System.Drawing.Point(17, 101);
            this.JSONFileLabel.Name = "JSONFileLabel";
            this.JSONFileLabel.Size = new System.Drawing.Size(82, 12);
            this.JSONFileLabel.TabIndex = 25;
            this.JSONFileLabel.Text = "LOOK FOR JSON:";
            // 
            // savedInfoRichTextBox
            // 
            this.savedInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedInfoRichTextBox.Location = new System.Drawing.Point(19, 158);
            this.savedInfoRichTextBox.Name = "savedInfoRichTextBox";
            this.savedInfoRichTextBox.Size = new System.Drawing.Size(271, 407);
            this.savedInfoRichTextBox.TabIndex = 31;
            this.savedInfoRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "PDF NAME:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 58);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.lastNameTextBox.TabIndex = 33;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(248, 58);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.firstNameTextBox.TabIndex = 34;
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(453, 58);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleInitialTextBox.TabIndex = 35;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(134, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 13);
            this.lastNameLabel.TabIndex = 87;
            this.lastNameLabel.Text = "LAST NAME";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(293, 81);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(82, 13);
            this.firstNameLabel.TabIndex = 88;
            this.firstNameLabel.Text = "FIRST NAME";
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.AutoSize = true;
            this.middleInitialLabel.BackColor = System.Drawing.Color.Transparent;
            this.middleInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialLabel.Location = new System.Drawing.Point(449, 81);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(102, 13);
            this.middleInitialLabel.TabIndex = 90;
            this.middleInitialLabel.Text = "MIDDLE INITIAL";
            // 
            // saveAsPDF
            // 
            this.saveAsPDF.BackColor = System.Drawing.Color.Transparent;
            this.saveAsPDF.FlatAppearance.BorderSize = 0;
            this.saveAsPDF.Location = new System.Drawing.Point(88, 580);
            this.saveAsPDF.Name = "saveAsPDF";
            this.saveAsPDF.Size = new System.Drawing.Size(132, 23);
            this.saveAsPDF.TabIndex = 91;
            this.saveAsPDF.Text = "Save As PDF Resume";
            this.saveAsPDF.UseVisualStyleBackColor = false;
            this.saveAsPDF.Click += new System.EventHandler(this.saveAsPDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(85, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "PDF CONVERTER";
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.appName.Location = new System.Drawing.Point(270, 23);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(172, 21);
            this.appName.TabIndex = 134;
            this.appName.Text = "RESUME GENERATOR";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(619, 23);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 23);
            this.closeBtn.TabIndex = 135;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // seeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveAsPDF);
            this.Controls.Add(this.middleInitialLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleInitialTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savedInfoRichTextBox);
            this.Controls.Add(this.JSONFileLabel);
            this.Controls.Add(this.seePersonInfoComboBox);
            this.Controls.Add(this.generatedQRPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateQRCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seeFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Generator";
            this.Load += new System.EventHandler(this.checkInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generatedQRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generateQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox generatedQRPictureBox;
        private System.Windows.Forms.ComboBox seePersonInfoComboBox;
        private System.Windows.Forms.Label JSONFileLabel;
        private System.Windows.Forms.RichTextBox savedInfoRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Button saveAsPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button closeBtn;
    }
}