using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 7 
            /*int[] n = new int[15];
            int v;
            Console.Write("Programa que  lê 15 números inteiros e mostra quantas vezes o número 0 é repetido no vetor");
            Console.ReadKey();
            Exercicio7 ex7 = new Exercicio7();
            ex7.Entrada(n);
            ex7.Calculo(n, out v);
            Console.Clear();
            Console.Write("O numero 0 foi repetido {0} no vetor",v);
            Console.ReadLine();*/

            //Exercicio 8
            /*int n;
            Console.Write("Programa que armazena um estoque de uma loja e exibe os valores do estoque");
            Console.Write("\nQuantos produtos você deseja armazenar? ");
            n = int.Parse(Console.ReadLine());

            string[] Nom = new string[n];
            int[] Qua = new int[n];
            double[] Val = new double[n];

            Exercicio8 ex8 = new Exercicio8();
            ex8.valida(ref n, 500);
            ex8.entrada(Nom, Qua, Val, n);
            ex8.calculaEstoque(Nom, Qua, Val, n);*/

            //Exercicio 9
            /* int[] vet1 = new int[6];
             int[] vet2 = new int[6];
             int[] vet3 = new int[6];
             Exercicio9 ex9 = new Exercicio9();
             Console.Write("\nPrograma que exibe 3 vetores na tela, sendo que o terceiro vetor é a soma dos outros.");
             Console.ReadKey();
             ex9.entrada(vet1,1);
             ex9.entrada(vet2,2);
             ex9.calculo(vet1, vet2, vet3);
             ex9.exibir(vet1, 1);
             ex9.exibir(vet2, 2);
             ex9.exibir(vet3, 3);
             Console.ReadKey();*/

            //Exercicio 10
            /*int[] janela = new int[24];
            int[] corredor = new int[24];
            int op;
            Exercicio10 ex10 = new Exercicio10();

            for (int i = 0; i < 24; i++)
            {
                janela[i] = 0;
                corredor[i] = 0;
            }
            do
            {
                Console.Clear();
                Console.Write("Programa que controla as poltronas ocupadas no corredor e na janela de um ônibus");
                Console.Write("\n1 – Vendas\n2 - Lugares vagos na janela\n3 - Lugares vagos no corredor\n4 - Sair ");
                Console.Write("\nQual operação você deseja fazer? ");
                op = int.Parse(Console.ReadLine());
                ex10.valida(ref op, 4);
                if (op == 1)
                {
                    ex10.vendas(janela, corredor);
                    Console.ReadKey();
                }else if (op == 2)
                {
                    ex10.listaLugares(janela);
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    ex10.listaLugares(corredor);
                    Console.ReadKey();
                }
            } while(op!=4);*/

            //exercicio da aividade (para ver se a logica funciona
            int[] nums = new int[100];
            int[] nums2 = new int[100];
            ExercicioAtv atv = new ExercicioAtv();
            atv.entrada(nums);
            atv.calcula(nums, nums2);
            atv.exibe(nums2);
            Console.ReadKey();

        }
    }
}
