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
    public partial class frmtksp : Form
    {
        SqlDataAdapter da;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\QLCHgiaydep\abc\QLCHgiaydep\ThiCSLT2\ThiCSLT2\BTL_QLGD.mdf;Integrated Security=True;Connect Timeout=30");
        public frmtksp()
        {
            InitializeComponent();
        }

        private void frmtksp_Load(object sender, EventArgs e)
        {
            popugrid();
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
            function.FillCombo("Select manuocsx from tblnuocsanxuat", cbomanuocsx, "manuocsx", "tennuocsx");
            cbomanuocsx.SelectedIndex = -1;

        }
        public void popugrid()
        {
            Con.Open();
            string query = "select * from tblsanpham";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void populatedGrid()
        {
            da = new SqlDataAdapter("Select * from tblsanpham", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            cbomaloai.DataSource = dt;
            cbomaloai.DisplayMember = "tenloai";
            cbomaloai.ValueMember = "maloai";

        }
        public void txttensp()
        {
            Con.Open();
            string query = "select * from tblsanpham where tengiaydep = '" + txttengiaydep.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void txtmasp()
        {
            Con.Open();
            string query = "select * from tblsanpham where magiaydep = '" + txtmagiaydep.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void maloai()
        {
            Con.Open();
            string query = "select magiaydep,tengiaydep,maloai,tenloai from tblsanpham," + "tbltheloai where tblsanpham.maloai = tbltheloai.maloai and tenloai ='" + cbomaloai.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetValues()
        {
            cbomanuocsx.Text = "";
            cbomamua.Text = "";
            cbomamau.Text = "";
            cbomaloai.Text = "";
            cbomachatlieu.Text = "";
            cbomadoituong.Text = "";
            cbomaco.Text = "";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            populatedGrid();
            txttengiaydep.Text = "";
            txtmagiaydep.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmagiaydep.Text.Length == 0 && txttengiaydep.Text.Length == 0)
            {
                Boolean kiemtraTK = false;
                string ctk = "1=1";
                if (cbomaloai.SelectedIndex != -1)
                {
                    ctk += " and maloai = " + cbomaloai.SelectedValue;
                }
                if (cbomaco.SelectedIndex != -1)
                {
                    ctk += " and maco = " + cbomaco.SelectedValue;
                }
                if (cbomachatlieu.SelectedIndex != -1)
                {
                    ctk += " and machatlieu = " + cbomachatlieu.SelectedValue;
                }
                if (cbomadoituong.SelectedIndex != -1)
                {
                    ctk += " and madoituong = " + cbomadoituong.SelectedValue;
                }
                if (cbomamua.SelectedIndex != -1)
                {
                    ctk += " and mamua = " + cbomamua.SelectedValue;
                }
                if (cbomamau.SelectedIndex != -1)
                {
                    ctk += " and mamau = " + cbomamau.SelectedValue;
                }
                if (cbomanuocsx.SelectedIndex != -1)
                {
                    ctk += " and manuocsx = " + cbomanuocsx.SelectedValue;
                }
                da = new SqlDataAdapter("Select * from tblsanpham where " + ctk, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                DataGridView.DataSource = dt;
            }
                 else
                if (txttengiaydep.Text.Length == 0)
                txtmasp();
            else
                if (txtmagiaydep.Text.Length == 0)
                txttensp();
            if (DataGridView.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + DataGridView.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
