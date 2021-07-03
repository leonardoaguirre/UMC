using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace xercicio_mercado_arquivo_texto_
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
            string caminho = "Produtos.txt";
            if (!File.Exists(caminho))
            {
                FileStream prod = new FileStream(caminho, FileMode.CreateNew, FileAccess.ReadWrite);
                prod.Close();
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Estoque de produtos do mercado");
                Console.WriteLine("1-Cadastro");
                Console.WriteLine("2-Listagem");
                Console.WriteLine("3-Consultar");
                Console.WriteLine("4-Lista do estoque");
                Console.WriteLine("5-Estoque total do mercado");
                Console.WriteLine("6-Sair");
                Console.Write("Qual operação você deseja fazer? ");
                op = int.Parse(Console.ReadLine());
                while (op < 1 || op > 6)
                {
                    Console.WriteLine("Operação incorreta, digite novamente! ");
                    Console.Write("\nQual operação você deseja fazer? ");
                    op = int.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1: cadastrar(caminho); break;
                    case 2: listar(caminho); break;
                    case 3: consultar(caminho); break;
                    case 4: listarEstoque(caminho); break;
                    case 5: estoqueTotal(caminho); break;
                }
            } while (op != 6);
        }
        static void cadastrar(string c)
        {
            FileStream prod = new FileStream(c, FileMode.Append, FileAccess.Write);
            StreamWriter pr = new StreamWriter(prod);

            Console.Clear();
            Console.Write("Qual o nome do produto? ");
            string nm = Console.ReadLine();
            Console.Write("Qual é o valor desse produto? ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Qual é a quantidade em estoque? ");
            int qt = int.Parse(Console.ReadLine());

            pr.WriteLine(nm + ";" + preco + ";" + qt);
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ReadKey();
            pr.Close();
            prod.Close();
        }
        static void listar(string c)
        {
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader list = new StreamReader(prod);
            int i = 1;
            while(list.Peek() != -1)
            {
                string linha = list.ReadLine();
                int p1 = linha.IndexOf(";") + 1;
                int p2 = linha.IndexOf(";", p1) + 1;

                string nm = linha.Substring(0, p1 - 1);
                double pr = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                int qt = int.Parse(linha.Substring(p2));

                Console.WriteLine("\n{0} produto", i);
                Console.WriteLine("Nome do produto: {0}", nm);
                Console.WriteLine("Preço do produto: R${0:N}", pr);
                Console.WriteLine("Quantidade em estoque: {0} unidades", qt);
                i++;
            }
            list.Close();
            prod.Close();
            Console.ReadKey();
        }
        static void consultar(string c)
        {
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader list = new StreamReader(prod);

            Console.Write("Qual o nome do produto que deseja pesquisar? ");
            string pesq = Console.ReadLine();
            int x = 0;

            while (list.Peek() != -1)
            {
                string linha = list.ReadLine();
                int p1 = linha.IndexOf(";") + 1;
                int p2 = linha.IndexOf(";", p1) + 1;

                string nm = linha.Substring(0, p1 - 1);
                double pr = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                int qt = int.Parse(linha.Substring(p2));

                if (nm == pesq)
                {
                    Console.WriteLine("\nProduto encontrado!");
                    Console.WriteLine("\nNome do produto: {0}", nm);
                    Console.WriteLine("Preço do produto: {0:N}", pr);
                    Console.WriteLine("Quantidade em estoque: {0}", qt);
                    x = 1;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Produto não encontrado!");
            }
            Console.ReadKey();
            list.Close();
            prod.Close();
        }
        static void listarEstoque(string c)
        {
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader list = new StreamReader(prod);
            int i = 1;
            while (list.Peek() != -1)
            {
                string linha = list.ReadLine();
                int p1 = linha.IndexOf(";") + 1;
                int p2 = linha.IndexOf(";", p1) + 1;

                string nm = linha.Substring(0, p1 - 1);
                double pr = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                int qt = int.Parse(linha.Substring(p2));
                double total = (double)qt * pr; 

                Console.WriteLine("\n{0} produto", i);
                Console.WriteLine("Nome do produto: {0}", nm);
                Console.WriteLine("Preço do produto: R${0:N}", pr);
                Console.WriteLine("Quantidade em estoque: {0} unidades", qt);
                Console.WriteLine("Preço total do(a) {1} em estoque: R${0:N}", total, nm);
                i++;
            }
            list.Close();
            prod.Close();
            Console.ReadKey();
        }
        static void estoqueTotal(string c)
        {
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader list = new StreamReader(prod);
            int i = 1;
            double geral = 0;
            while (list.Peek() != -1)
            {
                string linha = list.ReadLine();
                int p1 = linha.IndexOf(";") + 1;
                int p2 = linha.IndexOf(";", p1) + 1;

                string nm = linha.Substring(0, p1 - 1);
                double pr = double.Parse(linha.Substring(p1, p2 - p1 - 1));
                int qt = int.Parse(linha.Substring(p2));
                double total = (double)qt * pr;

                Console.WriteLine("\n{0} produto", i);
                Console.WriteLine("Nome do produto: {0}", nm);
                Console.WriteLine("Preço do produto: R${0:N}", pr);
                Console.WriteLine("Quantidade em estoque: {0} unidades", qt);
                Console.WriteLine("Preço total do(a) {1} em estoque: R${0:N}", total,nm);
                i++;
                geral = total + geral;
            }
            Console.WriteLine("\nPreço de todo o estoque dos {1} produtos existentes: R${0:N}", geral,i);
            list.Close();
            prod.Close();
            Console.ReadKey();
        }
    }
}
