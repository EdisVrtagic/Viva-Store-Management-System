
namespace VivaStore
{
    partial class AProdControl
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pro_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PQty = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pro_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pro_icon
            // 
            this.pro_icon.Location = new System.Drawing.Point(29, 7);
            this.pro_icon.Name = "pro_icon";
            this.pro_icon.Size = new System.Drawing.Size(142, 114);
            this.pro_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pro_icon.TabIndex = 103;
            this.pro_icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PName);
            this.panel1.Location = new System.Drawing.Point(3, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 104;
            // 
            // PName
            // 
            this.PName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PName.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PName.ForeColor = System.Drawing.Color.White;
            this.PName.Location = new System.Drawing.Point(0, 0);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(200, 31);
            this.PName.TabIndex = 100;
            this.PName.Text = "Product name";
            this.PName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PName.MouseEnter += new System.EventHandler(this.ColClick_MouseEnter);
            this.PName.MouseLeave += new System.EventHandler(this.ColClick_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PPrice);
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 31);
            this.panel2.TabIndex = 105;
            // 
            // PPrice
            // 
            this.PPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPrice.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PPrice.ForeColor = System.Drawing.Color.White;
            this.PPrice.Location = new System.Drawing.Point(0, 0);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(200, 31);
            this.PPrice.TabIndex = 100;
            this.PPrice.Text = "Product price";
            this.PPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PPrice.MouseEnter += new System.EventHandler(this.ColClick_MouseEnter);
            this.PPrice.MouseLeave += new System.EventHandler(this.ColClick_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PQty);
            this.panel3.Location = new System.Drawing.Point(3, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 31);
            this.panel3.TabIndex = 106;
            // 
            // PQty
            // 
            this.PQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PQty.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PQty.ForeColor = System.Drawing.Color.White;
            this.PQty.Location = new System.Drawing.Point(0, 0);
            this.PQty.Name = "PQty";
            this.PQty.Size = new System.Drawing.Size(200, 31);
            this.PQty.TabIndex = 100;
            this.PQty.Text = "Product qty";
            this.PQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PQty.MouseEnter += new System.EventHandler(this.ColClick_MouseEnter);
            this.PQty.MouseLeave += new System.EventHandler(this.ColClick_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ProID);
            this.panel4.Location = new System.Drawing.Point(3, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 31);
            this.panel4.TabIndex = 107;
            // 
            // ProID
            // 
            this.ProID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProID.ForeColor = System.Drawing.Color.White;
            this.ProID.Location = new System.Drawing.Point(0, 0);
            this.ProID.Name = "ProID";
            this.ProID.Size = new System.Drawing.Size(200, 31);
            this.ProID.TabIndex = 100;
            this.ProID.Text = "Product ID";
            this.ProID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AProdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pro_icon);
            this.MinimumSize = new System.Drawing.Size(200, 232);
            this.Name = "AProdControl";
            this.Size = new System.Drawing.Size(200, 265);
            this.Load += new System.EventHandler(this.AProdControl_Load);
            this.MouseEnter += new System.EventHandler(this.ColClick_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ColClick_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pro_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PQty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.PictureBox pro_icon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ProID;
    }
}
