using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int x, y;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 500;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            button1.Location = new Point(rnd.Next(0, this.Width - button1.Size.Width), rnd.Next(0, this.Height - button1.Size.Height - 50));
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }
        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton1.Location = new Point(rnd.Next(0, this.Width - button1.Size.Width), rnd.Next(0, this.Height - button1.Size.Height - 50));
        }
        private void progressBar1_MouseEnter(object sender, EventArgs e)
        {
            progressBar1.Value = rnd.Next(0, 101);
        }
    }
}
