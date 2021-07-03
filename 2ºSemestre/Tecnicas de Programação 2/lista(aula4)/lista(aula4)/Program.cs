using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1
            /*double n1, n2, n3, media;
            char letra;
            do
            {
                Console.Write("Qual é a primeira nota? ");
                n1 = double.Parse(Console.ReadLine());
                if (n1 < 0 || n1 > 10)
                {
                    Console.Write("Nota inválida! ");
                }
            } while (n1 < 0 || n1 > 10);
            do
            {
                Console.Write("Qual é a segunda nota? ");
                n2 = double.Parse(Console.ReadLine());
                if (n2 < 0 || n2 > 10)
                {
                    Console.Write("Nota inválida! ");
                }
            } while (n2 < 0 || n2 > 10);
            do
            {
                Console.Write("Qual é a terceira nota? ");
                n3 = double.Parse(Console.ReadLine());
                if (n3 < 0 || n3 > 10)
                {
                    Console.Write("Nota inválida! ");
                }
            } while (n3 < 0 || n3 > 10);
            do
            {
                Console.Write("Qual o tipo de calculo que deseja? (A/P) ");
                letra = char.Parse(Console.ReadLine());
                if (letra != 'A' && letra != 'a' && letra != 'P' && letra != 'p')
                {
                    Console.Write("Opção inválida! ");
                }
            } while (letra != 'A' && letra != 'a' && letra != 'P' && letra != 'p');
            calcular(n1, n2, n3, letra, out media);
            Console.Write("A sua média final é: {0}",media);
            Console.ReadKey();*/

            //exercicio2
            /*double taxaEuro, taxaDolar;
             do
             {
                 Console.Write("Qual é o valor do euro? ");
                 taxaEuro = double.Parse(Console.ReadLine());
                 if (taxaEuro < 0)
                 {
                     Console.Write("Valor incorreto! ");
                 }
             } while (taxaEuro < 0);
             do
             {
                 Console.Write("Qual é o valor do dolar? ");
                 taxaDolar = double.Parse(Console.ReadLine());
                 if (taxaDolar < 0)
                 {
                     Console.Write("Valor incorreto! ");
                 }
             } while (taxaDolar < 0);
            menu(ref taxaDolar, ref taxaEuro);*/

            //exercicio3
            int num,tent=1;
            Console.Write("Digite um numero entre 1 e 10: ");
            num = int.Parse(Console.ReadLine());
            verifica(ref num);
            confere(ref num, ref tent);
            Console.Write("Parabéns, você acertou, o numero correto era {0} e você acertou em {1} tentativas!",num,tent);
            Console.ReadKey();


        }
        static void menu(ref double taxaDolar , ref double taxaEuro)
        {
            int cod;
            double result, valor;
            do
            {
                Console.Write("\n----------------Menu-----------------");
                Console.Write("\n1 – Converter de real para dólar\n2 – Converter de real para euro\n3 – Converter de dólar para real\n4 – Converter de euro para real\n5 – Alterar taxas de conversão\n6 – Sair");
                Console.Write("\nDigite a opção desejada: ");
                cod = int.Parse(Console.ReadLine());
                while (cod < 1 || cod > 6)
                {
                    Console.Write("Opção incorreta! Digite uma opção valida: ");
                    cod = int.Parse(Console.ReadLine());
                }
                switch (cod)
                {
                    case 1:
                        menorMaior(out valor, ref taxaDolar, out result);
                        Console.Write("o Valor de R${0} convertido em dólar é: US${1} ", valor, result);
                        Console.ReadKey();
                        break;
                    case 2:
                        menorMaior(out valor, ref taxaEuro, out result);
                        Console.Write("o Valor de R${0} convertido em euro é: EUR${1} ", valor, result);
                        Console.ReadKey();
                        break;
                    case 3:
                        maiorMenor(out valor, ref taxaDolar, out result);
                        Console.Write("o Valor de US${0} convertido em real é: R${1} ", valor, result);
                        Console.ReadKey();
                        break;
                    case 4:
                        maiorMenor(out valor, ref taxaDolar, out result);
                        Console.Write("o Valor de EUR${0} convertido em real é: R${1} ", valor, result);
                        Console.ReadKey();
                        break;
                    case 5:
                        alterarTaxas(ref taxaDolar, ref taxaEuro);
                        Console.Write("Taxas alteradas com sucesso! \nNova taxa do dolar é US${0} e a do euro é EUR${1}", taxaDolar, taxaEuro);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("Você saiu do programa!");
                        Console.ReadKey();
                        break;
                }
            } while (cod != 6);
        }
        static void menorMaior(out double n1, ref double taxa, out double result)
        {
            do
            {
                Console.Write("Qual é o valor a ser convertido? ");
                n1 = double.Parse(Console.ReadLine());
                if (n1 < 0)
                {
                    Console.Write("Valor inválido! ");
                }
            } while (n1 < 0);
            result = n1 / taxa;
        }
        static void maiorMenor(out double n1, ref double taxa, out double result)
        {
            do {
                Console.Write("Qual é o valor a ser convertido? ");
                n1 = double.Parse(Console.ReadLine());
                if (n1 < 0)
                {
                    Console.Write("Valor inválido! ");
                }
            } while (n1 < 0);
            result = n1 * taxa;
        }
        static void alterarTaxas(ref double taxa1, ref double taxa2)
        {
            do
            {
                Console.Write("Qual é a nova taxa do dolar? ");
                taxa1 = double.Parse(Console.ReadLine());
                if (taxa1 < 0)
                {
                    Console.Write("Valor inválido! ");
                }
            } while (taxa1 < 0);
            do
            {
                Console.Write("Qual é a nova taxa do euro? ");
                taxa2 = double.Parse(Console.ReadLine());
                if (taxa2 < 0)
                {
                    Console.Write("Valor inválido! ");
                }
            } while (taxa2 < 0);
        }
        static void calcular(double n1, double n2, double n3, char l, out double m)
        {
            if(l=='a'|| l == 'A')
            {
                m = (n1 + n2 + n3) / 3;
            }
            else
            {
                m = (n1 * 5 + n2 * 3 + n3 * 2) / 10;
            }
        }
        static void verifica(ref int m)
        {
            while(m < 1 || m > 10)
            {
                Console.Write("\nNumero incorreto, digite um numero válido entre 1 e 10: ");
                m = int.Parse(Console.ReadLine());
            }
        }
        static void confere(ref int n1, ref int tent)
        {
            int n2;
                Console.Write("\nDigite um numero entre 1 e 10, para tentar acertar o numero digitado pelo outro usuário: ");
                n2 = int.Parse(Console.ReadLine());
            verifica(ref n2);

            while (n2 != n1)
            {
                if (n2 > n1)
                {
                    Console.Write("\nO numero é maior do que o numero escolhido pelo outro usuário!");
                }
                else
                {
                    Console.Write("\nO numero é menor do que o numero escolhido pelo outro usuário!");
                }
                tent++;
                Console.Write("\nDigite um numero entre 1 e 10, para tentar acertar o numero digitado pelo outro usuário: ");
                n2 = int.Parse(Console.ReadLine());
                verifica(ref n2);
            }
            
        }
    }
}
