using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Exercicio2
    {
        public void exercicio2()
        {
            int num=1, contNum = 0;
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                contNum++;
                Console.Write("Digite outro numero: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write("A quantidade de numeros positivos digitados foi de: {0}",contNum);
            Console.ReadKey();
        }
    }
}
