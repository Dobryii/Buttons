using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            button2.Text = "Зелёный";
            button2.Width = 130;
            button2.Height = 40;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Aquamarine;
            button3.Text = "Аквамарин";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
