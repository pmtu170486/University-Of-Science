using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;
namespace QuanLyThuVien.BUS
{
    class NhanVienBUS
    {
        public void themnhanvien(NhanVien nv)
        {
            // Kiem tra nhan vien du tieu chuan hay khong
            // Goi dao
            NhanVienDAO dao = new NhanVienDAO();
            dao.themnhanvien(nv);
        }
    }
}
