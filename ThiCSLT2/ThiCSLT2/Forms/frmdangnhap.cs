using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiCSLT2.Forms
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dangnhap()
        {
            if (txtusername.Text.Length == 0 && txtpass.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
            else
                if (this.txtusername.Text.Length == 0)
                MessageBox.Show("Bạn chưa điền Tài khoản");
            else
                if (this.txtpass.Text.Length == 0)
                MessageBox.Show("Bạn chưa điền Mật khẩu");
            else
                if (this.txtusername.Text == "chgiaydep" && this.txtpass.Text == "de4")
                MessageBox.Show("Đăng nhập thành công!");
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng!");
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmmain fm = new frmmain();
            if (this.txtusername.Text == "chgiaydep" && this.txtpass.Text == "de4")
            {
                fm.Show();
            }
            dangnhap();
        }
    }
}
