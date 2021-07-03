using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Exercicio1
    {
        public void principal()
        {
            int[,] num = new int[3, 2];
            Console.WriteLine("Lê e exibe uma matriz de 3 linhas e 2 colunas");
            Console.WriteLine("Entrada por linha");
            entrada(num);
            Console.Clear();
            saida(num);
            Console.ReadKey();
        }
        static void entrada(int[,] x)
        {
            for (int l = 0; l < 2; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("A[{0},{1}]= ", l + 1, c + 1);
                    x[l, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void saida(int[,] a)
        {
            for (int l = 0; l < 2; l++)
            {
                for (int c = 0; c < 4; l++)
                {
                    Console.Write(a[l, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
