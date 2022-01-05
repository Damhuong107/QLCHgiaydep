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
using ThiCSLT2.Forms;

namespace ThiCSLT2.Forms
{
    public partial class frmco : Form
    {
        DataTable tblc;
        public frmco()
        {
            InitializeComponent();
        }

        private void frmco_Load(object sender, EventArgs e)
        {
            txtmaco.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblco";
            tblc = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tblc;
            DataGridView.Columns[0].HeaderText = "Mã cỡ";
            DataGridView.Columns[1].HeaderText = "Tên cỡ";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmaco.Text = "";
            txttenco.Text = "";
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaco.Focus();
                return;
            }
            if (tblc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaco.Text = DataGridView.CurrentRow.Cells["maco"].Value.ToString();
            txttenco.Text = DataGridView.CurrentRow.Cells["tenco"].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmaco.Enabled = true;
            txtmaco.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaco.Focus();
                return;
            }
            if (txttenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenco.Focus();
                return;
            }
            sql = "UPDATE tblco SET tenco=N'" + txttenco.Text.ToString()
                + "' where maco=N'" + txtmaco.Text+ "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblco WHERE maco=N'" + txtmaco.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaco.Focus();
                return;
            }
            if (txttenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenco.Focus();
                return;
            }
            sql = "SELECT maco FROM tblco WHERE maco=N'" +txtmaco.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã cỡ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaco.Focus();
                txtmaco.Text = "";
                return;
            }
            sql = "INSERT INTO tblco (maco,tenco) VALUES(N'" + txtmaco.Text + "',N'" + txttenco.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaco.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaco.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
