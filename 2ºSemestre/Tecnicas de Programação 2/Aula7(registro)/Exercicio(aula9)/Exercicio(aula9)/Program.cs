using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_aula9_
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            string caminho = "Produtos.dat";
            int op;
            if (!File.Exists(caminho))
            {
                FileStream prod = new FileStream(caminho, FileMode.CreateNew, FileAccess.ReadWrite);
                prod.Close();
            }
            do
            {
                Console.Clear();
                Console.Write("\nMenu de produtos!");
                Console.Write("\n1-Cadastrar novo produto");
                Console.Write("\n2-Listagem geral de produtos");
                Console.Write("\n3-Listagem por categoria de produto");
                Console.Write("\n4-Alterar dados de um produto");
                Console.Write("\n5-Consultar dados de um produto");
                Console.Write("\n6-Excluir um produto");
                Console.WriteLine("\n7-Sair");
                op = int.Parse(Console.ReadLine());
                valida(ref op, 7);
                switch (op)
                {
                    case 1: cadastrar(caminho); break;
                    case 2: listagemGeral(caminho); break;
                    case 3: listagemPorCat(caminho); break;
                    case 4: alterar(caminho); break;
                    case 5: consultar(caminho); break;
                    case 6: excluir(caminho); break;
                }
            } while (op!=7);
        }
        static void valida(ref int n,int max)
        {
            while(n<1 && n > max)
            {
                Console.Write("\nNumero incorreto! Digite novamente por favor: ");
                n = int.Parse(Console.ReadLine());
            }
        }
        static void cadastrar(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Append, FileAccess.Write);
            BinaryWriter pr = new BinaryWriter(prod);

            Console.Write("\nQual é o codigo do produto? ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("\nQual é a descrição do produto? ");
            string desc = Console.ReadLine();
            Console.WriteLine("\nQual é a categoria do produto?\n1-Escritório-20%\n2-Eletrônicos-15%\n3-Comidas-30%\n4-Vestuário-25%\n5-Calçados-15% ");
            int ca = int.Parse(Console.ReadLine());
            valida(ref ca, 5);
            string cat="";
            int por=0;
            switch (ca)
            {
                case 1: cat = "Escritório"; por = 20; break;
                case 2: cat = "Eletrônicos"; por = 15; break;
                case 3: cat = "Comidas"; por = 30; break;
                case 4: cat = "Vestuário"; por = 25; break;
                case 5: cat = "Calçados"; por = 15; break;
            }
            Console.Write("\nQual é o preço de custo? ");
            double pre = double.Parse(Console.ReadLine());
            double preFinal = ((double)por/100) * pre + pre;

            pr.Write(cod);pr.Write(desc);pr.Write(cat);pr.Write(pre);pr.Write(por);pr.Write(preFinal);
            Console.Write("\nProduto cadastrado com sucesso!");
            Console.ReadKey();

            pr.Close();
            prod.Close();
        }
        static void listagemGeral(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader pr = new BinaryReader(prod);
            int i = 1;
            while (pr.PeekChar() != -1)
            {
                int cod = pr.ReadInt32();
                string desc = pr.ReadString();
                string cat = pr.ReadString();
                double pre = pr.ReadDouble();
                int por = pr.ReadInt32();
                double preFinal = pr.ReadDouble();

                Console.Write("\n{0}ºProduto",i);i++;
                Console.Write("\nCodigo: {0}",cod);
                Console.Write("\nDescrição: {0}", desc);
                Console.Write("\nCategoria: {0}", cat);
                Console.Write("\nPreço de custo: R${0}", pre);
                Console.Write("\nMargem de lucro: {0}%", por);
                Console.WriteLine("\nPreço Final: R${0}", preFinal);
            }
            Console.ReadKey();
            pr.Close();
            prod.Close();
        }
        static void listagemPorCat(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader pr = new BinaryReader(prod);
            int i = 1;
            Console.Write("\nQual categoria deseja pesquisar? \n1-Escritório\n2-Eletrônicos\n3-Comidas\n4-Vestuário\n5-Calçados");
            int ca = int.Parse(Console.ReadLine());
            valida(ref ca, 5);
            string catego="";
            switch (ca)
            {
                case 1: catego = "Escritório"; break;
                case 2: catego = "Eletrônicos";  break;
                case 3: catego = "Comidas";  break;
                case 4: catego = "Vestuário";  break;
                case 5: catego = "Calçados"; break;
            }
            bool flag = false;
            while (pr.PeekChar() != -1)
            {
                int cod = pr.ReadInt32();
                string desc = pr.ReadString();
                string cat = pr.ReadString();
                double pre = pr.ReadDouble();
                int por = pr.ReadInt32();
                double preFinal = pr.ReadDouble();

                if (catego == cat)
                {
                    flag = true;
                    Console.Write("\n{0}ºProduto", i); i++;
                    Console.Write("\nCodigo: {0}", cod);
                    Console.Write("\nDescrição: {0}", desc);
                    Console.Write("\nCategoria: {0}", cat);
                    Console.Write("\nPreço de custo: R${0}", pre);
                    Console.Write("\nMargem de lucro: {0}%", por);
                    Console.Write("\nPreço Final: R${0}", preFinal);
                }
            }
            if (flag == false)
            {
                Console.Write("\nProduto nenhum encontrado!");
            }
            Console.ReadKey();
            pr.Close();
            prod.Close();
        }
        static void alterar(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader pr = new BinaryReader(prod);

            string bak = "Produtos.bak";
            FileStream prodBack = new FileStream(bak, FileMode.Create, FileAccess.Write);
            BinaryWriter prBack = new BinaryWriter(prodBack);

            Console.Write("\nQual o codigo do produto que deseja alterar? ");
            int busca = int.Parse(Console.ReadLine());
            bool flag = false;
            while (pr.PeekChar() != -1)
            {
                int cod = pr.ReadInt32();
                string desc = pr.ReadString();
                string cat = pr.ReadString();
                double pre = pr.ReadDouble();
                int por = pr.ReadInt32();
                double preFinal = pr.ReadDouble();

                if (cod == busca)
                {
                    flag = true;
                    Console.WriteLine("\nDados;");
                    Console.Write("\nCodigo: {0}", cod);
                    Console.Write("\nDescrição: {0}", desc);
                    Console.Write("\nCategoria: {0}", cat);
                    Console.Write("\nPreço de custo: R${0}", pre);
                    Console.Write("\nMargem de lucro: {0}%", por);
                    Console.WriteLine("\nPreço Final: R${0}", preFinal);

                    Console.Write("\nNovos dados;");
                    Console.Write("\nQual é o novo codigo do produto? ");
                    cod = int.Parse(Console.ReadLine());
                    Console.Write("\nQual é a nova descrição do produto? ");
                    desc = Console.ReadLine();
                    Console.WriteLine("\nQual é a nova categoria do produto?\n1-Escritório-20%\n2-Eletrônicos-15%\n3-Comidas-30%\n4-Vestuário-25%\n5-Calçados-15% ");
                    int ca = int.Parse(Console.ReadLine());
                    valida(ref ca, 5);
                    cat = "";
                    por = 0;
                    switch (ca)
                    {
                        case 1: cat = "Escritório"; por = 20; break;
                        case 2: cat = "Eletrônicos"; por = 15; break;
                        case 3: cat = "Comidas"; por = 30; break;
                        case 4: cat = "Vestuário"; por = 25; break;
                        case 5: cat = "Calçados"; por = 15; break;
                    }
                    Console.Write("\nQual é o novo preço de custo? ");
                    pre = double.Parse(Console.ReadLine());
                    preFinal = ((double)por/100) * pre + pre;

                    prBack.Write(cod); prBack.Write(desc); prBack.Write(cat); prBack.Write(pre); prBack.Write(por); prBack.Write(preFinal);
                    Console.Write("\nProduto alterado com sucesso!");
                }
                else
                {
                    prBack.Write(cod); prBack.Write(desc); prBack.Write(cat); prBack.Write(pre); prBack.Write(por); prBack.Write(preFinal);
                }
            }
            if (flag == false)
            {
                Console.Write("\nCodigo inexistente!");
            }
            Console.ReadKey();
            pr.Close();
            prod.Close();
            prBack.Close();
            prodBack.Close();

            File.Delete("Produtos.dat");
            File.Move("Produtos.bak", "Produtos.dat");
        }
        static void consultar(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader pr = new BinaryReader(prod);

            Console.Write("\nQual o codigo do produto que deseja pesquisar? ");
            int busca = int.Parse(Console.ReadLine());

            bool flag = false;
            while (pr.PeekChar() != -1)
            {
                int cod = pr.ReadInt32();
                string desc = pr.ReadString();
                string cat = pr.ReadString();
                double pre = pr.ReadDouble();
                int por = pr.ReadInt32();
                double preFinal = pr.ReadDouble();

                if (busca == cod)
                {
                    flag = true;
                    Console.Write("\nProduto encontrado!");
                    Console.Write("\nCodigo: {0}", cod);
                    Console.Write("\nDescrição: {0}", desc);
                    Console.Write("\nCategoria: {0}", cat);
                    Console.Write("\nPreço de custo: R${0}", pre);
                    Console.Write("\nMargem de lucro: {0}%", por);
                    Console.Write("\nPreço Final: R${0}", preFinal);
                }
            }
            if (flag == false)
            {
                Console.Write("\nNenum produto encontrado!");
            }
            Console.ReadKey();
            pr.Close();
            prod.Close();
        }
        static void excluir(string c)
        {
            Console.Clear();
            FileStream prod = new FileStream(c, FileMode.Open, FileAccess.Read);
            BinaryReader pr = new BinaryReader(prod);

            string bak = "Produtos.bak";
            FileStream prodBack = new FileStream(bak, FileMode.Create, FileAccess.Write);
            BinaryWriter prBack = new BinaryWriter(prodBack);

            Console.Write("\nQual o codigo do produto que deseja excluir? ");
            int busca = int.Parse(Console.ReadLine());
            bool flag = false;
            while (pr.PeekChar() != -1)
            {
                int cod = pr.ReadInt32();
                string desc = pr.ReadString();
                string cat = pr.ReadString();
                double pre = pr.ReadDouble();
                int por = pr.ReadInt32();
                double preFinal = pr.ReadDouble();

                if (cod == busca)
                {
                    flag = true;
                    Console.Write("\nProduto excluido com sucesso!");
                }
                else
                {
                    prBack.Write(cod); prBack.Write(desc); prBack.Write(cat); prBack.Write(pre); prBack.Write(por); prBack.Write(preFinal);
                }
            }
            if (flag == false)
            {
                Console.Write("\nCodigo inexistente!");
            }

            pr.Close();
            prod.Close();
            prBack.Close();
            prodBack.Close();

            File.Delete("Produtos.dat");
            File.Move("Produtos.bak", "Produtos.dat");
            Console.ReadKey();
        }
    }
}
