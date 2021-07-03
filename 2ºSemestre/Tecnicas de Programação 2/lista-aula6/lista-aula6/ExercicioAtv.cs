using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class ExercicioAtv
    {
        public void entrada(int[]A)
        {
            for(int i = 1; i <=10; i++)
            {
                Console.Write("Digite o {0}º numero: ", i);
                A[i - 1] = int.Parse(Console.ReadLine());
                valida(A, i-1);
            }
        }
        public void valida(int[]A,int i)
        {
            while(A[i]%2 == 1)
            {
                Console.Write("Numero tem que ser par, digite um novo valor: ");
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        public void calcula(int[]A, int[] B)
        {
            for(int i = 1; i <=10; i++)
            {
                B[i-1] = A[i-1] * A[i-1] * A[i-1];
            }
        }
        public void exibe(int[] A)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("\nB[{0}] = {1}",i, A[i - 1]);
            }
        }
    }
}
