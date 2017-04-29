using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai07
{
    class HocSinh
    {
        //Thuoc tinh
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
        private float toan;

        public float Toan
        {
            get { return toan; }
            set { toan = value; }
        }
        private float ly;

        public float Ly
        {
            get { return ly; }
            set { ly = value; }
        }
        private float hoa;

        public float Hoa
        {
            get { return hoa; }
            set { hoa = value; }
        }
        private float dtb;

        public float Dtb
        {
            get { return dtb; }
            set { dtb = value; }
        }
        //Phuong thuc
        public void TinhDTB()
        {
            this.Dtb = (toan + ly + hoa) / 3;
        }
    }
}
