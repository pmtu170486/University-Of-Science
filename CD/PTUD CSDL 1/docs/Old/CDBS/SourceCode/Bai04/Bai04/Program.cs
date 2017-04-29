using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            IO.Write("Nhap so luong phan tu: ");
            n = int.Parse(IO.ReadLine());
            int[] a = new int[n];
            nhapmang(a, n);
            xuatmang(a, n);
            int m = max(a, n);
            IO.Write("So lon nhat: {0}",m);
        }
        static void nhapmang(int[] a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                IO.Write("Nhap phan tu thu {0}: ",i+1);
                a[i] = int.Parse(IO.ReadLine());
            }
        }
        static void xuatmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                IO.Write("{0}\t",a[i]);
            }
        }
        /// <summary>
        /// Tim so lon nhat trong mang
        /// </summary>
        /// <param name="a">Mang a</param>
        /// <param name="n">Kich thuoc n</param>
        /// <returns>So lon nhat cua mang</returns>
        static int max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }

    }
}
