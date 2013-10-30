using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMat
{
    public class Matrices
    {
        private int m, n;
        private double[,]elem;

        public Matrices(int m, int n) 
        {
            this.m = m;
            this.n = n;
            elem = new double[m,n];
        }

        public void Datos(ref double[,]x) 
        {
            elem=x;
        }

        public static Matrices operator + (Matrices A, Matrices B)
        {
           Matrices C = new Matrices(A.m, A.n); 
           for(int i=0; i<A.m; i++)
           {
               for (int j = 0; j < A.n; j++) 
               {
                   C.elem[i, j] = A.elem[i, j] + B.elem[i, j];   
               }
           }
           return (C); 
        }

        public void Resultado(ref double[,] Y) 
        {
            Y = elem;
        }
    }
}
