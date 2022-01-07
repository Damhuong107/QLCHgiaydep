using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiCSLT2.Forms;
using System.Data.SqlClient;

namespace ThiCSLT2.Forms
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            Class.function.Connect();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnudangnhap_Click(object sender, EventArgs e)
        {
            frmdangnhap a = new frmdangnhap();
            a.Show();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            
        }

        private void mnukhachhang_Click(object sender, EventArgs e)
        {
            frmdanhmuckhachhang a = new frmdanhmuckhachhang();
            a.Show();
        }

        private void mnunhacungcap_Click(object sender, EventArgs e)
        {
            frmdanhmucnhacungcap a = new frmdanhmucnhacungcap();
            a.Show();
        }

        private void mnusp_Click(object sender, EventArgs e)
        {
            frmsanpham a = new frmsanpham();
            a.Show();
        }

        private void mnumua_Click(object sender, EventArgs e)
        {
            frmmua a = new frmmua();
            a.Show();

        }

        private void mnudoituong_Click(object sender, EventArgs e)
        {
            frmdoituong a = new frmdoituong();
            a.Show();
        }

        private void mnutheloai_Click(object sender, EventArgs e)
        {
            frmtheloai a = new frmtheloai();
            a.Show();
        }

        private void mnunsx_Click(object sender, EventArgs e)
        {
            frmnuocsx a = new frmnuocsx();
            a.Show();
        }

        private void mnuco_Click(object sender, EventArgs e)
        {
            frmco a = new frmco();
            a.Show();
        }

        private void mnuchatlieu_Click(object sender, EventArgs e)
        {
            frmchatlieu a = new frmchatlieu();
            a.Show();
        }

        private void mnumau_Click(object sender, EventArgs e)
        {
            frmmau a = new frmmau();
            a.Show();
        }

        private void mnuban_Click(object sender, EventArgs e)
        {
            frmhoadonban a = new frmhoadonban();
            a.Show();
        }

        private void mnutkhdn_Click(object sender, EventArgs e)
        {
            
        }

        private void mnutkhdb_Click(object sender, EventArgs e)
        {
            frmtimkiemhdb a = new frmtimkiemhdb();
            a.Show();
        }

        private void mnutksp_Click(object sender, EventArgs e)
        {
            frmtksp a = new frmtksp();
            a.Show();
        }
    }
}
