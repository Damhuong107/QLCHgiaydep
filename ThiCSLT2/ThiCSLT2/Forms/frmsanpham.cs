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

namespace ThiCSLT2
{
    public partial class frmsanpham : Form
    {
        DataTable tblsp;
        public frmsanpham()
        {
            InitializeComponent();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmagiaydep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giày dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmagiaydep.Focus();
                return;
            }
            if (txttengiaydep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giày dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttengiaydep.Focus();
                return;
            }
            //1
            if (cbomamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamau.Focus();
                return;
            }
            //2
            if (cbomamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }
            //3
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            //4
            if (cbomadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomadoituong.Focus();
                return;
            }
            //5
            if (cbomanuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanuocsx.Focus();
                return;
            }
            //6
            if (cbomachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            //7
            if (cbomaco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaco.Focus();
                return;
            }
            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnopen.Focus();
                return;
            }
            string sql;
            sql = "SELECT magiaydep FROM tblsanpham WHERE magiaydep = N'" + txtmagiaydep.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmagiaydep.Focus();
                txttengiaydep.Text = "";
                return;
            }
            sql = "INSERT INTO tblHanghoa (magiaydep,tengiaydep,mamau,machatlieu,maco,madoituong,maloai,mamua,manuocsx,soluong,dongianhap,dongiaban,anh) VALUES(N'"
                + txtmagiaydep.Text.Trim() +
                "',N'" + txttengiaydep.Text.Trim() +
                "',N'" + cbomamau.SelectedValue.ToString() +
                "',N'" + cbomachatlieu.SelectedValue.ToString() +
                "',N'" + cbomaco.SelectedValue.ToString() +
                "',N'" + cbomadoituong.SelectedValue.ToString() +
                "',N'" + cbomaloai.SelectedValue.ToString() +
                "',N'" + cbomamua.SelectedValue.ToString() +
                "',N'" + cbomanuocsx.SelectedValue.ToString() +
                "'," + txtsoluong.Text.Trim() +
                "," + txtdongianhap.Text.Trim() +
                "," + txtdongiaban.Text.Trim() +
                ",'" + txtanh.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmagiaydep.Enabled = false;
        }

        private void frmsanpham_Load(object sender, EventArgs e)
        {
            Class.function.Connect();
            txtmagiaydep.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            function.FillCombo("Select mamau,tenmau from tblmau", cbomamau, "mamau", "tenmau");
            cbomamau.SelectedIndex = -1;
            function.FillCombo("Select mamua,tenmua from tblmua", cbomamua, "mamua", "tenmua");
            cbomamua.SelectedIndex = -1;
            function.FillCombo("Select maloai,tenloai from tbltheloai", cbomaloai, "maloai", "tenloai");
            cbomaloai.SelectedIndex = -1;
            function.FillCombo("Select machatlieu,tenchatlieu from tblchatlieu", cbomachatlieu, "machatlieu", "tenchatlieu");
            cbomachatlieu.SelectedIndex = -1;
            function.FillCombo("Select maco,tenco from tblco", cbomaco, "maco", "tenco");
            cbomaco.SelectedIndex = -1;
            function.FillCombo("Select madoituong from tbldoituong", cbomadoituong, "madoituong", "tendoituong");
            cbomadoituong.SelectedIndex = -1;
            function.FillCombo("Select manuocsx from tblnuocsx", cbomanuocsx, "manuocsx", "tennuocsx");
            cbomanuocsx.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select * from tblsanpham ";
            tblsp = Class.function.GetDataToTable(sql);
            DataGridView.DataSource = tblsp;
            DataGridView.Columns[0].HeaderText = "Mã sản phẩm";
            DataGridView.Columns[1].HeaderText = "Tên sản phẩm";
            DataGridView.Columns[2].HeaderText = "Mã loại";
            DataGridView.Columns[3].HeaderText = "Mã cỡ";
            DataGridView.Columns[4].HeaderText = "Mã chất liệu";
            DataGridView.Columns[5].HeaderText = "Mã màu";
            DataGridView.Columns[6].HeaderText = "Mã chất liệu";
            DataGridView.Columns[7].HeaderText = "Mã đối tượng";
            DataGridView.Columns[8].HeaderText = "Mã mùa";
            DataGridView.Columns[9].HeaderText = "Mã nước SX";
            DataGridView.Columns[10].HeaderText = "Số lượng";
            DataGridView.Columns[11].HeaderText = "Đơn giá nhập";
            DataGridView.Columns[12].HeaderText = "Đơn giá bán";
            DataGridView.Columns[13].HeaderText = "Ảnh";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmagiaydep.Text = "";
            txttengiaydep.Text = "";
            cbomanuocsx.Text = "";
            cbomamua.Text = "";
            cbomamau.Text = "";
            cbomaloai.Text = "";
            cbomachatlieu.Text = "";
            cbomadoituong.Text = "";
            cbomaco.Text = "";
            txtsoluong.Text = "0";
            txtdongianhap.Text = "0";
            txtdongiaban.Text = "0";
            txtsoluong.Enabled = true;
            txtdongianhap.Enabled = true;
            txtdongiaban.Enabled = true;
            txtanh.Text = "";
            anhsanpham.Image = null;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            string sql;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmagiaydep.Focus();
                return;
            }
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
  MessageBoxIcon.Information);
                return;
            }
            txtmagiaydep.Text = DataGridView.CurrentRow.Cells["Mahang"].Value.ToString();
            txttengiaydep.Text = DataGridView.CurrentRow.Cells["Tenhang"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["mamau"].Value.ToString();
            sql = "select tenmau from tblmau where mamau =N'" + ma + "'";
            cbomamau.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["mamua"].Value.ToString();
            sql = "select tenmua from tblmua where mamua =N'" + ma + "'";
            cbomamua.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["maco"].Value.ToString();
            sql = "select tenco from tblco where maco =N'" + ma + "'";
            cbomaco.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["machatlieu"].Value.ToString();
            sql = "select tenchatlieu from tblchatlieu where machatlieu =N'" + ma + "'";
            cbomachatlieu.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["madoituong"].Value.ToString();
            sql = "select tendoituong from tbldoituong where madoituong =N'" + ma + "'";
            cbomadoituong.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["manuocsx"].Value.ToString();
            sql = "select tennuocsx from tblnuocsx where manuocsx =N'" + ma + "'";
            cbomadoituong.Text = function.GetFieldValues(sql);
            ma = DataGridView.CurrentRow.Cells["maloai"].Value.ToString();
            sql = "select tenloaifrom tbltheloai where maloai =N'" + ma + "'";
            cbomaloai.Text = function.GetFieldValues(sql);
            txtsoluong.Text = DataGridView.CurrentRow.Cells["soluong"].Value.ToString();
            txtdongianhap.Text = DataGridView.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtdongiaban.Text = DataGridView.CurrentRow.Cells["dongiaban"].Value.ToString();
            sql = "select anh from tblsanpham where magiaydep = N'" + txtmagiaydep.Text + "'";
            txtanh.Text = function.GetFieldValues(sql);
            anhsanpham.Image = Image.FromFile(txtanh.Text);
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmagiaydep.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmagiaydep.Focus();
                return;
            }
            if (txttengiaydep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttengiaydep.Focus();
                return;
            }
            if (cbomamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamau.Focus();
                return;
            }
            //2
            if (cbomamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }
            //3
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            //4
            if (cbomadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomadoituong.Focus();
                return;
            }
            //5
            if (cbomanuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanuocsx.Focus();
                return;
            }
            //6
            if (cbomachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            //7
            if (cbomaco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaco.Focus();
                return;
            }
            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }
            sql = "UPDATE tblsanpham SET tengiaydep=N'" + txttengiaydep.Text.Trim().ToString()
                + "',mamua=N'" + cbomamua.SelectedValue.ToString()
                + "',mamau=N'" + cbomamau.SelectedValue.ToString()
                + "',maco=N'" + cbomaco.SelectedValue.ToString()
                + "',maloai=N'" + cbomaloai.SelectedValue.ToString()
                + "',machatlieu=N'" + cbomachatlieu.SelectedValue.ToString()
                + "',madoituong=N'" + cbomadoituong.SelectedValue.ToString()
                + "',manuocsx=N'" + cbomanuocsx.SelectedValue.ToString()
                + "',soluong='" + txtsoluong.Text.ToString()
                + "',dongianhap='" + txtdongianhap.Text.ToString()
                + "',dongiaban='" + txtdongiaban.Text.ToString()
                + "',Anh='" + txtanh.Text +
                "' where magiaydep=N'" + txtmagiaydep.Text.Trim() + "'";
            Class.function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmagiaydep.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblsanpham WHERE magiaydep=N'" + txtmagiaydep.Text + "'";
                Class.function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmagiaydep.Enabled = false;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "C:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                anhsanpham.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
