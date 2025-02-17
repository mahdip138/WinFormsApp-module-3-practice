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
    public partial class question17 : Form
    {
        public question17()
        {
            InitializeComponent();
        }
        public void multiplly(int num1, int num2)
        {
            label1.Text =  (num1*num2).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            multiplly(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}
