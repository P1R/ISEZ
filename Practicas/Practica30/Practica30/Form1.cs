using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica30
{
    public partial class Graficadora : Form
    {
        private int n, ci, cf, fi, ff, c, f;
        private double x, y, xi, xf, yi, yf, h;

        public Graficadora()
        {
            InitializeComponent();
        }
        private void Graficar(int ancho, int alto, Graphics g, double xi, double xf)
        {
            ci = 1; cf = ancho;
            fi = 1; ff = alto;
            //yi = -10; yf = 10;
            this.xi = xi;
            this.xf = xf;
            n = cf - ci;
            h = (xf - xi) / n;
            yi = yf = 0;
            for (int i = 1; i < n; i++)
            {
                x = xi + i * h;
                y = Fu(x);
                if (y < yi) yi = y;
                if (y > yf) yf = y;
            }
            if (yi * yf < 0)
            {
                y = 0;
                f = Fil();
                g.DrawLine(Pens.Red, ci, f, cf, f);
            }
            if (xi * xf < 0)
            {
                x = 0;
                c = Col();
                g.DrawLine(Pens.Red, c, fi, c, ff);
            }
            int c1, f1;
            x = xi;
            //y = Fu(x);
            c1 = Col();
            f1 = Fil();

            for (int k = 1; k <= n; k++)
            {
                double a = xi + k * h;
                double r = Fu(a);
                x = r *Math.Cos(a);
                y = r *Math.Sin(a);
                c = Col();
                f = Fil();
                //g.DrawLine(Pens.Black, c1, f1, c, f);
                //c1 = c;
                //f1 = f;
                if (k == 1)
                { 
                    c1 = c; f1 = f; 
                }
                else
                {
                    g.DrawLine(Pens.Purple, c1, f1, c, f);
                    c1 = c; f1 = f;
                }
            }

        }

        double Fu(double x)
        {
            double y;
            y = x;
            return (y);
        }

        int Col()
        {
            int co;
            co = (int)((x - xi) / (xf - xi) * (cf) + (xf - x) / (xf - xi) * (ci));
            return (co);
        }

        int Fil()
        {
            int fila;
            fila = (int)((y - yi) / (yf - yi) * (fi) + (yf - y) / (yf - yi) * (ff));
            return (fila);
        }

        private void Graficando_Click(object sender, EventArgs e)
        {
            double xi, xf;
            int an, al;
            xi = double.Parse(Xi.Text);
            xf = double.Parse(Xf.Text);
            Graphics g = pic1.CreateGraphics();
            an = pic1.Width;
            al = pic1.Height;

            Graficadora graf = new Graficadora();
            graf.Graficar(an, al, g, xi, xf);
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");  
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            pic1.Refresh();  
        }
    }
}
