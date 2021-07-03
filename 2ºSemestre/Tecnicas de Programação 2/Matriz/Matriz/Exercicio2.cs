using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Exercicio2
    {
        public void principal()
        {
            Console.Write("Qual será o numero de linhas da sua matriz? ");
            int linha = int.Parse(Console.ReadLine());
            valida(linha, 1000);

            Console.Write("Qual será o numero de colunas da sua matriz? ");
            int coluna = int.Parse(Console.ReadLine());
            valida(coluna, 1000);

            int[,] matriz = new int[linha, coluna];

            entrada(matriz, linha, coluna);
            saida(matriz, linha, coluna);
            Console.ReadKey();
        }
        static void valida(int n, int max)
        {
            while(n<0 && n > max)
            {
                Console.Write("Numero incorreto! Por favor digite novamente!");
                n = int.Parse(Console.ReadLine());
            }
        }
        static void entrada(int[,]x,int linha, int coluna)
        {
            for(int l = 0; l < linha; l++)
            {
                for(int c = 0; c < coluna; c++)
                {
                    Console.Write("Matriz[{0},{1}]= ",l+1,c+1);
                    x[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
        }
        static void saida(int[,]x ,int linha,int coluna)
        {
            int soma = 0;
            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write(x[l,c]+" ");
                    soma = x[l, c] + soma;
                }
                Console.WriteLine();
            }
            Console.Write("A soma total da matriz é: {0}", soma);
        }
    }
}
