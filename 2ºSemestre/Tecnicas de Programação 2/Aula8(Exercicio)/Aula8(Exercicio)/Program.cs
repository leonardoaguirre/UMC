using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula8_Exercicio_
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
            string caminho = "Funcionarios.dat";
            if (!File.Exists(caminho))
            {
                FileStream ar = new FileStream(caminho, FileMode.CreateNew, FileAccess.ReadWrite);
                ar.Close();
            }
            do
            {
                Console.Write("1 – Cadastrar funcionários\n2 – Listar todos funcionários\n3 – Listar acima de 10 salários\n4 – Consultar por nome\n5 – Alterar dados do funcionário\n6 – Excluir um funcionário\n7 – Fazer backup do arquivo\n8 – Sair\nDigite sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: Console.Clear(); cadastrar(caminho); Console.Clear(); break;
                    case 2: Console.Clear(); listar(caminho); Console.Clear(); break;
                    case 3: Console.Clear(); listar10salarios(caminho); Console.Clear(); break;
                    case 4: Console.Clear(); consultar(caminho); break;
                    case 5: Console.Clear(); alterar(caminho); Console.Clear(); break;
                    case 6: Console.Clear(); excluir(caminho); Console.Clear(); break;
                    case 7: Console.Clear(); backup(caminho); Console.Clear(); break;
                }
            } while (op != 8);
        }
        static void cadastrar(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Append, FileAccess.Write);
            BinaryWriter fn = new BinaryWriter(fun);

            Console.Write("Qual é o nome do funcionario? ");
            string func = Console.ReadLine();
            Console.Write("\nQual é o cargo do funcionario? ");
            string car = Console.ReadLine();
            Console.Write("\nQual é o salario do funcionario? ");
            double sal = double.Parse(Console.ReadLine());

            fn.Write(func); fn.Write(car); fn.Write(sal);
            Console.WriteLine("Funcionario cadsatrado com sucesso!");
            Console.ReadKey();

            fn.Close();
            fun.Close();
        }
        static void listar(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader list = new BinaryReader(fun);
            Console.WriteLine("Lista de funcionarios");
            while (list.PeekChar() != -1)
            {
                string nome = list.ReadString();
                string cargo = list.ReadString();
                double sal = list.ReadDouble();

                Console.WriteLine("\nNome: {0}\nCargo: {1}\nSalario: {2}", nome, cargo, sal);
            }
            Console.ReadKey();
            list.Close();
            fun.Close();
        }
        static void listar10salarios(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader list = new BinaryReader(fun);
            Console.WriteLine("Lista de funcionarios acima de 10 salarios minimos");

            Console.Write("Qual é o valor do salario minimo atual? ");
            double salAtual = double.Parse(Console.ReadLine());
            bool flag = false;

            while (list.PeekChar() != -1)
            {
                string nome = list.ReadString();
                string cargo = list.ReadString();
                double sal = list.ReadDouble();

                if (sal > salAtual * 10)
                {
                    Console.WriteLine("\nNome: {0}\nCargo: {1}\nSalario: {2}", nome, cargo, sal);
                    flag = true;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("Nenhum funcionario cadastrado ganha mais de 10 salarios minimos!");
            }
            Console.ReadKey();
            list.Close();
            fun.Close();
        }
        static void consultar(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader fn = new BinaryReader(fun);

            Console.Write("Qual o nome do funcionario que você deseja procurar? ");
            string busca = Console.ReadLine();
            bool flag = false;
            while (fn.PeekChar() != -1)
            {
                string nome = fn.ReadString();
                string cargo = fn.ReadString();
                double sal = fn.ReadDouble();

                if (nome == busca)
                {
                    Console.WriteLine("\nNome: {0}\nCargo: {1}\nSalario: {2}", nome, cargo, sal);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Nenhum funcionario foi encontrado!");
            }
            fn.Close();
            fun.Close();
            Console.ReadKey();
        }
        static void alterar(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader fn = new BinaryReader(fun);


            string back = "Funcionarios.bak";
            FileStream funBack = new FileStream(back, FileMode.Create, FileAccess.Write);
            BinaryWriter fnBack = new BinaryWriter(funBack);

            Console.Write("Entre com o nome que deseja buscar:");
            string busca = Console.ReadLine();

            bool flag = false;

            while (fn.PeekChar() != -1)
            {

                string nome = fn.ReadString();
                string cargo = fn.ReadString();
                double sal = fn.ReadDouble();

                if (busca == nome)
                {
                    Console.WriteLine("Dados;");
                    Console.WriteLine("\nNome: {0}\nCargo: {1}\nSalario: {2}", nome, cargo, sal);
                    Console.WriteLine("Novos dados;");
                    Console.Write("Entre com o novo nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Entre com o novo cargo: ");
                    cargo = Console.ReadLine();
                    Console.Write("Entre com o novo salario: ");
                    sal = double.Parse(Console.ReadLine());

                    flag = true;
                    fnBack.Write(nome); fnBack.Write(cargo); fnBack.Write(sal);
                    Console.Write("\nFuncionario alterado com sucesso!");
                }
                else
                {
                    fnBack.Write(nome); fnBack.Write(cargo); fnBack.Write(sal);
                }
            }

            if (!flag)
            {
                Console.WriteLine("Não existe esse nome");
            }
            Console.ReadKey();
            fun.Close();
            fn.Close();
            funBack.Close();
            fnBack.Close();

            File.Delete("Funcionarios.dat");
            File.Move("Funcionarios.bak", "Funcionarios.dat");

        }
        static void excluir(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader fn = new BinaryReader(fun);


            string back = "Funcionarios.bak";
            FileStream funBack = new FileStream(back, FileMode.Create, FileAccess.Write);
            BinaryWriter fnBack = new BinaryWriter(funBack);

            Console.Write("Entre com o nome que deseja buscar:");
            string busca = Console.ReadLine();

            bool flag = false;

            while (fn.PeekChar() != -1)
            {
                string nome = fn.ReadString();
                string cargo = fn.ReadString();
                double sal = fn.ReadDouble();

                if (busca == nome)
                {
                    flag = true;
                }
                else
                {
                    fnBack.Write(nome); fnBack.Write(cargo); fnBack.Write(sal);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("\nFuncionario Não cadastrado");
            }
            else
            {
                Console.WriteLine("\nRegistro apagado com sucesso");
            }
            fun.Close();
            fn.Close();
            funBack.Close();
            fnBack.Close();
            File.Delete("Funcionarios.dat");
            File.Move("Funcionarios.bak", "Funcionarios.dat");
            Console.ReadKey();
        }
        static void backup(string c)
        {
            FileStream fun = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader fn = new BinaryReader(fun);

            Console.Write("Qual o nome que você deseja colocar no arquivo de backup? ");
            string back = Console.ReadLine();
            FileStream funBack = new FileStream(back+".dat", FileMode.Create, FileAccess.Write);
            BinaryWriter fnBack = new BinaryWriter(funBack);

            while (fn.PeekChar() != -1)
            {
                string nome = fn.ReadString();
                string cargo = fn.ReadString();
                double sal = fn.ReadDouble();

                fnBack.Write(nome); fnBack.Write(cargo); fnBack.Write(sal);
            }
            fun.Close();
            fn.Close();
            funBack.Close();
            fnBack.Close();
            Console.Write("Arquivo de backup criado com successo!");
            Console.ReadKey();
        }
    }
}
