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
    public partial class frmnuocsx : Form
    {
        DataTable tblnsx;
        public frmnuocsx()
        {
            InitializeComponent();
        }
        private void frmnuocsx_Load(object sender, EventArgs e)
        {
            txtmanuocsx.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblnuocsanxuat";
            tblnsx = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tblnsx;
            DataGridView.Columns[0].HeaderText = "Mã nước sản xuất";
            DataGridView.Columns[1].HeaderText = "Tên nước sản xuất";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanuocsx.Focus();
                return;
            }
            if (tblnsx.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanuocsx.Text = DataGridView.CurrentRow.Cells["manuocsx"].Value.ToString();
            txttennuocsx.Text = DataGridView.CurrentRow.Cells["tennuocsx"].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }
        private void ResetValues()
        {
            txtmanuocsx.Text = "";
            txttennuocsx.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmanuocsx.Enabled = true;
            txtmanuocsx.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnsx.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanuocsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanuocsx.Focus();
                return;
            }
            if (txttennuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennuocsx.Focus();
                return;
            }
            sql = "UPDATE tblnuocsanxuat SET tennuocsx=N'" + txttennuocsx.Text.ToString() + "' where manuocsx=N'" + txtmanuocsx.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnsx.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanuocsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblnuocsanxuat WHERE manuocsx=N'" + txtmanuocsx.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanuocsx.Focus();
                return;
            }
            if (txttennuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennuocsx.Focus();
                return;
            }
            sql = "SELECT manuocsx FROM tblnuocsanxuat WHERE manuocsx=N'" + txtmanuocsx.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã nước sản xuất này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanuocsx.Focus();
                txtmanuocsx.Text = "";
                return;
            }
            sql = "INSERT INTO tblnuocsanxuat (manuocsx,tennuocsx) VALUES(N'"
                + txtmanuocsx.Text + "',N'" + txttennuocsx.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmanuocsx.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanuocsx.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
