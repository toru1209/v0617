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
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label4.Left = fpos.X - label4.Width / 2;
            label4.Top = fpos.Y - label4.Height / 2;

            label4.Text = $"{fpos.X},{fpos.Y}";

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

            if (score <= 0)
            {
                label3.Top = ClientSize.Height / 2;
                label3.Left = ClientSize.Width / 2;
                label3.Visible = true;
                timer1.Enabled = false;
            }

            if (   (fpos.Y >= label1.Top) 
                && (fpos.Y < label1.Bottom) 
                && (fpos.X <= label1.Left)
                && (fpos.X > label1.Right)
                )
            {
                timer1.Enabled = false;
            }
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
