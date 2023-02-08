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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }
        //Database connection
        static string conect = ConfigurationManager.ConnectionStrings["VCS"].ConnectionString;
        SqlConnection Con = new SqlConnection(conect);
        //AdminDash load
        private void AdminDash_Load(object sender, EventArgs e)
        {
            getAdminData();
            getInfoData();
            visibleAdminComponent();
        }
        //Visible Admin Component
        private void visibleAdminComponent()
        {
            //Date label
            dateLabel.Text = DateTime.Now.ToShortDateString();
            addProdPanel.Location = new Point(525, 319);
            addProdPanel.Visible = false;
            panel1.Location = new Point(238, 326);
            panel1.Visible = false;
            panel3.Location = new Point(238, 326);
            panel3.Visible = false;
            flowLayoutPanel2.Location = new Point(258, 369);
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Location = new Point(274, 369);
            flowLayoutPanel3.Visible = false;
            searchBox.Location = new Point(1201, 333);
            searchBox.Visible = false;
            guna2Panel6.Visible = false;

        }
        //Function Info Data
        private void getInfoData()
        {
            SqlDataAdapter sdt = new SqlDataAdapter("select count (Role) from UserTbl where Role = 'user'", Con);
            DataTable dr = new DataTable();
            sdt.Fill(dr);
            TotUsers.Text = dr.Rows[0][0].ToString();

            SqlDataAdapter sdt2 = new SqlDataAdapter("select count (Role) from UserTbl where Role = 'administrator'", Con);
            DataTable dr2 = new DataTable();
            sdt2.Fill(dr2);
            TotAdmin.Text = dr2.Rows[0][0].ToString();

            SqlDataAdapter sdt3 = new SqlDataAdapter("select count(*) from ProductsTbl", Con);
            DataTable dr3 = new DataTable();
            sdt3.Fill(dr3);
            TotProd.Text = dr3.Rows[0][0].ToString();

            SqlDataAdapter sdt4 = new SqlDataAdapter("select Budget from BudgetTbl", Con);
            DataTable dr4 = new DataTable();
            sdt4.Fill(dr4);
            BudgetLabel.Text = "€" +dr4.Rows[0][0].ToString();
        }
        //Function Admin Data
        private void getAdminData()
        {
            SqlDataAdapter sd = new SqlDataAdapter("select UserName from UDataTbl where UserEmail = '" + LogReg.accem + "'", Con);
            DataTable d = new DataTable();
            sd.Fill(d);
            AFName.Text = d.Rows[0][0].ToString();

            SqlDataAdapter sde = new SqlDataAdapter("select UserEmail from UDataTbl where UserEmail = '" + LogReg.accem + "'", Con);
            DataTable de = new DataTable();
            sde.Fill(de);
            AEmail.Text = de.Rows[0][0].ToString();
            Con.Close();
        }
        //Dynamic user profile control list
        public void GenerateDynamicProfileControl()
        {
            flowLayoutPanel2.Controls.Clear();
            DataTable dt = ReadProfileTable();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    AProfileControl[] listItems = new AProfileControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new AProfileControl();
                            listItems[i].IDUser = "ID: " + row["ID"].ToString();
                            listItems[i].NameUser = row["FullName"].ToString();
                            listItems[i].EmailUser = row["Email"].ToString();
                            listItems[i].AddressUser = row["Address"].ToString();
                            listItems[i].PassUser = row["Password"].ToString();
                            listItems[i].RolesUser = "Role: " + row["Role"].ToString();
                            flowLayoutPanel2.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
        //Reading profiles from the database
        public DataTable ReadProfileTable()
        {
            string query = "SELECT * FROM UserTbl";
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
        //Dynamic products control list
        public void GenerateDynamicProductsControl()
        {
            flowLayoutPanel3.Controls.Clear();
            DataTable dt = ReadProductTable();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    AProdControl[] listItems = new AProdControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new AProdControl();
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].ProductID = "ID: " + row["IDP"].ToString();
                            listItems[i].ProductsName = "Product: "+row["Product"].ToString();
                            listItems[i].ProductPrice = "Price: "+row["Price"].ToString()+" €";
                            listItems[i].ProductQty = "Quantity: "+row["Quantity"].ToString();
                            flowLayoutPanel3.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
        //Reading products from the database
        public DataTable ReadProductTable()
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
        //Logout admin button
        private void logAdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogReg logr = new LogReg();
            logr.Show();
        }
        //Admin button list users
        private void listUserAdminBtn_Click(object sender, EventArgs e)
        {
            GenerateDynamicProfileControl();
            flowLayoutPanel3.Visible = false;
            addProdPanel.Visible = false;
            searchBox.Visible = true;
            panel1.Visible = true;
            panel3.Visible = false;
            flowLayoutPanel2.Visible = true;
        }
        //Search box full name user
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var wdg = (AProfileControl)item;
                wdg.Visible = wdg.NameUser.ToLower().ToLower().Contains(searchBox.Text.Trim().ToLower());
            }
        }
        //Admin delete user button
        private void delUsBtn_Click(object sender, EventArgs e)
        {
            if (searchBoxEmail.Text == "")
            {
                MessageBox.Show("Enter the user email!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Email='" + searchBoxEmail.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sdat = new SqlDataAdapter("select count(*) from UDataTbl where UserEmail='" + searchBoxEmail.Text + "'", Con);
                    DataTable dtt = new DataTable();
                    sdat.Fill(dtt);
                    if (dtt.Rows[0][0].ToString() == "1")
                    {
                        string query = "delete from UserTbl where Email='" + searchBoxEmail.Text + "'";
                        string query1 = "delete from UDataTbl where UserEmail='" + searchBoxEmail.Text + "'";
                        string query2 = "delete from OrdersTbl where CustEmail='" + searchBoxEmail.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        SqlCommand cmd1 = new SqlCommand(query1, Con);
                        SqlCommand cmd2 = new SqlCommand(query2, Con);
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        searchBoxEmail.Text = "";
                        GenerateDynamicProfileControl();
                        getInfoData();
                        getAdminData();
                        MessageBox.Show("User profile deleted!");
                        Con.Close();
                    }
                }
                else
                {
                    searchBoxEmail.Text = "";
                    MessageBox.Show("Error email");
                }
            }
            Con.Close();
        }
        //Browse image product
        private void BrowseImageLabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                prodPicPrew.Image = image;
                pGetName.Text = Path.GetFullPath(opendlg.FileName);
                FileInfo fs = new FileInfo(pGetName.Text);
                long filesize = fs.Length;
                pGetSize.Text = Convert.ToString("Image Size: " + filesize);
                guna2Panel6.Visible = true;
            }
        }
        //Close browse image button
        private void closeimgBtn_Click(object sender, EventArgs e)
        {
            prodPicPrew.Image = null;
            pGetName.Text = "";
            pGetSize.Text = "";
            guna2Panel6.Visible = false;
        }
        //Add product
        private void addproBtn_Click(object sender, EventArgs e)
        {
            if (NamePro.Text == "" || PricePro.Text == "" || QtyPro.Text == "" || prodPicPrew.Image == null)
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                Con.Open();
                string query = "Insert into ProductsTbl(Product,Price,Quantity,Image)values(@Product,@Price,@Quantity,@Image)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        Image img = prodPicPrew.Image;
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                        cmd.Parameters.AddWithValue("@Product", NamePro.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", PricePro.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", QtyPro.Text.Trim());
                        cmd.Parameters.AddWithValue("@Image", arr.ToArray());
                        cmd.ExecuteNonQuery();
                        NamePro.Text = "";
                        PricePro.Text = "";
                        QtyPro.Text = "";
                        prodPicPrew.Image = null;
                        guna2Panel6.Visible = false;
                        getInfoData();
                        MessageBox.Show("Product added!");
                        Con.Close();
                    }
                }
                catch
                {

                }
            }
        }
        //Add product button
        private void addProdAdminBtn_Click(object sender, EventArgs e)
        {
            addProdPanel.Visible = true;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = false;
            searchBox.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
        }
        //List products button
        private void listProdAdminBtn_Click(object sender, EventArgs e)
        {
            addProdPanel.Visible = false;
            flowLayoutPanel2.Visible = false;
            searchBox.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            GenerateDynamicProductsControl();
            flowLayoutPanel3.Visible = true;
        }
        //Home admin button
        private void homeAdminBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = false;
            addProdPanel.Visible = false;
            searchBox.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            flowLayoutPanel2.Visible = false;
        }
        //Delete product button
        private void delProBtn_Click(object sender, EventArgs e)
        {
            if (searchIDPro.Text == "")
            {
                MessageBox.Show("Enter ID product!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductsTbl where IDP='" + searchIDPro.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                        string query = "delete from ProductsTbl where IDP='" + searchIDPro.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        searchIDPro.Text = "";
                        GenerateDynamicProductsControl();
                        getInfoData();
                        MessageBox.Show("Product deleted!");
                        Con.Close();
                }
                else
                {
                    searchIDPro.Text = "";
                    MessageBox.Show("Error ID");
                }
            }
            Con.Close();
        }
    }
}
