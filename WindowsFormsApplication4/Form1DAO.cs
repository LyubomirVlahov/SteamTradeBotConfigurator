using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication4
{
    public class Form1DAO
    {
        Log log2 = new Log();
        string logPath = @"C:\Documents and Settings\lubo\My Documents\Visual Studio 2010\Projects\WindowsFormsApplication4\log.txt";

        public int getItemDefindexFromDB(string name)
        {
            int def = 0;

            SqlCeConnection cn = new SqlCeConnection("DataSource=\"AllItemsDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            string sql = "select defindex from AllItems ";
            sql += "where name like '" + name + "%' ";


            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, cn);
                cmd.CommandType = CommandType.Text;

                // If you need to be able to update the result set, instead use:
                SqlCeResultSet rs = cmd.ExecuteResultSet(
                ResultSetOptions.Scrollable | ResultSetOptions.Updatable);

                if (rs.HasRows)
                {
                    int oredItemDefindex = rs.GetOrdinal("defindex");
                    rs.ReadFirst();
                    def = rs.GetInt32(oredItemDefindex);
                }
                else
                {
                    MessageBox.Show("I'm not finding this item in my database. Select Item Name!", "Oh Crap.",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            finally
            {
                cn.Close();
            }
            return def;
        }

        public void loadARowInItems(Item item, string table)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            SqlCeCommand cmd;

            string sql = "insert into " + table
              + "(id, Defindex, ItemName, ItemQuality, IsCraft)"
              + "values (@id, @defindex, @itemname, @itemquality, @iscraft)";

            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@defindex", item.Defindex);
                cmd.Parameters.AddWithValue("@itemname", item.ItemName);
                cmd.Parameters.AddWithValue("@itemquality", item.Quality);
                if (item.Craft != null)
                {
                    cmd.Parameters.AddWithValue("@iscraft", item.Craft);
                }
                else
                    cmd.Parameters.AddWithValue("@iscraft", DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            finally
            {
                cn.Close();
            }
        }

        public void loadARowIntoMultipleItemsForBuying(string itemname, double price, int priceIndex)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            SqlCeCommand cmd;

            string sql = "insert into MultipleItemsForBuying"
              + "(Names, Buyingprice, itemid)"
              + "values (@names, @price, @itemid)";

            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@names", itemname);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@itemid", priceIndex);
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
        }

        public void loadARowIntoMultipleItemsForSelling(string itemname, double price, string command, int priceIndex)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            SqlCeCommand cmd;

            string sql = "insert into MultipleItemsForSelling"
              + "(Names, Sellingprice, addCommand, itemid)"
              + "values (@names, @price, @command, @itemid)";

            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@names", itemname);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@command", command);
                cmd.Parameters.AddWithValue("@itemid", priceIndex);
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
        }

        public void loadARowIntoPrices(int index, double price, string command)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            SqlCeCommand cmd;

            string sql = "insert into Prices "
              + "(id, price, addCommand)"
              + "values (@id, @price, @command)";

            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", index);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@command", command);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success! Trade was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            finally
            {
                cn.Close();
            }
        }

        public void createTradeDB()
        {
            string connectionString = "DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"";
            if (File.Exists("TradeDB.sdf"))
            {
                File.Delete("TradeDB.sdf");
            }

            SqlCeEngine en = new SqlCeEngine(connectionString);
            en.CreateDatabase();

            SqlCeConnection cn = new SqlCeConnection(connectionString);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlCeCommand ItemsForBuying;
            SqlCeCommand CreatePrices;
            SqlCeCommand ItemsForSelling;
            SqlCeCommand MultipleItemsForBuying;
            SqlCeCommand MultipleItemsForSelling;

            string sql1 = "CREATE TABLE ItemsForBuying ("
                        + "id INT, "
                        + "Defindex SMALLINT NOT NULL, "
                        + "ItemName NVARCHAR (70), "
                        + "ItemQuality NVARCHAR (10), "
                        + "IsCraft BIT )";

            string sql2 = "CREATE TABLE ItemsForSelling ("
                        + "id INT, "
                        + "Defindex SMALLINT NOT NULL, "
                        + "ItemName NVARCHAR (70), "
                        + "ItemQuality NVARCHAR (10), "
                        + "IsCraft BIT )";

            string sql3 = "CREATE TABLE Prices ("
                        + "id INT NOT NULL , "
                        + "price FLOAT NOT NULL, "
                        + "addCommand NVARCHAR(100), "
                        + "constraint pk_id primary key (id))";

            string sql4 = "CREATE TABLE MultipleItemsForBuying("
                        + "id INT IDENTITY (1, 1), "
                        + "Names NVARCHAR (256), "
                        + "Buyingprice FLOAT, "
                        + "itemid INT NOT NULL )";

            string sql5 = "CREATE TABLE MultipleItemsForSelling ("
                        + "id INT IDENTITY (1, 1), "
                        + "Names NVARCHAR (1024), "
                        + "Sellingprice FLOAT, "
                        + "addCommand NVARCHAR(100), "
                        + "itemid INT NOT NULL )";

            ItemsForBuying = new SqlCeCommand(sql1, cn);
            ItemsForSelling = new SqlCeCommand(sql2, cn);
            CreatePrices = new SqlCeCommand(sql3, cn);
            MultipleItemsForBuying = new SqlCeCommand(sql4, cn);
            MultipleItemsForSelling = new SqlCeCommand(sql5, cn);

            try
            {
                CreatePrices.ExecuteNonQuery();
                ItemsForBuying.ExecuteNonQuery();
                ItemsForSelling.ExecuteNonQuery();
                MultipleItemsForBuying.ExecuteNonQuery();
                MultipleItemsForSelling.ExecuteNonQuery();

            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show(sqlexception.Message, "Something goes wrong. Please try again or contact with seller.",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something goes wrong. Please try again or contact with seller.", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<SqlCeResultSet> LoadDataGridViews()
        {
            List<SqlCeResultSet> dgvResultSets = new List<SqlCeResultSet>();
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");

            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            try
            {
                // Set the command to use the table, not a query
                SqlCeCommand cmd1 = new SqlCeCommand("MultipleItemsForBuying", cn);
                cmd1.CommandType = CommandType.TableDirect;

                SqlCeCommand cmd2 = new SqlCeCommand("MultipleItemsForSelling", cn);
                cmd2.CommandType = CommandType.TableDirect;

                dgvResultSets.Add(cmd1.ExecuteResultSet(ResultSetOptions.Scrollable));
                dgvResultSets.Add(cmd2.ExecuteResultSet(ResultSetOptions.Scrollable));
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            return dgvResultSets;
        }

        public void deleteRow(string table1, string table2, int id)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");

            string sql1 = "DELETE FROM " + table1 + " WHERE id like " + getItemsID(table2, id);
            string sql3 = "DELETE FROM " + table2 + " WHERE id like " + id;
            string sql2 = "DELETE FROM Prices " + "WHERE id like " + getItemsID(table2, id);

            try
            {
                using (SqlCeCommand com = new SqlCeCommand(sql1, cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    com.ExecuteNonQuery();
                }
                using (SqlCeCommand com = new SqlCeCommand(sql3, cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    com.ExecuteNonQuery();
                }
                using (SqlCeCommand com = new SqlCeCommand(sql2, cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    com.ExecuteNonQuery();
                }
                MessageBox.Show("Success! Trade was removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.Message, w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.Message, w);
                }
            }
        }

        public int getItemsID(string table, int id)
        {
            int index = 0;

            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            string sql = "select itemid from " + table + " where id like '" + id + "%' ";

            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, cn);
                cmd.CommandType = CommandType.Text;

                // If you need to be able to update the result set, instead use:
                SqlCeResultSet rs = cmd.ExecuteResultSet(
                ResultSetOptions.Scrollable | ResultSetOptions.Updatable);

                if (rs.HasRows)
                {
                    int oredItemID = rs.GetOrdinal("itemid");
                    rs.ReadFirst();
                    index = rs.GetInt32(oredItemID);
                }
                else
                {
                    MessageBox.Show("I'm not finding this item in my database. Select Item Name!", "Oh Crap.",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.Message, w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.Message, w);
                }
            }
            finally
            {
                cn.Close();
            }

            return index;
        }

        public SqlCeResultSet getItemsInListBox()
        {
            SqlCeResultSet rs = null;
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"AllItemsDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            try
            {
                // Set the command to use the table, not a query
                SqlCeCommand cmd = new SqlCeCommand("AllItems", cn);
                cmd.CommandType = CommandType.TableDirect;


                rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);


            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            return rs;
        }

        public void addKeyBuyPrice(double price)
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            SqlCeCommand cmd;

            string sql = "insert into Prices "
              + "(id, price, addCommand)"
              + "values (@id, @price, @command)";

            try
            {
                cmd = new SqlCeCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@command", "asd6565");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success! Key price was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            finally
            {
                cn.Close();
            }
        }

        public double getKeyPrice()
        {
            double price = 0;
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");
            if (cn.State == ConnectionState.Closed) { cn.Open(); }

            string sql = "select price from Prices where id like '" + 1 + "%' ";

            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, cn);
                cmd.CommandType = CommandType.Text;

                // If you need to be able to update the result set, instead use:
                SqlCeResultSet rs = cmd.ExecuteResultSet(
                ResultSetOptions.Scrollable | ResultSetOptions.Updatable);

                if (rs.HasRows)
                {
                    int oredItemID = rs.GetOrdinal("price");
                    rs.ReadFirst();
                    price = rs.GetDouble(oredItemID);
                }

            }
            catch (SqlCeException sqlexception)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(sqlexception.ToString(), w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's problem. Please contact customer support.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (StreamWriter w = File.AppendText(logPath))
                {
                    log2.LogMessage(ex.ToString(), w);
                }
            }
            finally
            {
                cn.Close();
            }

            return price;
        }

        public void deleteKeyPrice()
        {
            SqlCeConnection cn = new SqlCeConnection("DataSource=\"TradeDB.sdf\"; Password=\"mypassword\"");

            string sql1 = "DELETE FROM Prices WHERE id like " + 1;

            using (SqlCeCommand com = new SqlCeCommand(sql1, cn))
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                com.ExecuteNonQuery();
            }
        }
    }
}
