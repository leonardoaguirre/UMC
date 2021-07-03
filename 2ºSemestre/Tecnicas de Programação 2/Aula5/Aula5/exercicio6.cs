using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class exercicio6
    {
        public void entrada(double[]A,double[]B)
        {
            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Escreva o peso da {0} pessoa: ", i+1);
                A[i] = double.Parse(Console.ReadLine());
                while(A[i]<0 || A[i] > 300)
                {
                    Console.Write("\nNumero incorreto! Escreva o peso da {0} pessoa:: ", i+1);
                    A[i] = double.Parse(Console.ReadLine());
                }
                Console.Write("Escreva a altura da {0} pessoa: ", i+1);
                B[i] = double.Parse(Console.ReadLine());
                while (B[i] < 0 || B[i] > 2.5)
                {
                    Console.Write("\nNumero incorreto! Escreva a altura da {0} pessoa: ", i+1);
                    B[i] = double.Parse(Console.ReadLine());
                }
            }
        }
        public void calcula(double[] a, double[] b)
        {
            double imc;
            for (int i = 0; i <= 4; i++)
            {
                imc = a[i] / Math.Pow(b[i],2);
                Console.Write("\n{0} pessoa IMC: {1}", i + 1, imc);
            }
            Console.ReadKey();
        }
    }
}
