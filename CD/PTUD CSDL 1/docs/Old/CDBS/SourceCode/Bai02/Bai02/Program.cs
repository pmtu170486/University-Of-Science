using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            int n;
            IO.Write("Nhap x: ");
            x = float.Parse(IO.ReadLine());
            IO.Write("Nhap n: ");
            n = int.Parse(IO.ReadLine());
            float sum = tong(x, n);
            IO.Write("Tong la: {0}",sum);
        }
        static float tong(float x, int n)
        {
            float tu=x;
            float mau = x*x;
            float sum = 1 + tu/mau;
            for (int i = 1; i < n; i++)
            {
                tu = tu * x*x;
                mau = mau * x * x;
                sum = sum + tu / mau;
            }
            return sum;
        }
    }
}
