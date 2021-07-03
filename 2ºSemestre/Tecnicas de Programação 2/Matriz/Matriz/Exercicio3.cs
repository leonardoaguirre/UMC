using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Exercicio3
    {
        public void principal()
        {
            Console.Write("Qual será o numero de linhas da sua matriz? ");
            int linha = int.Parse(Console.ReadLine());
            valida(linha, 1000);

            Console.Write("Qual será o numero de colunas da sua matriz? ");
            int coluna = int.Parse(Console.ReadLine());
            valida(coluna, 1000);

            Console.Write("Qual será o valor do multiplicador da sua matriz B? ");
            int k = int.Parse(Console.ReadLine());
            valida(k, 10000);

            int[,] matriz = new int[linha, coluna];

            entrada(matriz, linha, coluna);
            saida(matriz, linha, coluna,k);
            Console.ReadKey();
        }
        static void valida(int n, int max)
        {
            while (n < 0 && n > max)
            {
                Console.Write("Numero incorreto! Por favor digite novamente!");
                n = int.Parse(Console.ReadLine());
            }
        }
        static void entrada(int[,] x, int linha, int coluna)
        {
            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write("Matriz[{0},{1}]= ", l + 1, c + 1);
                    x[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
        }
        static void saida(int[,] x, int linha, int coluna,int k)
        {
            Console.WriteLine("Matriz A:");
            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write(x[l, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz B = Matriz A * k");
            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write(x[l, c]*k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
