using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThiCSLT2.Class
{
    class function
    {
        public static SqlConnection Conn;
        public static string ConnString;
        public static void Connect()
        {
            Conn = new SqlConnection();
            ConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\QLCHgiaydep\\bsj\\QLCHgiaydep\\ThiCSLT2\\ThiCSLT2\\database\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            Conn.ConnectionString = ConnString;
            Conn.Open();
        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = function.Conn;
            a.SelectCommand.CommandText = sql;
            DataTable bang = new DataTable();
            a.Fill(bang);
            return bang;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = function.Conn;
            a.SelectCommand.CommandText = sql;
            DataTable bang = new DataTable();
            a.Fill(bang);
            if (bang.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;                     
            cmd = new SqlCommand();         
            cmd.Connection = Conn;    
            cmd.CommandText = sql;           
            try
            {
                cmd.ExecuteNonQuery();        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter a = new SqlDataAdapter(sql, function.Conn);
            DataTable bang = new DataTable();
            a.Fill(bang);
            cbo.DataSource = bang;
            cbo.ValueMember = ma;    // Truong gia tri
            cbo.DisplayMember = ten;    // Truong hien thi
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}


