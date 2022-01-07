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
    public partial class frmtimkiemnhacungcap : Form
    {
        DataTable tblnhacungcap;
        public frmtimkiemnhacungcap()
        {
            InitializeComponent();
        }

        private void timkiemnhacungcap_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvtimkiemnhacungcap.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmancc.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Hãy nhập mã nhà cung cấp!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblnhacungcap WHERE 1=1";
            if (txtmancc.Text != "")
                sql = sql + " AND mancc Like N'%" + txtmancc.Text + "%'";
            tblnhacungcap = Class.function.GetDataTable(sql);
            if (tblnhacungcap.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblnhacungcap.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvtimkiemnhacungcap.DataSource = tblnhacungcap;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dgvtimkiemnhacungcap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvtimkiemnhacungcap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvtimkiemnhacungcap.Columns[2].HeaderText = "Địa chỉ";
            dgvtimkiemnhacungcap.Columns[3].HeaderText = "Điện thoại";
            dgvtimkiemnhacungcap.Columns[0].Width = 150;
            dgvtimkiemnhacungcap.Columns[1].Width = 100;
            dgvtimkiemnhacungcap.Columns[2].Width = 80;
            dgvtimkiemnhacungcap.Columns[3].Width = 80;
            dgvtimkiemnhacungcap.AllowUserToAddRows = false;
            dgvtimkiemnhacungcap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvtimkiemnhacungcap.DataSource = null;
        }

        private void dgvtimkiemnhacungcap_DoubleClick(object sender, EventArgs e)
        {
            string mancc;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mancc = dgvtimkiemnhacungcap.CurrentRow.Cells["mancc"].Value.ToString();
                frmtimkiemnhacungcap frm = new frmtimkiemnhacungcap();
                frm.txtmancc.Text = mancc;
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
