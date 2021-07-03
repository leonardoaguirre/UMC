using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_BB
{
    class Program
    {

        public struct Reg_BB
        {
            public string Pai;
            public string Mae;
            public string Nome;
            public string Data;
            public double Peso;
            public string Sexo;
        }

        static void Main(string[] args)
        {
            Reg_BB certidaoNasc;

            Console.Write("Nome do recém nascido: ");
            certidaoNasc.Nome = Console.ReadLine();

            Console.Write("Nome do pai: ");
            certidaoNasc.Pai = Console.ReadLine();

            Console.Write("Nome da mãe?");
            certidaoNasc.Mae = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            certidaoNasc.Data = Console.ReadLine();

            Console.Write("Peso do recém nascido: ");
            certidaoNasc.Peso = double.Parse(Console.ReadLine());

            Console.Write("Sexo do recém nascido: ");
            certidaoNasc.Sexo = Console.ReadLine();

            Console.Clear();

            Console.Write("Nascido no dia {0}, filho de {1} com {2} nasce {3} do sexo {4} com {5:F2} kg", certidaoNasc.Data, certidaoNasc.Mae, certidaoNasc.Pai, certidaoNasc.Nome, certidaoNasc.Sexo, certidaoNasc.Peso);

            Console.ReadKey();
        }
    }
}
