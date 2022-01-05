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
    public partial class frmdoituong : Form
    {
        DataTable tbldt;
        public frmdoituong()
        {
            InitializeComponent();
        }

        private void frmdoituong_Load(object sender, EventArgs e)
        {
            txtmadoituong.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tbldoituong";
            tbldt = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tbldt;
            DataGridView.Columns[0].HeaderText = "Mã đối tượng";
            DataGridView.Columns[1].HeaderText = "Tên đối tượng";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadoituong.Focus();
                return;
            }
            if (tbldt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmadoituong.Text = DataGridView.CurrentRow.Cells["madoituong"].Value.ToString();
            txttendoituong.Text = DataGridView.CurrentRow.Cells["tendoituong"].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }
        private void ResetValues()
        {
            txtmadoituong.Text = "";
            txttendoituong.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmadoituong.Enabled = true;
            txtmadoituong.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbldt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadoituong.Focus();
                return;
            }
            if (txttendoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendoituong.Focus();
                return;
            }
            sql = "UPDATE tbldoituong SET tendoituong=N'" + txttendoituong.Text.ToString() + "' where madoituong=N'" + txtmadoituong.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbldt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbldoituong WHERE madoituong=N'" + txtmadoituong.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadoituong.Focus();
                return;
            }
            if (txttendoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendoituong.Focus();
                return;
            }
            sql = "SELECT madoituong FROM tbldoituong WHERE madoituong=N'" + txtmadoituong.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã đối tượng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadoituong.Focus();
                txtmadoituong.Text = "";
                return;
            }
            sql = "INSERT INTO tbldoituong (madoituong,tendoituong) VALUES(N'"
                + txtmadoituong.Text + "',N'" + txttendoituong.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmadoituong.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmadoituong.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
