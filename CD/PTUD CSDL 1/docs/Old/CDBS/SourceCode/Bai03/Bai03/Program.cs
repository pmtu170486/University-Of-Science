using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viet ham hoan vi 2 so va goi ham trong ham main
            IO.Write("Nhap a: ");
            int a = int.Parse(IO.ReadLine());
            IO.Write("Nhap b: ");
            int b = int.Parse(IO.ReadLine());
            IO.Write("Truoc khi hoan vi: a {0} \\ b {1}",a,b);
            hoanvi(ref a, ref b);
            IO.WriteLine("\nSau khi hoan vi: a {0} \\ b {1}", a, b);
        }

        static void hoanvi(ref int a ,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
