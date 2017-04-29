using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    class daoLop
    {
        //
        Connection c = new Connection();
        SqlCommand comman;
        public List<dtoLop> LayThongTinLop()
        {
            //B2: Mo ket noi den CSDL
            c.OpenConnect();

            //B3: Tao cao truy van
            comman = new SqlCommand("sp_LayThongTinLop", c.Connect);
            comman.CommandType = System.Data.CommandType.StoredProcedure;

            //B4: thuc thi cau truy van
            SqlDataReader reader = comman.ExecuteReader();

            List<dtoLop> list=new List<dtoLop>();
            dtoLop l;
            while (reader.Read())
            {
                l = new dtoLop();
                l.Malop = int.Parse(reader["malop"].ToString());
                l.Tenlop = reader["tenlop"].ToString();
                l.Siso = int.Parse(reader["siso"].ToString());
                list.Add(l);
            }
            c.CloseConnect();
            return list;
        }
    }
}
