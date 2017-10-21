using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Modau : Form
    {
        public Modau()
        {
            InitializeComponent();
        }

        private void Modau_Load(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void btnBegin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;       
        }
    }
}
