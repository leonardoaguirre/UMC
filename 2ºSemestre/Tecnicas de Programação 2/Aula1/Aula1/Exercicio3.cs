using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Exercicio3
    {
        int n, total_folha, cont2500, cont1300, salario,media_salario,percentual;
        public void exercicio3()
        {
            
            Console.Write("Quantos funcionarios você possui? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Write("Qual é o salario do {0} funcionario? ", i);
                salario = int.Parse(Console.ReadLine());
                if (salario > 2500)
                {
                    cont2500++;
                }
                if(salario<1300)
                {
                    cont1300++;
                }
                total_folha = total_folha + salario;
            }
            media_salario = total_folha / n;
            percentual = cont1300 / n * 100;

            Console.Write("O total da folha de pagamento é R${0}, a quantidade de pessoas que recebem mais de R$2500 é {1}\nA media salarial é R${2} e o percentual de quem recebe menos de R$1300 é {3}%", total_folha, cont2500, media_salario, percentual;
            Console.ReadKey();
        }
    }
}
