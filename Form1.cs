using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VerificationCaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Captcha.GenerateImage();
            label1.Text = $"Answer: {Captcha.CaptchaAnswer}";
        }

        // so we can round corners
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 20;

            // setting up rounded corners with a path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            // making the form's region match the rounded corners
            this.Region = new Region(path);

            // optional border
            using (Pen pen = new Pen(Color.Black, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // when the button is clicked, generate new captcha
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Captcha.GenerateImage();
            label1.Text = $"Answer: {Captcha.CaptchaAnswer}";
            textBox1.Clear();
        }

        // checking if user input matches captcha
        private void button3_Click(object sender, EventArgs e)
        {
            bool AllowAnyCapitalization = true;

            if (AllowAnyCapitalization)
            {
                if (textBox1.Text.ToLower() == Captcha.CaptchaAnswer.ToLower())
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Incorrect");
            }
            else
            {
                if (textBox1.Text == Captcha.CaptchaAnswer)
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Incorrect");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // quit the app when button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
