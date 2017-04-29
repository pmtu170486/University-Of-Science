using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace WindowsApplication22
{
    class myClock:Control
    {
        private Timer timer1;
        public myClock()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            this.Paint += new PaintEventHandler(myClock_Paint);
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        void myClock_Paint(object sender, PaintEventArgs e)
        {
            string str = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            e.Graphics.DrawString(str, this.Font, new SolidBrush(Color.Black), new Point(0, 0));
        }
    }
}
