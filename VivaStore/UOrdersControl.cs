using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaStore
{
    public partial class UOrdersControl : UserControl
    {
        public UOrdersControl()
        {
            InitializeComponent();
        }
        private string _custname;
        private string _deladdress;
        private string _custproname;
        private string _custprices;
        private string _custqtys;
        private string _custpayme;
        private string _custtotprice;
        public string Customer_Name
        {
            get { return _custname; }
            set { _custname = value; CName.Text = value; }
        }
        public string Customer_Address
        {
            get { return _deladdress; }
            set { _deladdress = value; CAddress.Text = value; }
        }
        public string Customer_Product
        {
            get { return _custproname; }
            set { _custproname = value; CProdName.Text = value; }
        }
        public string Customer_PriceProd
        {
            get { return _custprices; }
            set { _custprices = value; CProdPrice.Text = value; }
        }
        public string Customer_QtyProd
        {
            get { return _custqtys; }
            set { _custqtys = value; CProdQty.Text = value; }
        }
        public string Customer_Payment
        {
            get { return _custpayme; }
            set { _custpayme = value; CPayMet.Text = value; }
        }
        public string Customer_TotalPrice
        {
            get { return _custtotprice; }
            set { _custtotprice = value; CTotPay.Text = value; }
        }
        private void Colr_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 23, 27);
        }

        private void Colr_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }

        private void UOrdersControl_Load(object sender, EventArgs e)
        {

        }
    }
}
