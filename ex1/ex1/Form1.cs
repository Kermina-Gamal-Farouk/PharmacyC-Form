using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Shampoo";
            textBox2.Text = "130";
            pictureBox1.Image = Properties.Resources.photo_2026_10_11_01_57_26;
            pictureBox1.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Vitamin";
            textBox2.Text = "260";
            pictureBox1.Image = Properties.Resources.photo_2026_10_11_01_57_30;
            pictureBox1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Soap";
            textBox2.Text = "30";
            pictureBox1.Image = Properties.Resources.photo_2026_10_11_01_57_32;
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
