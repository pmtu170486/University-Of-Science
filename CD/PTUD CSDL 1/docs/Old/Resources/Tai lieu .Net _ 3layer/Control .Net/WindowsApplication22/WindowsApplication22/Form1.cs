using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myButton1.NormalFile = "c:\\Soap Bubbles.bmp";
            myButton1.HighLightFile = "c:\\Zapotec.bmp";
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myAddress1.SoNha + " " + myAddress1.Duong);
            
        }

        private void myAddress1_AddressChanged(string address)
        {
            textBox1.Text = address;
        }
    }
}