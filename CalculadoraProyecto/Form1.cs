using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MTPARSERCOMLib;

namespace Calculadora_Proyecto
{
    public partial class Form1 : Form
    {
        string opera = "", num = "";
        double resul = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void division_Click(object sender, EventArgs e)
        {
            opera += textBox1.Text + " / ";
            textBox2.Text = opera;
            num = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            opera += textBox1.Text + " * ";
            textBox2.Text = opera;
            num = "";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            opera += textBox1.Text + " - ";
            textBox2.Text = opera;
            num = "";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            num += "1";
            textBox1.Text = num;
        }

        private void dos_Click(object sender, EventArgs e)
        {
            num += "2";
            textBox1.Text = num;
        }

        private void tres_Click(object sender, EventArgs e)
        {
            num += "3";
            textBox1.Text = num;
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            num += "4";
            textBox1.Text = num;
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            num += "5";
            textBox1.Text = num;
        }

        private void seis_Click(object sender, EventArgs e)
        {
            num += "6";
            textBox1.Text = num;
        }

        private void siete_Click(object sender, EventArgs e)
        {
            num += "7";
            textBox1.Text = num;
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            num += "8";
            textBox1.Text = num;
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            num += "9";
            textBox1.Text = num;
        }

        private void cero_Click(object sender, EventArgs e)
        {
            num += "0";
            textBox1.Text = num;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            opera += textBox1.Text + " + ";
            textBox2.Text = opera;
            num = "";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            num += ".";
            textBox1.Text = num;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            MTParser conv = new MTParser();
            opera += textBox1.Text;
            resul = conv.evaluate(opera);
            textBox1.Text = resul.ToString();
            textBox2.Text = "";
            opera = "";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double aux;
            aux = Math.Sqrt(Double.Parse(textBox1.Text));
            textBox1.Text = Math.Round(aux, 3).ToString();
            num = "";
        }

        private void mos_Click(object sender, EventArgs e)
        {
            double aux;
            aux = -1 * (Double.Parse(textBox1.Text));
            textBox1.Text = aux.ToString();
        }

        private void inver_Click(object sender, EventArgs e)
        {
            double aux;
            aux = 1 / (Double.Parse(textBox1.Text));
            textBox1.Text = aux.ToString();
        }

        private void limpiatodo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            opera = "";
            num = "";
        }
    }
}
