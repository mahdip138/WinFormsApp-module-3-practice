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
    public partial class question14 : Form
    {
        public question14()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = random.Next(1, 5);
            if (num == 1)
            {
                label1.Left += 10;
                label1.Top += 10;
            }
            else if (num == 2)
            {
                label1.Left -= 10;
                label1.Top -= 10;
            }
            else if (num == 3)
            {
                label1.Left += 10;
                label1.Top -= 10;
            }
            else if (num == 4)
            {
                label1.Left -= 10;
                label1.Top += 10;
            }
        }
        int click_count = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            click_count++;
            label1.Text = click_count.ToString();
        }
    }
}
