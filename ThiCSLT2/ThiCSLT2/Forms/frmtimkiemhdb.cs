using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThiCSLT2.Class;


namespace ThiCSLT2.Forms
{
    public partial class frmtimkiemhdb : Form
    {
        DataTable tbltkhdb;
        public frmtimkiemhdb()
        {
            InitializeComponent();
        }

        private void frmtimkiemhdb_Load(object sender, EventArgs e)
        {
            Class.function.Connect();
            ResetValues();
            dgridtimkiemhdb.DataSource = null;

        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmahoadon.Focus();
        }
        private void Load_DataGridView()
        {
            dgridtimkiemhdb.Columns[0].HeaderText = "Mã hóa đơn bán";
            dgridtimkiemhdb.Columns[1].HeaderText = "Mã nhân viên";
            dgridtimkiemhdb.Columns[2].HeaderText = "Ngày bán";
            dgridtimkiemhdb.Columns[3].HeaderText = "Mã khách";
            dgridtimkiemhdb.Columns[4].HeaderText = "Tổng tiền";
            dgridtimkiemhdb.Columns[0].Width = 150;
            dgridtimkiemhdb.Columns[1].Width = 100;
            dgridtimkiemhdb.Columns[2].Width = 80;
            dgridtimkiemhdb.Columns[3].Width = 80;
            dgridtimkiemhdb.Columns[4].Width = 80;
            dgridtimkiemhdb.AllowUserToAddRows = false;
            dgridtimkiemhdb.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmahoadon.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") &&
               (txtmanhanvien.Text == "") && (txtmakhachhang.Text == "") &&
               (txttongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhoadonban WHERE 1=1";
            if (txtmahoadon.Text != "")
                sql = sql + " AND sohdb Like N'%" + txtmahoadon.Text + "%'";
            if (txtthang.Text != "")
                sql = sql + " AND MONTH(ngayban) =" + txtthang.Text;
            if (txtnam.Text != "")
                sql = sql + " AND YEAR(ngayban) =" + txtnam.Text;
            if (txtmanhanvien.Text != "")
                sql = sql + " AND manv Like N'%" + txtmanhanvien.Text + "%'";
            if (txtmakhachhang.Text != "")
                sql = sql + " AND makhach Like N'%" + txtmakhachhang.Text + "%'";
            if (txttongtien.Text != "")
                sql = sql + " AND tongtien <=" + txttongtien.Text;
            tbltkhdb = Class.function.GetDataToTable(sql);
            if (tbltkhdb.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltkhdb.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridtimkiemhdb.DataSource = tbltkhdb;
            Load_DataGridView();

        }

        private void dgridtimkiemhdb_Click(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgridtimkiemhdb.CurrentRow.Cells["sohdb"].Value.ToString();
                frmhoadonban frm = new frmhoadonban();
                frm.txtmahoadon.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridtimkiemhdb.DataSource = null;

        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
