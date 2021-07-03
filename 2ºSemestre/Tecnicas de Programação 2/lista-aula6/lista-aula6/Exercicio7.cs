using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class Exercicio7
    {
        public void Entrada(int[] n)
        {
            for(int i = 0; i <= 14; i++)
            {
                Console.Clear();
                Console.Write("\nQual é o {0}ºnumero? ",i+1);
                n[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Calculo(int[]n,out int v)
        {
            v = 0;
            for(int i = 0; i <= 14; i++)
            {
                if (n[i] == 0)
                {
                    v++;
                }
            }
        }
    }
}
