using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkChungChi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChungChi.Checked == true)
            {
                cboChungChi.Enabled = true;
            }
            else
            {
                cboChungChi.Enabled = false;
            }
        }
    }
}