using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF_demo.DAL;
namespace EF_demo.BLL
{
    class TaiKhoanServices
    {
        demoConnection data = new demoConnection();
        public bool transfer(TaiKhoan tk1,TaiKhoan tk2,decimal money)
        {
            
            TaiKhoan a = (from p in data.TaiKhoans
                         where p.matk == tk1.matk
                         select p).Single<TaiKhoan>();
            if (a.sodu - 50000 < money)
                return false;
            a.sodu = a.sodu - money;
            TaiKhoan b = (from p in data.TaiKhoans
                          where p.matk == tk2.matk
                          select p).Single<TaiKhoan>();
            b.sodu = b.sodu + money;
            data.SaveChanges();
            return true;
        }
        public List<object> findAll()
        {
            var s = (from p in data.TaiKhoans
                    select p).ToList<object>();
            return s;
        }
    }
}
