using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Exemplo2
    {
        public void CadastraNomes(ref string[]nomes)
        {
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("\nQual é o nome da {0} pessoa? ", i + 1);
                nomes[i] = Console.ReadLine();
            }
            Console.Write("\nNomes cadastrados com sucesso!");
            Console.ReadKey();
        }
        public void CadastraEmail(string[] email)
        {
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("\nQual é o email da {0} pessoa? ", i + 1);
                email[i] = Console.ReadLine();
            }
            Console.Write("\nEmails cadastrados com sucesso!");
            Console.ReadKey();
        }
        public void ExibeNomes(string[] nomes)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("\nO nome da {0} pessoa é: {1}", i + 1, nomes[i]);
            }
            Console.ReadKey();
        }
        public void ConsultaEmail(string[]nomes,string[]email)
        {
            int cont = 0;
            string x;
            Console.Write("Qual é o nome que deseja consultar? ");
            x = Console.ReadLine();
            for (int i = 0; i <= 9; i++)
            {
                if (x == nomes[i])
                {
                    Console.Write("\nO email de {0} é: {1}", nomes[i], email[i]);
                }
                else
                {
                    cont++;
                }
            }
            if(cont == 10)
            {
                Console.Write("\nEste nome não está cadastrado!");
            }
            Console.ReadKey();
        }
    }
}
