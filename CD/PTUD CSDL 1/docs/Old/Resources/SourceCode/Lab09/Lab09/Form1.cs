using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e1)
        {
            loadDepartment();
            loadEmployee();
            
        }
        public void loadDepartment()
        {
            EmpDBEntities context = new EmpDBEntities();
            var q = from p in context.Departments
                    select p;
            cboDepartment.DataSource = q;
            cboDepartment.DisplayMember = "name";
            cboDepartment.ValueMember = "id";
        }
        public void loadEmployee()
        {
            EmpDBEntities context = new EmpDBEntities();
            var q = from em in context.Employees
                    join dep in context.Departments
                    on em.department equals dep.id
                    select new 
                    {
                        id=em.id,
                        EmployeeName=em.name,
                        Address=em.address,
                        em.phone,
                        em.salary,
                        em.email,
                        DepartmentID=dep.id,
                        DepartmentName=dep.name
                    };
            dgvEmployee.DataSource = q;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
             * Kiểm tra dữ liệu nhập hợp lệ từ người dùng
             * ............
             */
            EmpDBEntities context = new EmpDBEntities();
            Employee emp = new Employee();
            emp.name = txtName.Text;
            emp.address = txtAddress.Text;
            emp.email = txtEmail.Text;
            emp.salary = decimal.Parse(txtSalary.Text);
            emp.phone = txtPhone.Text;
            emp.department = (int)cboDepartment.SelectedValue;
            context.Employees.AddObject(emp);
            context.SaveChanges();
            MessageBox.Show("Insert Successfully!!!");
            loadEmployee();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Text = dgvEmployee.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvEmployee.Rows[index].Cells[1].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[index].Cells[2].Value.ToString();
            txtPhone.Text = dgvEmployee.Rows[index].Cells[3].Value.ToString();
            txtSalary.Text = dgvEmployee.Rows[index].Cells[4].Value.ToString();
            txtEmail.Text = dgvEmployee.Rows[index].Cells[5].Value.ToString();
            cboDepartment.SelectedValue=int.Parse(dgvEmployee.Rows[index].Cells[6].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtID.Text);
            EmpDBEntities context = new EmpDBEntities();
            Employee emp = (from p in context.Employees
                          where p.id == id
                          select p).Single();
            emp.name = txtName.Text;
            emp.address = txtAddress.Text;
            emp.email = txtEmail.Text;
            emp.phone = txtPhone.Text;
            emp.salary = decimal.Parse(txtSalary.Text);
            emp.department = (int)cboDepartment.SelectedValue;
            context.SaveChanges();
            MessageBox.Show("Update Successfully!!!");
            loadEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            EmpDBEntities context = new EmpDBEntities();
            Employee emp = (from p in context.Employees
                            where p.id == id
                            select p).Single();
            context.Employees.DeleteObject(emp);
            context.SaveChanges();
            MessageBox.Show("Delete Successfully!!!");
            loadEmployee();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text;
            EmpDBEntities context = new EmpDBEntities();
            var q = from em in context.Employees
                    join dep in context.Departments
                    on em.department equals dep.id
                    where em.name.Contains(keyword) ||
                    em.phone.Contains(keyword) ||
                    em.email.Contains(keyword) ||
                    em.address.Contains(keyword) ||
                    dep.name.Contains(keyword)
                    select new 
                    {
                        id = em.id,
                        EmployeeName = em.name,
                        Address = em.address,
                        em.phone,
                        em.salary,
                        em.email,
                        DepartmentID = dep.id,
                        DepartmentName = dep.name
                    };
            dgvEmployee.DataSource = q;
        }
    }
}
