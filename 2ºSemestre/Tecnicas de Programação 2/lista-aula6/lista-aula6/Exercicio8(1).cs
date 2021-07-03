using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class Exercicio8
    {
        public void valida(ref int n, int max)
        {
            while(n<=0 || n > max)
            {
                Console.Write("\nNumero invalido! Por favor digite um numero valido entre 1 e {0}: ", max);
                n = int.Parse(Console.ReadLine());

            }
        }
        public void valida2(ref double n, double max)
        {
            while (n <= 0 || n > max)
            {
                Console.Write("\nNumero invalido! Por favor digite um numero valido entre 1 e {0}: ", max);
                n = int.Parse(Console.ReadLine());

            }
        }
        public void entrada(string[]n , int[]q , double[]v , int x)
        {
            for(int i=0;i< x; i++)
            {
                Console.Clear();
                Console.Write("\nQual é o nome do {0}º produto? ", i + 1);
                n[i] = Console.ReadLine();
                Console.Write("\nQual é a quantidade do {0}º produto em estoque? ", i + 1);
                q[i] = int.Parse(Console.ReadLine());
                valida(ref q[i], 1000);
                Console.Write("\nQual é o valor do {0}º produto? ", i + 1);
                v[i] = double.Parse(Console.ReadLine());
                valida2(ref v[i], 1000);
            }
        }
        public void calculaEstoque(string[] n, int[] q, double[] v, int x)
        {
            double totalProd, totalEst = 0;
            for(int i = 0; i < x; i++)
            {
                totalProd = q[i] * v[i];
                totalEst = totalEst + totalProd;
                Console.Write("\nO produto {0} possui um valor total de R${1} em estoque",n[i],totalProd);
            }
            Console.Write("\nO valor total de produtos em estoque é de R${0}", totalEst);
            Console.ReadKey();
        }
    }
}
