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
    public partial class question8 : Form
    {
        public question8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure for exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(exit == DialogResult.OK)
                this.Close();
            // if you want to close all of the app : Application.Exit();
            else if (exit == DialogResult.Cancel)
            {
                button1.Text = "Welcome";
                this.BackColor = Color.Green;
            }
        }
    }
}
