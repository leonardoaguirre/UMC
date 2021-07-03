using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class Exercicio9
    {
        public void entrada(int[] vet,int n)
        {
            Console.Clear();
            Console.Write("\nDigite 6 numeros inteiros para o {0}ºvetor!",n);
            for (int i=0; i < 6; i++)
            {
                Console.Write("\n {0}ºNumero: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());
            }
        }
        public void calculo(int[] v1, int[] v2, int[] v3)
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                v3[i] = v1[i] + v2[i];
            }
        }
        public void exibir(int[] v,int n)
        {
            Console.Write("\n{0}ºvetor:", n);
            for (int i = 0; i < 6; i++)
            {
                Console.Write(" |{0}|", v[i]);
            }
        }
    }
}
