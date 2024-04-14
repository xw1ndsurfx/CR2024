using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandPlayBgs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPlayBGS = new DarkGroupBox();
            cmbSound = new DarkComboBox();
            lblSound = new Label();
            btnCancel = new DarkButton();
            btnSave = new DarkButton();
            grpPlayBGS.SuspendLayout();
            SuspendLayout();
            // 
            // grpPlayBGS
            // 
            grpPlayBGS.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            grpPlayBGS.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpPlayBGS.Controls.Add(cmbSound);
            grpPlayBGS.Controls.Add(lblSound);
            grpPlayBGS.Controls.Add(btnCancel);
            grpPlayBGS.Controls.Add(btnSave);
            grpPlayBGS.ForeColor = System.Drawing.Color.Gainsboro;
            grpPlayBGS.Location = new System.Drawing.Point(4, 3);
            grpPlayBGS.Margin = new Padding(4, 3, 4, 3);
            grpPlayBGS.Name = "grpPlayBGS";
            grpPlayBGS.Padding = new Padding(4, 3, 4, 3);
            grpPlayBGS.Size = new Size(403, 145);
            grpPlayBGS.TabIndex = 17;
            grpPlayBGS.TabStop = false;
            grpPlayBGS.Text = "Play Sound";
            // 
            // cmbSound
            // 
            cmbSound.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSound.BorderStyle = ButtonBorderStyle.Solid;
            cmbSound.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSound.Dock = DockStyle.Top;
            cmbSound.DrawDropdownHoverOutline = false;
            cmbSound.DrawFocusRectangle = false;
            cmbSound.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSound.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSound.FlatStyle = FlatStyle.Flat;
            cmbSound.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSound.FormattingEnabled = true;
            cmbSound.Location = new System.Drawing.Point(4, 19);
            cmbSound.Margin = new Padding(4, 3, 4, 3);
            cmbSound.Name = "cmbSound";
            cmbSound.Size = new Size(395, 24);
            cmbSound.TabIndex = 22;
            cmbSound.Text = null;
            cmbSound.TextPadding = new Padding(2);
            cmbSound.SelectedIndexChanged += cmbSprite_SelectedIndexChanged;
            // 
            // lblSound
            // 
            lblSound.AutoSize = true;
            lblSound.Location = new System.Drawing.Point(148, 56);
            lblSound.Margin = new Padding(4, 0, 4, 0);
            lblSound.Name = "lblSound";
            lblSound.Size = new Size(44, 15);
            lblSound.TabIndex = 21;
            lblSound.Text = "Sound:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(104, 112);
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
            btnSave.Location = new System.Drawing.Point(8, 112);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 6, 6, 6);
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 19;
            btnSave.Text = "Ok";
            btnSave.Click += btnSave_Click;
            // 
            // EventCommandPlayBgs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            Controls.Add(grpPlayBGS);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventCommandPlayBgs";
            Size = new Size(413, 159);
            grpPlayBGS.ResumeLayout(false);
            grpPlayBGS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DarkGroupBox grpPlayBGS;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label lblSound;
        private DarkComboBox cmbSound;
    }
}
