using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs1 = new HocSinh();
            HocSinh hs2 = new HocSinh();
            HocSinh hs3 = new HocSinh();
            hs1.Name = "nguyen van a";
            hs1.Address = "tphcm";
            hs1.Toan = 5;
            hs1.Ly = 2;
            hs1.Hoa = 5;
            hs1.TinhDTB();
            Console.Write("{0}\t{1}\t{2}",
                hs1.Name,hs1.Address,hs1.Dtb);
        }
    }
}
