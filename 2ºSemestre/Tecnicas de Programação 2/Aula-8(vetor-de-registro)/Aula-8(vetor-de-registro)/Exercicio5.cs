using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio5
    {
        public struct dados
        {
            public string nome;
            public char sexo;
            public int idade;
            public string rg;
        }
        public void principal()
        {
            int num;
            Console.Write("Quantas pessoas voce deseaja registrar? ");
            num = int.Parse(Console.ReadLine());
            valida(ref num,20);
            dados[] pessoas = new dados[num];
            entrada(num,pessoas);
            relatorio(num, pessoas);
            Console.ReadKey();
        }
        static void entrada(int n,dados[]p)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write("Digite o nome da {0} pessoa: ",i+1);
                p[i].nome = Console.ReadLine();
                Console.Write("Digite o rg da {0} pessoa: ", i + 1);
                p[i].rg = Console.ReadLine();
                Console.Write("Digite o sexo da {0} pessoa: ", i + 1);
                p[i].sexo = char.Parse(Console.ReadLine());
                validaSexo(ref p[i].sexo);
                Console.Write("Digite a idade da {0} pessoa: ", i + 1);
                p[i].idade = int.Parse(Console.ReadLine());
                valida(ref p[i].idade, 120);
            }
        }
        static void valida(ref int n,int max)
        {
            while(n<1 || n > max)
            {
                Console.Write("\nNumero incorreto! Digite novamente: ");
                n = int.Parse(Console.ReadLine());
            }
        }
        static void validaSexo(ref char s)
        {
            while(s!='F' && s!='f' && s!='m' && s!='M')
            {
                Console.Write("Sexo incorreto! Digite novamente(M/F): ");
                s = char.Parse(Console.ReadLine());
            }
        }
        static void relatorio(int n,dados[]p)
        {
            Console.Clear();
            Console.Write("Realatorio com pessoas do sexo feminino com mais de 30 anos.");
            for (int i = 0; i < n; i++)
            {
                if ((p[i].sexo == 'f' || p[i].sexo == 'F') && p[i].idade > 30)
                {
                    Console.Write("\nNome: {0}  RG: {3} Idade: {1}  Sexo: {2} ",p[i].nome,p[i].idade,p[i].sexo, p[i].rg);
                }
            }
        }
    }
}
