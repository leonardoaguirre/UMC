using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao
{
    class Aluno
    {
        public struct reg_aluno
        {
            public string RGM;
            public string nome;
            public double M1;
            public double M2;
            public double MF;
            public string situacao;
        }
        public void dados()
        {
            reg_aluno Aluno;

            Console.WriteLine("Cálculo da média e situação de 1 aluno");
            Console.Write("Digite o RGM: ");
            Aluno.RGM = Console.ReadLine();

            Console.Write("Digite o nome: ");
            Aluno.nome = Console.ReadLine();

            Console.Write("Digite a M1: ");
            Aluno.M1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a M2: ");
            Aluno.M2 = double.Parse(Console.ReadLine());

            Aluno.MF = (Aluno.M1 + Aluno.M2 * 2) / 3;

            if (Aluno.MF >= 5)
            {
                Aluno.situacao = "Aprovado!";
            }
            else if (Aluno.MF < 3)
            {
                Aluno.situacao = "Reprovado!";
            }
            else
            {
                Aluno.situacao = "Exame!";
            }

            Console.Clear();

            Console.WriteLine("O aluno {0}, com média final {1:N}, está: {2}", Aluno.nome, Aluno.MF, Aluno.situacao);

            Console.ReadKey();
        }
    
}
}
