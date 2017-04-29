using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.GUI
{
    public partial class NhanVienGUI : Form
    {
        public NhanVienGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lay thong tin nhan vien nguoi 
            //dung nhap vao
            NhanVien nv = new NhanVien();
            nv.name = "thong tin nguoi dung nhap";
            nv.address = "thong tin nguoi dung nhap";
            NhanVienBUS bus = new NhanVienBUS();
            bus.themnhanvien(nv);
            MessageBox.Show("Thanh cong");

        }
    }
}
