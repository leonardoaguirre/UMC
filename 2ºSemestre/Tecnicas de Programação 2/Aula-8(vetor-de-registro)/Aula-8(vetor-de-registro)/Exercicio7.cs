using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio7
    {
        public struct dados
        {
            public string nome;
            public char sexo;
            public int idade;
            public double altura;
        }
        public void principal()
        {
            Console.Write("Quantas pessoas voce deseaja registrar? ");
            int num = int.Parse(Console.ReadLine());
            valida(ref num, 100);
            dados[] pessoas = new dados[num];
            entrada(num, pessoas);
            maisAlto(num,pessoas);
            maisNovo(num,pessoas);
            mediaBaixos(num,pessoas);
            mulheres(num,pessoas);
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
                Console.Write("Digite a altura da {0} pessoa: ", i + 1);
                p[i].altura = double.Parse(Console.ReadLine());
                validaAltura(ref p[i].altura, 2.50);
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
        static void validaAltura(ref double n, double max)
        {
            while (n < 0 || n > max)
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
        static void maisAlto(int n,dados[]p)
        {
            int mais = 0;
            double alt=0;
            for(int i = 0; i < n; i++)
            {
                if(p[i].altura > alt)
                {
                    mais = i;
                }
            }
            Console.WriteLine("O mais alto de todos é: \nNome: {0}, Sexo: {1}, Idade: {2}, Altura: {3}m", p[mais].nome, p[mais].sexo, p[mais].idade, p[mais].altura);
            Console.ReadKey();
        }
        static void maisNovo(int n,dados[]p)
        {
            int mais=0;
            int idade = 1500;
            for (int i = 0; i < n; i++)
            {
                if (p[i].idade < idade)
                {
                    idade = p[i].idade;
                    mais = i;
                }
            }
            Console.WriteLine("O mais novo de todos é: \nNome: {0}, Sexo: {1}, Idade: {2}, Altura: {3}m", p[mais].nome, p[mais].sexo, p[mais].idade, p[mais].altura);
            Console.ReadKey();
        }
        static void mediaBaixos(int n,dados[]p)
        {
            double media=0;
            for (int i = 0; i < n; i++)
            {
                if (p[i].altura <= 1.58)
                {
                    media = media+p[i].altura;
                }
            }
            media = media / n;
            Console.WriteLine("O media de altura dos mais baixos é: {0}m",media);
            Console.ReadKey();
        }
        static void mulheres(int n,dados[]p)
        {
            int cont=0;
            Console.Write("Mulheres que tem idade igual ou superior a 20 anos: ");
            for (int i = 0; i < n; i++)
            {
                if ((p[i].idade >= 20) && (p[i].sexo =='f' || p[i].sexo=='F'))
                {
                    Console.Write("\nNome: {0}, Sexo: {1}, Idade: {2}, Altura: {3}m", p[i].nome, p[i].sexo, p[i].idade, p[i].altura);
                    cont++;
                }
            }
            Console.WriteLine("Totalizando {0} mulheres nessa categoria",cont);
            Console.ReadKey();
        }
    }
}
