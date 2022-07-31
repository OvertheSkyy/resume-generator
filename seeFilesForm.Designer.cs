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
            this.seePersonInfoComboBox = new System.Windows.Forms.ComboBox();
            this.JSONFileLabel = new System.Windows.Forms.Label();
            this.savedInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.saveAsPDF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // seePersonInfoComboBox
            // 
            this.seePersonInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfoComboBox.FormattingEnabled = true;
            this.seePersonInfoComboBox.Items.AddRange(new object[] {
            ""});
            this.seePersonInfoComboBox.Location = new System.Drawing.Point(116, 97);
            this.seePersonInfoComboBox.Name = "seePersonInfoComboBox";
            this.seePersonInfoComboBox.Size = new System.Drawing.Size(542, 21);
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
            this.savedInfoRichTextBox.Location = new System.Drawing.Point(198, 158);
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
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "DATE OF MEETING:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(134, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(0, 13);
            this.lastNameLabel.TabIndex = 87;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(293, 81);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(0, 13);
            this.firstNameLabel.TabIndex = 88;
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.AutoSize = true;
            this.middleInitialLabel.BackColor = System.Drawing.Color.Transparent;
            this.middleInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialLabel.Location = new System.Drawing.Point(449, 81);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(0, 13);
            this.middleInitialLabel.TabIndex = 90;
            // 
            // saveAsPDF
            // 
            this.saveAsPDF.BackColor = System.Drawing.Color.Transparent;
            this.saveAsPDF.FlatAppearance.BorderSize = 0;
            this.saveAsPDF.Location = new System.Drawing.Point(274, 571);
            this.saveAsPDF.Name = "saveAsPDF";
            this.saveAsPDF.Size = new System.Drawing.Size(132, 23);
            this.saveAsPDF.TabIndex = 91;
            this.saveAsPDF.Text = "Save As PDF Minutes";
            this.saveAsPDF.UseVisualStyleBackColor = false;
            this.saveAsPDF.Click += new System.EventHandler(this.saveAsPDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(271, 139);
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
            this.appName.Size = new System.Drawing.Size(180, 21);
            this.appName.TabIndex = 134;
            this.appName.Text = "MINUTES GENERATOR";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 136;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // seeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 617);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveAsPDF);
            this.Controls.Add(this.middleInitialLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savedInfoRichTextBox);
            this.Controls.Add(this.JSONFileLabel);
            this.Controls.Add(this.seePersonInfoComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seeFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Generator";
            this.Load += new System.EventHandler(this.checkInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox seePersonInfoComboBox;
        private System.Windows.Forms.Label JSONFileLabel;
        private System.Windows.Forms.RichTextBox savedInfoRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Button saveAsPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}