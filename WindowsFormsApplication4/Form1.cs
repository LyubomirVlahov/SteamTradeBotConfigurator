using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data.SqlServerCe;
using MetroFramework.Controls;
using System.Text.RegularExpressions;
using MetroFramework.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Login login = new Login();
        Form1DAO form1DAO = new Form1DAO();
        Log log = new Log();

        string selectedItemName;
        string selectedQuality = "6";
        bool? selectedCraft = null;

        static int priceIndex = 2;
        int addedItems = 0;

        string items;

        MetroRadioButton rb1 = new MetroRadioButton();
        MetroRadioButton rb2 = new MetroRadioButton();

        double sellingPrice;
        string addCommand;

        List<Item> addedItemsList = new List<Item>();

        public Form1()
        {
            InitializeComponent();
            this.cbAllItems.SelectionChangeCommitted += new System.EventHandler(cbAllItems_SelectionChangeCommitted);
            this.cbQuality.SelectionChangeCommitted += new System.EventHandler(cbQuality_SelectionChangeCommitted);
            this.cbCraft.SelectionChangeCommitted += new System.EventHandler(cbCraft_SelectionChangeCommitted);
            this.radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
            this.radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
            this.btnDeleteTrade1.Click += new System.EventHandler(btnDeleteTrade_Click);
            this.btnDeleteTrade2.Click += new System.EventHandler(btnDeleteTrade_Click);
            this.chbKeyPrice.CheckedChanged += new System.EventHandler(chbKeyPrice_CheckedChanged);
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbQuality.SelectedIndex = -1;
            cbCraft.SelectedIndex = -1;

            LoadLoginFields();
            LoadItemsInListBox();          
            form1DAO.createTradeDB();
            LoadDataGridViews();
            LoadKeyPrice();
        }

        private void cbAllItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbQuality.Enabled = true;
            MetroComboBox comboBox = (MetroComboBox)sender;
            selectedItemName = comboBox.Text;
            int itemDefindex = form1DAO.getItemDefindexFromDB(selectedItemName);
            if (itemDefindex >= 190 && itemDefindex <= 212 || itemDefindex==655 || itemDefindex >= 736 && itemDefindex <= 737)
            {
                cbQuality.Text = "Strange";
                cbQuality.Enabled = false;
                selectedQuality = "11";
            }
            if (itemDefindex >= 0 && itemDefindex <= 30)
            {
                cbQuality.Text = "Unique";
                cbQuality.Enabled = false;
                selectedQuality = "6";
            }
            if (itemDefindex == 743)
            {
                cbQuality.Text = "Vintage";
                cbQuality.Enabled = false;
                selectedQuality = "3";
            }
        }

        private void cbQuality_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox)sender;
            string sq = comboBox.GetItemText(comboBox.SelectedItem);
            switch (sq)
            {
                case "Unique": selectedQuality = "6"; break;
                case "Strange": selectedQuality = "11"; break;
                case "Vintage": selectedQuality = "3"; break;
                case "Haunted": selectedQuality = "13"; break;
            }
        }

        private void cbCraft_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox)sender;
            string selectedCraftString = comboBox.GetItemText(comboBox.SelectedItem);
            if (selectedCraftString == "Uncraftable")
            {
                selectedCraft = false;
            }
            if (selectedCraftString == "Craftable")
            {
                selectedCraft = true;
            }
            if (selectedCraftString == "Both Craftable/Uncraftable")
            {
                selectedCraft = null;
            }
        }

        private void radioButton1_CheckedChanged(Object sender, EventArgs e)
        {
            resetFields1();
            resetFields2();
            addedItemsList.Clear();

            rb1 = (MetroRadioButton)sender;
            tbAddComand.Visible = false;
            tbSellPrice.Visible = true;
            lblSellingPrice.Visible = true;
            lblAddCommand.Visible = false;
            lblSellingPrice.Text = "Buying price: ";
        }


        private void radioButton2_CheckedChanged(Object sender, EventArgs e)
        {
            resetFields1();
            resetFields2();
            addedItemsList.Clear();

            rb2 = (MetroRadioButton)sender;
            addedItems = 0;
            lblSellingPrice.Visible = true;
            tbAddComand.Visible = true;
            tbSellPrice.Visible = true;
            lblAddCommand.Visible = true;
            lblSellingPrice.Text = "Selling price: ";
        }

        private void resetFields1()
        {
            selectedItemName = null;
            cbAllItems.SelectedIndex = -1;
            cbCraft.SelectedIndex = 0;
            cbQuality.SelectedIndex = 0;
            selectedCraft = null;
            selectedQuality = "6";
        }

        private void resetFields2()
        {
            addedItems = 0;
            tbAddComand.Clear();
            tbSellPrice.Clear();
            tbAddedItems.Clear();
        }

        

        private void btnSaveLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
                MessageBox.Show("You must enter password.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                LogginDetails details = new LogginDetails(login.readUserName(), tbPassword.Text, tbDisplayName.Text, tbDisplayNamePrefix.Text, tbChatResponse.Text);
                login.writeJsonToFile(login.EditJson(login.readJsonFile(), details));
            }
        }

        private void LoadKeyPrice()
        {
            if (form1DAO.getKeyPrice() != 0)
                tbKeyPrice.Text = form1DAO.getKeyPrice().ToString();
            else
            {
                tbKeyPrice.Clear();
                tbKeyPrice.Visible = false;
                btnAddKeyPrice.Visible = false;
            }
        }


        private void LoadLoginFields()
        {
            var lgn = login.getDetailsValues(login.readJsonFile());

            tbUserName.Text = lgn.UserName;
            tbDisplayName.Text = lgn.DisplayName;
            tbDisplayNamePrefix.Text = lgn.DisplayNamePrefix;
            tbChatResponse.Text = lgn.ChatResponse;
        }

        private void LoadItemsInListBox()
        {
                cbAllItems.DataSource = form1DAO.getItemsInListBox();
                cbAllItems.DisplayMember = "name";
                cbAllItems.SelectedIndex = -1;                 
        }

        private void LoadDataGridViews()
        {
            var resultSet = form1DAO.LoadDataGridViews();
            dataGridView1.DataSource = resultSet[0];
            dataGridView2.DataSource = resultSet[1];
            dataGridView1.Columns["itemid"].Visible = false;
            dataGridView2.Columns["itemid"].Visible = false;
        }

        private string setTextBox1(string q, bool? c)
        {
            string cr = "";
            switch (q)
            {
                case "6": q = "Unique"; break;
                case "11": q = "Strange"; break;
                case "3": q = "Vintage"; break;
                case "13": q = "Haunted"; break;
            }

            if (c == false)
            {
                cr = "Uncraftable";
            }
            if (c == true)
            {
                cr = "Craftable";
            }
            if (c == null)
            {
                cr = "Craftable/Uncraftable";
            }
            return "( " + q + ", " + cr + " ), " + "\r\n";
        }

        public void addNewTrade(string table)
        {
            addCommand = tbAddComand.Text;

            foreach (Item item in addedItemsList)
            {
                form1DAO.loadARowInItems(item, table);
                items += item.ItemName + setTextBox1(item.Quality, item.Craft);
            }

            form1DAO.loadARowIntoPrices(priceIndex, sellingPrice, addCommand);

            if (rb1.Checked == true)
            {
                form1DAO.loadARowIntoMultipleItemsForBuying(items, sellingPrice, priceIndex);
            }
            if (rb2.Checked == true)
            {
                form1DAO.loadARowIntoMultipleItemsForSelling(items, sellingPrice, addCommand, priceIndex);
            }

            priceIndex++;
            addedItemsList.Clear();
            LoadDataGridViews();
            resetFields1();
            resetFields2();
            items = "";
        }

        public bool validatePrice(string input)
        {
            Match match = Regex.Match(input, @"^\d+[\.\,](\d)\1$");
            if (match.Success && Double.TryParse(input, out sellingPrice))
                return true;
            else
                return false;
        }

        private void btnDeleteTrade_Click(object sender, EventArgs e)
        {
            string table1 = null;
            string table2 = null;
            int id = 0;

            if (MetrotabControl1.SelectedIndex == 2)
            {
                table1 = "ItemsForBuying";
                table2 = "MultipleItemsForBuying";
                id = dataGridView1.SelectedRows[0].Index + 1;
            }
            if (MetrotabControl1.SelectedIndex == 3)
            {
                table1 = "ItemsForSelling";
                table2 = "MultipleItemsForSelling";
                id = dataGridView2.SelectedRows[0].Index + 1;
            }

            form1DAO.deleteRow(table1, table2, id);           
            LoadDataGridViews();
        }

        private void addItem()
        {
            var item = form1DAO.getItemDefindexFromDB(selectedItemName);
            addedItemsList.Add(new Item(priceIndex, item, selectedItemName, selectedQuality, selectedCraft));
            tbAddedItems.Text += selectedItemName + setTextBox1(selectedQuality, selectedCraft);
        }

        private void addBuyItem()
        {
            if (addedItems == 0)
            {
                addCommand = "NULL";
                addItem();
                addedItems++;
            }
            else MessageBox.Show("You can add only 1 item.");
        }

           
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (selectedItemName != null)
            {
                if (rb1.Checked == true)
                {
                    addBuyItem();
                }
                else
                {
                    if (rb2.Checked == true)
                    {
                        addItem();
                    }
                    else MessageBox.Show("Sellect trade type!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Sellect item!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAddTrade_Click(object sender, EventArgs e)
        {

            if (rb1.Checked == true)
            {
                if (tbSellPrice.Text != "")
                {
                    if (validatePrice(tbSellPrice.Text))
                    {
                        addNewTrade("ItemsForBuying");
                    }
                    else
                        MessageBox.Show("Please write correct price.\n Price format is X,YY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    MessageBox.Show("Please write price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rb2.Checked == true)
            {
                if (tbSellPrice.Text != "" && tbAddComand.Text != "")
                {
                    if (validatePrice(tbSellPrice.Text))
                    {
                        addNewTrade("ItemsForSelling");
                    }
                    else
                        MessageBox.Show("Please write correct price.\n Price format is X,YY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tbAddComand.Text == "")
                    {
                        MessageBox.Show("Please write add command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (tbSellPrice.Text == "")
                    {
                        MessageBox.Show("Please write price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void chbKeyPrice_CheckedChanged(Object sender, EventArgs e)
        {
            if (chbKeyPrice.Checked == true)
            {
                tbKeyPrice.Visible = true;
                btnAddKeyPrice.Visible = true;
            }
            else
            {
                form1DAO.deleteKeyPrice();
                LoadKeyPrice();
                tbKeyPrice.Visible = false;
                btnAddKeyPrice.Visible = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (chbKeyPrice.Checked == true && validatePrice(tbKeyPrice.Text))
            {
                if (Convert.ToDouble(tbKeyPrice.Text) != form1DAO.getKeyPrice())
                form1DAO.addKeyBuyPrice(Convert.ToDouble(tbKeyPrice.Text));
            }
            else
                MessageBox.Show("Please write correct price.\n Price format is X,YY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
