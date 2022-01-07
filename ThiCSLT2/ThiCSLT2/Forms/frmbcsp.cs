using System;
using System.Data;
using System.Windows.Forms;

namespace ThiCSLT2.Forms
{
    public partial class frmbcsp : Form
    {
        public frmbcsp()
        {
            InitializeComponent();
        }

        private void frmbcsp_Load(object sender, EventArgs e)
        {

            Class.function.Connect();
            DateTime dateTime = DateTime.Now;
            string month = dateTime.Month.ToString();
            string sql = "select top(1) a.magiaydep,SUM(a.soluong) " +
                "from tblchitiethdban a join tblhoadonban b on a.sohdb=b.sohdb " +
                "where MONTH(b.ngayban)=" + month +
                " group by a.magiaydep " +
                "order by SUM(a.soluong) desc ";
            DataTable dataTable = Class.function.GetDataToTable(sql);
            txtmagiaydep.Text = dataTable.Rows[0]["magiaydep"].ToString();
            sql = "select sp.tengiaydep," +
                "           m.tenmua," +
                "           ma.tenmau," +
                "           dt.tendoituong," +
                "           nsx.tennuocsx," +
                "           tl.tenloai," +
                "           c.tenco," +
                "           cl.tenchatlieu " +
                "from tblsanpham sp join tblmua m on sp.mamua = m.mamua " +
                "   join tblmau ma on sp.mamau = ma.mamau " +
                "   join tbldoituong dt on sp.madoituong = dt.madoituong " +
                "   join tblnuocsanxuat nsx on sp.manuocsx = nsx.manuocsx " +
                "   join tbltheloai tl on sp.maloai = tl.maloai " +
                "   join tblco c on sp.maco = c.maco " +
                "   join tblchatlieu cl on sp.machatlieu = cl.machatlieu";
            dataTable = Class.function.GetDataToTable(sql);
            txttengiaydep.Text = dataTable.Rows[0]["tengiaydep"].ToString();
            txttenmua.Text = dataTable.Rows[0]["tenmua"].ToString();
            txttendoituong.Text = dataTable.Rows[0]["tendoituong"].ToString();
            txtnuocsanxuat.Text = dataTable.Rows[0]["tennuocsx"].ToString();
            txtloai.Text = dataTable.Rows[0]["tenloai"].ToString();
            txtco.Text = dataTable.Rows[0]["tenco"].ToString();
            txtchatlieu.Text = dataTable.Rows[0]["tenchatlieu"].ToString();
            txtmau.Text = dataTable.Rows[0]["tenmau"].ToString();
        }

    }
}
