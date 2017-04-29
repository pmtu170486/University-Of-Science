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
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }
        BLL.TaiKhoanServices ser = new BLL.TaiKhoanServices();
        private void Frm3_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dgvTaiKhoan.DataSource = ser.findAll();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            TaiKhoan tk1 = new TaiKhoan();
            tk1.matk = int.Parse(txtTK1.Text);
            TaiKhoan tk2 = new TaiKhoan();
            tk2.matk = int.Parse(txtTK2.Text);
            bool kq= ser.transfer(tk1, tk2, decimal.Parse(txtSoTien.Text));
            if (kq == true)
            {
                MessageBox.Show("Successfull!");
                load();
            }
            else
                MessageBox.Show("Fail!");
        }
    }
}
