using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDanhSachSinhVien : Form
    {
        public frmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            daoSinhVien daoSV = new daoSinhVien();
            dtgDSSV.DataSource = daoSV.LayThongTinSinhVien();
            daoLop daoL=new daoLop();
            cboLop.DataSource = daoL.LayThongTinLop();
            cboLop.DisplayMember = "tenlop";
            cboLop.ValueMember = "malop";

        }

        private void dtgDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vtdong = dtgDSSV.CurrentRow.Index;
            txtMSSV.Text = dtgDSSV.Rows[vtdong].Cells[0].Value.ToString();
            txtHoTen.Text = dtgDSSV.Rows[vtdong].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgDSSV.Rows[vtdong].Cells[2].Value.ToString();
            cboGioiTinh.Text = dtgDSSV.Rows[vtdong].Cells[3].Value.ToString(); ;
            cboLop.SelectedValue = int.Parse(dtgDSSV.Rows[vtdong].Cells[4].Value.ToString());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dtoSinhVien sv = new dtoSinhVien();
            sv.Hoten = txtHoTen.Text;
            sv.Gioitinh = cboGioiTinh.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Malop = (int)cboLop.SelectedValue;
            sv.Mssv = int.Parse(txtMSSV.Text);
            daoSinhVien daoSV=new daoSinhVien();
            daoSV.CapNhatSinhVien(sv);
            MessageBox.Show("Cap nhat thanh cong");
            dtgDSSV.DataSource = daoSV.LayThongTinSinhVien();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vtdong = dtgDSSV.CurrentRow.Index;
            dtoSinhVien sv = new dtoSinhVien();
            sv.Mssv = int.Parse(dtgDSSV.Rows[vtdong].Cells[0].Value.ToString());
            daoSinhVien daoSV = new daoSinhVien();
            daoSV.XoaSinhVien(sv);
            MessageBox.Show("Xoa thanh cong");
            dtgDSSV.DataSource = daoSV.LayThongTinSinhVien();
        }
    }
}