using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMat;

namespace Practica36
{
    public partial class OperacionesMatrices : Form
    {
        int ma, na, mb, nb, mc, nc;
        int i, j;
        double [,]a;
        double [,]b;
        double [,]c;
        public OperacionesMatrices()
        {
            InitializeComponent();
        }

        private void Tamaño_Click(object sender, EventArgs e)
        {
            if(rlA.Checked)
            {
                ma = Int32.Parse(cm.Text);
                na = Int32.Parse(cn.Text); 
                a = new double [ma,na];
            }
            if (rlB.Checked)
            {
                mb = Int32.Parse(cm.Text);
                nb = Int32.Parse(cn.Text);
                b = new double[mb, nb];
            }
        }

        private void Operación_Click(object sender, EventArgs e)
        {
            if(rlA.Checked)
            {
                i = Int32.Parse(ci.Text);
                j = Int32.Parse(cj.Text);
                a[i, j] = double.Parse(elem.Text);
            }
            if (rlB.Checked)
            {
                i = Int32.Parse(ci.Text);
                j = Int32.Parse(cj.Text);
                b[i, j] = double.Parse(elem.Text);
            }
            if(rpA.Checked)
            {
                string aux ="";
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        aux = aux + a[i, j].ToString()+" ";   
                    }
                    LBA.Items.Add(aux);  
                    aux = "";
                }
            }
            if (rpB.Checked)
            {
                string aux = "";
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        aux = aux + b[i, j].ToString() + " ";
                    }
                    LBB.Items.Add(aux);
                    aux = "";
                }
            }
            if (rpC.Checked)
            {
                string aux = "";
                for (int i = 0; i < ma; i++)
                {
                    for (int j = 0; j < na; j++)
                    {
                        aux = aux + c[i, j].ToString() + " ";
                    }
                    LBC.Items.Add(aux);
                    aux = "";
                }
            } 
            if(rSum.Checked)
            {
                mc = ma;
                nc = na;
                c = new double[mc, nc];
                Matrices A = new Matrices(ma, na);
                Matrices B = new Matrices(mb, nb);
                Matrices C = new Matrices(mc, nc);
                A.Datos(ref a);
                B.Datos(ref b);
                C.Datos(ref c);
                C = A + B;
                C.Resultado(ref c); 


                            
            }
        }

    }
}
