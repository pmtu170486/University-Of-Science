using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace demoReportDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TableReport report = new TableReport();
            ChartReport report = new ChartReport();
            ReportPrintTool tool = 
                new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
