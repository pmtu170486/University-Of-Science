using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demoGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northWindDataSet1.Orders);
            // TODO: This line of code loads data into the 'northWindDataSet.Orders' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter1.Fill(this.northWindDataSet1.Order_Details);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ordersTableAdapter.Update(northWindDataSet1.Orders);
            order_DetailsTableAdapter1.Update(northWindDataSet1.Order_Details);
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv =
                    (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                        return;

                }
                
                gv.DeleteRow(gv.FocusedRowHandle);
                ordersTableAdapter.Update(northWindDataSet1.Orders);
                order_DetailsTableAdapter1.Update(northWindDataSet1.Order_Details);
            }
            catch(Exception ex)
            {
                ordersTableAdapter.Fill(northWindDataSet1.Orders);
                MessageBox.Show("Khong the xoa", "Info");
                
            }
        }

        private void cardView1_KeyDown(object sender, KeyEventArgs e)
        {
            DevExpress.XtraGrid.Views.Card.CardView cv =
                    (DevExpress.XtraGrid.Views.Card.CardView)sender;
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                        return;

                }

                cv.DeleteRow(cv.FocusedRowHandle);
                ordersTableAdapter.Update(northWindDataSet1.Orders);
                order_DetailsTableAdapter1.Update(northWindDataSet1.Order_Details);
            }
        }
    }

