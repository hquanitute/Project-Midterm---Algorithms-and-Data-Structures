namespace Graphic
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tbsophantu = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.lblSoSanh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbThanhSoSanh = new System.Windows.Forms.CheckBox();
            this.pnlChinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbsophantu
            // 
            this.tbsophantu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsophantu.Location = new System.Drawing.Point(14, 62);
            this.tbsophantu.Name = "tbsophantu";
            this.tbsophantu.Size = new System.Drawing.Size(113, 20);
            this.tbsophantu.TabIndex = 0;
            this.tbsophantu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbsophantu.TextChanged += new System.EventHandler(this.tbsophantu_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt1.Location = new System.Drawing.Point(14, 88);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(113, 33);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Tạo";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSort.Location = new System.Drawing.Point(14, 125);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(113, 33);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // pnlChinh
            // 
            this.pnlChinh.Controls.Add(this.lblSoSanh);
            this.pnlChinh.Location = new System.Drawing.Point(34, 25);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(817, 502);
            this.pnlChinh.TabIndex = 3;
            // 
            // lblSoSanh
            // 
            this.lblSoSanh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoSanh.Location = new System.Drawing.Point(5, 4);
            this.lblSoSanh.Name = "lblSoSanh";
            this.lblSoSanh.Size = new System.Drawing.Size(808, 2);
            this.lblSoSanh.TabIndex = 0;
            this.lblSoSanh.Text = "lblSoSanh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.ckbThanhSoSanh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.tbSpeed);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(862, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiện ích";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStop.Location = new System.Drawing.Point(14, 128);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Dừng lại";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(14, 77);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(113, 45);
            this.tbSpeed.TabIndex = 0;
            this.tbSpeed.Value = 50;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbsophantu);
            this.groupBox2.Controls.Add(this.bt1);
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(862, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 165);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo lập";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phần tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(14, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tốc độ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ckbThanhSoSanh
            // 
            this.ckbThanhSoSanh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ckbThanhSoSanh.Checked = true;
            this.ckbThanhSoSanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbThanhSoSanh.Location = new System.Drawing.Point(19, 174);
            this.ckbThanhSoSanh.Name = "ckbThanhSoSanh";
            this.ckbThanhSoSanh.Size = new System.Drawing.Size(107, 46);
            this.ckbThanhSoSanh.TabIndex = 2;
            this.ckbThanhSoSanh.Text = "Chọn thanh    so sánh";
            this.ckbThanhSoSanh.UseVisualStyleBackColor = false;
            this.ckbThanhSoSanh.CheckedChanged += new System.EventHandler(this.ckbThanhSoSanh_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlChinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô tả thuật toán sắp xếp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlChinh.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox tbsophantu;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lblSoSanh;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbThanhSoSanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

