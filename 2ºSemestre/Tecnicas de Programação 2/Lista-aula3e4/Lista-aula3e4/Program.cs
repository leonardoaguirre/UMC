using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_aula3e4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1
            /*Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            while (n1 < 0)
            {
                Console.Write("Numero invalido!");
                Console.Write("Digite o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            while (n2 < 0)
            {
                Console.Write("Numero invalido!");
                Console.Write("Digite o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o terceiro numero: ");
            int n3 = int.Parse(Console.ReadLine());
            while (n3 < 0)
            {
                Console.Write("Numero invalido!");
                Console.Write("Digite o terceiro numero: ");
                n3 = int.Parse(Console.ReadLine());
            }
            int num1 = calc(n1);
            int num2 = calc(n2);
            int num3 = calc(n3);
            Console.Write("O dobro de {0} é {1}, o dobro de {2} é {3} e o dobro de {4} é {5}", n1, num1, n2, num2, n3, num3);
            Console.ReadKey();*/

            //Exercicio2
            /*int bas, exp;
            double resul;
            do
            {
                Console.Write("Qual o valor da base? ");
                bas = int.Parse(Console.ReadLine());
                if (bas < 0)
                {
                    Console.WriteLine("Numero Incorreto!");
                }
            } while (bas < 0);
            do {
                Console.Write("Qual o valor do expoente? ");
                exp = int.Parse(Console.ReadLine());
                if (exp < 0)
                {
                    Console.WriteLine("Numero Incorreto!");
                }
            } while (exp < 0);
            
            calc2(bas, exp, out resul);
            Console.Write("O resultado da potência é: {0}",resul);
            Console.ReadKey();*/

            //exercicio3
            /*int n1, n2, n3, maiorde2,maior;
            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            n3 = int.Parse(Console.ReadLine());
            maiordedois(n1, n2, out maiorde2);
            maiordetres(maiorde2, n3, out maior);
            Console.Write("O maior numero digitado foi: {0}", maior);
            Console.ReadKey();*/

            //exercicio4
            /*double alt,peso;
            char sexo;
            do {
                Console.Write("Digite a sua altura: ");
                alt = double.Parse(Console.ReadLine());
                if (alt < 0.5 || alt > 3)
                {
                    Console.Write("Altura incorreta! ");
                }
            } while(alt<0.5 || alt>3);
            do {
                Console.Write("Digite o seu sexo(F/M): ");
                sexo = char.Parse(Console.ReadLine());
                if (sexo != 'F' && sexo != 'f' && sexo != 'M' && sexo != 'm')
                {
                    Console.Write("Sexo incorreto!");
                }
            } while (sexo != 'F' && sexo != 'f' && sexo != 'M' && sexo != 'm');
            peso = calculaPeso(alt, sexo);
            Console.Write("O seu peso ideal é: {0}", peso);
            Console.ReadKey();*/

            //exercicio5
            /*int result;
            char resp;
            do
            { 
                pot(out result);
                Console.Write("O resultado da potencia é: {0}",result);
                continuar(out resp);
            } while (resp == 's' || resp == 'S');*/

            //exercicio6
            char resp = 's';
            int fatorial;
            while (resp=='s'|| resp == 'S')
            {
                fatorial = fat();
                Console.Write("O resultado fatorial é: {0}",fatorial);
                resp = continuar2();
            }
            
        }
        static int calc(int n)
        {
            n = n * 2;
            return n;
        }
        static void calc2(int bas ,int  exp, out double result)
        {
            result = Math.Pow(bas,exp);
        }
        static void maiordedois(int n1, int n2, out int maior)
        {
            if (n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
        }
        static void maiordetres(int n1, int n2, out int maior)
        {
            if (n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
        }
        static double calculaPeso(double alt,double sexo)
        {
            double peso;
            if(sexo == 'M' || sexo == 'm')
            {
                peso = 72.7 * alt - 58;
            }
            else
            {
                peso = 62.1 * alt - 44.7;
            }
            return peso;
        }
        static void pot(out int result)
        {
            int bas, exp,potencia=1;
            do
            {
                Console.Write("Qual o valor da base? ");
                bas = int.Parse(Console.ReadLine());
                if (bas < 0)
                {
                    Console.Write("Numero Incorreto!");
                }
            } while (bas < 0);
            do
            {
                Console.Write("Qual o valor do expoente? ");
                exp = int.Parse(Console.ReadLine());
                if (exp < 0)
                {
                    Console.Write("Numero Incorreto!");
                }
            } while (exp < 0);
            for(int i = 1; i <= exp; i++)
            {
                potencia = potencia * bas;
            }

            result = potencia;
        }
        static void continuar(out char resp)
        {
            do
            {
                Console.Write("\nDeseja continuar? (S/N)");
                resp = char.Parse(Console.ReadLine());
                if (resp != 'N' && resp != 'n' && resp != 's' && resp != 'S')
                {
                    Console.Write("Resposta incorreta! ");
                }
            } while (resp != 'N' && resp != 'n' && resp != 's' && resp != 'S');
        }
        static int fat()
        {
            int fatorial = 1,num;
            Console.Write("Qual o numero que você deseja calcular o fatorial? ");
            num = int.Parse(Console.ReadLine());
            for(int cont=1; cont <= num; cont++)
            {
                fatorial = fatorial * cont;
            }
            return fatorial;
        }
        static char continuar2()
        {
            char resp;
            do
            {
                Console.Write("\nDeseja continuar? (S/N)");
                resp = char.Parse(Console.ReadLine());
                if (resp != 'N' && resp != 'n' && resp != 's' && resp != 'S')
                {
                    Console.Write("Resposta incorreta! ");
                }
            } while (resp != 'N' && resp != 'n' && resp != 's' && resp != 'S');
            return resp;
        }
    }
}
