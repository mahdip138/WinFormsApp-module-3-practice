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
    public partial class question4cs : Form
    {
        public question4cs()
        {
            InitializeComponent();
        }

        //bool accident = false;
        int movement = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (label1.Left + label1.Width == label2.Left)
                accident = true;
            if (accident)
            {
                label1.Left -= 3;
                label2.Left += 3;
            }
            else
            {
                label1.Left += 7;
                label2.Left -= 7;
            }*/
            label1.Left += movement;
            label2.Left -= movement;
            if (label1.Left + label1.Width == label2.Left)
                movement = -1;

        }

        private void question4cs_Load(object sender, EventArgs e)
        {
            int a = (label2.Left - (label1.Left + label1.Width)) % (1*2);
            if (a != 0)
                label2.Left -= a;
        }
    }
}
