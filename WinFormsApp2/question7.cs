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
    public partial class question7 : Form
    {
        public question7()
        {
            InitializeComponent();
        }

        int left, top;
        private void question7_Load(object sender, EventArgs e)
        {
            left = label1.Left;
            top = label1.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Top == top && label1.Left < left + 500)
                label1.Left += 1;
            else if (label1.Left == left + 500 && label1.Top < top + 500)
                label1.Top += 1;
            else if (label1.Top == top + 500 && label1.Left > left)
                label1.Left -= 1;
            else if (label1.Left == left && label1.Top > top)
                label1.Top -= 1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int color_num = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (color_num == 0)
                label1.BackColor = Color.Green;
            else if(color_num == 1)
                label1.BackColor = Color.Red;
            else if(color_num == 2)
                label1.BackColor = Color.Yellow;
            else if(color_num == 3)
            {
                label1.BackColor = Color.Blue;
                color_num = 0;
            }
            color_num++;
        }
    }
}
