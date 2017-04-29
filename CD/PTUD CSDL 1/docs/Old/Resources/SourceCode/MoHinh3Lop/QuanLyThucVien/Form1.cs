using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThucVien.DTO;
using QuanLyThucVien.BUS;
namespace QuanLyThucVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DauSach ds = new DauSach();
            ds.name = txtName.Text;
            DauSachBUS bus = new DauSachBUS();
            bus.them(ds);
            MessageBox.Show("Thanh cong");
        }
    }
}
