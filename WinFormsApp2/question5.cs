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
    public partial class question5 : Form
    {
        public question5()
        {
            InitializeComponent();
        }
        int click_count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                click_count++;
            else
                timer1.Enabled = true; 
            button1.Text = click_count.ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.Enabled = false;
            click_count = 0;
        }
    }
}
