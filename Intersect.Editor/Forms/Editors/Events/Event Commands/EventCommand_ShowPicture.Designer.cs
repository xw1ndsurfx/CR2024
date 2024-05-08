namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommand_ShowPicture
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
            grpShowPicture = new DarkUI.Controls.DarkGroupBox();
            chkWaitUntilClosed = new DarkUI.Controls.DarkCheckBox();
            nudHideTime = new DarkUI.Controls.DarkNumericUpDown();
            lblHide = new Label();
            chkClick = new DarkUI.Controls.DarkCheckBox();
            cmbSize = new DarkUI.Controls.DarkComboBox();
            lblSize = new Label();
            cmbPicture = new DarkUI.Controls.DarkComboBox();
            lblPicture = new Label();
            btnCancel = new DarkUI.Controls.DarkButton();
            btnSave = new DarkUI.Controls.DarkButton();
            grpShowPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHideTime).BeginInit();
            SuspendLayout();
            // 
            // grpShowPicture
            // 
            grpShowPicture.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            grpShowPicture.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpShowPicture.Controls.Add(chkWaitUntilClosed);
            grpShowPicture.Controls.Add(nudHideTime);
            grpShowPicture.Controls.Add(lblHide);
            grpShowPicture.Controls.Add(chkClick);
            grpShowPicture.Controls.Add(cmbSize);
            grpShowPicture.Controls.Add(lblSize);
            grpShowPicture.Controls.Add(cmbPicture);
            grpShowPicture.Controls.Add(lblPicture);
            grpShowPicture.Controls.Add(btnCancel);
            grpShowPicture.Controls.Add(btnSave);
            grpShowPicture.ForeColor = System.Drawing.Color.Gainsboro;
            grpShowPicture.Location = new System.Drawing.Point(4, 3);
            grpShowPicture.Margin = new Padding(4, 3, 4, 3);
            grpShowPicture.Name = "grpShowPicture";
            grpShowPicture.Padding = new Padding(4, 3, 4, 3);
            grpShowPicture.Size = new Size(416, 225);
            grpShowPicture.TabIndex = 18;
            grpShowPicture.TabStop = false;
            grpShowPicture.Text = "Show Picture:";
            // 
            // chkWaitUntilClosed
            // 
            chkWaitUntilClosed.CheckAlign = ContentAlignment.MiddleRight;
            chkWaitUntilClosed.Location = new System.Drawing.Point(108, 153);
            chkWaitUntilClosed.Margin = new Padding(4, 3, 4, 3);
            chkWaitUntilClosed.Name = "chkWaitUntilClosed";
            chkWaitUntilClosed.Size = new Size(174, 20);
            chkWaitUntilClosed.TabIndex = 28;
            chkWaitUntilClosed.Text = "Wait Until Closed?";
            // 
            // nudHideTime
            // 
            nudHideTime.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudHideTime.ForeColor = System.Drawing.Color.Gainsboro;
            nudHideTime.Location = new System.Drawing.Point(108, 97);
            nudHideTime.Margin = new Padding(4, 3, 4, 3);
            nudHideTime.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudHideTime.Name = "nudHideTime";
            nudHideTime.Size = new Size(174, 23);
            nudHideTime.TabIndex = 27;
            nudHideTime.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblHide
            // 
            lblHide.AutoSize = true;
            lblHide.Location = new System.Drawing.Point(6, 97);
            lblHide.Margin = new Padding(4, 0, 4, 0);
            lblHide.Name = "lblHide";
            lblHide.Size = new Size(91, 15);
            lblHide.TabIndex = 26;
            lblHide.Text = "Hide After (ms):";
            // 
            // chkClick
            // 
            chkClick.CheckAlign = ContentAlignment.MiddleRight;
            chkClick.Location = new System.Drawing.Point(108, 127);
            chkClick.Margin = new Padding(4, 3, 4, 3);
            chkClick.Name = "chkClick";
            chkClick.Size = new Size(174, 20);
            chkClick.TabIndex = 25;
            chkClick.Text = "Click To Close?";
            // 
            // cmbSize
            // 
            cmbSize.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSize.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSize.BorderStyle = ButtonBorderStyle.Solid;
            cmbSize.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSize.DrawDropdownHoverOutline = false;
            cmbSize.DrawFocusRectangle = false;
            cmbSize.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FlatStyle = FlatStyle.Flat;
            cmbSize.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "Original", "Full Screen", "Half Screen", "Stretch To Fit" });
            cmbSize.Location = new System.Drawing.Point(108, 61);
            cmbSize.Margin = new Padding(4, 3, 4, 3);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(173, 24);
            cmbSize.TabIndex = 24;
            cmbSize.Text = "Original";
            cmbSize.TextPadding = new Padding(2);
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new System.Drawing.Point(6, 61);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(30, 15);
            lblSize.TabIndex = 23;
            lblSize.Text = "Size:";
            // 
            // cmbPicture
            // 
            cmbPicture.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbPicture.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbPicture.BorderStyle = ButtonBorderStyle.Solid;
            cmbPicture.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbPicture.Dock = DockStyle.Top;
            cmbPicture.DrawDropdownHoverOutline = false;
            cmbPicture.DrawFocusRectangle = false;
            cmbPicture.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPicture.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPicture.FlatStyle = FlatStyle.Flat;
            cmbPicture.ForeColor = System.Drawing.Color.Gainsboro;
            cmbPicture.FormattingEnabled = true;
            cmbPicture.Location = new System.Drawing.Point(4, 19);
            cmbPicture.Margin = new Padding(4, 3, 4, 3);
            cmbPicture.Name = "cmbPicture";
            cmbPicture.Size = new Size(408, 24);
            cmbPicture.TabIndex = 22;
            cmbPicture.Text = null;
            cmbPicture.TextPadding = new Padding(2);
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Location = new System.Drawing.Point(44, 46);
            lblPicture.Margin = new Padding(4, 0, 4, 0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(47, 15);
            lblPicture.TabIndex = 21;
            lblPicture.Text = "Picture:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(195, 190);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 6, 6, 6);
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(7, 190);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 6, 6, 6);
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 19;
            btnSave.Text = "Ok";
            btnSave.Click += btnSave_Click;
            // 
            // EventCommand_ShowPicture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            Controls.Add(grpShowPicture);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventCommand_ShowPicture";
            Size = new Size(424, 232);
            grpShowPicture.ResumeLayout(false);
            grpShowPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHideTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkGroupBox grpShowPicture;
        private DarkUI.Controls.DarkComboBox cmbPicture;
        private System.Windows.Forms.Label lblPicture;
        private DarkUI.Controls.DarkButton btnCancel;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private DarkUI.Controls.DarkCheckBox chkClick;
        private System.Windows.Forms.Label lblHide;
        private DarkUI.Controls.DarkCheckBox chkWaitUntilClosed;
        private DarkUI.Controls.DarkNumericUpDown nudHideTime;
    }
}