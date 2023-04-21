using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao_6_9_10_11
{
    internal class Matriz
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {

                String[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {

                    matriz[i, j] = int.Parse(values[j]);

                }
            }

            Console.WriteLine("Diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");

            }

            int cont = 0;
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){

                    if (matriz[i,j] < 0)
                    {
                        cont++;
                    }

                }
            }

            Console.WriteLine("Negative Numbers: " + cont);
        }
    }
}
