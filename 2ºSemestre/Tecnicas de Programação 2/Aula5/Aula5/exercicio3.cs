using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class exercicio3
    {
        public void entrada(ref int alunos)
        {
            Console.WriteLine("Programa que ostra quantos alunos tem mais de 25 anos");
           
                Console.Write("\nQuantos alunos você possui? ");
                alunos = int.Parse(Console.ReadLine());
                valida(ref alunos, 100);
        }
        public void valida(ref int n ,int max)
        {
            while (n <0 || n>max)
            {
                Console.Write("Numero invalido!Digite novamente: ");
                n=int.Parse(Console.ReadLine());
            }
        }
        public void calcula(int []vet, int max)
        {
            int maior = 0;
            idades(vet,ref maior,max);
            Console.Write("Você possui {0} alunos com mais de 25 anos!", maior);
            Console.WriteLine("Veja a seguir a lista completa: ");
            for(int i = 1;i <= max; i++)
            {
                Console.Write("\n{0}ºAluno , com {1} anos;",i,vet[i-1]);
               
            }
            Console.ReadKey();
        }
        public void idades(int[] A,ref int maior, int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.Write("\nQual a idade do {0}ºaluno: ", i);
                A[i - 1] = int.Parse(Console.ReadLine());
                if (A[i-1] > 25)
                {
                    maior++;
                }
            }
        }
    }
}
