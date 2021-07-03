using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 3
            /*int[] idade = new int[10];
            Console.WriteLine("Calculo da media de idade de 10 alunos");
            Console.WriteLine("Entrada dos dados");
            Entrada(idade);
            Console.WriteLine("A média é de: {0}", media(idade));
            Console.ReadKey();*/

            //exercicio 4
            /*int n=0;
            exercicio3 ex3 = new exercicio3();
            ex3.entrada(ref n);
            int[] idades = new int[n];
            ex3.calcula(idades, n);*/

            //exercicio 5
            /*int[] nums = new int[20];
            int n2 = 0;
            exercicio5 ex5 = new exercicio5();
            ex5.entrada(ref nums);
            ex5.verifica(nums, ref n2);
            Console.Write("Foi digitado o numero cinco {0} vezes confira: ", n2);
            for (int i = 0; i <= 19; i++)
            {
                Console.Write("\n{0} numero foi: {1}",i+1,nums[i]);
            }
            Console.ReadKey();*/

            //exercicio 6
            /*double[] pesos = new double[5];
            double[] alturas = new double[5];
            exercicio6 ex6 = new exercicio6();
            ex6.entrada(pesos, alturas);
            ex6.calcula(pesos, alturas);*/

            //exercicio 7 
            double Nfun;
            Console.Write("Quantos funcionarios você possui? ");
            Nfun = int.Parse(Console.ReadLine());
            exercicio7 ex7 = new exercicio7();
            ex7.verifica(ref Nfun, 100);
            string[] nomes = new string[(int)Nfun];
            double[] salarios = new double[(int)Nfun];
            ex7.entrada(nomes, salarios, (int)Nfun);
            ex7.calcula(nomes, salarios, (int)Nfun);
        }
        static void Entrada(int[]A)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite A[{0}]: ", i+1);
                A[i] = int.Parse(Console.ReadLine());
                valida(ref A[i]);
            }
        }
        static void valida(ref int x)
        {
            while(x < 1 || x > 120)
            {
                Console.Write("Valor inválido, digite novamente: ");
                x = int.Parse(Console.ReadLine());
            }
        }
        static double media(int[]B)
        {
            int i, s=0;
            double m;
            for (i = 0; i < 10; i++)
            {
                s = s +B[i];
            }
            m = (double)s / 10;
            return m;
        }

    }
}
