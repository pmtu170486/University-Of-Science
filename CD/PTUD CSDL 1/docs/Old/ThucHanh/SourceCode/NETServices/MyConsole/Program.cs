using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServices.EmployeeSerClient ser = new EmployeeServices.EmployeeSerClient();
            EmployeeServices.NhanVien[] lst = ser.getall();
            foreach(EmployeeServices.NhanVien nv in lst )
            {
                Console.WriteLine("{0} - {1} - {2}", nv.id, nv.name, nv.address);
            }
        }
    }
}
