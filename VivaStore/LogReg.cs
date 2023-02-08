using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VivaStore
{
    public partial class LogReg : Form
    {
        public LogReg()
        {
            InitializeComponent();
        }
        //Database connection
        static string cone = ConfigurationManager.ConnectionStrings["VCS"].ConnectionString;
        SqlConnection Con = new SqlConnection(cone);
        //Load form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load functions
            VisibleComponent();
        }
        //Visible component
        private void VisibleComponent()
        {
            //Register/login form
            regPanel.Visible = false;
            uaeMess.Visible = false;
            pdneMess.Visible = false;
            siP.Visible = false;
            suP.Location = new Point(62, 564);
            suP.Visible = true;
            //Other
        }
        //Reset login data
        private void ResetL()
        {
            maLog.Text = "";
            passLog.Text = "";
        }
        //Reset registration data
        private void ResetR()
        {
            FName.Text = "";
            boxEmail.Text = "";
            boxAddress.Text = "";
            boxPass.Text = "";
        }
        //Timer form opacity
        private void timerForm_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timerForm.Stop();
            }
            Opacity += .2;
        }
        //signUp button
        private void signUp_Click(object sender, EventArgs e)
        {
            if (siP.Visible == false)
            {
                ResetR();
                logPanel.Visible = false;
                regPanel.Location = new Point(2, 104);
                regPanel.Visible = true;
                suP.Visible = false;
                siP.Location = new Point(85, 564);
                siP.Visible = true;
            }
            else
            {
                regPanel.Visible = false;
                logPanel.Visible = true;
                siP.Visible = false;
            }
        }
        //signIn button
        private void signIn_Click(object sender, EventArgs e)
        {
            if (suP.Visible == false)
            {
                ResetL();
                regPanel.Visible = false;
                logPanel.Visible = true;
                siP.Visible = false;
                suP.Visible = true;
            }
            else
            {
                logPanel.Visible = false;
                regPanel.Visible = true;
                suP.Visible = false;
            }
        }
        //Facebook direct link profile
        private void fbBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/don.marquez60");
        }
        //YouTube direct link channel
        private void ytBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/DonMarquez21");
        }
        //GitHub direct link profile
        private void gitBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EdisVrtagic");
        }
        //RegLog close button
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Register user button
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || boxEmail.Text == "" || boxAddress.Text == "" || boxPass.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                Con.Open();
                string querys = "select * from UserTbl where Email ='" + boxEmail.Text + "'";
                SqlCommand cmds = new SqlCommand(querys, Con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a;
                a = ds.Tables[0].Rows.Count;
                if (a == 1)
                {
                    uaeMess.Visible = true;
                    TimerError.Start();
                }
                else
                {
                    string query = "insert into UserTbl values('" + FName.Text + "','" + boxEmail.Text + "','" + boxAddress.Text + "','" + boxPass.Text + "','user')";
                    string queryss = "insert into UDataTbl values('" + FName.Text + "','" + boxEmail.Text + "','0','0','None','None','None','No')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlCommand cmdss = new SqlCommand(queryss, Con);
                    cmd.ExecuteNonQuery();
                    cmdss.ExecuteNonQuery();
                    MessageBox.Show("Profile created.");
                    ResetR();
                    Con.Close();
                }
                Con.Close();
            }
        }
        //Login user button
        public static string accem;
        public static string accrole;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (maLog.Text == "" || passLog.Text == "")
            {
                MessageBox.Show("Enter the requested information!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Email='" + maLog.Text + "' and Password='" + passLog.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sdaa = new SqlDataAdapter("select Role from UserTbl where Email='" + maLog.Text + "' and Password='" + passLog.Text + "'", Con);
                    DataTable dtt = new DataTable();
                    sdaa.Fill(dtt);
                    accem = maLog.Text;
                    accrole = dtt.Rows[0][0].ToString();
                    if (accrole == "user")
                    {
                        this.Hide();
                        UserDash usd = new UserDash();
                        usd.Show();
                    }
                    else if (accrole == "administrator")
                    {
                        this.Hide();
                        AdminDash adas = new AdminDash();
                        adas.Show();
                    }
                    Con.Close();
                }
                else
                {
                    pdneMess.Visible = true;
                    TimerError2.Start();
                }
            }
            Con.Close();
        }
        //User already exists message
        private void TimerError_Tick(object sender, EventArgs e)
        {
            if (TimerError.Interval == 1800)
            {
                uaeMess.Visible = false;
                TimerError.Stop();
            }
        }
        //Profile does not exist message
        private void TimerError2_Tick(object sender, EventArgs e)
        {
            if (TimerError2.Interval == 1800)
            {
                pdneMess.Visible = false;
                TimerError2.Stop();
            }
        }
    }
}
