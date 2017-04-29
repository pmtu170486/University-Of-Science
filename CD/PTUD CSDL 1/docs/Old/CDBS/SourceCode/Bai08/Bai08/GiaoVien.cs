using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai08
{
    class GiaoVien
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private float luong;

        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }

        //Phuong thuc
        public void nhap()
        {
            IO.Write("Nhap ten: ");
            this.Name = IO.ReadLine();
            IO.Write("Nhap dia chi: ");
            this.Address = IO.ReadLine();
            IO.Write("Nhap email: ");
            this.Email = IO.ReadLine();
            IO.Write("Nhap gioi tinh: ");
            this.Gioitinh = IO.ReadLine();
            IO.Write("Nhap luong: ");
            this.Luong=float.Parse(IO.ReadLine());
        }
        public void xuat()
        {
            IO.Write("\n{0}\t{1}\t{2}\t{3}\t{4}",
                this.Name,this.Address,this.Email,this.Gioitinh,
                this.Luong);
        }
    }
}
