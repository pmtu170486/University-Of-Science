using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            IO.Write("Nhap dong: ");
            n=int.Parse(IO.ReadLine());
            int[][] a = new int[n][];
            nhapmang(a, n);
            xuatmang(a,n);

        }
        static void nhapmang(int[][] a, int n)
        {
            for (int i = 0; i < n; i++)
			{
                int c;
                IO.WriteLine("Nhap so cot cho dong {0}: ",i);
                c = int.Parse(IO.ReadLine());
                a[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    IO.Write("Nhap gia tri dong {0} cot {1}: ",i,j);
                    a[i][j] = int.Parse(IO.ReadLine());
                }
			}
        }
        static void xuatmang(int[][] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    IO.Write("{0}\t",a[i][j]);
                }
                IO.WriteLine();
            }
        }

    }
}
