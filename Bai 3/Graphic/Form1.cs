using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 : Form
    {
        int[] mang;
        int n=0;
        int max = 100;
        int speed = 500;
        ThreadStart temp;
        Thread dung;
        //int min = 0;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void bt1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            n = int.Parse(tbsophantu.Text.ToString());
            //addToolBox();
            Panel[] pnl = new Panel[n];
            mang = new int[n];
            pnlChinh.Controls.Clear();
            createpanel();
            creatTBIntNumber();
            btnSort.Enabled = true;
        }

        Panel[] pnlCon;
        //
       // Panel mau;
        void creatTBIntNumber()
        {
            TextBox tb1 = new TextBox();
            string s = "";
            int i = 0;
            for (i=0; i < n; i++) 
            {
                if (i != n - 1)
                    s = s + (mang[i]).ToString()+", ";
                else
                    s = s + (mang[i]).ToString();
            }
            tb1.Location = new System.Drawing.Point(160, 0);
            tb1.Width = 450;
            tb1.Text = s;
            tb1.ReadOnly = true;
            pnlChinh.Controls.Add(tb1);
        }
        void createpanel()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            pnlCon = new Panel[n];
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                int a = ran.Next(1, 40);
                mang[i] = a;
               // MessageBox.Show(a.ToString(),"xuat");
                pnlCon[i] = new Panel();
            
                pnlCon[i].BorderStyle = BorderStyle.FixedSingle;
                pnlCon[i].Width=((pnlChinh.Width-10)/n);
                pnlCon[i].Height = (pnlChinh.Height - 10) * a / max;
                pnlCon[i].Location = new System.Drawing.Point(i * Convert.ToInt32(pnlCon[i].Width),pnlChinh.Height - Convert.ToInt32(pnlCon[i].Height));
                pnlCon[i].BackColor = Color.Black;
                
                pnlChinh.Controls.Add(pnlCon[i]);
            }
            pnlChinh.Controls.Add(lblSoSanh);
            lblSoSanh.Width = Convert.ToInt32(pnlChinh.Width);
            lblSoSanh.Height = 2;
            //pnlChinh.Controls.Add(mau);
        }
        void inform()
        {
            TextBox thongBao = new TextBox();
            thongBao.BackColor = Color.Gold;
            thongBao.ForeColor = Color.Blue;
            thongBao.Text = "Day cac so ngau nhien";
            thongBao.ReadOnly = true;
            thongBao.Width = 150;
            // thongBao.Text.
            pnlChinh.Controls.Add(thongBao);
        }

        void insertSort()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //int mauHeight;
            int chieucao = 0;
            lblSoSanh.Visible = true;
            lblSoSanh.Location = new Point(0, 0);
            lblSoSanh.Width = Convert.ToInt32(pnlChinh.Width);
            lblSoSanh.Height = 1;
            for (int i = 1; i < n; i++)
            {
                pnlCon[i].BackColor=Color.Red;
                int temp = mang[i];
                chieucao = pnlCon[i].Height;
                Point loc = new Point(0, pnlCon[i].Location.Y);
                Thread.Sleep(speed);
                int j;
                for (j = i - 1; j >= 0; j--)
                {
                    pnlCon[j].BackColor = Color.BlueViolet;
                    
                    if (temp < mang[j])
                    {
                        //
                        mang[j + 1] = mang[j];
                        Thread.Sleep(speed);
                        pnlCon[j + 1].Height = Convert.ToInt32(pnlCon[j].Height);
                        pnlCon[j+1].Location = new System.Drawing.Point((j+1) * Convert.ToInt32(pnlCon[j+1].Width), pnlChinh.Height - Convert.ToInt32(pnlCon[j+1].Height));
                        lblSoSanh.Location = loc;
                        //this.Update();
                        //this.Refresh();
                        Thread.Sleep(speed);
                        
                        pnlCon[j].BackColor = Color.Black;
                       
                    }
                    else
                    {
                        pnlCon[j].BackColor = Color.Black;
                        break;
                    }
                    pnlCon[i].BackColor = Color.Black;

                }
                mang[j + 1] = temp;
                pnlCon[j + 1].Height=chieucao;
                pnlCon[j+1].Location = new System.Drawing.Point((j+1) * Convert.ToInt32(pnlCon[j+1].Width), pnlChinh.Height - Convert.ToInt32(pnlCon[j+1].Height));
                Thread.Sleep(speed);
            }
            lblSoSanh.Visible = false;
            bt1.Enabled = true;
            MessageBox.Show("Xong. Mệt nghỉ, éo làm nữa","Hoàn thành",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            bt1.Enabled = false;
            temp = new ThreadStart(insertSort);
            dung = new Thread(temp);
            dung.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnSort.Enabled = false;

            lblSoSanh.Visible = false;
        }

        private void tbsophantu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Bạn muốn thoát?", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;

        }

        private void pnlTong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            speed =10*( 100- Convert.ToInt32(tbSpeed.Value.ToString()));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            dung.Abort();
        }

        private void ckbThanhSoSanh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbThanhSoSanh.Checked)
                lblSoSanh.Height = 1;
            else
                lblSoSanh.Height = 0;
        }
    }
}
    