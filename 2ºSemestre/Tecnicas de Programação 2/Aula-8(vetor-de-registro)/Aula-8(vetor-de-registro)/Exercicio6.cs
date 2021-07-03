using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio6
    {
        public struct dados
        {
            public string nome;
            public char sexo;
            public int idade;
        }
        public void principal()
        {
            Console.Write("Quantas pessoas voce deseaja registrar? ");
            int num = int.Parse(Console.ReadLine());
            valida(ref num, 20);
            dados[] pessoas = new dados[num];
            entrada(num,pessoas);
            realatorio1(num, pessoas);
            relatorio2(num, pessoas);
            relatorio3(num, pessoas);
        }
        static void entrada(int n, dados[] p)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write("Digite o nome da {0} pessoa: ", i + 1);
                p[i].nome = Console.ReadLine();
                Console.Write("Digite o sexo da {0} pessoa: ", i + 1);
                p[i].sexo = char.Parse(Console.ReadLine());
                validaSexo(ref p[i].sexo);
                Console.Write("Digite a idade da {0} pessoa: ", i + 1);
                p[i].idade = int.Parse(Console.ReadLine());
                valida(ref p[i].idade, 120);
            }
        }
        static void valida(ref int n, int max)
        {
            while (n < 1 || n > max)
            {
                Console.Write("\nValor incorreto! Digite novamente: ");
                n = int.Parse(Console.ReadLine());
            }
        }
        static void validaSexo(ref char s)
        {
            while (s != 'F' && s != 'f' && s != 'm' && s != 'M')
            {
                Console.Write("Sexo incorreto! Digite novamente(M/F): ");
                s = char.Parse(Console.ReadLine());
            }
        }
        static void realatorio1(int n,dados[]p)
        {
            Console.WriteLine("\nRelatorio de pessoas que a idade é maior que da primeira pessoa.");
            for(int i = 1; i < n; i++)
            {
                if (p[i].idade > p[0].idade)
                {
                    Console.Write("\nNome: {0}   Sexo: {1}    Idade: {2}", p[i].nome, p[i].sexo, p[i].idade);
                }
            }
            Console.ReadKey();
        }
        static void relatorio2(int n, dados[] p)
        {
            Console.WriteLine("\nRelatorio de pessoas do sexo feminino");
            for (int i = 0; i < n; i++)
            {
                if (p[i].sexo == 'f' || p[i].sexo =='F')
                {
                    Console.Write("\nNome: {0}   Sexo: {1}    Idade: {2}", p[i].nome, p[i].sexo, p[i].idade);
                }
            }
            Console.ReadKey();
        }
        static void relatorio3(int n, dados[] p)
        {
            Console.WriteLine("\nRelatorio de pessoas do sexo masculino com menos de 21 anos");
            for (int i = 0; i < n; i++)
            {
                if ((p[i].sexo == 'm' || p[i].sexo == 'M') && p[i].idade < 21)
                {
                    Console.Write("\nNome: {0}   Sexo: {1}    Idade: {2}", p[i].nome, p[i].sexo, p[i].idade);
                }
            }
            Console.ReadKey();
        }
    }
}
