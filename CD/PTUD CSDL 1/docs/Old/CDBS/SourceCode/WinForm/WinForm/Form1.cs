using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForm.Data;
using DevExpress.XtraReports.UI;
namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadProduct();
        }
        public void loadProduct()
        {
            Data.Ewebsite data = new Data.Ewebsite();
            BindingSource bd = new BindingSource();
            var s = (from p in data.Products
                    select new { 
                        id=p.id,
                        name=p.name,
                        quantity=p.quantity,
                        price=p.price,
                        type=p.ProductType.name
                    }).ToList();
            
            bd.DataSource = s;
            dgvProducts.DataSource = bd;

            

            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            XtraReport2 report = new XtraReport2();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
