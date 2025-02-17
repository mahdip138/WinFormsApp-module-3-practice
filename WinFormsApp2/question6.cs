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
    public partial class question6 : Form
    {
        public question6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "start";
            }
            else
            {
                persec = 0;
                sec = 0;
                min = 0;
                timer1.Enabled = true;
                button1.Text = "stop";
            }
        }
        int persec, sec, min;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(persec == 100)
            {
                persec = 0;
                sec++;
            }
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            label1.Text = persec.ToString();
            label2.Text = sec.ToString();
            label3.Text =min.ToString();
            persec++;
        }
    }
}
