using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication22
{
    public partial class myAddress : UserControl
    {
        public delegate void AddressChangedHandler(string address);
        public event AddressChangedHandler AddressChanged;

        public myAddress()
        {
            InitializeComponent();
        }
        public string ThanhPho
        {
            get
            {
                return textBox4.Text;
            }
            set
            {
                textBox4.Text = value;
            }
        }
        public string SoNha
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string Duong
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public string Quan
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string diachimoi = SoNha + " " + Duong + " " + Quan + " " + ThanhPho;
            if (AddressChanged != null)
            {
                AddressChanged(diachimoi);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string diachimoi = SoNha + " " + Duong + " " + Quan + " " + ThanhPho;
            if (AddressChanged != null)
            {
                AddressChanged(diachimoi);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string diachimoi = SoNha + " " + Duong + " " + Quan + " " + ThanhPho;
            if (AddressChanged != null)
            {
                AddressChanged(diachimoi);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string diachimoi = SoNha + " " + Duong + " " + Quan + " " + ThanhPho;
            if (AddressChanged != null)
            {
                AddressChanged(diachimoi);
            }
        }
    }
}
