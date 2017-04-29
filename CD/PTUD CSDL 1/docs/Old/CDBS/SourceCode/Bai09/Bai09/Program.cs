using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai09
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement stMana = new StudentManagement();
            do
            {
                IO.WriteLine("1. Nhap ");
                IO.WriteLine("2. Xuat ");
                IO.WriteLine("3. Xoa ");
                IO.WriteLine("4. Tim kiem ");
                IO.WriteLine("5. Thoat ");
                int cn;
                IO.Write("Moi nhap chuc nang: ");
                cn = int.Parse(IO.ReadLine());
                switch (cn)
                {
                    case 1:
                        stMana.create();
                        break;
                    case 2:
                        stMana.findAll();
                        break;
                    case 3:
                        IO.Write("\nNhap id can xoa: ");
                        int id = int.Parse(IO.ReadLine());
                        stMana.remove(id);
                        stMana.findAll();
                        break;
                    case 5:
                        return;
                }

            } while (true);
        }
    }
}
