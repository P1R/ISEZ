using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nu, k;
            Console.Write("ingresa el numero de n:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                Nu = 1;
                for (k =(N-i); k > 0; k--)
                    Console.Write(" "); 
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Nu+" ");
                    Nu = (Nu*(i-j)/(j+1));
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
