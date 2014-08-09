namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.MetrotabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.btnSaveLogin = new MetroFramework.Controls.MetroButton();
            this.tbChatResponse = new MetroFramework.Controls.MetroTextBox();
            this.tbDisplayNamePrefix = new MetroFramework.Controls.MetroTextBox();
            this.tbDisplayName = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblChatResponse = new MetroFramework.Controls.MetroLabel();
            this.lblDisplayNamePrefix = new MetroFramework.Controls.MetroLabel();
            this.lblDisplayName = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.tbAddComand = new MetroFramework.Controls.MetroTextBox();
            this.btnAddTrade = new MetroFramework.Controls.MetroButton();
            this.btnAddItem = new MetroFramework.Controls.MetroButton();
            this.cbCraft = new MetroFramework.Controls.MetroComboBox();
            this.tbSellPrice = new MetroFramework.Controls.MetroTextBox();
            this.cbQuality = new MetroFramework.Controls.MetroComboBox();
            this.lblAddCommand = new MetroFramework.Controls.MetroLabel();
            this.tbAddedItems = new MetroFramework.Controls.MetroTextBox();
            this.cbAllItems = new MetroFramework.Controls.MetroComboBox();
            this.lblSellingPrice = new MetroFramework.Controls.MetroLabel();
            this.lblItemCraft = new MetroFramework.Controls.MetroLabel();
            this.lblItemQuality = new MetroFramework.Controls.MetroLabel();
            this.lblItemName = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnDeleteTrade2 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnDeleteTrade1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.chbKeyPrice = new MetroFramework.Controls.MetroCheckBox();
            this.btnAddKeyPrice = new MetroFramework.Controls.MetroButton();
            this.tbKeyPrice = new MetroFramework.Controls.MetroTextBox();
            this.MetrotabControl1.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.metroTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetrotabControl1
            // 
            this.MetrotabControl1.Controls.Add(this.metroTabPage4);
            this.MetrotabControl1.Controls.Add(this.metroTabPage1);
            this.MetrotabControl1.Controls.Add(this.metroTabPage3);
            this.MetrotabControl1.Controls.Add(this.metroTabPage2);
            this.MetrotabControl1.Controls.Add(this.metroTabPage5);
            this.MetrotabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.MetrotabControl1.Location = new System.Drawing.Point(9, 56);
            this.MetrotabControl1.Name = "MetrotabControl1";
            this.MetrotabControl1.SelectedIndex = 3;
            this.MetrotabControl1.Size = new System.Drawing.Size(646, 474);
            this.MetrotabControl1.TabIndex = 0;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.btnSaveLogin);
            this.metroTabPage4.Controls.Add(this.tbChatResponse);
            this.metroTabPage4.Controls.Add(this.tbDisplayNamePrefix);
            this.metroTabPage4.Controls.Add(this.tbDisplayName);
            this.metroTabPage4.Controls.Add(this.tbPassword);
            this.metroTabPage4.Controls.Add(this.tbUserName);
            this.metroTabPage4.Controls.Add(this.lblChatResponse);
            this.metroTabPage4.Controls.Add(this.lblDisplayNamePrefix);
            this.metroTabPage4.Controls.Add(this.lblDisplayName);
            this.metroTabPage4.Controls.Add(this.lblPassword);
            this.metroTabPage4.Controls.Add(this.lblUserName);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(638, 435);
            this.metroTabPage4.TabIndex = 0;
            this.metroTabPage4.Text = "Login information";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // btnSaveLogin
            // 
            this.btnSaveLogin.Location = new System.Drawing.Point(246, 337);
            this.btnSaveLogin.Name = "btnSaveLogin";
            this.btnSaveLogin.Size = new System.Drawing.Size(114, 23);
            this.btnSaveLogin.TabIndex = 12;
            this.btnSaveLogin.Text = "Save";
            this.btnSaveLogin.Click += new System.EventHandler(this.btnSaveLogin_Click);
            // 
            // tbChatResponse
            // 
            this.tbChatResponse.Location = new System.Drawing.Point(299, 287);
            this.tbChatResponse.Name = "tbChatResponse";
            this.tbChatResponse.Size = new System.Drawing.Size(168, 23);
            this.tbChatResponse.TabIndex = 11;
            // 
            // tbDisplayNamePrefix
            // 
            this.tbDisplayNamePrefix.Location = new System.Drawing.Point(299, 228);
            this.tbDisplayNamePrefix.Name = "tbDisplayNamePrefix";
            this.tbDisplayNamePrefix.Size = new System.Drawing.Size(168, 23);
            this.tbDisplayNamePrefix.TabIndex = 10;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(299, 169);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(168, 23);
            this.tbDisplayName.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(299, 110);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(168, 23);
            this.tbPassword.TabIndex = 8;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(299, 51);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(168, 23);
            this.tbUserName.TabIndex = 7;
            // 
            // lblChatResponse
            // 
            this.lblChatResponse.AutoSize = true;
            this.lblChatResponse.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblChatResponse.Location = new System.Drawing.Point(171, 294);
            this.lblChatResponse.Name = "lblChatResponse";
            this.lblChatResponse.Size = new System.Drawing.Size(103, 19);
            this.lblChatResponse.TabIndex = 6;
            this.lblChatResponse.Text = "Chat Response:";
            // 
            // lblDisplayNamePrefix
            // 
            this.lblDisplayNamePrefix.AutoSize = true;
            this.lblDisplayNamePrefix.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDisplayNamePrefix.Location = new System.Drawing.Point(144, 235);
            this.lblDisplayNamePrefix.Name = "lblDisplayNamePrefix";
            this.lblDisplayNamePrefix.Size = new System.Drawing.Size(133, 19);
            this.lblDisplayNamePrefix.TabIndex = 5;
            this.lblDisplayNamePrefix.Text = "Display Name Prefix:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDisplayName.Location = new System.Drawing.Point(184, 176);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(94, 19);
            this.lblDisplayName.TabIndex = 4;
            this.lblDisplayName.Text = "Display name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPassword.Location = new System.Drawing.Point(208, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUserName.Location = new System.Drawing.Point(205, 58);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.groupBox1);
            this.metroTabPage3.Controls.Add(this.tbAddComand);
            this.metroTabPage3.Controls.Add(this.btnAddTrade);
            this.metroTabPage3.Controls.Add(this.btnAddItem);
            this.metroTabPage3.Controls.Add(this.cbCraft);
            this.metroTabPage3.Controls.Add(this.tbSellPrice);
            this.metroTabPage3.Controls.Add(this.cbQuality);
            this.metroTabPage3.Controls.Add(this.lblAddCommand);
            this.metroTabPage3.Controls.Add(this.tbAddedItems);
            this.metroTabPage3.Controls.Add(this.cbAllItems);
            this.metroTabPage3.Controls.Add(this.lblSellingPrice);
            this.metroTabPage3.Controls.Add(this.lblItemCraft);
            this.metroTabPage3.Controls.Add(this.lblItemQuality);
            this.metroTabPage3.Controls.Add(this.lblItemName);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(638, 435);
            this.metroTabPage3.TabIndex = 1;
            this.metroTabPage3.Text = "Add new trade";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(207, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 46);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trade type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 15);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sell";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 15);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbAddComand
            // 
            this.tbAddComand.Location = new System.Drawing.Point(329, 355);
            this.tbAddComand.Name = "tbAddComand";
            this.tbAddComand.Size = new System.Drawing.Size(121, 23);
            this.tbAddComand.TabIndex = 13;
            // 
            // btnAddTrade
            // 
            this.btnAddTrade.Location = new System.Drawing.Point(274, 400);
            this.btnAddTrade.Name = "btnAddTrade";
            this.btnAddTrade.Size = new System.Drawing.Size(114, 23);
            this.btnAddTrade.TabIndex = 15;
            this.btnAddTrade.Text = "Add trade";
            this.btnAddTrade.Click += new System.EventHandler(this.btnAddTrade_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(274, 190);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 23);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cbCraft
            // 
            this.cbCraft.FormattingEnabled = true;
            this.cbCraft.ItemHeight = 23;
            this.cbCraft.Items.AddRange(new object[] {
            "Both Craftable/Uncraftable",
            "Craftable",
            "Uncraftable"});
            this.cbCraft.Location = new System.Drawing.Point(243, 145);
            this.cbCraft.Name = "cbCraft";
            this.cbCraft.Size = new System.Drawing.Size(272, 29);
            this.cbCraft.TabIndex = 7;
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.Location = new System.Drawing.Point(329, 326);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.Size = new System.Drawing.Size(121, 23);
            this.tbSellPrice.TabIndex = 12;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.ItemHeight = 23;
            this.cbQuality.Items.AddRange(new object[] {
            "Unique",
            "Vintage",
            "Strange",
            "Haunted"});
            this.cbQuality.Location = new System.Drawing.Point(243, 110);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(272, 29);
            this.cbQuality.TabIndex = 6;
            // 
            // lblAddCommand
            // 
            this.lblAddCommand.AutoSize = true;
            this.lblAddCommand.Location = new System.Drawing.Point(200, 362);
            this.lblAddCommand.Name = "lblAddCommand";
            this.lblAddCommand.Size = new System.Drawing.Size(94, 16);
            this.lblAddCommand.TabIndex = 11;
            this.lblAddCommand.Text = "Add Comand:";
            // 
            // tbAddedItems
            // 
            this.tbAddedItems.Location = new System.Drawing.Point(152, 219);
            this.tbAddedItems.Multiline = true;
            this.tbAddedItems.Name = "tbAddedItems";
            this.tbAddedItems.ReadOnly = true;
            this.tbAddedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAddedItems.Size = new System.Drawing.Size(345, 91);
            this.tbAddedItems.TabIndex = 9;
            // 
            // cbAllItems
            // 
            this.cbAllItems.FormattingEnabled = true;
            this.cbAllItems.ItemHeight = 23;
            this.cbAllItems.Location = new System.Drawing.Point(243, 75);
            this.cbAllItems.Name = "cbAllItems";
            this.cbAllItems.Size = new System.Drawing.Size(272, 29);
            this.cbAllItems.TabIndex = 5;
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(205, 333);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(89, 16);
            this.lblSellingPrice.TabIndex = 10;
            this.lblSellingPrice.Text = "Selling price:";
            // 
            // lblItemCraft
            // 
            this.lblItemCraft.AutoSize = true;
            this.lblItemCraft.Location = new System.Drawing.Point(138, 158);
            this.lblItemCraft.Name = "lblItemCraft";
            this.lblItemCraft.Size = new System.Drawing.Size(70, 16);
            this.lblItemCraft.TabIndex = 4;
            this.lblItemCraft.Text = "Craftable:";
            // 
            // lblItemQuality
            // 
            this.lblItemQuality.AutoSize = true;
            this.lblItemQuality.Location = new System.Drawing.Point(152, 123);
            this.lblItemQuality.Name = "lblItemQuality";
            this.lblItemQuality.Size = new System.Drawing.Size(56, 16);
            this.lblItemQuality.TabIndex = 3;
            this.lblItemQuality.Text = "Quality:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(130, 88);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(78, 16);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnDeleteTrade2);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(638, 435);
            this.metroTabPage2.TabIndex = 4;
            this.metroTabPage2.Text = "Buy trades";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // btnDeleteTrade2
            // 
            this.btnDeleteTrade2.Location = new System.Drawing.Point(255, 287);
            this.btnDeleteTrade2.Name = "btnDeleteTrade2";
            this.btnDeleteTrade2.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteTrade2.TabIndex = 3;
            this.btnDeleteTrade2.Text = "Delete Trade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 185);
            this.dataGridView1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnDeleteTrade1);
            this.metroTabPage1.Controls.Add(this.dataGridView2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(638, 435);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Sell trades";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btnDeleteTrade1
            // 
            this.btnDeleteTrade1.Location = new System.Drawing.Point(255, 287);
            this.btnDeleteTrade1.Name = "btnDeleteTrade1";
            this.btnDeleteTrade1.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteTrade1.TabIndex = 3;
            this.btnDeleteTrade1.Text = "Delete Trade";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(623, 185);
            this.dataGridView2.TabIndex = 2;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.chbKeyPrice);
            this.metroTabPage5.Controls.Add(this.btnAddKeyPrice);
            this.metroTabPage5.Controls.Add(this.tbKeyPrice);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(638, 435);
            this.metroTabPage5.TabIndex = 5;
            this.metroTabPage5.Text = "Other options";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            // 
            // chbKeyPrice
            // 
            this.chbKeyPrice.AutoSize = true;
            this.chbKeyPrice.Location = new System.Drawing.Point(26, 47);
            this.chbKeyPrice.Name = "chbKeyPrice";
            this.chbKeyPrice.Size = new System.Drawing.Size(133, 15);
            this.chbKeyPrice.TabIndex = 2;
            this.chbKeyPrice.Text = "Accept keys as metal";
            this.chbKeyPrice.UseVisualStyleBackColor = true;
            // 
            // btnAddKeyPrice
            // 
            this.btnAddKeyPrice.Location = new System.Drawing.Point(273, 39);
            this.btnAddKeyPrice.Name = "btnAddKeyPrice";
            this.btnAddKeyPrice.Size = new System.Drawing.Size(59, 23);
            this.btnAddKeyPrice.TabIndex = 4;
            this.btnAddKeyPrice.Text = "Change";
            this.btnAddKeyPrice.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbKeyPrice
            // 
            this.tbKeyPrice.Location = new System.Drawing.Point(181, 39);
            this.tbKeyPrice.Name = "tbKeyPrice";
            this.tbKeyPrice.Size = new System.Drawing.Size(75, 23);
            this.tbKeyPrice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 553);
            this.Controls.Add(this.MetrotabControl1);
            this.Name = "Form1";
            this.Text = "Trade Bot";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MetrotabControl1.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MetrotabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTextBox tbChatResponse;
        private MetroFramework.Controls.MetroTextBox tbDisplayNamePrefix;
        private MetroFramework.Controls.MetroTextBox tbDisplayName;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroTextBox tbUserName;
        private MetroFramework.Controls.MetroLabel lblChatResponse;
        private MetroFramework.Controls.MetroLabel lblDisplayNamePrefix;
        private MetroFramework.Controls.MetroLabel lblDisplayName;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroButton btnSaveLogin;
        private MetroFramework.Controls.MetroComboBox cbCraft;
        private MetroFramework.Controls.MetroComboBox cbQuality;
        private MetroFramework.Controls.MetroComboBox cbAllItems;
        private MetroFramework.Controls.MetroLabel lblItemCraft;
        private MetroFramework.Controls.MetroLabel lblItemQuality;
        private MetroFramework.Controls.MetroLabel lblItemName;
        private MetroFramework.Controls.MetroTextBox tbAddedItems;
        private MetroFramework.Controls.MetroButton btnAddItem;
        private MetroFramework.Controls.MetroTextBox tbAddComand;
        private MetroFramework.Controls.MetroTextBox tbSellPrice;
        private MetroFramework.Controls.MetroLabel lblAddCommand;
        private MetroFramework.Controls.MetroLabel lblSellingPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton radioButton2;
        private MetroFramework.Controls.MetroRadioButton radioButton1;
        private MetroFramework.Controls.MetroButton btnAddTrade;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnDeleteTrade1;
        private MetroFramework.Controls.MetroButton btnDeleteTrade2;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroCheckBox chbKeyPrice;
        private MetroFramework.Controls.MetroButton btnAddKeyPrice;
        private MetroFramework.Controls.MetroTextBox tbKeyPrice;

    }
}

