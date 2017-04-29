namespace WindowsApplication22
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myAddress1 = new WindowsApplication22.myAddress();
            this.myClock2 = new WindowsApplication22.myClock();
            this.myClock1 = new WindowsApplication22.myClock();
            this.myButton1 = new WindowsApplication22.myButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myAddress1
            // 
            this.myAddress1.Duong = "";
            this.myAddress1.Location = new System.Drawing.Point(190, 155);
            this.myAddress1.Name = "myAddress1";
            this.myAddress1.Quan = "";
            this.myAddress1.Size = new System.Drawing.Size(356, 110);
            this.myAddress1.SoNha = "34";
            this.myAddress1.TabIndex = 3;
            this.myAddress1.ThanhPho = "";
            this.myAddress1.AddressChanged += new WindowsApplication22.myAddress.AddressChangedHandler(this.myAddress1_AddressChanged);
            // 
            // myClock2
            // 
            this.myClock2.Location = new System.Drawing.Point(95, 195);
            this.myClock2.Name = "myClock2";
            this.myClock2.Size = new System.Drawing.Size(75, 23);
            this.myClock2.TabIndex = 2;
            this.myClock2.Text = "myClock2";
            // 
            // myClock1
            // 
            this.myClock1.Location = new System.Drawing.Point(200, 22);
            this.myClock1.Name = "myClock1";
            this.myClock1.Size = new System.Drawing.Size(75, 23);
            this.myClock1.TabIndex = 1;
            this.myClock1.Text = "myClock1";
            // 
            // myButton1
            // 
            this.myButton1.HighLightFile = null;
            this.myButton1.Location = new System.Drawing.Point(212, 105);
            this.myButton1.Name = "myButton1";
            this.myButton1.NormalFile = null;
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myAddress1);
            this.Controls.Add(this.myClock2);
            this.Controls.Add(this.myClock1);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myButton myButton1;
        private myClock myClock1;
        private myClock myClock2;
        private myAddress myAddress1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

