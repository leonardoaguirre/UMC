
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_IMC_arquivo_texto_
{
    class BInario
    {
        public void principal()
        {
            menu();
        }
        static void menu()
        {
            int op;
            string caminho = "Pessoas.dat";
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
                while (op < 1 || op > 3)
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
            FileStream pes = new FileStream(c, FileMode.Append, FileAccess.Write);
            //StreamWriter dados = new StreamWriter(pes);
            BinaryWriter dados = new BinaryWriter(pes);

            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é  seu peso? ");
            double peso = double.Parse(Console.ReadLine());
            valida(ref peso, 15, 500);
            Console.Write("Qual é a sua altura? ");
            double alt = double.Parse(Console.ReadLine());
            valida(ref alt, 0.5, 2.5);

            //dados.WriteLine(nome + ";" + peso + ";" + alt);
            dados.Write(nome);dados.Write(peso);dados.Write(alt);

            Console.WriteLine("Pessoa cadastrada com sucesso!");
            Console.ReadKey();
            dados.Close();
            pes.Close();
        }
        static void calcular(string c)
        {
            FileStream pes = new FileStream(c, FileMode.Open, FileAccess.Read);
            //StreamReader dados = new StreamReader(pes);
            BinaryReader dados = new BinaryReader(pes);

            //while (dados.Peek() != -1)
            while(dados.PeekChar() != -1)
            {
                //IMC=peso/altura^2
                //string linha = dados.ReadLine();

                /*int p1 = linha.IndexOf(";")+1;
                int p2 = linha.IndexOf(";", p1)+1;

                string nome = linha.Substring(0, p1 - 1);
                double peso = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                double alt = double.Parse(linha.Substring(p2));*/

                //string linha = dados.ReadLine();
                //string[] l = linha.Split(';');//split divide a linha recuperada em palavras e as coloca em um vetor através do separador dado como argumento no caso o ";"

                /*string nome = l[0];
                double peso = double.Parse(l[1]);
                double alt = double.Parse(l[2]);*/

                string nome = dados.ReadString();
                double peso = dados.ReadDouble();
                double alt = dados.ReadDouble();

                double imc = peso / Math.Pow(alt, 2);

                Console.WriteLine("\nNome: {0} IMC: {1:N}", nome, imc);
            }
            Console.WriteLine("\nResultado	    Situação\nAbaixo de 17        Muito abaixo do peso\nEntre 17 e 18,49    Abaixo do peso\nEntre 18,5 e 24,99  Peso normal\nEntre 25 e 29,99    Acima do peso\nEntre 30 e 34,99    Obesidade I\nEntre 35 e 39,99    Obesidade II(severa)\nAcima de 40         Obesidade III(mórbida)");
            Console.ReadKey();
        }
        static void valida(ref double n, double min, double max)
        {
            while (n < min && n < max)
            {
                Console.WriteLine("Numero incorreto! Digite novamente: ");
                n = double.Parse(Console.ReadLine());
            }
        }
    }
}
