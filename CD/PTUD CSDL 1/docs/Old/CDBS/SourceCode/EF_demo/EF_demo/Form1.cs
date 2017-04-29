using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EF_demo.DAL;
namespace EF_demo
{
    public partial class Form1 : Form
    {
        BLL.ProductServices servics = new BLL.ProductServices();
        public Form1()
        {
            InitializeComponent();
        }
        public void loadProduct()
        {
            BindingSource db = new BindingSource();
            db.DataSource = servics.findAll();
            dgvProduct.DataSource = db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            //Kiem tra du lieu hop le
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.price = decimal.Parse(txtPrice.Text);
            p.quantity = txtQuantity.Text;
            p.supply = txtSupply.Text;
            servics.create(p);
            MessageBox.Show("Successful!");
            loadProduct();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Product p = new Product();
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.price = decimal.Parse(txtPrice.Text);
            p.quantity = txtQuantity.Text;
            p.supply = txtSupply.Text;
            servics.edit(p);
            MessageBox.Show("Successful!");
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Text =dgvProduct.Rows[index].Cells[0].Value.ToString();
            txtName.Text= dgvProduct.Rows[index].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[index].Cells[2].Value.ToString();
            txtQuantity.Text= dgvProduct.Rows[index].Cells[3].Value.ToString();
            txtSupply.Text = dgvProduct.Rows[index].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.price = decimal.Parse(txtPrice.Text);
            p.quantity = txtQuantity.Text;
            p.supply = txtSupply.Text;
            servics.remove(p);
            loadProduct();
            MessageBox.Show("Successful!");
        }
        

    }
}
