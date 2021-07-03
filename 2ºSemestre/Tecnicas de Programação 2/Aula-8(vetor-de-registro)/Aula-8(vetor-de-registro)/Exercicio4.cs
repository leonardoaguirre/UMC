using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio4
    {
        public struct taxiLocal
        {
            public int cod;
            public string nome;
            public int ntaxi;
            public double kper;
        }
        public void principal()
        {
            int nmoto;
            validaTaxis(out nmoto);
            taxiLocal[] taxis = new taxiLocal[nmoto];
            entrada(taxis,nmoto);
            saida(taxis,nmoto);
        }
        static void entrada(taxiLocal[] vet, int q)
        {
            for (int c = 0; c < q; c++)
            {
                Console.Clear();
                Console.Write("Digite o código do {0}º taxi: ", c + 1);
                vet[c].cod = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do condutor do {0}º taxi: ", c + 1);
                vet[c].nome = Console.ReadLine();
                Console.Write("Digite o numero do {0}º taxi: ", c + 1);
                vet[c].ntaxi = int.Parse(Console.ReadLine());
                Console.Write("Digite o quilometro percorrido pelo {0}º taxi: ", c + 1);
                vet[c].kper = double.Parse(Console.ReadLine());
            }
        }
        static void validaTaxis(out int nmoto)
        {
            do
            {
                Console.Write("Quantos motoristas você deseja registrar? ");
                nmoto = int.Parse(Console.ReadLine());
                if (nmoto < 0 || nmoto > 20)
                {
                    Console.Write("\nNumero incorreto! Por favor digite novamente;");
                }
            } while (nmoto < 0 || nmoto > 20);
        }
        static void saida(taxiLocal[] vet,int q)
        {
            Console.Write("Nome do Motorista        Nº d Taxi        Valor a receber");
            for (int i =0;i< q; i++)
            {
                Console.Write("\n{0}                       {1}                 R${2:N}",vet[i].nome,vet[i].ntaxi,vet[i].kper*1.20);
            }
            Console.ReadKey();
        }
    }
}
