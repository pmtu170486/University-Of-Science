using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{
    class Connection
    {
        private string _connectString;

        public string ConnectString
        {
            get { return _connectString; }
            set { _connectString = value; }
        }

        
        private SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public Connection()
        {
            //B1: Tao chuoi ket noi
            ConnectString = @"Data Source=PMTU-LAPTOP\SQL2008;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            connect = new SqlConnection(ConnectString);
        }
        public void OpenConnect()
        {
            connect.Open();
        }
        public void CloseConnect()
        {
            connect.Close();
        }
    }
}
