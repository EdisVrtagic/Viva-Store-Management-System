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
    public partial class AProfileControl : UserControl
    {
        public AProfileControl()
        {
            InitializeComponent();
        }
        private string _nameuser;
        private string _emailuser;
        private string _passuser;
        private string _addressuser;
        private string _rolesuser;
        private string _iduser;

        public string NameUser
        {
            get { return _nameuser; }
            set { _nameuser = value; NameProfile.Text = value; }
        }
        public string EmailUser
        {
            get { return _emailuser; }
            set { _emailuser = value; EmailProfile.Text = value; }
        }
        public string PassUser
        {
            get { return _passuser; }
            set { _passuser = value; PassProfile.Text = value; }
        }
        public string AddressUser
        {
            get { return _addressuser; }
            set { _addressuser = value; AddressProfile.Text = value; }
        }
        public string RolesUser
        {
            get { return _rolesuser; }
            set { _rolesuser = value; RoleProfile.Text = value; }
        }
        public string IDUser
        {
            get { return _iduser; }
            set { _iduser = value; IDProfile.Text = value; }
        }
        private void AProfileControl_Load(object sender, EventArgs e)
        {
            NameProfile.Click += new EventHandler((object senders, EventArgs es) => this.OnClick(es));
            EmailProfile.Click += new EventHandler((object senders, EventArgs es) => this.OnClick(es));
            PassProfile.Click += new EventHandler((object senders, EventArgs es) => this.OnClick(es));
            AddressProfile.Click += new EventHandler((object senders, EventArgs es) => this.OnClick(es));
            IDProfile.Click += new EventHandler((object senders, EventArgs es) => this.OnClick(es));
        }
        private void ColorClick_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 37, 40);
        }

        private void ColorClick_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 23, 27);
        }
    }
}
