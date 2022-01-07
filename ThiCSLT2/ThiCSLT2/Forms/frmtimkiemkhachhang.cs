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
    public partial class frmtimkiemkhachhang : Form
    {
        DataTable tblkhachhang;
        public frmtimkiemkhachhang()
        {
            InitializeComponent();
        }

        private void frmtimkiemkhachhang_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvtimkiemkhachhang.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmakhach.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Hãy nhập mã khách hàng!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblkhachhang WHERE 1=1";
            if (txtmakhach.Text != "")
                sql = sql + " AND makhach Like N'%" + txtmakhach.Text + "%'";
            tblkhachhang = Class.function.GetDataToTable(sql);
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblkhachhang.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvtimkiemkhachhang.DataSource = tblkhachhang;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dgvtimkiemkhachhang.Columns[0].HeaderText = "Mã khách";
            dgvtimkiemkhachhang.Columns[1].HeaderText = "Tên khách";
            dgvtimkiemkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgvtimkiemkhachhang.Columns[3].HeaderText = "Điện thoại";
            dgvtimkiemkhachhang.Columns[0].Width = 150;
            dgvtimkiemkhachhang.Columns[1].Width = 100;
            dgvtimkiemkhachhang.Columns[2].Width = 80;
            dgvtimkiemkhachhang.Columns[3].Width = 80;
            dgvtimkiemkhachhang.AllowUserToAddRows = false;
            dgvtimkiemkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvtimkiemkhachhang.DataSource = null;
        }

        private void dgvtimkiemkhachhang_DoubleClick(object sender, EventArgs e)
        {
            string makhach;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                makhach = dgvtimkiemkhachhang.CurrentRow.Cells["makhach"].Value.ToString();
                frmtimkiemkhachhang frm = new frmtimkiemkhachhang();
                frm.txtmakhach.Text = makhach;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
