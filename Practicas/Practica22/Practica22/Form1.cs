using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circulos_Click(object sender, EventArgs e)
        {
            Graphics g = pic1.CreateGraphics();
            g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
            g.FillEllipse(Brushes.Red, 100, 100, 200, 200); 

        }


        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }

        private void lineas_Click(object sender, EventArgs e)
        {
            Graphics g=pic1.CreateGraphics();
            g.DrawLine(Pens.Brown, 5, 10, 5, 150);
            g.DrawLine(Pens.Brown, 110, 10, 110, 150);
            g.DrawLine(Pens.DarkOrange, 150, 100, 400, 100);
        }

        private void puntos_Click(object sender, EventArgs e)
        {
            Graphics g = pic1.CreateGraphics();
            g.FillEllipse(Brushes.Red, 50, 50, 3, 3);
            g.FillEllipse(Brushes.Red, 50, 60, 3, 3);
            g.FillEllipse(Brushes.Red, 50, 70, 3, 3);
            g.FillEllipse(Brushes.Red, 50, 80, 3, 3);
            g.FillEllipse(Brushes.Red, 30, 50, 3, 3);
            g.FillEllipse(Brushes.Red, 30, 60, 3, 3);
            g.FillEllipse(Brushes.Red, 30, 70, 3, 3);
            g.FillEllipse(Brushes.Red, 30, 80, 3, 3);
        }

        private void Cuadros_Click(object sender, EventArgs e)
        {
            Graphics g = pic1.CreateGraphics();
            g.FillRectangle(Brushes.Violet, 250, 300, 100, 100);
            g.FillRectangle(Brushes.Chocolate, 250, 300, 50, 50);
            g.FillRectangle(Brushes.Green, 10, 200, 50, 50);
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

    }
}