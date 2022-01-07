using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;



namespace ThiCSLT2.Forms
{
    public partial class frmhoadonban : Form
    {
        DataTable tblhdb;
        public frmhoadonban()
        {
            InitializeComponent();
        }

        private void frmhoadonban_Load(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnin.Enabled = false;
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenkhachhang.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtdienthoai.ReadOnly = true;
            txttenhang.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtgiamgia.Text = "0";
            txttongtien.Text = "0";
            Class.function.FillCombo("SELECT makhach, tenkhach FROM tblkhachhang", cbomakhachhang, "makhach", "makhach");
            cbomakhachhang.SelectedIndex = -1;
            Class.function.FillCombo("SELECT manv,tennhanvien FROM tblnhanvien", cbomanhanvien, "manv", "manv");
            cbomanhanvien.SelectedIndex = -1;
            Class.function.FillCombo("SELECT magiaydep, tengiaydep FROM tblsanpham", cbomahang, "magiaydep", "tengiaydep");
            cbomahang.SelectedIndex = -1;
            Class.function.FillCombo("SELECT sohdb FROM tblchitiethdban", cbomahoadon, "sohdb", "sohdb");
            cbomahoadon.SelectedIndex = -1;
            if (txtmahoadon.Text != "")
            {
                Load_ThongtinHD();
                btnxoa.Enabled = true;
                btnin.Enabled = true;
            }
            Load_DataGridViewChitiet();

        }
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT a.magiaydep, b.tengiaydep, a.soluong, b.dongiaban, a.giamgia, a.thanhtien" +
                " FROM tblchitiethdban as a join tblsanpham as b on a.magiaydep=b.magiaydep" +
               " where a.sohdb = N'" +txtmahoadon.Text+"'";
            tblhdb = Class.function.GetDataToTable(sql);
            dgridhoadonban.DataSource = tblhdb;
            dgridhoadonban.Columns[0].HeaderText = "Mã hàng";
            dgridhoadonban.Columns[1].HeaderText = "Tên hàng";
            dgridhoadonban.Columns[2].HeaderText = "Số lượng";
            dgridhoadonban.Columns[3].HeaderText = "Đơn giá";
            dgridhoadonban.Columns[4].HeaderText = "Giảm giá %";
            dgridhoadonban.Columns[5].HeaderText = "Thành tiền";
            dgridhoadonban.Columns[0].Width = 80;
            dgridhoadonban.Columns[1].Width = 100;
            dgridhoadonban.Columns[2].Width = 80;
            dgridhoadonban.Columns[3].Width = 90;
            dgridhoadonban.Columns[4].Width = 90;
            dgridhoadonban.Columns[5].Width = 90;
            dgridhoadonban.AllowUserToAddRows = false;
            dgridhoadonban.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT ngayban FROM tblhoadonban WHERE sohdb = N'" + txtmahoadon.Text + "'";
            txtngayban.Text = Class.function.ConvertDateTime(Class.function.GetFieldValues(str));
            str = "SELECT manv FROM tblhoadonban WHERE sohdb = N'" + txtmahoadon.Text + "'";
            cbomanhanvien.Text = Class.function.GetFieldValues(str);

            str = "SELECT makhach FROM tblhoadonban WHERE sohdb = N'" + txtmahoadon.Text + "'";
            cbomakhachhang.Text = Class.function.GetFieldValues(str);

            str = "SELECT tongtien FROM tblhoadonban WHERE sohdb = N'" + txtmahoadon.Text + "'";
            txttongtien.Text = Class.function.GetFieldValues(str);

            lblbangchu.Text = "Bằng chữ: " + Class.function.ChuyenSoSangChu(txttongtien.Text);
        }
        private void ResetValuesHang()
        {
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
        }
        private void ResetValues()
        {
            txtmahoadon.Text = "";
            txtngayban.Text = DateTime.Now.ToShortDateString();
            cbomanhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
            
        }


