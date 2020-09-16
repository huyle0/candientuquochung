namespace candientuquochung
{
    partial class frmdangnhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lbllogo = new System.Windows.Forms.Label();
            this.logodangnhap = new System.Windows.Forms.Label();
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.cbbtaikhoan = new System.Windows.Forms.ComboBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(285, 104);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(138, 22);
            this.txtmatkhau.TabIndex = 14;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(193, 104);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(77, 20);
            this.lblmatkhau.TabIndex = 13;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaikhoan.Location = new System.Drawing.Point(189, 52);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(81, 20);
            this.lbltaikhoan.TabIndex = 11;
            this.lbltaikhoan.Text = "Tài khoản";
            // 
            // lbllogo
            // 
            this.lbllogo.Image = global::candientuquochung.Properties.Resources.logo;
            this.lbllogo.Location = new System.Drawing.Point(24, 9);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(133, 154);
            this.lbllogo.TabIndex = 10;
            // 
            // logodangnhap
            // 
            this.logodangnhap.AutoSize = true;
            this.logodangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.logodangnhap.Image = global::candientuquochung.Properties.Resources.logo;
            this.logodangnhap.Location = new System.Drawing.Point(65, 131);
            this.logodangnhap.Name = "logodangnhap";
            this.logodangnhap.Size = new System.Drawing.Size(0, 17);
            this.logodangnhap.TabIndex = 9;
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.Location = new System.Drawing.Point(205, 9);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(154, 32);
            this.lbldangnhap.TabIndex = 8;
            this.lbldangnhap.Text = "Đăng nhập";
            // 
            // cbbtaikhoan
            // 
            this.cbbtaikhoan.FormattingEnabled = true;
            this.cbbtaikhoan.Items.AddRange(new object[] {
            "thangcuto",
            ""});
            this.cbbtaikhoan.Location = new System.Drawing.Point(285, 52);
            this.cbbtaikhoan.Name = "cbbtaikhoan";
            this.cbbtaikhoan.Size = new System.Drawing.Size(138, 24);
            this.cbbtaikhoan.TabIndex = 15;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndangnhap.Location = new System.Drawing.Point(197, 153);
            this.btndangnhap.MaximumSize = new System.Drawing.Size(90, 40);
            this.btndangnhap.MinimumSize = new System.Drawing.Size(90, 40);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(90, 40);
            this.btndangnhap.TabIndex = 16;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnketthuc.Location = new System.Drawing.Point(333, 153);
            this.btnketthuc.MaximumSize = new System.Drawing.Size(90, 40);
            this.btnketthuc.MinimumSize = new System.Drawing.Size(90, 40);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(90, 40);
            this.btnketthuc.TabIndex = 17;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(454, 201);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.cbbtaikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.logodangnhap);
            this.Controls.Add(this.lbldangnhap);
            this.MaximumSize = new System.Drawing.Size(472, 248);
            this.MinimumSize = new System.Drawing.Size(472, 248);
            this.Name = "frmdangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Label logodangnhap;
        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.ComboBox cbbtaikhoan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnketthuc;
    }
}