using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyThucVien
{
    class DataProvider
    {
        private static SqlConnection conn = null;
        private DataProvider() { }
        /// <summary>
        /// Phương thức này lấy đối tượng kết nối dùng mẫu singleton
        /// </summary>
        /// <returns>Kết quả trả về là một đối tượng</returns>
        public static void getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            }
        }

        public static void open()
        {
            if (conn != null)
            {
                conn.Open();
            }
        }
        public static void close()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public static void ExcuteNonquery(string query)
        {
            if (conn != null)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
        }
    }
}
