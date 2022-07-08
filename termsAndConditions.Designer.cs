namespace contact_tracing
{
    partial class termsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(termsAndConditions));
            this.privacyPolicyParagraph = new System.Windows.Forms.Label();
            this.returnHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // privacyPolicyParagraph
            // 
            this.privacyPolicyParagraph.AutoSize = true;
            this.privacyPolicyParagraph.BackColor = System.Drawing.Color.Transparent;
            this.privacyPolicyParagraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacyPolicyParagraph.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyPolicyParagraph.Location = new System.Drawing.Point(11, 4);
            this.privacyPolicyParagraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privacyPolicyParagraph.Name = "privacyPolicyParagraph";
            this.privacyPolicyParagraph.Size = new System.Drawing.Size(1322, 611);
            this.privacyPolicyParagraph.TabIndex = 0;
            this.privacyPolicyParagraph.Text = resources.GetString("privacyPolicyParagraph.Text");
            // 
            // returnHomeBtn
            // 
            this.returnHomeBtn.BackColor = System.Drawing.Color.Gray;
            this.returnHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnHomeBtn.Location = new System.Drawing.Point(593, 640);
            this.returnHomeBtn.Name = "returnHomeBtn";
            this.returnHomeBtn.Size = new System.Drawing.Size(75, 23);
            this.returnHomeBtn.TabIndex = 1;
            this.returnHomeBtn.Text = "Back";
            this.returnHomeBtn.UseVisualStyleBackColor = false;
            this.returnHomeBtn.Click += new System.EventHandler(this.returnHomeBtn_Click);
            // 
            // termsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 675);
            this.Controls.Add(this.returnHomeBtn);
            this.Controls.Add(this.privacyPolicyParagraph);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "termsAndConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privacyPolicyParagraph;
        private System.Windows.Forms.Button returnHomeBtn;
    }
}