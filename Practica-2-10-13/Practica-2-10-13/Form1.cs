using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_10_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xi, xf;
            int an, al;
            xi = double.Parse(tbxi.Text);
            xf = double.Parse(tbxf.Text);
            Graphics g = pic.CreateGraphics();
            an = pic.Width;
            al = pic.Height;
            graficadores graf = new graficadores();
            graf.graficar(an, al, g, xi, xf);
        }
    }
    public partial class graficadores
    {
        private int n, ci, cf, fi, ff, c, f;
        private double x, y, xf, xi, yf, yi, h;

        public void graficar(int ancho, int alto, Graphics g, double xi, double xf)
        {
            ci = 1;
            fi = 1;
            cf = ancho;
            ff = alto;
            yi = -10;
            yf = 10;
            this.xi = xi;
            this.xf = xf;
            n = cf - ci;
            h = (xf - xi) / n;
            for (int k = 1; k <= n; k++ )
            {
                x = xi + k * h;
                y = fu(x);
                x = col();
                y = fil();
                g.DrawLine(Pens.Blue, c, f, c + 1, f);

            }
        }
        double fu(double x)
        {
            double y;
            y = Math.Exp(x);
            return y;
        }
        int col()
        {
            int c0 = Convert.ToInt32(((x - xi) / (xf - xi)) * cf + ((xf - x) / (xf - xi)) * ci);
            return c0;
        }
        int fil()
        {
            int fila = Convert.ToInt32(((y-yi)/(yf-yi))*fi+((yf-y)/(yf-yi))*ff);
            return fila;
        }
    }
}
