using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_da_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos caracteres tem o seu nome?");
            int num_caracter = int.Parse(Console.ReadLine());
            char[] Letras = new char[20];
            char[,] mat_letras = new char[20, 20];
            Entrada(Letras, num_caracter);
            Gerador(mat_letras, Letras, num_caracter);
            Saida(mat_letras, num_caracter);
            Console.ReadKey();
        }
        static void Entrada(char []vet, int n)
        {
            
            Console.Write("Digite seu nome letra por letra:\n");
            
            for (int i = 0; i < n; i++)
            {
                 vet[i] = char.Parse(Console.ReadLine());
            }
            
        }
        static void Gerador(char[,] matriz,char[]vet,  int n)
        {
            Console.Clear();
            Console.Write("Resultado:\n");
            for (int j=0; j<n; j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = 0; i< n; i++)
                    {
                        matriz[i, j] = vet[i];
                    
                    }
                }
                else
                {
                    for (int i=0; i< n; i++)
                    {
                        matriz[i, j] = '*';
                    }
                }
            }
        }
        static void Saida(char[,] mat, int n)
        {
            for (int i = 0; i< n; i++)
            {
                for (int j=0; j < n; j++)
                {
                    Console.Write("{0}  ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
