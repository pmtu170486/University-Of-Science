using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThucVien.DTO;

namespace QuanLyThucVien.DAO
{
    class DauSachDB
    {
        private DataProvider data;
        public void them(DauSach ds)
        {
            DataProvider.getConnection();
            DataProvider.open();
            string query = "insert into dausach values('"+ds.name+"')";
            DataProvider.ExcuteNonquery(query);

        }
    }
}
