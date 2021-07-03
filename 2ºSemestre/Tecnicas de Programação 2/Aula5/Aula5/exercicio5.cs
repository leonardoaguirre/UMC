using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class exercicio5
    {
        public void entrada(ref int[] a)
        {
            for (int i = 0; i <= 19; i++)
            {
                Console.Write("Escreva o {0} numero: ",i+1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void verifica(int[]a,ref int n)
        {
            for(int i=0; i <= 19; i++)
            {
                if (a[i] == 5)
                {
                    n = n + 1;
                }
            }
        }
    }
}
