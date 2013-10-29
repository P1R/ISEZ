using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace Examen_III
{
    public partial class Form1 : Form
    {
        int m, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void tamaño_Click(object sender, EventArgs e)
        {
            m = Int32.Parse(filas.Text);
            n = Int32.Parse(columnas.Text);
            A.RowCount = m;
            A.ColumnCount = n;
            B.RowCount = n;
            B.ColumnCount = m;
            P.RowCount = m;
            P.ColumnCount = n;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Complex[,] X = new Complex[m, n];
            string s, aux = "", aux2="";
            double r, im;
            int k;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    s = A[j, i].Value.ToString();
                    for (k = 0; k < s.Length; k++) 
                    {
                        if (s[k] != ',')
                        {
                            aux = aux + s[k];
                        }
                        else break;
                    }
                    for (int g = k + 1; g < s.Length; g++)
                    {
                        aux2 = aux2 + s[g];
                    }
                    Double.TryParse(aux, out r);
                    Double.TryParse(aux2, out im);
                    X[i, j] = new Complex(r, im);
                    aux = "";
                    aux2 = "";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[j, i].Value = X[j,i];
                }
            }
            if (m != n) 
            {
                label6.Text = "No se puede realizar la resta (condición: m = n).";
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        P[j, i].Value = Complex.Subtract(X[i, j], X[j, i]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filas.Text = "";
            columnas.Text = "";
            B.Rows.Clear();
            B.Columns.Clear();
            A.Rows.Clear();
            A.Columns.Clear();
            P.Rows.Clear();
            P.Columns.Clear();
        }
    }
}
