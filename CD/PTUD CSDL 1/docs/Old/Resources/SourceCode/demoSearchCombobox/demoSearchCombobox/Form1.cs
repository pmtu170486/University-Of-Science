using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoSearchCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<SinhVien> lst = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lst.Add(new SinhVien { id = 1, name = "nguyen van a" });
            lst.Add(new SinhVien { id = 2, name = "Tran van anh" });
            lst.Add(new SinhVien { id = 3, name = "Lam thanh tung" });
            lst.Add(new SinhVien { id = 4, name = "Thanh thuy" });

            cboSinhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSinhVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSinhVien.DataSource = lst;
            cboSinhVien.ValueMember = "id";
            cboSinhVien.DisplayMember = "name";
        }
    }
}
