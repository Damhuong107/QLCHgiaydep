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
    public partial class frmmua : Form
    {
        DataTable tblm;
        public frmmua()
        {
            InitializeComponent();
        }

        private void frmmua_Load(object sender, EventArgs e)
        {
            txtmamua.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblmua";
            tblm = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tblm;
            DataGridView.Columns[0].HeaderText = "Mã mùa";
            DataGridView.Columns[1].HeaderText = "Tên mùa";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmamua.Text = "";
            txttenmua.Text = "";
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamua.Focus();
                return;
            }
            if (tblm.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmamua.Text = DataGridView.CurrentRow.Cells["mamua"].Value.ToString();
            txttenmua.Text = DataGridView.CurrentRow.Cells["tenmua"].Value.ToString();
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
            txtmamua.Enabled = true;
            txtmamua.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamua.Focus();
                return;
            }
            if (txttenmua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmua.Focus();
                return;
            }
            sql = "SELECT mamua FROM tblmua WHERE mamua=N'" + txtmamua.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã mùa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamua.Focus();
                txtmamua.Text = "";
                return;
            }
            sql = "INSERT INTO tblmua (mamua,tenmua) VALUES(N'"
                + txtmamua.Text +"',N'" + txttenmua.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmamua.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmamua.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblm.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamua.Focus();
                return;
            }
            if (txttenmua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmua.Focus();
                return;
            }
            sql = "UPDATE tblmua SET tenmua=N'" + txttenmua.Text.ToString()+ "' where mamua=N'" + txtmamua.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblm.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblmua WHERE mamua=N'" + txtmamua.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
    }
}
