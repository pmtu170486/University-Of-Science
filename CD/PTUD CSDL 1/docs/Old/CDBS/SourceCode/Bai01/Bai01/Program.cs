using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai 1: Hay viet chuong trinh kiem tra 
            // mot so co phai la so nguyen to hay khong?
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            if(n==1)
                Console.Write("{0} khong la so nguyen to", n);
            if(ktsnt(n)==true)
                Console.Write("{0} la so nguyen to",n);
            else
                Console.Write("{0} khong la so nguyen to", n);
        }
        static bool ktsnt(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
