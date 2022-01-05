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
    public partial class frmtheloai : Form
    {
        DataTable tbll;
        public frmtheloai()
        {
            InitializeComponent();
        }
        private void frmtheloai_Load(object sender, EventArgs e)
        {
            Class.function.Connect();
            txtmaloai.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tbltheloai";
            tbll = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tbll;
            DataGridView.Columns[0].HeaderText = "Mã thể loại";
            DataGridView.Columns[1].HeaderText = "Tên thể loại";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (tbll.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaloai.Text = DataGridView.CurrentRow.Cells["maloai"].Value.ToString();
            txttenloai.Text = DataGridView.CurrentRow.Cells["tenloai"].Value.ToString();
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
        }
        private void ResetValues()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmaloai.Enabled = true;
            txtmaloai.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbll.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloai.Focus();
                return;
            }
            sql = "UPDATE tbltheloai SET tenloai=N'" + txttenloai.Text.ToString() + "' where maloai=N'" + txtmaloai.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbll.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbltheloai WHERE maloai=N'" + txtmaloai.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloai.Focus();
                return;
            }
            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloai.Focus();
                return;
            }
            sql = "SELECT maloai FROM tbltheloai WHERE maloai=N'" + txtmaloai.Text.Trim() + "'";
            if (Class.function.CheckKey(sql))
            {
                MessageBox.Show("Mã loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloai.Focus();
                txtmaloai.Text = "";
                return;
            }
            sql = "INSERT INTO tbltheloai (maloai,tenloai) VALUES(N'"+ txtmaloai.Text + "',N'" + txttenloai.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
