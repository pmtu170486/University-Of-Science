using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
   
    
    
    class daoSinhVien
    {
        Connection c = new Connection();
        SqlCommand comman;
        public void ThemSinhVien(dtoSinhVien sv)
        {
            c.OpenConnect();
            comman = new SqlCommand("sp_ThemSinhVien",c.Connect);
            comman.CommandType = System.Data.CommandType.StoredProcedure;
            comman.Parameters.Add("@hoten", System.Data.SqlDbType.NVarChar, 100).Value = sv.Hoten;
            comman.Parameters.Add("@diachi", System.Data.SqlDbType.NVarChar, 200).Value = sv.Diachi;
            comman.Parameters.Add("@gioitinh", System.Data.SqlDbType.NVarChar, 200).Value = sv.Gioitinh;
            comman.Parameters.Add("@malop", System.Data.SqlDbType.Int).Value = sv.Malop;
            comman.ExecuteNonQuery();
            c.CloseConnect();
        }
        public List<dtoSinhVien> LayThongTinSinhVien()
        {
            //B2: Mo ket noi den CSDL
            c.OpenConnect();

            //B3: Tao cao truy van
            comman = new SqlCommand("sp_LayThongTinSinhVien", c.Connect);
            comman.CommandType = System.Data.CommandType.StoredProcedure;

            //B4: thuc thi cau truy van
            SqlDataReader reader = comman.ExecuteReader();

            List<dtoSinhVien> list = new List<dtoSinhVien>();
            dtoSinhVien sv;
            while (reader.Read())
            {
                sv = new dtoSinhVien();
                sv.Mssv = int.Parse(reader["mssv"].ToString());
                sv.Malop = int.Parse(reader["malop"].ToString());
                sv.Hoten = reader["hoten"].ToString();
                sv.Diachi = reader["diachi"].ToString();
                sv.Gioitinh = reader["gioitinh"].ToString();
                list.Add(sv);
            }
            c.CloseConnect();
            return list;
        }
        public void CapNhatSinhVien(dtoSinhVien sv)
        {
            c.OpenConnect();
            comman = new SqlCommand("sp_CapNhatSinhVien", c.Connect);
            comman.CommandType = System.Data.CommandType.StoredProcedure;
            comman.Parameters.Add("@hoten", System.Data.SqlDbType.NVarChar, 100).Value = sv.Hoten;
            comman.Parameters.Add("@diachi", System.Data.SqlDbType.NVarChar, 200).Value = sv.Diachi;
            comman.Parameters.Add("@gioitinh", System.Data.SqlDbType.NVarChar, 200).Value = sv.Gioitinh;
            comman.Parameters.Add("@malop", System.Data.SqlDbType.Int).Value = sv.Malop;
            comman.Parameters.Add("@mssv", System.Data.SqlDbType.Int).Value = sv.Mssv;
            comman.ExecuteNonQuery();
            c.CloseConnect();
        }
        public void XoaSinhVien(dtoSinhVien sv)
        {
            c.OpenConnect();
            comman = new SqlCommand("sp_XoaSinhVien", c.Connect);
            comman.CommandType = System.Data.CommandType.StoredProcedure;
            comman.Parameters.Add("@mssv", System.Data.SqlDbType.Int).Value = sv.Mssv;
            comman.ExecuteNonQuery();
            c.CloseConnect();
        }

    }
}
