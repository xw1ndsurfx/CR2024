using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmShop
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShop));
            grpShops = new DarkGroupBox();
            btnClearSearch = new DarkButton();
            txtSearch = new DarkTextBox();
            lstGameObjects = new Controls.GameObjectList();
            grpGeneral = new DarkGroupBox();
            lblSellSound = new Label();
            cmbSellSound = new DarkComboBox();
            lblBuySound = new Label();
            cmbBuySound = new DarkComboBox();
            btnAddFolder = new DarkButton();
            lblFolder = new Label();
            cmbFolder = new DarkComboBox();
            cmbDefaultCurrency = new DarkComboBox();
            lblDefaultCurrency = new Label();
            lblName = new Label();
            txtName = new DarkTextBox();
            grpItemsSold = new DarkGroupBox();
            btnItemDown = new DarkButton();
            btnItemUp = new DarkButton();
            nudSellCost = new DarkNumericUpDown();
            cmbSellFor = new DarkComboBox();
            lblSellFor = new Label();
            lblSellCost = new Label();
            btnDelSoldItem = new DarkButton();
            btnAddSoldItem = new DarkButton();
            cmbAddSoldItem = new DarkComboBox();
            lblAddSoldItem = new Label();
            lstSoldItems = new ListBox();
            grpItemsBought = new DarkGroupBox();
            nudBuyAmount = new DarkNumericUpDown();
            cmbBuyFor = new DarkComboBox();
            lblBuyFor = new Label();
            lblBuyAmount = new Label();
            btnDelBoughtItem = new DarkButton();
            btnAddBoughtItem = new DarkButton();
            cmbAddBoughtItem = new DarkComboBox();
            lblItemBought = new Label();
            lstBoughtItems = new ListBox();
            rdoBuyBlacklist = new DarkRadioButton();
            rdoBuyWhitelist = new DarkRadioButton();
            pnlContainer = new Panel();
            btnCancel = new DarkButton();
            btnSave = new DarkButton();
            toolStrip = new DarkToolStrip();
            toolStripItemNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripItemDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAlphabetical = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripItemCopy = new ToolStripButton();
            toolStripItemPaste = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripItemUndo = new ToolStripButton();
            grpShops.SuspendLayout();
            grpGeneral.SuspendLayout();
            grpItemsSold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSellCost).BeginInit();
            grpItemsBought.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuyAmount).BeginInit();
            pnlContainer.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // grpShops
            // 
            grpShops.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpShops.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpShops.Controls.Add(btnClearSearch);
            grpShops.Controls.Add(txtSearch);
            grpShops.Controls.Add(lstGameObjects);
            grpShops.ForeColor = System.Drawing.Color.Gainsboro;
            grpShops.Location = new System.Drawing.Point(14, 39);
            grpShops.Margin = new Padding(4, 3, 4, 3);
            grpShops.Name = "grpShops";
            grpShops.Padding = new Padding(4, 3, 4, 3);
            grpShops.Size = new Size(237, 579);
            grpShops.TabIndex = 15;
            grpShops.TabStop = false;
            grpShops.Text = "Shops";
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new System.Drawing.Point(209, 23);
            btnClearSearch.Margin = new Padding(4, 3, 4, 3);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Padding = new Padding(6, 6, 6, 6);
            btnClearSearch.Size = new Size(21, 23);
            btnClearSearch.TabIndex = 37;
            btnClearSearch.Text = "X";
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtSearch.Location = new System.Drawing.Point(7, 23);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 36;
            txtSearch.Text = "Search...";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // lstGameObjects
            // 
            lstGameObjects.AllowDrop = true;
            lstGameObjects.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstGameObjects.BorderStyle = BorderStyle.None;
            lstGameObjects.ForeColor = System.Drawing.Color.Gainsboro;
            lstGameObjects.HideSelection = false;
            lstGameObjects.ImageIndex = 0;
            lstGameObjects.LineColor = System.Drawing.Color.FromArgb(150, 150, 150);
            lstGameObjects.Location = new System.Drawing.Point(7, 53);
            lstGameObjects.Margin = new Padding(4, 3, 4, 3);
            lstGameObjects.Name = "lstGameObjects";
            lstGameObjects.SelectedImageIndex = 0;
            lstGameObjects.Size = new Size(223, 515);
            lstGameObjects.TabIndex = 35;
            // 
            // grpGeneral
            // 
            grpGeneral.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpGeneral.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpGeneral.Controls.Add(lblSellSound);
            grpGeneral.Controls.Add(cmbSellSound);
            grpGeneral.Controls.Add(lblBuySound);
            grpGeneral.Controls.Add(cmbBuySound);
            grpGeneral.Controls.Add(btnAddFolder);
            grpGeneral.Controls.Add(lblFolder);
            grpGeneral.Controls.Add(cmbFolder);
            grpGeneral.Controls.Add(cmbDefaultCurrency);
            grpGeneral.Controls.Add(lblDefaultCurrency);
            grpGeneral.Controls.Add(lblName);
            grpGeneral.Controls.Add(txtName);
            grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            grpGeneral.Location = new System.Drawing.Point(-1, 2);
            grpGeneral.Margin = new Padding(4, 3, 4, 3);
            grpGeneral.Name = "grpGeneral";
            grpGeneral.Padding = new Padding(4, 3, 4, 3);
            grpGeneral.Size = new Size(610, 120);
            grpGeneral.TabIndex = 16;
            grpGeneral.TabStop = false;
            grpGeneral.Text = "General";
            // 
            // lblSellSound
            // 
            lblSellSound.AutoSize = true;
            lblSellSound.Location = new System.Drawing.Point(315, 88);
            lblSellSound.Margin = new Padding(4, 0, 4, 0);
            lblSellSound.Name = "lblSellSound";
            lblSellSound.Size = new Size(65, 15);
            lblSellSound.TabIndex = 59;
            lblSellSound.Text = "Sell Sound:";
            // 
            // cmbSellSound
            // 
            cmbSellSound.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSellSound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSellSound.BorderStyle = ButtonBorderStyle.Solid;
            cmbSellSound.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSellSound.DrawDropdownHoverOutline = false;
            cmbSellSound.DrawFocusRectangle = false;
            cmbSellSound.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSellSound.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSellSound.FlatStyle = FlatStyle.Flat;
            cmbSellSound.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSellSound.FormattingEnabled = true;
            cmbSellSound.Items.AddRange(new object[] { "None" });
            cmbSellSound.Location = new System.Drawing.Point(394, 83);
            cmbSellSound.Margin = new Padding(4, 3, 4, 3);
            cmbSellSound.Name = "cmbSellSound";
            cmbSellSound.Size = new Size(208, 24);
            cmbSellSound.TabIndex = 58;
            cmbSellSound.Text = "None";
            cmbSellSound.TextPadding = new Padding(2);
            cmbSellSound.SelectedIndexChanged += cmbSellSound_SelectedIndexChanged;
            // 
            // lblBuySound
            // 
            lblBuySound.AutoSize = true;
            lblBuySound.Location = new System.Drawing.Point(315, 57);
            lblBuySound.Margin = new Padding(4, 0, 4, 0);
            lblBuySound.Name = "lblBuySound";
            lblBuySound.Size = new Size(67, 15);
            lblBuySound.TabIndex = 57;
            lblBuySound.Text = "Buy Sound:";
            // 
            // cmbBuySound
            // 
            cmbBuySound.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbBuySound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbBuySound.BorderStyle = ButtonBorderStyle.Solid;
            cmbBuySound.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbBuySound.DrawDropdownHoverOutline = false;
            cmbBuySound.DrawFocusRectangle = false;
            cmbBuySound.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBuySound.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuySound.FlatStyle = FlatStyle.Flat;
            cmbBuySound.ForeColor = System.Drawing.Color.Gainsboro;
            cmbBuySound.FormattingEnabled = true;
            cmbBuySound.Items.AddRange(new object[] { "None" });
            cmbBuySound.Location = new System.Drawing.Point(394, 52);
            cmbBuySound.Margin = new Padding(4, 3, 4, 3);
            cmbBuySound.Name = "cmbBuySound";
            cmbBuySound.Size = new Size(208, 24);
            cmbBuySound.TabIndex = 56;
            cmbBuySound.Text = "None";
            cmbBuySound.TextPadding = new Padding(2);
            cmbBuySound.SelectedIndexChanged += cmbBuySound_SelectedIndexChanged;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new System.Drawing.Point(230, 47);
            btnAddFolder.Margin = new Padding(4, 3, 4, 3);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Padding = new Padding(6, 6, 6, 6);
            btnAddFolder.Size = new Size(21, 24);
            btnAddFolder.TabIndex = 55;
            btnAddFolder.Text = "+";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new System.Drawing.Point(7, 51);
            lblFolder.Margin = new Padding(4, 0, 4, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 54;
            lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            cmbFolder.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbFolder.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbFolder.BorderStyle = ButtonBorderStyle.Solid;
            cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbFolder.DrawDropdownHoverOutline = false;
            cmbFolder.DrawFocusRectangle = false;
            cmbFolder.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolder.FlatStyle = FlatStyle.Flat;
            cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            cmbFolder.FormattingEnabled = true;
            cmbFolder.Location = new System.Drawing.Point(70, 47);
            cmbFolder.Margin = new Padding(4, 3, 4, 3);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(152, 24);
            cmbFolder.TabIndex = 53;
            cmbFolder.Text = null;
            cmbFolder.TextPadding = new Padding(2);
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // cmbDefaultCurrency
            // 
            cmbDefaultCurrency.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbDefaultCurrency.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbDefaultCurrency.BorderStyle = ButtonBorderStyle.Solid;
            cmbDefaultCurrency.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbDefaultCurrency.DrawDropdownHoverOutline = false;
            cmbDefaultCurrency.DrawFocusRectangle = false;
            cmbDefaultCurrency.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDefaultCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDefaultCurrency.FlatStyle = FlatStyle.Flat;
            cmbDefaultCurrency.ForeColor = System.Drawing.Color.Gainsboro;
            cmbDefaultCurrency.FormattingEnabled = true;
            cmbDefaultCurrency.Location = new System.Drawing.Point(394, 20);
            cmbDefaultCurrency.Margin = new Padding(4, 3, 4, 3);
            cmbDefaultCurrency.Name = "cmbDefaultCurrency";
            cmbDefaultCurrency.Size = new Size(208, 24);
            cmbDefaultCurrency.TabIndex = 8;
            cmbDefaultCurrency.Text = null;
            cmbDefaultCurrency.TextPadding = new Padding(2);
            cmbDefaultCurrency.SelectedIndexChanged += cmbDefaultCurrency_SelectedIndexChanged;
            // 
            // lblDefaultCurrency
            // 
            lblDefaultCurrency.AutoSize = true;
            lblDefaultCurrency.Location = new System.Drawing.Point(288, 23);
            lblDefaultCurrency.Margin = new Padding(4, 0, 4, 0);
            lblDefaultCurrency.Name = "lblDefaultCurrency";
            lblDefaultCurrency.Size = new Size(102, 15);
            lblDefaultCurrency.TabIndex = 2;
            lblDefaultCurrency.Text = "Default Currency: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(7, 20);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtName.Location = new System.Drawing.Point(70, 18);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // grpItemsSold
            // 
            grpItemsSold.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpItemsSold.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpItemsSold.Controls.Add(btnItemDown);
            grpItemsSold.Controls.Add(btnItemUp);
            grpItemsSold.Controls.Add(nudSellCost);
            grpItemsSold.Controls.Add(cmbSellFor);
            grpItemsSold.Controls.Add(lblSellFor);
            grpItemsSold.Controls.Add(lblSellCost);
            grpItemsSold.Controls.Add(btnDelSoldItem);
            grpItemsSold.Controls.Add(btnAddSoldItem);
            grpItemsSold.Controls.Add(cmbAddSoldItem);
            grpItemsSold.Controls.Add(lblAddSoldItem);
            grpItemsSold.Controls.Add(lstSoldItems);
            grpItemsSold.ForeColor = System.Drawing.Color.Gainsboro;
            grpItemsSold.Location = new System.Drawing.Point(0, 129);
            grpItemsSold.Margin = new Padding(4, 3, 4, 3);
            grpItemsSold.Name = "grpItemsSold";
            grpItemsSold.Padding = new Padding(4, 3, 4, 3);
            grpItemsSold.Size = new Size(301, 450);
            grpItemsSold.TabIndex = 17;
            grpItemsSold.TabStop = false;
            grpItemsSold.Text = "Items Sold";
            // 
            // btnItemDown
            // 
            btnItemDown.Location = new System.Drawing.Point(272, 219);
            btnItemDown.Margin = new Padding(4, 3, 4, 3);
            btnItemDown.Name = "btnItemDown";
            btnItemDown.Padding = new Padding(6, 6, 6, 6);
            btnItemDown.Size = new Size(26, 46);
            btnItemDown.TabIndex = 46;
            btnItemDown.Text = "▼";
            btnItemDown.Click += btnItemDown_Click;
            // 
            // btnItemUp
            // 
            btnItemUp.Location = new System.Drawing.Point(272, 23);
            btnItemUp.Margin = new Padding(4, 3, 4, 3);
            btnItemUp.Name = "btnItemUp";
            btnItemUp.Padding = new Padding(6, 6, 6, 6);
            btnItemUp.Size = new Size(26, 46);
            btnItemUp.TabIndex = 45;
            btnItemUp.Text = "▲";
            btnItemUp.Click += btnItemUp_Click;
            // 
            // nudSellCost
            // 
            nudSellCost.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudSellCost.ForeColor = System.Drawing.Color.Gainsboro;
            nudSellCost.Location = new System.Drawing.Point(94, 375);
            nudSellCost.Margin = new Padding(4, 3, 4, 3);
            nudSellCost.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            nudSellCost.Name = "nudSellCost";
            nudSellCost.Size = new Size(200, 23);
            nudSellCost.TabIndex = 44;
            nudSellCost.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // cmbSellFor
            // 
            cmbSellFor.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSellFor.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSellFor.BorderStyle = ButtonBorderStyle.Solid;
            cmbSellFor.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSellFor.DrawDropdownHoverOutline = false;
            cmbSellFor.DrawFocusRectangle = false;
            cmbSellFor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSellFor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSellFor.FlatStyle = FlatStyle.Flat;
            cmbSellFor.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSellFor.FormattingEnabled = true;
            cmbSellFor.Location = new System.Drawing.Point(7, 342);
            cmbSellFor.Margin = new Padding(4, 3, 4, 3);
            cmbSellFor.Name = "cmbSellFor";
            cmbSellFor.Size = new Size(286, 24);
            cmbSellFor.TabIndex = 11;
            cmbSellFor.Text = null;
            cmbSellFor.TextPadding = new Padding(2);
            // 
            // lblSellFor
            // 
            lblSellFor.AutoSize = true;
            lblSellFor.Location = new System.Drawing.Point(8, 323);
            lblSellFor.Margin = new Padding(4, 0, 4, 0);
            lblSellFor.Name = "lblSellFor";
            lblSellFor.Size = new Size(48, 15);
            lblSellFor.TabIndex = 10;
            lblSellFor.Text = "Sell For:";
            // 
            // lblSellCost
            // 
            lblSellCost.AutoSize = true;
            lblSellCost.Location = new System.Drawing.Point(8, 377);
            lblSellCost.Margin = new Padding(4, 0, 4, 0);
            lblSellCost.Name = "lblSellCost";
            lblSellCost.Size = new Size(55, 15);
            lblSellCost.TabIndex = 5;
            lblSellCost.Text = "Sell Cost:";
            // 
            // btnDelSoldItem
            // 
            btnDelSoldItem.Location = new System.Drawing.Point(158, 412);
            btnDelSoldItem.Margin = new Padding(4, 3, 4, 3);
            btnDelSoldItem.Name = "btnDelSoldItem";
            btnDelSoldItem.Padding = new Padding(6, 6, 6, 6);
            btnDelSoldItem.Size = new Size(136, 27);
            btnDelSoldItem.TabIndex = 4;
            btnDelSoldItem.Text = "Remove Selected";
            btnDelSoldItem.Click += btnDelSoldItem_Click;
            // 
            // btnAddSoldItem
            // 
            btnAddSoldItem.Location = new System.Drawing.Point(7, 412);
            btnAddSoldItem.Margin = new Padding(4, 3, 4, 3);
            btnAddSoldItem.Name = "btnAddSoldItem";
            btnAddSoldItem.Padding = new Padding(6, 6, 6, 6);
            btnAddSoldItem.Size = new Size(136, 27);
            btnAddSoldItem.TabIndex = 3;
            btnAddSoldItem.Text = "Add Selected";
            btnAddSoldItem.Click += btnAddSoldItem_Click;
            // 
            // cmbAddSoldItem
            // 
            cmbAddSoldItem.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbAddSoldItem.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbAddSoldItem.BorderStyle = ButtonBorderStyle.Solid;
            cmbAddSoldItem.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbAddSoldItem.DrawDropdownHoverOutline = false;
            cmbAddSoldItem.DrawFocusRectangle = false;
            cmbAddSoldItem.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAddSoldItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddSoldItem.FlatStyle = FlatStyle.Flat;
            cmbAddSoldItem.ForeColor = System.Drawing.Color.Gainsboro;
            cmbAddSoldItem.FormattingEnabled = true;
            cmbAddSoldItem.Location = new System.Drawing.Point(7, 293);
            cmbAddSoldItem.Margin = new Padding(4, 3, 4, 3);
            cmbAddSoldItem.Name = "cmbAddSoldItem";
            cmbAddSoldItem.Size = new Size(286, 24);
            cmbAddSoldItem.TabIndex = 2;
            cmbAddSoldItem.Text = null;
            cmbAddSoldItem.TextPadding = new Padding(2);
            // 
            // lblAddSoldItem
            // 
            lblAddSoldItem.AutoSize = true;
            lblAddSoldItem.Location = new System.Drawing.Point(8, 275);
            lblAddSoldItem.Margin = new Padding(4, 0, 4, 0);
            lblAddSoldItem.Name = "lblAddSoldItem";
            lblAddSoldItem.Size = new Size(116, 15);
            lblAddSoldItem.TabIndex = 1;
            lblAddSoldItem.Text = "Add Item To Be Sold:";
            // 
            // lstSoldItems
            // 
            lstSoldItems.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstSoldItems.BorderStyle = BorderStyle.FixedSingle;
            lstSoldItems.ForeColor = System.Drawing.Color.Gainsboro;
            lstSoldItems.FormattingEnabled = true;
            lstSoldItems.ItemHeight = 15;
            lstSoldItems.Location = new System.Drawing.Point(8, 23);
            lstSoldItems.Margin = new Padding(4, 3, 4, 3);
            lstSoldItems.Name = "lstSoldItems";
            lstSoldItems.Size = new Size(260, 242);
            lstSoldItems.TabIndex = 0;
            // 
            // grpItemsBought
            // 
            grpItemsBought.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpItemsBought.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpItemsBought.Controls.Add(nudBuyAmount);
            grpItemsBought.Controls.Add(cmbBuyFor);
            grpItemsBought.Controls.Add(lblBuyFor);
            grpItemsBought.Controls.Add(lblBuyAmount);
            grpItemsBought.Controls.Add(btnDelBoughtItem);
            grpItemsBought.Controls.Add(btnAddBoughtItem);
            grpItemsBought.Controls.Add(cmbAddBoughtItem);
            grpItemsBought.Controls.Add(lblItemBought);
            grpItemsBought.Controls.Add(lstBoughtItems);
            grpItemsBought.Controls.Add(rdoBuyBlacklist);
            grpItemsBought.Controls.Add(rdoBuyWhitelist);
            grpItemsBought.ForeColor = System.Drawing.Color.Gainsboro;
            grpItemsBought.Location = new System.Drawing.Point(308, 129);
            grpItemsBought.Margin = new Padding(4, 3, 4, 3);
            grpItemsBought.Name = "grpItemsBought";
            grpItemsBought.Padding = new Padding(4, 3, 4, 3);
            grpItemsBought.Size = new Size(301, 450);
            grpItemsBought.TabIndex = 18;
            grpItemsBought.TabStop = false;
            grpItemsBought.Text = "Items Bought (Whitelist - Buy Listed Items)";
            // 
            // nudBuyAmount
            // 
            nudBuyAmount.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudBuyAmount.ForeColor = System.Drawing.Color.Gainsboro;
            nudBuyAmount.Location = new System.Drawing.Point(96, 375);
            nudBuyAmount.Margin = new Padding(4, 3, 4, 3);
            nudBuyAmount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            nudBuyAmount.Name = "nudBuyAmount";
            nudBuyAmount.Size = new Size(200, 23);
            nudBuyAmount.TabIndex = 45;
            nudBuyAmount.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // cmbBuyFor
            // 
            cmbBuyFor.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbBuyFor.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbBuyFor.BorderStyle = ButtonBorderStyle.Solid;
            cmbBuyFor.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbBuyFor.DrawDropdownHoverOutline = false;
            cmbBuyFor.DrawFocusRectangle = false;
            cmbBuyFor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBuyFor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuyFor.FlatStyle = FlatStyle.Flat;
            cmbBuyFor.ForeColor = System.Drawing.Color.Gainsboro;
            cmbBuyFor.FormattingEnabled = true;
            cmbBuyFor.Location = new System.Drawing.Point(9, 342);
            cmbBuyFor.Margin = new Padding(4, 3, 4, 3);
            cmbBuyFor.Name = "cmbBuyFor";
            cmbBuyFor.Size = new Size(286, 24);
            cmbBuyFor.TabIndex = 12;
            cmbBuyFor.Text = null;
            cmbBuyFor.TextPadding = new Padding(2);
            // 
            // lblBuyFor
            // 
            lblBuyFor.AutoSize = true;
            lblBuyFor.Location = new System.Drawing.Point(7, 323);
            lblBuyFor.Margin = new Padding(4, 0, 4, 0);
            lblBuyFor.Name = "lblBuyFor";
            lblBuyFor.Size = new Size(50, 15);
            lblBuyFor.TabIndex = 11;
            lblBuyFor.Text = "Buy For:";
            // 
            // lblBuyAmount
            // 
            lblBuyAmount.AutoSize = true;
            lblBuyAmount.Location = new System.Drawing.Point(7, 377);
            lblBuyAmount.Margin = new Padding(4, 0, 4, 0);
            lblBuyAmount.Name = "lblBuyAmount";
            lblBuyAmount.Size = new Size(75, 15);
            lblBuyAmount.TabIndex = 6;
            lblBuyAmount.Text = "Sell Amount:";
            // 
            // btnDelBoughtItem
            // 
            btnDelBoughtItem.Location = new System.Drawing.Point(161, 412);
            btnDelBoughtItem.Margin = new Padding(4, 3, 4, 3);
            btnDelBoughtItem.Name = "btnDelBoughtItem";
            btnDelBoughtItem.Padding = new Padding(6, 6, 6, 6);
            btnDelBoughtItem.Size = new Size(136, 27);
            btnDelBoughtItem.TabIndex = 6;
            btnDelBoughtItem.Text = "Remove Selected";
            btnDelBoughtItem.Click += btnDelBoughtItem_Click;
            // 
            // btnAddBoughtItem
            // 
            btnAddBoughtItem.Location = new System.Drawing.Point(10, 412);
            btnAddBoughtItem.Margin = new Padding(4, 3, 4, 3);
            btnAddBoughtItem.Name = "btnAddBoughtItem";
            btnAddBoughtItem.Padding = new Padding(6, 6, 6, 6);
            btnAddBoughtItem.Size = new Size(136, 27);
            btnAddBoughtItem.TabIndex = 5;
            btnAddBoughtItem.Text = "Add Selected";
            btnAddBoughtItem.Click += btnAddBoughtItem_Click;
            // 
            // cmbAddBoughtItem
            // 
            cmbAddBoughtItem.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbAddBoughtItem.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbAddBoughtItem.BorderStyle = ButtonBorderStyle.Solid;
            cmbAddBoughtItem.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbAddBoughtItem.DrawDropdownHoverOutline = false;
            cmbAddBoughtItem.DrawFocusRectangle = false;
            cmbAddBoughtItem.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAddBoughtItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddBoughtItem.FlatStyle = FlatStyle.Flat;
            cmbAddBoughtItem.ForeColor = System.Drawing.Color.Gainsboro;
            cmbAddBoughtItem.FormattingEnabled = true;
            cmbAddBoughtItem.Location = new System.Drawing.Point(9, 293);
            cmbAddBoughtItem.Margin = new Padding(4, 3, 4, 3);
            cmbAddBoughtItem.Name = "cmbAddBoughtItem";
            cmbAddBoughtItem.Size = new Size(286, 24);
            cmbAddBoughtItem.TabIndex = 3;
            cmbAddBoughtItem.Text = null;
            cmbAddBoughtItem.TextPadding = new Padding(2);
            // 
            // lblItemBought
            // 
            lblItemBought.AutoSize = true;
            lblItemBought.Location = new System.Drawing.Point(7, 277);
            lblItemBought.Margin = new Padding(4, 0, 4, 0);
            lblItemBought.Name = "lblItemBought";
            lblItemBought.Size = new Size(59, 15);
            lblItemBought.TabIndex = 2;
            lblItemBought.Text = "Add Item:";
            // 
            // lstBoughtItems
            // 
            lstBoughtItems.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstBoughtItems.BorderStyle = BorderStyle.FixedSingle;
            lstBoughtItems.ForeColor = System.Drawing.Color.Gainsboro;
            lstBoughtItems.FormattingEnabled = true;
            lstBoughtItems.ItemHeight = 15;
            lstBoughtItems.Location = new System.Drawing.Point(9, 23);
            lstBoughtItems.Margin = new Padding(4, 3, 4, 3);
            lstBoughtItems.Name = "lstBoughtItems";
            lstBoughtItems.Size = new Size(286, 242);
            lstBoughtItems.TabIndex = 2;
            // 
            // rdoBuyBlacklist
            // 
            rdoBuyBlacklist.AutoSize = true;
            rdoBuyBlacklist.Location = new System.Drawing.Point(220, 272);
            rdoBuyBlacklist.Margin = new Padding(4, 3, 4, 3);
            rdoBuyBlacklist.Name = "rdoBuyBlacklist";
            rdoBuyBlacklist.Size = new Size(68, 19);
            rdoBuyBlacklist.TabIndex = 1;
            rdoBuyBlacklist.Text = "Blacklist";
            rdoBuyBlacklist.CheckedChanged += rdoBuyBlacklist_CheckedChanged;
            // 
            // rdoBuyWhitelist
            // 
            rdoBuyWhitelist.AutoSize = true;
            rdoBuyWhitelist.Checked = true;
            rdoBuyWhitelist.Location = new System.Drawing.Point(138, 272);
            rdoBuyWhitelist.Margin = new Padding(4, 3, 4, 3);
            rdoBuyWhitelist.Name = "rdoBuyWhitelist";
            rdoBuyWhitelist.Size = new Size(71, 19);
            rdoBuyWhitelist.TabIndex = 0;
            rdoBuyWhitelist.TabStop = true;
            rdoBuyWhitelist.Text = "Whitelist";
            rdoBuyWhitelist.CheckedChanged += rdoBuyWhitelist_CheckedChanged;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(grpItemsBought);
            pnlContainer.Controls.Add(grpGeneral);
            pnlContainer.Controls.Add(grpItemsSold);
            pnlContainer.Location = new System.Drawing.Point(259, 39);
            pnlContainer.Margin = new Padding(4, 3, 4, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(609, 579);
            pnlContainer.TabIndex = 19;
            pnlContainer.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(645, 625);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 6, 6, 6);
            btnCancel.Size = new Size(222, 31);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(416, 625);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 6, 6, 6);
            btnSave.Size = new Size(222, 31);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            toolStrip.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripItemNew, toolStripSeparator1, toolStripItemDelete, toolStripSeparator2, btnAlphabetical, toolStripSeparator4, toolStripItemCopy, toolStripItemPaste, toolStripSeparator3, toolStripItemUndo });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(6, 0, 1, 0);
            toolStrip.Size = new Size(876, 29);
            toolStrip.TabIndex = 50;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            toolStripItemNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemNew.Image = (Image)resources.GetObject("toolStripItemNew.Image");
            toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemNew.Name = "toolStripItemNew";
            toolStripItemNew.Size = new Size(23, 26);
            toolStripItemNew.Text = "New";
            toolStripItemNew.Click += toolStripItemNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // toolStripItemDelete
            // 
            toolStripItemDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemDelete.Enabled = false;
            toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemDelete.Image = (Image)resources.GetObject("toolStripItemDelete.Image");
            toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemDelete.Name = "toolStripItemDelete";
            toolStripItemDelete.Size = new Size(23, 26);
            toolStripItemDelete.Text = "Delete";
            toolStripItemDelete.Click += toolStripItemDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 29);
            // 
            // btnAlphabetical
            // 
            btnAlphabetical.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAlphabetical.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnAlphabetical.Image = (Image)resources.GetObject("btnAlphabetical.Image");
            btnAlphabetical.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAlphabetical.Name = "btnAlphabetical";
            btnAlphabetical.Size = new Size(23, 26);
            btnAlphabetical.Text = "Order Chronologically";
            btnAlphabetical.Click += btnAlphabetical_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator4.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 29);
            // 
            // toolStripItemCopy
            // 
            toolStripItemCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemCopy.Enabled = false;
            toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemCopy.Image = (Image)resources.GetObject("toolStripItemCopy.Image");
            toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemCopy.Name = "toolStripItemCopy";
            toolStripItemCopy.Size = new Size(23, 26);
            toolStripItemCopy.Text = "Copy";
            toolStripItemCopy.Click += toolStripItemCopy_Click;
            // 
            // toolStripItemPaste
            // 
            toolStripItemPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemPaste.Enabled = false;
            toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemPaste.Image = (Image)resources.GetObject("toolStripItemPaste.Image");
            toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemPaste.Name = "toolStripItemPaste";
            toolStripItemPaste.Size = new Size(23, 26);
            toolStripItemPaste.Text = "Paste";
            toolStripItemPaste.Click += toolStripItemPaste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator3.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 29);
            // 
            // toolStripItemUndo
            // 
            toolStripItemUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemUndo.Enabled = false;
            toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemUndo.Image = (Image)resources.GetObject("toolStripItemUndo.Image");
            toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemUndo.Name = "toolStripItemUndo";
            toolStripItemUndo.Size = new Size(23, 26);
            toolStripItemUndo.Text = "Undo";
            toolStripItemUndo.Click += toolStripItemUndo_Click;
            // 
            // FrmShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(876, 673);
            ControlBox = false;
            Controls.Add(toolStrip);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpShops);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Editor";
            Load += frmShop_Load;
            KeyDown += form_KeyDown;
            grpShops.ResumeLayout(false);
            grpShops.PerformLayout();
            grpGeneral.ResumeLayout(false);
            grpGeneral.PerformLayout();
            grpItemsSold.ResumeLayout(false);
            grpItemsSold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSellCost).EndInit();
            grpItemsBought.ResumeLayout(false);
            grpItemsBought.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuyAmount).EndInit();
            pnlContainer.ResumeLayout(false);
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DarkGroupBox grpShops;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpItemsSold;
        private System.Windows.Forms.ListBox lstSoldItems;
        private DarkGroupBox grpItemsBought;
        private System.Windows.Forms.ListBox lstBoughtItems;
        private DarkRadioButton rdoBuyBlacklist;
        private DarkRadioButton rdoBuyWhitelist;
        private DarkButton btnDelSoldItem;
        private DarkButton btnAddSoldItem;
        private DarkComboBox cmbAddSoldItem;
        private System.Windows.Forms.Label lblAddSoldItem;
        private DarkButton btnDelBoughtItem;
        private DarkButton btnAddBoughtItem;
        private DarkComboBox cmbAddBoughtItem;
        private System.Windows.Forms.Label lblItemBought;
        private System.Windows.Forms.Label lblBuyAmount;
        private System.Windows.Forms.Label lblSellCost;
        private DarkComboBox cmbDefaultCurrency;
        private System.Windows.Forms.Label lblDefaultCurrency;
        private DarkComboBox cmbSellFor;
        private System.Windows.Forms.Label lblSellFor;
        private DarkComboBox cmbBuyFor;
        private System.Windows.Forms.Label lblBuyFor;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkNumericUpDown nudSellCost;
        private DarkNumericUpDown nudBuyAmount;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Controls.GameObjectList lstGameObjects;
        private DarkButton btnItemDown;
        private DarkButton btnItemUp;
        private System.Windows.Forms.Label lblSellSound;
        private DarkComboBox cmbSellSound;
        private System.Windows.Forms.Label lblBuySound;
        private DarkComboBox cmbBuySound;
    }
}