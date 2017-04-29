using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienCoBan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadCombobox();
        }

        public void loadCombobox()
        {
            string[] thanhpho = new string[] { "Ha noi",
                "Da nang","Ho chi minh"};
            cboThanhPho.DataSource = thanhpho;
        }

        private void cboThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboThanhPho.SelectedIndex;
            string[] quan = null;
            switch(index)
            {
                case 0:
                    quan = new string[] {"Hoan kiem","Ba dinh"};
                    break;
                case 1:
                    quan = new string[] {"a","b","c"};
                    break;
                case 2:
                    quan = new string[] { "binh chanh","binh thanh"};
                    break;
            }
            cboQuan.DataSource = quan;
        }

        private  BindingList<SinhVien> lst = new BindingList<SinhVien>();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            // Lay dia chi text box nguoi dung nhap ho ten 
            // va gan vao thuoc tinh ho ten cua sinh vien
            sv.hoten = txtHoTen.Text;
            // Lay gioi tinh nguoi dung chon them vao thuoc tinh
            // gioi tinh cua sinh vien
            if (rdoNam.Checked)
                sv.gioitinh = "nam";
            else
                sv.gioitinh = "Nu";
            // Lay dia chi nguoi dung nhap va gan vao thuoc tinh
            // dia chi cua sinh vien
            StringBuilder str = new StringBuilder();
            if(rdoThanhPho.Checked)
                str.Append(" thanh pho - ");
            else
                str.Append(" ngoai thanh - ");
            str.Append(cboThanhPho.Text + " - "+cboQuan.Text);
            sv.diachi = str.ToString();
            // Them doi tuong sinh vien vao List
            lst.Add(sv);
            // Hien thi cac gia tri trong list tren Data Grid View
            // De cap nhat phan tu mới trong list hien thi dât grid view, ta dung doi 
            // tuong BindingList
            gv.DataSource = lst;
           
        }


    }
}
