using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=demo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("Connected!!!!");
            SqlCommand command = new SqlCommand("select * from sach");

        }
    }
}
