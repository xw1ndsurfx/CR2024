﻿using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Controls;
using Timer = System.Windows.Forms.Timer;

namespace Intersect.Editor.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            var resources = new ComponentResourceManager(typeof(FrmLogin));
            lblStatus = new Label();
            tmrSocket = new Timer(components);
            txtUsername = new DarkTextBox();
            txtPassword = new DarkTextBox();
            btnLogin = new DarkButton();
            picLogo = new PictureBox();
            lblVersion = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblGettingStarted = new Label();
            chkRemember = new DarkCheckBox();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)picLogo).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(13, 525);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(584, 27);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Connecting to server, please wait...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tmrSocket
            // 
            tmrSocket.Enabled = true;
            tmrSocket.Tick += tmrSocket_Tick;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtUsername.Location = new System.Drawing.Point(327, 183);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(148, 23);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtPassword.Location = new System.Drawing.Point(327, 213);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 2;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(388, 268);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(6, 6, 6, 6);
            btnLogin.Size = new Size(88, 27);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new System.Drawing.Point(102, 317);
            picLogo.Margin = new Padding(4, 3, 4, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(550, 194);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = System.Drawing.Color.Gainsboro;
            lblVersion.Location = new System.Drawing.Point(471, 529);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(300, 23);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "Editor v1.0.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = System.Drawing.Color.White;
            lblUsername.Location = new System.Drawing.Point(255, 187);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = System.Drawing.Color.White;
            lblPassword.Location = new System.Drawing.Point(255, 217);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // lblGettingStarted
            // 
            lblGettingStarted.BackColor = System.Drawing.Color.Transparent;
            lblGettingStarted.ForeColor = System.Drawing.Color.White;
            lblGettingStarted.Location = new System.Drawing.Point(193, 73);
            lblGettingStarted.Margin = new Padding(4, 0, 4, 0);
            lblGettingStarted.Name = "lblGettingStarted";
            lblGettingStarted.Size = new Size(424, 67);
            lblGettingStarted.TabIndex = 8;
            lblGettingStarted.Text = "Getting Started?\r\n1. Start the Intersect Server\r\n2. Open the Intersect Client & Create an Account\r\n3. Login to that account here to start designing your game!";
            lblGettingStarted.Visible = false;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.ForeColor = System.Drawing.Color.White;
            chkRemember.Location = new System.Drawing.Point(327, 242);
            chkRemember.Margin = new Padding(4, 3, 4, 3);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(104, 19);
            chkRemember.TabIndex = 3;
            chkRemember.Text = "Remember Me";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(123, 56);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 112);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(784, 561);
            Controls.Add(pictureBox1);
            Controls.Add(chkRemember);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblVersion);
            Controls.Add(picLogo);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblStatus);
            Controls.Add(lblGettingStarted);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CR Scripteur";
            Load += frmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            ((ISupportInitialize)picLogo).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Timer tmrSocket;
        private DarkTextBox txtUsername;
        private DarkTextBox txtPassword;
        private DarkButton btnLogin;
        private PictureBox picLogo;
        private Label lblVersion;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblGettingStarted;
        private DarkCheckBox chkRemember;
        public Label lblStatus;
        private PictureBox pictureBox1;
    }
}