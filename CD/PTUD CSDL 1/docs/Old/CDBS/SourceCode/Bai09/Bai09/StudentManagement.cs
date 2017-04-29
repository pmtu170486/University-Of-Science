using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Bai09
{
    class StudentManagement
    {
        private Student st=new Student();
        private ArrayList list = new ArrayList();

        public void create()
        {
            list.Add(st.nhap());
        }
        public void findAll()
        {
            foreach(Student st in list)
            {
                st.xuat();
            }
        }
        public void remove(int id)
        {
            foreach (Student item in list)
            {
                if (item.Id == id)
                {
                    list.Remove(item);
                    break;
                }
            }
        }
        public void edit(Student st)
        {

        }
        public void find(int id)
        {

        }
    }
}
