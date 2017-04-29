using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO = System.Console;
namespace Bai09
{
    class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private float score;

        public float Score
        {
            get { return score; }
            set { score = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //Khai bao phuong thuc
        public Student nhap()
        {
            Student obj=new Student();
            IO.Write("Input id: ");
            obj.Id = int.Parse(IO.ReadLine());
            IO.Write("Input name: ");
            obj.Name = IO.ReadLine();
            IO.Write("Input email: ");
            obj.Email = IO.ReadLine();
            IO.Write("Input score: ");
            obj.Score = float.Parse(IO.ReadLine());
            return obj;
        }
        public void xuat()
        {
            IO.WriteLine("{0}\t{1}\t{2}\t{3}",this.Id,this.Name,this.Email,
                this.Score);
        }
    }
}
