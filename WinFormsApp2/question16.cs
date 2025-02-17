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
    public partial class question16 : Form
    {
        public question16()
        {
            InitializeComponent();
        }

        public int power(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
                result *= num ;
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result = power(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = result.ToString();
        }
    }
}
