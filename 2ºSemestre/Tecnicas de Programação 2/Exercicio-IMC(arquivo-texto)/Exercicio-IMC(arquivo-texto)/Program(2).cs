using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_IMC_arquivo_texto_
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            int op;
            string caminho = "Pessoas.txt";
            if (!File.Exists(caminho))
            {
                FileStream pes = new FileStream(caminho, FileMode.CreateNew, FileAccess.ReadWrite);
                pes.Close();
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Calcular o IMC das pessoas cadastradas");
                Console.Write("\n1-Cadastrar nova pessoa");
                Console.Write("\n2-Calcular IMC das pessoas cadsatradas");
                Console.Write("\n3-Sair");
                Console.Write("\nQual operação deseja fazer? ");
                op = int.Parse(Console.ReadLine());
                while(op<1 || op > 3)
                {
                    Console.WriteLine("Opção incorreta! Digite novamente: ");
                    op = int.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1: cadastrar(caminho); break;
                    case 2: calcular(caminho); break;
                }
            } while (op != 3);

        }
        static void cadastrar(string c)
        {
            FileStream pes = new FileStream(c, FileMode.Append,FileAccess.Write);
            StreamWriter dados = new StreamWriter(pes);

            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é  seu peso? ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Qual é a sua altura? ");
            double alt = double.Parse(Console.ReadLine());

            dados.WriteLine(nome + ";" + peso+";" + alt);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
            dados.Close();
            pes.Close();
        }
        static void calcular(string c)
        {
            FileStream pes = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader dados = new StreamReader(pes);

            while (dados.Peek() != -1)
            {
                //IMC=peso/altura^2
                string linha = dados.ReadLine();

                int p1 = linha.IndexOf(";")+1;
                int p2 = linha.IndexOf(";", p1)+1;

                string nome = linha.Substring(0, p1 - 1);
                double peso = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                double alt = double.Parse(linha.Substring(p2));

                double imc = peso / Math.Pow(alt, 2);

                Console.WriteLine("\nNome: {0} IMC: {1:N}", nome, imc);        
            }
            Console.WriteLine("\nResultado	    Situação\nAbaixo de 17        Muito abaixo do peso\nEntre 17 e 18,49    Abaixo do peso\nEntre 18,5 e 24,99  Peso normal\nEntre 25 e 29,99    Acima do peso\nEntre 30 e 34,99    Obesidade I\nEntre 35 e 39,99    Obesidade II(severa)\nAcima de 40         Obesidade III(mórbida)");
            Console.ReadKey();
        }
    }
}
