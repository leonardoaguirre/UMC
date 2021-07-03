using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Exercicio1
    {
        public void exercicio1()
        {
            int num, fat = 1;
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
            while (num < 0)
            {
                if (num < 0)
                {
                    Console.Write("Numero incorreto! Digite um numero maior que zero");
                }
                Console.Write("\nDigite um numero positivo: ");
                num = int.Parse(Console.ReadLine());
            }
            for (int k = 1; k <= num; k++)
            {
                fat = fat * k;
            }
            Console.Write("O fatorial de {1} é: {0}", fat, num);
            Console.ReadKey();
        }
    }
}
