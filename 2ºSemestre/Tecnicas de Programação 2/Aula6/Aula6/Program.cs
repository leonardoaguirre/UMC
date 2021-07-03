using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo 1

            /*bool resp = false;
             int op;
             do
             {
                 Console.Clear();
                 Console.Write("1 – Cadastra o nome de 10 amigos\n2 - Exibe os nomes cadastrados\n3 – Sair");
                 Console.Write("\nQual operação deseja fazer?");
                 op = int.Parse(Console.ReadLine());
                 while (op < 1 || op > 3)
                 {
                     Console.Write("\nOperação incorreta! Qual operação deseja fazer?");
                     op = int.Parse(Console.ReadLine());
                 }
                 exemplo1 ex1 = new exemplo1();
                 string[] ns = new string[10];
                 switch (op)
                 {

                     case 1: ex1.CadastrarNomes(ns); break;
                     case 2: ex1.ExibeNomes(ns); break;
                     case 3: resp = true; break;
                 }
             } while (resp == false);*/

            //exemplo 2

            string[] ns = new string[10];
            string[] em = new string[10];
            bool resp = false;
            do
            {
                
                int op;
                Console.Clear();
                Console.Write("1 – Cadastra o nome\n2 – Cadastra o e - mail\n3 - Exibe os nomes e e - mail\n4 – Consultar e - mail por nome\n5 – Sair");
                Console.Write("\nQual operação deseja fazer? ");
                op = int.Parse(Console.ReadLine());
                while (op < 1 || op > 5)
                {
                    Console.Write("\nOperação incorreta! Qual operação deseja fazer? ");
                    op = int.Parse(Console.ReadLine());
                }
                //Exemplo2 ex2 = new Exemplo2();
                switch (op)
                {

                    case 1: CadastraNomes(ns); break;
                    case 2: CadastraEmail(em); break;
                    case 3: ExibeNomes(ns); break;
                    case 4: ConsultaEmail(ns,em); break;
                    case 5: resp = true; break;
                }
            } while (resp == false);
            }
        static void ExibeNomes(string[] nomes)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("\nO nome da {0} pessoa é: {1} ", i + 1,nomes[i]);
            }
            Console.ReadKey();
        }
        static void CadastraNomes(string[] nomes)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("\nQual é o nome da {0} pessoa? ", i + 1);
                nomes[i] = Console.ReadLine();
            }
            Console.Write("\nNomes cadastrados com sucesso!");
            Console.ReadKey();
        }
        static void CadastraEmail(string[] email)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("\nQual é o email da {0} pessoa? ", i + 1);
                email[i] = Console.ReadLine();
            }
            Console.Write("\nEmails cadastrados com sucesso!");
            Console.ReadKey();
        }
        static void ConsultaEmail(string[] nomes, string[] email)
        {
            int cont = 0;
            string x;
            Console.Write("Qual é o nome que deseja consultar? ");
            x = Console.ReadLine();
            for (int i = 0; i <= 9; i++)
            {
                if (x == nomes[i])
                {
                    Console.Write("\nO email de {0} é: {1}", nomes[i], email[i]);
                }
                else
                {
                    cont++;
                }
            }
            if (cont == 10)
            {
                Console.Write("\nEste nome não está cadastrado!");
            }
            Console.ReadKey();
        }
    }
}
