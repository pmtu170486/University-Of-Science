using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EF_demo
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }
        EF_demo.BLL.ProductServices servics = new BLL.ProductServices();
        public void loadGridview()
        {
            BindingSource bd=new BindingSource();
            bd.DataSource=servics.findAlls();
            gridControl1.DataSource = bd;
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            loadGridview();
        }
    }
}
