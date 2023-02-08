
namespace VivaStore
{
    partial class AProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AProfileControl));
            this.profile_icon = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.NameProfile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmailProfile = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassProfile = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddressProfile = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IDProfile = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RoleProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile_icon
            // 
            this.profile_icon.Image = ((System.Drawing.Image)(resources.GetObject("profile_icon.Image")));
            this.profile_icon.Location = new System.Drawing.Point(14, 20);
            this.profile_icon.Name = "profile_icon";
            this.profile_icon.Size = new System.Drawing.Size(104, 93);
            this.profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_icon.TabIndex = 103;
            this.profile_icon.TabStop = false;
            this.profile_icon.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.profile_icon.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // NameProfile
            // 
            this.NameProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameProfile.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameProfile.ForeColor = System.Drawing.Color.White;
            this.NameProfile.Location = new System.Drawing.Point(0, 0);
            this.NameProfile.Name = "NameProfile";
            this.NameProfile.Size = new System.Drawing.Size(215, 31);
            this.NameProfile.TabIndex = 104;
            this.NameProfile.Text = "Name and Surname";
            this.NameProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameProfile.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.NameProfile.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameProfile);
            this.panel1.Location = new System.Drawing.Point(124, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 31);
            this.panel1.TabIndex = 105;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EmailProfile);
            this.panel2.Location = new System.Drawing.Point(124, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 31);
            this.panel2.TabIndex = 106;
            // 
            // EmailProfile
            // 
            this.EmailProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailProfile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailProfile.ForeColor = System.Drawing.Color.White;
            this.EmailProfile.Location = new System.Drawing.Point(0, 0);
            this.EmailProfile.Name = "EmailProfile";
            this.EmailProfile.Size = new System.Drawing.Size(215, 31);
            this.EmailProfile.TabIndex = 104;
            this.EmailProfile.Text = "User Email";
            this.EmailProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmailProfile.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.EmailProfile.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PassProfile);
            this.panel3.Location = new System.Drawing.Point(124, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 31);
            this.panel3.TabIndex = 107;
            // 
            // PassProfile
            // 
            this.PassProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassProfile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassProfile.ForeColor = System.Drawing.Color.White;
            this.PassProfile.Location = new System.Drawing.Point(0, 0);
            this.PassProfile.Name = "PassProfile";
            this.PassProfile.Size = new System.Drawing.Size(215, 31);
            this.PassProfile.TabIndex = 104;
            this.PassProfile.Text = "User Password";
            this.PassProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AddressProfile);
            this.panel4.Location = new System.Drawing.Point(124, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 31);
            this.panel4.TabIndex = 108;
            // 
            // AddressProfile
            // 
            this.AddressProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressProfile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressProfile.ForeColor = System.Drawing.Color.White;
            this.AddressProfile.Location = new System.Drawing.Point(0, 0);
            this.AddressProfile.Name = "AddressProfile";
            this.AddressProfile.Size = new System.Drawing.Size(215, 31);
            this.AddressProfile.TabIndex = 104;
            this.AddressProfile.Text = "User Address";
            this.AddressProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressProfile.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.AddressProfile.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.IDProfile);
            this.panel5.Location = new System.Drawing.Point(14, -3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 28);
            this.panel5.TabIndex = 109;
            // 
            // IDProfile
            // 
            this.IDProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDProfile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDProfile.ForeColor = System.Drawing.Color.White;
            this.IDProfile.Location = new System.Drawing.Point(0, 0);
            this.IDProfile.Name = "IDProfile";
            this.IDProfile.Size = new System.Drawing.Size(104, 28);
            this.IDProfile.TabIndex = 104;
            this.IDProfile.Text = "ID";
            this.IDProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IDProfile.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.IDProfile.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RoleProfile);
            this.panel6.Location = new System.Drawing.Point(14, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 28);
            this.panel6.TabIndex = 110;
            // 
            // RoleProfile
            // 
            this.RoleProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleProfile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleProfile.ForeColor = System.Drawing.Color.White;
            this.RoleProfile.Location = new System.Drawing.Point(0, 0);
            this.RoleProfile.Name = "RoleProfile";
            this.RoleProfile.Size = new System.Drawing.Size(325, 28);
            this.RoleProfile.TabIndex = 104;
            this.RoleProfile.Text = "Role";
            this.RoleProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoleProfile.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.RoleProfile.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            // 
            // AProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profile_icon);
            this.MinimumSize = new System.Drawing.Size(370, 153);
            this.Name = "AProfileControl";
            this.Size = new System.Drawing.Size(370, 153);
            this.Load += new System.EventHandler(this.AProfileControl_Load);
            this.MouseEnter += new System.EventHandler(this.ColorClick_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ColorClick_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profile_icon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label AddressProfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PassProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EmailProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label IDProfile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label RoleProfile;
    }
}
