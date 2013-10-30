using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica34
{
    public partial class GraficadoraF : Form
    {
        private int n, ci, cf, fi, ff, c, f;
        private double x, y, xi, xf, yi, yf, h;
        public GraficadoraF()
        {
            InitializeComponent();
        }
        private void Graficar(int ancho, int alto, Graphics g, double xi, double xf, double T)
        {
            ci = 1; cf = ancho;
            fi = 1; ff = alto;
            this.xi = xi;
            this.xf = xf;
            n = cf - ci;
            h = (xf - xi) / n;
            yi = yf = 0;
            for (int i = 1; i < n; i++)
            {
                x = xi + i * h;
                if (listBox1.SelectedIndex == 0)
                    y = Math.Cos(x + T);
                if (listBox1.SelectedIndex == 1)
                    y = Math.Sin(x + T);
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
                f = Fil();
                g.DrawLine(Pens.Red, c, fi, c, ff);
            }
            int c1, f1;
            x = xi;
            //y = Fu(x);
            c1 = Col();
            f1 = Fil();

            for (int k = 1; k <= n; k++)
            {
                x = xi + k * h;
                if (listBox1.SelectedIndex == 0)
                    y = Math.Cos(x+T);
                if (listBox1.SelectedIndex == 1)
                    y = Math.Sin(x + T);
                c = Col();
                f = Fil();
                g.DrawLine(Pens.Black, c1, f1, c, f);
                c1 = c;
                f1 = f;
            }

        }

        double Fu(double x)
        {
            double y;
            y = Math.Sin(x);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            double ti, tf, T;
            int an, al;
            T = timer1.Interval;
            ti= double.Parse(Xi.Text);
            tf = double.Parse(Xf.Text);
            an = pic1.Width;
            al = pic1.Height;
            Graphics g=pic1.CreateGraphics();
            GraficadoraF gr= new GraficadoraF();
            gr.Graficar(an, al, g, ti, tf, T);
            gr.Refresh(); 
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");  
        }
    }
}
