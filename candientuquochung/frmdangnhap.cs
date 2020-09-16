using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace candientuquochung
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       


        private void btndangnhap_Click(object sender, EventArgs e)
        {
            /*
              if (string.IsNullOrEmpty(txtUsr.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản","Tài khoản không thể để trống",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtUsr.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPwd.Select();
                return;
            }
             */
            this.Hide();
            frmmain frm = new frmmain();
            frm.Show();
            
        }
    }
}
