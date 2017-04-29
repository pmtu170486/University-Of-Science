namespace QuanLySinhVien
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
            this.btnXemTTSV = new System.Windows.Forms.Button();
            this.dtGVSV = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemTTSV
            // 
            this.btnXemTTSV.Location = new System.Drawing.Point(32, 77);
            this.btnXemTTSV.Name = "btnXemTTSV";
            this.btnXemTTSV.Size = new System.Drawing.Size(193, 35);
            this.btnXemTTSV.TabIndex = 0;
            this.btnXemTTSV.Text = "Xem thông tin sinh viên";
            this.btnXemTTSV.UseVisualStyleBackColor = true;
            this.btnXemTTSV.Click += new System.EventHandler(this.btnXemTTSV_Click);
            // 
            // dtGVSV
            // 
            this.dtGVSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVSV.Location = new System.Drawing.Point(32, 131);
            this.dtGVSV.Name = "dtGVSV";
            this.dtGVSV.RowTemplate.Height = 24;
            this.dtGVSV.Size = new System.Drawing.Size(551, 247);
            this.dtGVSV.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(244, 77);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(171, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 421);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtGVSV);
            this.Controls.Add(this.btnXemTTSV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemTTSV;
        private System.Windows.Forms.DataGridView dtGVSV;
        private System.Windows.Forms.Button btnXoa;
    }
}

