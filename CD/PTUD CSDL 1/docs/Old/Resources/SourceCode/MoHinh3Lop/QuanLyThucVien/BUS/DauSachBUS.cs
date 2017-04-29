using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThucVien.DTO;
using QuanLyThucVien.DAO;
namespace QuanLyThucVien.BUS
{
    class DauSachBUS
    {
        private DauSachDB db = new DauSachDB();
        public void them(DauSach ds)
        {
            db.them(ds);
        }
    }
}
