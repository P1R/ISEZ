using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics; 


namespace Practica14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double x, y;
            Complex Z1;
            Complex Z2 = new Complex();

            x = double.Parse(cx1.Text);
            y = double.Parse(cy1.Text);

            Z1 = new Complex(x, y);
            Z2 = Complex.Cos(Z1);

            x = Z2.Real;
            y = Z2.Imaginary;

            cx2.Text = x.ToString();
            cy2.Text = y.ToString(); 
        }
    }
}
