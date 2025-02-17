namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form_Loader(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Loader(new question1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Loader(new question2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Loader(new question3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Loader(new question4cs());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Loader(new question5());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Loader(new question6());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_Loader(new question7());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_Loader(new question8());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_Loader(new question9());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_Loader(new question10());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form_Loader(new question11());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_Loader(new question12());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form_Loader(new question13());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form_Loader(new question14());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form_Loader(new question15());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form_Loader(new question16());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form_Loader(new question17());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form_Loader(new question18());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form_Loader(new question19());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form_Loader(new question20());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form_Loader(new question21());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form_Loader(new quesyion22());
        }
    }
}
