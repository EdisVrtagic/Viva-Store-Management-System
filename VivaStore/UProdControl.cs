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
    public partial class UProdControl : UserControl
    {
        public UProdControl()
        {
            InitializeComponent();
        }
        private Image _prodicon;
        private string _nameproduct;
        private string _priceproduct;
        private string _prqty;
        public Image IconPro
        {
            get { return _prodicon; }
            set { _prodicon = value; product_icon.Image = value; }
        }
        public string NameProd
        {
            get { return _nameproduct; }
            set { _nameproduct = value; PrName.Text = value; }
        }
        public string PriceProd
        {
            get { return _priceproduct; }
            set { _priceproduct = value; ProPrice.Text = value; }
        }
        public string QtyProd
        {
            get { return _prqty; }
            set { _prqty = value;}
        }
        private void UProdControl_Load(object sender, EventArgs e)
        {
            product_icon.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
            PrName.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
            ProPrice.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
            ProLabel1.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
            ProPrice1.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
            CurrPro.Click += new EventHandler((object senders, EventArgs pro) => this.OnClick(pro));
        }

        private void Cols_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 23, 27);
        }

        private void Cols_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }
    }
}
