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
            mnudanhmuc.Enabled = false;
            mnuhoadon.Enabled= false;
            mnutimkiem.Enabled = false;
            mnubaocao.Enabled = false;

        }
        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmdangnhap dn = new Forms.frmdangnhap();
            dn.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnusp_Click(object sender, EventArgs e)
        {
            ThiCSLT2.frmsanpham f = new ThiCSLT2.frmsanpham();
            f.Show();
        }
    }
}
