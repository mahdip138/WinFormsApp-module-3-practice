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
    public partial class question9 : Form
    {
        public question9()
        {
            InitializeComponent();
        }
        int left, top;
        int movement;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left == left  && label1.Top == top)
            {

                movement = 1;
                label1.Top += movement;
                label1.Left += movement;
            }
            if (label1.Left <= left+50  && label1.Left > left)
            {

                label1.Left += movement;
                label1.Top -= movement;
            }
            else if (label1.Left <= left+100 && label1.Left >= left + 50)
            {
                label1.Top += movement;
                label1.Left += movement;
            }
            else if (label1.Left <= left + 150 && label1.Left > left + 100)
            {
                label1.Left += movement;
                label1.Top -= movement;
            }
            else if (label1.Left < left + 200 && label1.Left >= left + 150)
            {
                label1.Top += movement;
                label1.Left += movement;
            }
            else if (label1.Left == left + 200 && label1.Top == top)
            {

                movement = -1;
                label1.Top += movement;
                label1.Left += movement;
            }
        }

        private void question9_Load(object sender, EventArgs e)
        {
            left = label1.Left;
            top = label1.Top;
        }
    }
}
