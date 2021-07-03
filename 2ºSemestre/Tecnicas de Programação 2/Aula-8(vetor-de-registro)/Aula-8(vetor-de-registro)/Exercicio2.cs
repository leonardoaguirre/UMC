using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio2
    {
        public void principal()
        {
            ty_prod[] vet = new ty_prod[30];
            int n;
            double total=0;
            do
            {
                Console.Write("Quantos produtos deseja registrar? ");
                n= int.Parse(Console.ReadLine());
                if(n>=30 || n < 0)
                {
                    Console.WriteLine("Numero incorreto! Digite novamente;");
                }
            } while (n >= 30 || n<0);
            entrada(vet, n);
            calculo(vet, n,out total);
            Console.Clear();
            Console.Write("O valor total de produtos em estoque é: R${0}", total);
            Console.ReadKey();
        }
        public struct ty_prod
        {
            public int cod;
            public string nome;
            public int qtd;
            public double v_unit;
        }
        static void entrada(ty_prod[] vet, int q)
        {
            for(int c=0; c< q; c++)
            {
                Console.Clear();
                Console.Write("Digite o código do {0}º produto: ", c + 1);
                vet[c].cod = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do {0}º produto: ", c + 1);
                vet[c].nome = Console.ReadLine();
                Console.Write("Digite a quantidade do {0}º produto: ", c + 1);
                vet[c].qtd = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de cada unidade do {0}º produto: ", c + 1);
                vet[c].v_unit = double.Parse(Console.ReadLine());
            }
        }
        static void calculo(ty_prod[] prod,int q,out double tot)
        {
            tot = 0;
            for(int c=0;c< q; c++)
            {
                tot = tot + prod[c].qtd * prod[c].v_unit;
            }
        }
    }
}
