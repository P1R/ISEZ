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

namespace Practica37
{
    public partial class OpMatrices : Form
    {
        int ma, na ,mb,nb;
        public OpMatrices()
        {
            InitializeComponent();
        }


        private void Tamaño_Click_1(object sender, EventArgs e)
        {
            ma = Int32.Parse(cm.Text);
            na = Int32.Parse(cn.Text);
            matA.RowCount = ma;
            matA.ColumnCount = na;
        }
        private void TamañoB_Click_1(object sender, EventArgs e)
        {
            mb = Int32.Parse(cmb.Text);
            nb = Int32.Parse(cnb.Text);
            matB.RowCount = mb;
            matB.ColumnCount = nb; 
        }

        private void TamañoAC_Click(object sender, EventArgs e)
        {
            ma = Int32.Parse(mac.Text);
            na = Int32.Parse(nac.Text);
            matAC.RowCount = ma;
            matAC.ColumnCount = na;
        }

        private void TamañoBC_Click(object sender, EventArgs e)
        {
            mb = Int32.Parse(mbc.Text);
            nb = Int32.Parse(nbc.Text);
            matBC.RowCount = mb;
            matBC.ColumnCount = nb; 
        }


        private void Calcular_Click_1(object sender, EventArgs e)
        {
            Matrices A = new Matrices(ma, na);
            Matrices B = new Matrices(mb, nb);
            Matrices C = new Matrices(ma, na);

            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    A.Elem[i, j] = Convert.ToDouble(matA[j, i].Value);
                }
            }
            if (rse.Checked)
            {
                A.GJ();
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        matA[j, i].Value = A.Elem[i, j];
                    }
                }
            }
            if (transp.Checked)
            {
                matB.RowCount = na;
                matB.ColumnCount = ma;
                A.trans();
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        matB[j, i].Value = A.Elemt[i, j];
                    }
                }
            }
            if (res.Checked)
            {
                matP.RowCount = ma;
                matP.ColumnCount = na;
                A.trans();
                A.res();
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        matP[j, i].Value = A.Elemres[i, j];
                    }
                }
            }
        }
        private void CalcularC_Click(object sender, EventArgs e)
        {
            Matrices A = new Matrices(ma, na);
            Matrices B = new Matrices(mb, nb);
            Matrices C = new Matrices(ma, na);

            string s, aux = "", aux2 = "";
            double r, im;
            int k;
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    s = matAC[j, i].Value.ToString();
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
                    A.Elemc[i, j] = new Complex(r, im);
                    aux = "";
                    aux2 = "";
                }
            }

            if (transpC.Checked)
            {
                matBC.RowCount = na;
                matBC.ColumnCount = ma;
                A.transC();
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        matBC[j, i].Value = A.Elemct[i, j];
                    }
                }
            }
            if (resC.Checked)
            {
                matPC.RowCount = ma;
                matPC.ColumnCount = na;
                A.transC();
                A.resC();
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        matPC[j, i].Value = A.Elemcres[i, j];
                    }
                }
            }
        }

        class Matrices
        {
            private int m, n;
            private double[,] elem;
            private double[,] elemt;
            private double[,] elemres;
            private Complex[,] elemc;
            private Complex[,] elemct;
            private Complex[,] elemcres;

            public int Mm
            {
                set { m = value; }
                get { return m;  }
            }

            public int Nn
            {
                set { n = value; }
                get { return n;  }
            }

            public double[,] Elem 
            {
                set { elem = value; }
                get { return elem;  }
            }

            public double[,] Elemt 
            {
                set { elemt = value; }
                get { return elemt; }
            }

            public double[,] Elemres
            {
                set { elemres = value; }
                get { return elemres; }
            }

            public Complex[,] Elemc
            {
                set { elemc = value; }
                get { return elemc; }
            }

            public Complex[,] Elemct
            {
                set { elemct = value; }
                get { return elemct; }
            }

            public Complex[,] Elemcres
            {
                set { elemcres = value; }
                get { return elemcres; }
            }

            public Matrices(int m, int n) 
            {
                Mm = m;
                Nn = n;
                Elem = new double[m, n];
                Elemt = new double[n, m];
                Elemres = new double[n, m];
                Elemc = new Complex[m, n];
                Elemct = new Complex[n, m];
                Elemcres = new Complex[n, m];
            }

            public void trans() 
            {
                for (int i = 0; i < Mm; i++ ) 
                {
                    for (int j = 0; j < Nn; j++) 
                    {
                        Elemt[j, i] = Elem[i, j];
                    }
                }
            }

            public void transC()
            {
                for (int i = 0; i < Mm; i++)
                {
                    for (int j = 0; j < Nn; j++)
                    {
                        Elemct[j, i] = Elemc[i, j];
                    }
                }
            }

            public void res() 
            {
                for (int i = 0; i < Mm; i++)
                {
                    for (int j = 0; j < Nn; j++)
                    {
                        Elemres[i, j] = Elem[i, j] - Elemt[i, j];
                    }
                }
            }

            public void resC()
            {
                for (int i = 0; i < Mm; i++)
                {
                    for (int j = 0; j < Nn; j++)
                    {
                        Elemcres[i, j] = Elemc[i, j] - Elemct[i, j];
                    }
                }
            }

            public void GJ()
            {
                double piv, cero;
                for (int i = 0; i < Mm; i++)
                {
                    piv = Elem[i, i];
                    for (int j = i; j < Nn; j++)
                    {
                        Elem[i, j] = Elem[i, j] / piv;
                    }
                    for (int k = 0; k <Mm; k++) 
                    {
                        if (k != i) 
                        {
                            cero = Elem[k, i];
                            for (int j = 0; j < Nn; j++) 
                            {
                                Elem[k, j] = Elem[k, j] - cero * Elem[i, j];
                            }
                        }
                    } 
                }
            }
        }


    }
}
