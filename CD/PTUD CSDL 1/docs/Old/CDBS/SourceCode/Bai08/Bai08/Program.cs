using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai08
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaoVien[] gv = new GiaoVien[3];
            nhapmang(gv);
            xuatmang(gv);
            Console.WriteLine("\nDanh sach giao vien sau khi duoc sap xep");
            sapgiam(gv);
            xuatmang(gv);
        }
        static void nhapmang(GiaoVien[] gv)
        {
            for (int i = 0; i < gv.Length; i++)
            {
                Console.WriteLine("\nNhap giao vien thu {0}",i+1);
                gv[i] = new GiaoVien();
                gv[i].nhap();
            }
        }
        static void xuatmang(GiaoVien[] gv)
        {
            for (int i = 0; i < gv.Length; i++)
            {
                gv[i].xuat();
            }
        }
        static void sapgiam(GiaoVien[] gv)
        {
            for (int i = 0; i < gv.Length-1; i++)
            {
                for (int j = i+1; j < gv.Length; j++)
                {
                    if (gv[i].Luong < gv[j].Luong)
                    {
                        GiaoVien temp = gv[i];
                        gv[i] = gv[j];
                        gv[j] = temp;
                    }
                }
            }
        }
    }
}
