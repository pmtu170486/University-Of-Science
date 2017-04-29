using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsEmployees
{
    using wsEmployees.dao;
    
    class EmployeeManagement:IEmployeeSer
    {

        public List<NhanVien> getall()
        {
            QuanLyNhanVienEntities data = new QuanLyNhanVienEntities();
            var result = from p in data.NhanViens
                         select p;
            return result.ToList<NhanVien>();
        }

        public void create(NhanVien nv)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void update(NhanVien nv)
        {
            throw new NotImplementedException();
        }
    }
}
