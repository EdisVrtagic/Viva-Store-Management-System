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
    public partial class AProdControl : UserControl
    {
        public AProdControl()
        {
            InitializeComponent();
        }
        private Image _icon;
        private string _namepro;
        private string _pricepro;
        private string _qtypro;
        private string _idpro;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pro_icon.Image = value; }
        }
        public string ProductsName
        {
            get { return _namepro; }
            set { _namepro = value; PName.Text = value; }
        }
        public string ProductPrice
        {
            get { return _pricepro; }
            set { _pricepro = value; PPrice.Text = value; }
        }
        public string ProductQty
        {
            get { return _qtypro; }
            set { _qtypro= value; PQty.Text = value; }
        }
        public string ProductID
        {
            get { return _idpro; }
            set { _idpro = value; ProID.Text = value; }
        }
        private void ColClick_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }

        private void ColClick_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 23, 27);
        }

        private void AProdControl_Load(object sender, EventArgs e)
        {
            PName.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            PPrice.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            PQty.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            ProID.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            pro_icon.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
        }
    }
}