        private void dgridhoadonban_Click(object sender, EventArgs e)
        {
            string mahang;
            Double Thanhtien;

            if (tblhdb.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahang = dgridhoadonban.CurrentRow.Cells["magiaydep"].Value.ToString();
                DelHang(txtmahoadon.Text, mahang);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(dgridhoadonban.CurrentRow.Cells["thanhtien"].Value.ToString());
                DelUpdateTongtien(txtmahoadon.Text, Thanhtien);
                Load_DataGridViewChitiet();
            }


        }

        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT tongtien FROM tblhoadonban WHERE sohdb = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Class.function.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblhoadonban SET tongtien =" + Tongmoi + " WHERE  sohdb= N'" +Mahoadon + "'";
            Class.function.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Class.function.ChuyenSoSangChu(Tongmoi.ToString());
        }


        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT soluong FROM tblchitiethdban WHERE sohdb = N'" + Mahoadon + "' " +
                "AND magiaydep = N'" + Mahang + "'";
            string a = Class.function.GetFieldValues(sql);
            s = Convert.ToDouble(Class.function.GetFieldValues(sql));
            
            sql = "DELETE tblchitiethdban WHERE sohdb=N'" + Mahoadon + "' AND magiaydep = N'" + Mahang + "'";
            Class.function.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT soluong FROM tblsanpham WHERE magiaydep = N'" + Mahang + "'";
            sl = Convert.ToDouble(Class.function.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblsanpham SET soluong =" + SLcon + " WHERE magiaydep= N'" + Mahang + "'";
            Class.function.RunSql(sql);
        }
        

        private void cbomanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")
                txttennhanvien.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select tennhanvien from tblnhanvien where manv =N'" + cbomanhanvien.SelectedValue + "'";
            txttennhanvien.Text = Class.function.GetFieldValues(str);

        }

        private void cbomakhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                txtdienthoai.Text = "";
            }
            //Khi kich chon Ma khach thi ten khach, dia chi, dien thoai se tu dong hien ra
            str = "Select tenkhach from tblkhachhang where makhach = N'" + cbomakhachhang.SelectedValue + "'";
            txttenkhachhang.Text = Class.function.GetFieldValues(str);
            str = "Select diachi from tblkhachhang where makhach = N'" + cbomakhachhang.SelectedValue + "'";
            txtdiachi.Text = Class.function.GetFieldValues(str);
            str = "Select dienthoai from tblkhachhang where makhach= N'" + cbomakhachhang.SelectedValue + "'";
            txtdienthoai.Text = Class.function.GetFieldValues(str);

        }

        private void cbomahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtdongia.Text = "";
            }
            // Khi kich chon Ma hang thi ten hang va gia ban se tu dong hien ra
            str = "SELECT tengiaydep FROM tblsanpham WHERE magiaydep =N'" + cbomahang.SelectedValue + "'";
            txttenhang.Text = Class.function.GetFieldValues(str);
            str = "SELECT dongiaban FROM tblsanpham WHERE magiaydep =N'" + cbomahang.SelectedValue + "'";
            txtdongia.Text = Class.function.GetFieldValues(str);

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;
            txtsoluong.Enabled = true;
            txtgiamgia.Enabled = true;
            txtthanhtien.Enabled = true;
            ResetValues();
            txtmahoadon.Text = Class.function.CreateKey("HDB");
            Load_DataGridViewChitiet();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT sohdb FROM tblhoadonban WHERE sohdb=N'" + txtmahoadon.Text + "'";
            if (!Class.function.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayban.Focus();
                    return;
                }
                if (cbomanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomanhanvien.Focus();
                    return;
                }
                if (cbomakhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomakhachhang.Focus();
                    return;
                }
                //lưu thông tin chung vào bảng tblhdban    
                sql = "INSERT INTO tblhoadonban(sohdb, manv, ngayban, makhach, tongtien) VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + cbomanhanvien.SelectedValue + "',N'" + Class.function.ConvertDateTime(txtngayban.Text.Trim()) + "',N'" + cbomakhachhang.SelectedValue + "',N'" + txttongtien.Text + "')";
                    
                Class.function.RunSql(sql);
            }

            // Lưu thông tin của các mặt hàng
            if (cbomahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahang.Focus();
                return;
            }
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiamgia.Focus();
                return;
            }
            
          
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Class.function.GetFieldValues("SELECT soluong FROM tblsanpham" +
                " WHERE magiaydep = N'" + cbomahang.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "INSERT INTO tblchitiethdban " +
                " values(N'" + txtmahoadon.Text.Trim() + "',N'" + cbomahang.SelectedValue + "',N'" + txtsoluong.Text + "',N'" + txtgiamgia.Text + "',N'" + txtthanhtien.Text + "',N'" + txtdongia.Text + "')";
            Class.function.RunSql(sql);
            Load_DataGridViewChitiet();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "UPDATE tblsanpham SET soluong =" + SLcon + " WHERE magiaydep= N'" + cbomahang.SelectedValue + "'";
            Class.function.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán

            tong = Convert.ToDouble(Class.function.GetFieldValues("SELECT tongtien FROM tblhoadonban WHERE sohdb = N'" + txtmahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE tblhoadonban SET tongtien =" + Tongmoi + " WHERE sohdb = N'" + txtmahoadon.Text + "'";
            Class.function.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Class.function.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnin.Enabled = true;

        }
       


        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT magiaydep  FROM tblchitiethdban WHERE sohdb = N'" + txtmahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Class.function.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtmahoadon.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE tblhoadonban WHERE sohdb=N'" + txtmahoadon.Text + "'";
                Class.function.RunSqlDel(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                btnxoa.Enabled = false;
                btnin.Enabled = false;
                txtngayban.Text = "";
                txttenhang.Text = "";
                txtdongia.Text = "";
                

            }

        }


        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahoadon.Focus();
                return;
            }
            txtmahoadon.Text = cbomahoadon.Text;
            Load_ThongtinHD();
            Load_DataGridViewChitiet();
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnin.Enabled = true;
            cbomahoadon.SelectedIndex = -1;

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop giày dép BA";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc-Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.sohdb, a.ngayban, a.tongtien, b.tenkhach, b.diachi, b.dienthoai, c.tennhanvien FROM tblhoadonban AS a, tblkhachhang AS b, tblnhanvien AS c " +
                "WHERE a.sohdb = N'" + txtmahoadon.Text + "' AND a.makhach = b.makhach AND a.manv =c.manv";
            tblThongtinHD = Class.function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.tengiaydep, a.soluong, b.dongiaban, a.giamgia, a.thanhtien " + "FROM tblchitiethdban AS a , tblsanpham AS b WHERE a.sohdb = N'" +txtmahoadon.Text + "' AND a.magiaydep = b.magiaydep";
            tblThongtinHang = Class.function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Class.function.ChuyenSoSangChu
 (tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }
        private void frmHoadonban_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }

        private void cbomahoadon_DropDown(object sender, EventArgs e)
        {
            Class.function.FillCombo("SELECT sohdb FROM tblhoadonban", cbomahoadon, "sohdb","sohdb");
            cbomahoadon.SelectedIndex = -1;

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        
    }
}
