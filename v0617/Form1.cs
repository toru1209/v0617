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
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);

        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next() % ClientSize.Width;
            label1.Top = rand.Next() % ClientSize.Height;
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

            if (    (fpos.Y >= label1.Top)
                 && (fpos.Y < label1.Bottom)
                 && (fpos.X <= label1.Left)
                 && (fpos.X > label1.Right)
                )
                timer1.Enabled = false;

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


            label5.Left += vx1;
            label5.Top += vy1;

            if (label5.Left < 0)
                vx1 = vx1 * -1;
            if (label5.Top < 0)
                vy1 = -vy1;
            if (label5.Right > ClientSize.Width)
                vx1 = vx1 * -1;
            if (label5.Bottom > ClientSize.Height)
                vy1 = -vy1;

            label6.Left += vx2;
            label6.Top += vy2;

            if (label6.Left < 0)
                vx2 = vx2 * -1;
            if (label6.Top < 0)
                vy2 = -vy2;
            if (label6.Right > ClientSize.Width)
                vx2 = vx2 * -1;
            if (label6.Bottom > ClientSize.Height)
                vy2 = -vy2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
