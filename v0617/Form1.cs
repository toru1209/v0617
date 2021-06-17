using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int score = 100;
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
                vx = vx * -1;
            if (label1.Top < 0)
                vy = -vy;
            if (label1.Right > ClientSize.Width)
                vx = vx * -1;
            if (label1.Bottom > ClientSize.Height)
                vy = -vy;

            score -= 1;
            label2.Text = "score " + score;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
