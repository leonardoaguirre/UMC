using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class exercicio7
    {
        public void verifica(ref double n, double max)
        {
            while(n<0 || n > max)
            {
                Console.Write("\nNumero inválido! Digite novamente: ");
                n = double.Parse(Console.ReadLine());
            }
        }
        public void entrada(string[] a, double[] b, int nf)
        {
            for(int i=1; i <= nf; i++)
            {
                Console.Write("Qual o nome do seu {0} funcionario? ",i);
                a[i - 1] = Console.ReadLine();
                Console.Write("Qual é o salário do seu {0} funcionario? ", i);
                b[i - 1] = double.Parse(Console.ReadLine());
                verifica(ref b[i], 15000);
            }
        }
        public void calcula(string[] a, double[] b, int nf)
        {
            string nmaior=a[0], nmenor=a[0];
            double smaior=b[0], smenor=b[0],folha=0,media;
            for (int i = 0; i <= nf; i++)
            {
                folha = b[i] + folha;
                if (b[i] > smaior)
                {
                    smaior = b[i];
                    nmaior = a[i];
                }else if (b[i] < smenor)
                {
                    smenor = b[i];
                    nmenor = a[i];
                }
            }
            media = folha / nf;
            Console.Write("A folha salarial é de R${0};\nA media salarial é de R${1};\nO {2} é o funcionario que possui o menor salario de R${3};\nO {4} é o funcionario com o maior salario de R${5}", folha, media, nmenor, smenor, nmaior, smaior);
            Console.ReadKey();
        }
    }
}
