using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8_vetor_de_registro_
{
    class Exercicio1
    {
        public struct reg_func
        {
            public int cod;
            public string nome;
            public string cargo;
            public double salario;
        }
        public void principal()
        {
            reg_func[] funcionario = new reg_func[5];
            entrada(funcionario);
            saida(funcionario);
            maisq5000(funcionario);
        }
        static void entrada(reg_func[] f)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("Digite o código do {0}º funcionario: ", i + 1);
                f[i].cod = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do {0}º funcionario: ", i + 1);
                f[i].nome = Console.ReadLine();
                Console.Write("Digite o cargo do {0}º funcionario: ", i + 1);
                f[i].cargo = Console.ReadLine();
                Console.Write("Digite o salário do {0}º funcionario: ", i + 1);
                f[i].salario = double.Parse(Console.ReadLine());
            }
        }
        static void saida(reg_func[] f)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n{0}ºfuncionario", i + 1);
                Console.Write("\nCodigo: {0}\nNome: {1}\nCargo: {2}\nSalario: {2}", f[i].cod, f[i].nome, f[i].cargo, f[i].salario);
            }
            Console.ReadKey();
        }
        static void maisq5000(reg_func[] f)
        {
            Console.Clear();
            Console.WriteLine("Funcionarios que ganham mais de R$5000!");
            for (int i = 0; i < 5; i++)
            {
                if (f[i].salario > 5000)
                {
                    Console.WriteLine("Codigo: {0}\nNome: {1}\nCargo{2}", f[i].cod, f[i].nome, f[i].cargo);
                }
                Console.ReadKey();
            }
        }
    }
}
