namespace Intersect.Editor.Forms
{
    partial class FrmAbout
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            picLogo = new PictureBox();
            label1 = new Label();
            lblWebsite = new Label();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new System.Drawing.Point(34, 12);
            picLogo.Margin = new Padding(4, 3, 4, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(663, 132);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // label1
            // 
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(13, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(696, 179);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Visible = false;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblWebsite.ForeColor = System.Drawing.Color.White;
            lblWebsite.Location = new System.Drawing.Point(19, 448);
            lblWebsite.Margin = new Padding(4, 0, 4, 0);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(494, 13);
            lblWebsite.TabIndex = 2;
            lblWebsite.Text = "Click here to visit the Ascension Game Dev community for support, updates and more!";
            lblWebsite.Visible = false;
            lblWebsite.Click += lblWebsite_Click;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.ForeColor = System.Drawing.Color.White;
            lblVersion.Location = new System.Drawing.Point(341, 162);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(356, 17);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "v. 1.0.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(726, 187);
            Controls.Add(lblVersion);
            Controls.Add(lblWebsite);
            Controls.Add(label1);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += frmAbout_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblVersion;
    }
}