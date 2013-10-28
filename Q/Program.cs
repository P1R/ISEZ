using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, l;
            string s = "";
            Console.Write("Introduce m: ");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce n: ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce l: ");
            l = Int32.Parse(Console.ReadLine());
            Cubo A = new Cubo(m, n, l);
            A.lee(s);
            Console.Write("\nResultado= {0}", ~A);
            Console.ReadLine();
        }
    }
    class Cubo {
        private int m, n, l;
        private int[, ,] a;
        public Cubo() {
            m = 3;
            n = 3;
            l = 3;
            a = new int[m, n, l];
        }
        public Cubo(int m) {
            this.m = m;
            n = m;
            l = m;
            a = new int[m, n, l];
        }
        public Cubo(int m, int n, int l) {
            this.m = m;
            this.n = n;
            this.l = l;
            a = new int[m, n, l];
        }
        public void lee() {
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    for (int k = 0; k < l; k++)
                    {
                        Console.Write("a[{0},{1},{2}]= ", i, j, k);
                        a[i, j, k] = Int32.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public void lee(string shit)
        {
            shit = "\nIntroducir Valores\n";
            Console.WriteLine(shit);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        Console.Write("a[{0},{1},{2}]= ", i, j, k);
                        a[i, j, k] = Int32.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public static int operator ~(Cubo A) {
            int q = 0, aux1 = 1, aux2 = 0;
            for (int i = 0; i < A.m; i++)
            {
                for (int j = 0; j < A.n; j++)
                {
                    for (int k = 0; k < A.l; k++)
                    {
                        if (i != j || i != k)
                            aux2 = aux2 + A.a[i, j, k];
                    }
                    aux1 = aux1 * aux2;
                    aux2 = 0;
                }
                q += aux1;
                aux1 = 1;
            }
            return q;
        }
    }
}
