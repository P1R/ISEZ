using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double dx, ry, dy;
        public Form1()
        {
            InitializeComponent();
            Cy1.Text = "0.0";
            Cx1.Text="0.0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Cos(dx);
            R.Text = ry.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Tan(dx);
            R.Text = ry.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Exp(dx);
            R.Text = ry.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Sin(dx);
            R.Text = ry.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Asin(dx);
            R.Text = ry.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Acos(dx);
            R.Text = ry.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cy1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Atan(dx);
            R.Text = ry.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dx= Double.Parse(Cx1.Text);
            ry = Math.Sinh(dx);
            R.Text = ry.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Cosh(dx);
            R.Text = ry.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Tanh(dx);
            R.Text = ry.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Log10(dx);
            R.Text = ry.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Log(dx);
            R.Text = ry.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Sqrt(dx);
            R.Text = ry.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            ry = Math.Pow(dx,2);
            R.Text = ry.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(Cx1.Text);
            dy = Double.Parse(Cy1.Text);
            ry = Math.Pow(dx, dy);
            R.Text = ry.ToString();
        }
        
    }
}
