using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection connect;
        private string connectString;



        public void Connection()
        {
            connectString = "Data Source=.;Initial Catalog=QuanLySinhVien;User ID=sa;pwd=sa";
            connect = new SqlConnection(connectString);
            connect.Open();
        }
        public void disConnection()
        {
            connect.Close();
        }
        private void btnXemTTSV_Click(object sender, EventArgs e)
        {
            Connection();
            List<SinhVien> l = new List<SinhVien>();
            SinhVien sv;
            string query = "select * from sinhvien";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sv = new SinhVien();
                sv.Mssv = int.Parse(reader["mssv"].ToString());
                sv.Hoten = reader["hoten"].ToString();
                sv.Gioitinh = reader["gioitinh"].ToString();
                sv.Diachi = reader["diachi"].ToString();
                sv.Malop = int.Parse(reader["malop"].ToString());
                l.Add(sv);
            }
            dtGVSV.DataSource = l;
            disConnection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection();
            int vtdong = dtGVSV.CurrentRow.Index;
            if (vtdong < 0)
                return;
            int mssv = int.Parse(dtGVSV.Rows[vtdong].Cells[0].Value.ToString());
            string query = "delete from sinhvien where mssv="+mssv;
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            disConnection();
            MessageBox.Show("Xoa thanh cong");
            btnXemTTSV_Click(sender, e);           
        }
    }
}