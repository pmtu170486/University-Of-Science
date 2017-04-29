using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace WindowsApplication22
{
    class myButton:Button
    {
        private string normalFile;
        private string highLightFile;
        public myButton()
        {
            this.MouseEnter += new EventHandler(myButton_MouseEnter);
            this.MouseLeave += new EventHandler(myButton_MouseLeave);
        }
        public string NormalFile
        {
            get
            {
                return normalFile;
            }
            set
            {
                normalFile = value;
            }
        
        }
        public string HighLightFile
        {
            get
            {
                return highLightFile;
            }
            set
            {
                highLightFile = value;
            }
        }

        void myButton_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile(this.normalFile);
            if (image != null)
            {
                this.BackgroundImage = image;
            }
        }

        void myButton_MouseEnter(object sender, EventArgs e)
        {
            Image image = Image.FromFile(this.highLightFile);
            if (image != null)
            {
                this.BackgroundImage = image;
            }
        }
    }
}
