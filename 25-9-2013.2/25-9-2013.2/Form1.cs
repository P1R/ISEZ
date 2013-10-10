using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_9_2013._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Pic1.CreateGraphics();
            g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
            g.FillEllipse(Brushes.Red, 100, 100, 200, 200);
        }

        private void Pic1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Pic1.CreateGraphics();
            g.DrawLine(Pens.IndianRed, 100, 100, 101, 100);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = Pic1.CreateGraphics();
            g.DrawLine(Pens.HotPink, 20, 20, 150, 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = Pic1.CreateGraphics();
            g.DrawRectangle(Pens.Firebrick,10,10,200,200);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color col = new Color();
            int x1, y1, x2, y2, colr, colg, colb, i;
            Graphics g = Pic1.CreateGraphics();
            Random rn = new Random();
            for (i = 1; i < 20000; i++)
            {
                colr = rn.Next(255);
                colg = rn.Next(255);
                colb = rn.Next(255);
                x2 = rn.Next(Pic1.Width);
                y2 = rn.Next(Pic1.Height);
                Pen lapiz = new Pen();
                lapiz = Color.FromArgb(colr, colg, colb);

            }
        }

    }
}
