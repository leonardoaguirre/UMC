using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class exemplo1
    {
        public void CadastrarNomes(string[] nomes)
        {
            for(int i = 0; i <= 9; i++)
            {
                Console.Write("Qual é o nome da {0} pessoa? ",i+1);
                nomes[i] = Console.ReadLine();
            }
        }
        public void ExibeNomes(string[] nomes)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("O nome da {0} pessoa é: {1}", i + 1, nomes[i]);
            }
        }
    }
}
