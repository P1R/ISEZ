using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto6
{
    public partial class graficos : Form
    {
        public Boolean rata, linea, circulo;
        public Boolean cuadro_relleno, circulo_relleno;
        public graficos()
        {
            InitializeComponent();
        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            rata = false;
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            rata = true;
        }

        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pic1.CreateGraphics();

            if (linea)
            {
                if (rata)
                    g.DrawLine(Pens.Black, e.X , e.Y , e.X +1 , e.Y );
            }
            else if (circulo)
            {
                if (rata)
                    g.DrawEllipse(Pens.Black, e.X, e.Y, e.X + 1, e.Y);
            }
            else if (cuadro_relleno)
            {
                if (rata)
                    g.FillRectangle(Brushes.Blue, e.X, e.Y, e.X + 1, e.Y);
            }
            else if (circulo_relleno)
            {
                if (rata)
                    g.FillEllipse (Brushes.Green, e.X, e.Y, e.X + 1, e.Y);
            }
            
        }

        private void Lineas_Click(object sender, EventArgs e)
        {
            circulo_relleno = false;
            cuadro_relleno = false;
            circulo = false;
            linea = true;

        }

        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe"); 
        }

        private void Circulos_Click(object sender, EventArgs e)
        {
            circulo_relleno = false;
            cuadro_relleno = false;                
            linea = false;
            circulo = true;
        }

        private void Cuadros_Click(object sender, EventArgs e)
        {
            circulo_relleno = false;
            linea = false;
            circulo = false;
            cuadro_relleno = true;
        }

        private void circulos_relleno_Click(object sender, EventArgs e)
        {
            linea = false;
            circulo = false;
            cuadro_relleno = false;
            circulo_relleno = true;
        }

    }
}
