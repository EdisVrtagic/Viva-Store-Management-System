using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static VivaStore.AProfileControl;

namespace VivaStore
{
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();
        }
        //Database connection
        static string conse = ConfigurationManager.ConnectionStrings["VCS"].ConnectionString;
        SqlConnection Con = new SqlConnection(conse);
        //Wallet variables
        int oldwallet, inputwallet, newwallet, newwallet1, oldspent, newspent;
        //Product calculator variables
        int prodprice, inputqty, totprice;
        //Product quantity variables
        int oldprodqty, newprodqty;
        int procondition;
        //Budget store variables
        int oldbudget, newbudget;
        //Credit card string
        public static string cardadd;
        public static string cardyes = "Yes";
        //UserDash load form
        private void UserDash_Load(object sender, EventArgs e)
        {
            //Date label
            dateLabel.Text = DateTime.Now.ToShortDateString();
            //Load functions
            getUserData();
            getCreditCard();
            GenerateDynamicOrderControl();
            visibleComponentDash();
        }
        //Visible component user dashboard
        private void visibleComponentDash()
        {
            flowLayoutPanel2.Location = new Point(306, 162);
            flowLayoutPanel2.Visible = false;
            label15.Location = new Point(302, 130);
            label15.Visible = false;
            prodBuyPanel.Location = new Point(618, 159);
            prodBuyPanel.Visible = false;
            flowLayoutPanel1.Location = new Point(257, 108);
            flowLayoutPanel1.Visible = false;
            panel1.Location = new Point(257, 69);
            panel1.Visible = false;
            panel3.Location = new Point(601, 16);
            panel3.Visible = false;
            AddCCPanel.Location = new Point(598,332);
            LoadDataGif.Location = new Point(723,334);
            DataPanels.Location = new Point(386, 128);
            AddCCPanel.Visible = false;
            LoadDataGif.Visible = false;
        }
        //Function User Data
        private void getUserData()
        {
            SqlDataAdapter sd = new SqlDataAdapter("select UserName from UDataTbl where UserEmail = '" + LogReg.accem + "'", Con);
            DataTable d = new DataTable();
            sd.Fill(d);
            UFName.Text = d.Rows[0][0].ToString();

            SqlDataAdapter sde = new SqlDataAdapter("select UserEmail from UDataTbl where UserEmail = '" + LogReg.accem + "'", Con);
            DataTable de = new DataTable();
            sde.Fill(de);
            UEmail.Text = de.Rows[0][0].ToString();
            Con.Close();
        }
        //Function Credit Card user
        private void getCreditCard()
        {
            Con.Open();
            SqlDataAdapter sdt = new SqlDataAdapter("select CCAdd from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable det = new DataTable();
            sdt.Fill(det);
            cardadd = det.Rows[0][0].ToString();
            if (cardadd == "No")
            {
                NameCC.Enabled = true;
                CCNum.Enabled = true;
                ExpirDate.Enabled = true;
                addCCBtn.Enabled = true;
                CCCBtn.Enabled = true;
                addMoneyBox.Enabled = false;
                addMonBtn.Enabled = false;
                BuyCardBtn.Enabled = false;
            }
            else if (cardadd == "Yes")
            {
                NameCC.Enabled = false;
                CCNum.Enabled = false;
                ExpirDate.Enabled = false;
                addCCBtn.Enabled = false;
                CCCBtn.Enabled = false;
                addMoneyBox.Enabled = true;
                addMonBtn.Enabled = true;
                BuyCardBtn.Enabled = true;
                if (NameCC.Enabled == false || CCNum.Enabled == false || ExpirDate.Enabled == false)
                {
                    NameCC.PlaceholderText = "Disabled";
                    CCNum.PlaceholderText = "Disabled";
                    ExpirDate.PlaceholderText = "Disabled";
                }
            }

            SqlDataAdapter duser = new SqlDataAdapter("select CCName from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable dete = new DataTable();
            duser.Fill(dete);
            FNCard.Text = dete.Rows[0][0].ToString();

            SqlDataAdapter dusers = new SqlDataAdapter("select right (CCNum,4) from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable detes = new DataTable();
            dusers.Fill(detes);
            CardNum.Text = detes.Rows[0][0].ToString();

            SqlDataAdapter duserss = new SqlDataAdapter("select left (CCExp,4) from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable detess = new DataTable();
            duserss.Fill(detess);
            ExpDate.Text = detess.Rows[0][0].ToString();

            SqlDataAdapter sda = new SqlDataAdapter("select Wallet from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            WallLabel.Text = "€" + dt.Rows[0][0].ToString();
            oldwallet = int.Parse(dt.Rows[0][0].ToString());

            SqlDataAdapter sdas = new SqlDataAdapter("select TotalSpent from UDataTbl where UserEmail = '" + UEmail.Text + "'", Con);
            DataTable dts = new DataTable();
            sdas.Fill(dts);
            TotSpLabel.Text = "-€" + dts.Rows[0][0].ToString();
            oldspent = int.Parse(dts.Rows[0][0].ToString());
            Con.Close();
        }
        //Logout button
        private void logUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogReg log = new LogReg();
            log.Show();
        }
        //Money user button
        private void moneyUserBtn_Click(object sender, EventArgs e)
        {
            DataPanels.Visible = true;
            flowLayoutPanel2.Visible = false;
            label15.Visible = false;
            prodBuyPanel.Visible = false;
            QtyBox.Text = "";
            panel1.Visible = false;
            panel3.Visible = false;
            flowLayoutPanel1.Visible = false;
            AddCCPanel.Visible = true;
        }
        //Dashboard user button
        private void dashUserBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            label15.Visible = false;
            prodBuyPanel.Visible = false;
            QtyBox.Text = "";
            panel1.Visible = false;
            panel3.Visible = false;
            flowLayoutPanel1.Visible = false;
            AddCCPanel.Visible = false;
            DataPanels.Visible = true;
        }
        //Products user button
        private void prodUserBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            label15.Visible = false;
            AddCCPanel.Visible = false;
            prodBuyPanel.Visible = false;
            QtyBox.Text = "";
            panel3.Visible = true;
            GenerateDynamicProdControl();
            flowLayoutPanel1.Visible = true;
            panel1.Visible = true;
        }
        //Orders user button
        private void orderUserBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            prodBuyPanel.Visible = false;
            DataPanels.Visible = false;
            QtyBox.Text = "";
            panel3.Visible = false;
            panel1.Visible = false;
            AddCCPanel.Visible = false;
            flowLayoutPanel2.Visible = true;
            label15.Visible = true;
        }
        //Add credit card user button
        private void addCCBtn_Click(object sender, EventArgs e)
        {
            if (NameCC.Text == "" || CCNum.Text == "" || ExpirDate.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                try
                {
                        Con.Open();
                        string query = "update UDataTbl set CCName ='" + NameCC.Text + "', CCNum = '" + CCNum.Text + "', CCExp = '" + ExpirDate.Text + "', CCAdd = '" + cardyes + "' where UserEmail = '" + UEmail.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        DataPanels.Visible = false;
                        AddCCPanel.Visible = false;
                        LoadDataGif.Visible = true;
                        TimerLoad.Start();
                    }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }
        //Reset data user textBox
        private void ResetData()
        {
            NameCC.Text = "";
            CCNum.Text = "";
            ExpirDate.Text = "";
            addMoneyBox.Text = "";
        }
        //Cancel add credit card user button
        private void CCCBtn_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        //Timer load database
        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            if (TimerLoad.Interval == 1600)
            {
                LoadDataGif.Visible = false;
                TimerLoad.Stop();
                getCreditCard();
                ResetData();
                Con.Close();
                DataPanels.Visible = true;
                AddCCPanel.Visible = true;
            }
        }
        //Add money user textBox
        private void addMonBtn_Click(object sender, EventArgs e)
        {
            if (addMoneyBox.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                try
                {
                    int val;
                    val = int.Parse(addMoneyBox.Text);
                    if (val < 1 || val > 1000)
                    {
                        MessageBox.Show("The minimum amount is 1 and the maximum amount is 1000!");
                    }
                    else
                    {
                        inputwallet = int.Parse(addMoneyBox.Text);
                        newwallet = oldwallet + inputwallet;
                        Con.Open();
                        string query = "update UDataTbl set Wallet ='" + newwallet + "' where UserEmail = '" + UEmail.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        DataPanels.Visible = false;
                        AddCCPanel.Visible = false;
                        LoadDataGif.Visible = true;
                        TimerLoad.Start();
                    }
                }
                catch (Exception)
                {

                }
            }
            Con.Close();
        }
        //Dynamic product control list
        public void GenerateDynamicProdControl()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = ReadProdTable();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UProdControl[] listItems = new UProdControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new UProdControl();
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            listItems[i].IconPro = new Bitmap(ms);
                            listItems[i].NameProd = row["Product"].ToString();
                            listItems[i].PriceProd = row["Price"].ToString();
                            listItems[i].QtyProd = row["Quantity"].ToString();
                            flowLayoutPanel1.Controls.Add(listItems[i]);
                            listItems[i].Click += new EventHandler(this.BuyControl_Click);

                        }
                    }
                }
            }
        }
        //Reading products from the database
        public DataTable ReadProdTable()
        {
            string query = "SELECT * FROM ProductsTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
        //Product click deatils
        void BuyControl_Click(object sender, EventArgs es)
        {
            UProdControl obj = (UProdControl)sender;
            producticon.Image = obj.IconPro;
            ProductN.Text = obj.NameProd;
            ProductP.Text = obj.PriceProd;
            prodprice = int.Parse(obj.PriceProd);
            oldprodqty = int.Parse(obj.QtyProd);
            prodBuyPanel.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            DataPanels.Visible = false;
            flowLayoutPanel1.Visible = false;
        }
        //Dynamic product control list
        public void GenerateDynamicOrderControl()
        {
            flowLayoutPanel2.Controls.Clear();
            DataTable dt = ReadOrdTable();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UOrdersControl[] listItems = new UOrdersControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new UOrdersControl();
                            listItems[i].Customer_Name = row["CustName"].ToString();
                            listItems[i].Customer_Address = row["CustDeliver"].ToString();
                            listItems[i].Customer_Product = row["CustProduct"].ToString();
                            listItems[i].Customer_PriceProd = row["CustPrice"].ToString();
                            listItems[i].Customer_QtyProd = row["CustQty"].ToString();
                            listItems[i].Customer_Payment = row["CustPayment"].ToString();
                            listItems[i].Customer_TotalPrice = row["CustTotal"].ToString();
                            flowLayoutPanel2.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }
        //Reading orders from the database
        public DataTable ReadOrdTable()
        {
            string query = "SELECT * FROM OrdersTbl where CustEmail = '" + UEmail.Text +"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
        //Search product box
        private void searchBoxProd_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (UProdControl)item;
                wdg.Visible = wdg.NameProd.ToLower().ToLower().Contains(searchBoxProd.Text.Trim().ToLower());
            }
        }
        //Close Buy button
        private void closeBuyBtn_Click(object sender, EventArgs e)
        {
            prodBuyPanel.Visible = false;
            panel1.Visible = true;
            panel3.Visible = true;
            QtyBox.Text = "";
            flowLayoutPanel1.Visible = true;
        }
        //Buy card product button
        private void BuyCardBtn_Click(object sender, EventArgs e)
        {
            if (QtyBox.Text == "" || AddressBox.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                Con.Open();
                string querys = "select * from UserTbl where Email ='" + UEmail.Text + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 1)
                {
                    try
                    {
                        int val1;
                        val1 = int.Parse(QtyBox.Text);
                        if (val1 < 1 || val1 > 10)
                        {
                            MessageBox.Show("The minimum number of products is 1, and the maximum is 10!");
                        }
                        else
                        {
                            SqlDataAdapter sdaas = new SqlDataAdapter("select Quantity from ProductsTbl where Product='" + ProductN.Text + "'", Con);
                            DataTable dtts = new DataTable();
                            sdaas.Fill(dtts);
                            procondition = int.Parse(dtts.Rows[0][0].ToString());
                        }
                        if (procondition < val1)
                        {
                            MessageBox.Show("Desired quantity is out of stock!");
                        }
                        else
                        {
                            inputqty = int.Parse(QtyBox.Text);
                            totprice = prodprice * inputqty;
                            SqlDataAdapter sdaas2 = new SqlDataAdapter("select Wallet from UDataTbl where UserEmail='" + UEmail.Text + "'", Con);
                            DataTable dtts2 = new DataTable();
                            sdaas2.Fill(dtts2);
                            oldwallet = int.Parse(dtts2.Rows[0][0].ToString());
                            if (oldwallet < totprice)
                            {
                                MessageBox.Show("You don't have enough money on your card!");
                            }
                            else
                            {
                                newprodqty = oldprodqty - inputqty;
                                newwallet1 = oldwallet - totprice;
                                newspent = oldspent + totprice;
                                SqlDataAdapter sdt4 = new SqlDataAdapter("select Budget from BudgetTbl", Con);
                                DataTable dr4 = new DataTable();
                                sdt4.Fill(dr4);
                                oldbudget = int.Parse(dr4.Rows[0][0].ToString());
                                string query = "insert into OrdersTbl values('" + UEmail.Text + "','" + UFName.Text + "','" + AddressBox.Text + "','" + ProductN.Text + "','" + ProductP.Text + "','" + QtyBox.Text + "','Card','" + totprice + "')";
                                SqlCommand cmd = new SqlCommand(query, Con);
                                cmd.ExecuteNonQuery();
                                string queryy = "update ProductsTbl set Quantity ='" + newprodqty + "' where Product = '" + ProductN.Text + "';";
                                SqlCommand cmdr = new SqlCommand(queryy, Con);
                                cmdr.ExecuteNonQuery();
                                string queryy1 = "update UDataTbl set Wallet ='" + newwallet1 + "' where UserEmail = '" + UEmail.Text + "';";
                                SqlCommand cmdr1 = new SqlCommand(queryy1, Con);
                                cmdr1.ExecuteNonQuery();
                                string queryy2 = "update UDataTbl set TotalSpent ='" + newspent + "' where UserEmail = '" + UEmail.Text + "';";
                                SqlCommand cmdr2 = new SqlCommand(queryy2, Con);
                                cmdr2.ExecuteNonQuery();
                                newbudget = oldbudget + totprice;
                                string queryy3 = "update BudgetTbl set Budget ='" + newbudget + "';";
                                SqlCommand cmdr3 = new SqlCommand(queryy3, Con);
                                cmdr3.ExecuteNonQuery();
                                Con.Close();
                                getCreditCard();
                                GenerateDynamicOrderControl();
                                QtyBox.Text = "";
                                MessageBox.Show("Order successful!");
                                prodBuyPanel.Visible = false;
                                panel1.Visible = true;
                                panel3.Visible = true;
                                flowLayoutPanel1.Visible = true;
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                Con.Close();
            }
        }
        //Buy manually product button
        private void BuyManBtn_Click(object sender, EventArgs e)
        {
            if (QtyBox.Text == "" || AddressBox.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                Con.Open();
                string querys = "select * from UserTbl where Email ='" + UEmail.Text + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 1)
                {
                    try
                    {
                        int val2;
                        val2 = int.Parse(QtyBox.Text);
                        if (val2 < 1 || val2 > 10)
                        {
                            MessageBox.Show("The minimum number of products is 1, and the maximum is 10!");
                        }
                        else
                        {
                            SqlDataAdapter sdaas3 = new SqlDataAdapter("select Quantity from ProductsTbl where Product='" + ProductN.Text + "'", Con);
                            DataTable dtts3 = new DataTable();
                            sdaas3.Fill(dtts3);
                            procondition = int.Parse(dtts3.Rows[0][0].ToString());
                        }
                        if (procondition < val2)
                        {
                            MessageBox.Show("Desired quantity is out of stock!");
                        }
                        else
                        {
                            inputqty = int.Parse(QtyBox.Text);
                            totprice = prodprice * inputqty;
                            newprodqty = oldprodqty - inputqty;
                            string query = "insert into OrdersTbl values('" + UEmail.Text + "','" + UFName.Text + "','" + AddressBox.Text + "','" + ProductN.Text + "','" + ProductP.Text + "','" + QtyBox.Text + "','Manually','" + totprice + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            string queryy = "update ProductsTbl set Quantity ='" + newprodqty + "' where Product = '" + ProductN.Text + "';";
                            SqlCommand cmdr = new SqlCommand(queryy, Con);
                            cmdr.ExecuteNonQuery();
                            Con.Close();
                            GenerateDynamicOrderControl();
                            QtyBox.Text = "";
                            MessageBox.Show("Order successful!");
                            prodBuyPanel.Visible = false;
                            panel1.Visible = true;
                            panel3.Visible = true;
                            flowLayoutPanel1.Visible = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                Con.Close();
            }
        }
    }
}
