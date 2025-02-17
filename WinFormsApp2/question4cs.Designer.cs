namespace WinFormsApp2
{
    partial class question4cs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Lime;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(351, 175);
            label1.Name = "label1";
            label1.Size = new Size(120, 45);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.Lime;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(740, 175);
            label2.Name = "label2";
            label2.Size = new Size(120, 45);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // question4cs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 523);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "question4cs";
            Text = "question4cs";
            Load += question4cs_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}