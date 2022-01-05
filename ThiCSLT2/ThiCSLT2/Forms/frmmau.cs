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
    public partial class frmmau : Form
    {
        DataTable tblma;
        public frmmau()
        {
            InitializeComponent();
        }

        private void frmmau_Load(object sender, EventArgs e)
        {
            txtmamau.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblmau";
            tblma = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tblma;
            DataGridView.Columns[0].HeaderText = "Mã màu";
            DataGridView.Columns[1].HeaderText = "Tên màu";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamau.Focus();
                return;
            }
            if (tblma.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmamau.Text = DataGridView.CurrentRow.Cells["mamau"].Value.ToString();
            txttenmau.Text = DataGridView.CurrentRow.Cells["tenmau"].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }
        private void ResetValues()
        {
            txtmamau.Text = "";
            txttenmau.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmamau.Enabled = true;
            txtmamau.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblma.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamau.Focus();
                return;
            }
            if (txttenmau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmau.Focus();
                return;
            }
            sql = "UPDATE tblmau SET tenmau=N'" + txttenmau.Text.ToString() + "' where mamau=N'" + txtmamau.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblma.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblmau WHERE mamau=N'" + txtmamau.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Focus();
                return;
            }
            if (txttenmau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmau.Focus();
                return;
            }
            sql = "SELECT mamau FROM tblmau WHERE mamau=N'" + txtmamau.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã màu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Focus();
                txtmamau.Text = "";
                return;
            }
            sql = "INSERT INTO tblmau (mamau,tenmau) VALUES(N'"
                + txtmamau.Text + "',N'" + txttenmau.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmamau.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmamau.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
