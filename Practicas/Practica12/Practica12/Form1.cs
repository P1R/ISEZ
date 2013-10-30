using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12
{
    public partial class Calculadora : Form
    {
        private double dx, dy, ry;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void sen1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Sin(dx);
            cy1.Text = ry.ToString();
        }

        private void cos1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Cos(dx);
            cy1.Text = ry.ToString();
        }

        private void tan1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Tan(dx);
            cy1.Text = ry.ToString();
        }

        private void asen1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Asin(dx);
            cy1.Text = ry.ToString();
        }

        private void acos1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Acos(dx);
            cy1.Text = ry.ToString();
        }

        private void atan1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Atan(dx);
            cy1.Text = ry.ToString();
        }

        private void senh1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Sinh(dx);
            cy1.Text = ry.ToString();
        }

        private void cosh1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Cosh(dx);
            cy1.Text = ry.ToString();
        }

        private void tanh1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Tanh(dx);
            cy1.Text = ry.ToString();
        }

        private void exp1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Exp(dx);
            cy1.Text = ry.ToString();
        }

        private void log1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Log10(dx);
            cy1.Text = ry.ToString();
        }

        private void ln1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Log(dx);
            cy1.Text = ry.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }

        private void raiz1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Sqrt(dx); 
            cy1.Text = ry.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = dx^2;
            cy1.Text = ry.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            dy = Double.Parse(cx2.Text);
            ry = (dx^dy)d;
            cy1.Text = ry.ToString();
        }
    }
}
