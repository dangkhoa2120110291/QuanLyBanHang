using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        

        private void btExit_Click_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                this.Close();
        }

        private void btLogin_Click_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "123";
            if (user.Equals(txtUsername.Text) && pass.Equals(txtPassword.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }
    }
}
