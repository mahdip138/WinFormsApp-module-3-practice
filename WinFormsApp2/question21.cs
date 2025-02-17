using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class question21 : Form
    {
        public question21()
        {
            InitializeComponent();
        }
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            pictureBox1.Width += 10;
            pictureBox1.Height += 10;
            if (c == 1)
                pictureBox1.Image = Properties.Resources._7567;
            else if (c == 2)
                pictureBox1.Image = Properties.Resources._098890;
            else if (c == 3)
                pictureBox1.Image = Properties.Resources.R__1_;
            else if (c == 4)
            {
                pictureBox1.Image = Properties.Resources._234;
                c = 0;
            }

        }
    }
}
