using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{

    class Exemplo
    {
        public void principal()
        {
            int[,] num = new int[3, 2];
            Console.WriteLine("Lê e exibe uma matriz de 3 linhas e 2 colunas");
            Console.WriteLine("Entrada por linha");
            entrada(num);
            Console.WriteLine("Entrada por coluna");
            entrada2(num);
            Console.Clear();
            saida(num);
            Console.ReadKey();
        }
        static void entrada(int[,] x)
        {
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("A[{0},{1}]= ", l + 1, c + 1);
                    x[l, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void entrada2(int[,] a)
        {
            for (int c = 0; c < 2; c++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write("A[{0},{1}]= ", l + 1, c + 1);
                    a[l, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void saida(int[,] a)
        {
            for (int c = 0; c < 2; c++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(a[l, c] + " ");
                }
                Console.WriteLine();
            }
        }
}
}
