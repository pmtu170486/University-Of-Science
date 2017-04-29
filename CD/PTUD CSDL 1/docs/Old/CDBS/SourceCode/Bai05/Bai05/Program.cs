using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            int d,c;
            IO.Write("Nhap dong: ");
            d=int.Parse(IO.ReadLine());
            IO.Write("Nhap cot: ");
            c=int.Parse(IO.ReadLine());
            int [,] a=new int[d,c];
            nhapmang(a, d, c);
            xuatmang(a, d, c);
            int tong = tongcheochinh(a, d);
            IO.WriteLine("Tong la: {0}", tong);
        }

        static void nhapmang(int[,] a, int d, int c)
        {
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    IO.Write("Nhap gia tri dong {0} cot {1}: ",i,j);
                    a[i, j] = int.Parse(IO.ReadLine());
                }
            }
        }
        static void xuatmang(int[,] a, int d, int c)
        {
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    IO.Write("{0}\t",a[i,j]);
                }
                IO.WriteLine();
            }
        }
        static int tongcheochinh(int[,] a, int d)
        {
            int tong = 0;
            for (int i = 0; i < d; i++)
            {
                tong = tong + a[i, i];
            }
            return tong;
        }
    }
}
