using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sempre importar essa biblioteca para poder criar um arquivo texto
using System.IO;

namespace Aula_Arquivo_Texto_
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = "C:/Users/alunocmc/Desktop/agenda.txt";//cria a sting com o camiho do arquivo
            //FileStream relatorio = new FileStream(caminho, FileMode.CreateNew/*cria novo arquivo*/, FileAccess.ReadWrite/*libera o acesso ao arquivo podendo ler e eescrever o arquivo*/);
            //relatorio.Close();//fecha o arquivo que esta em aberto

            //escrever(caminho);
            //ler(caminho);
            sobrescrever(caminho);
        }
        static void escrever(string c)
        {
            FileStream relatorio = new FileStream(c, FileMode.Append/*posiciona na ultima escrita do arquivo e não no começo*/, FileAccess.Write/*ação de escrever somente no arquivo*/);
            StreamWriter ag = new StreamWriter(relatorio);//objeto em que carrega as informações a serem escritas

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o celular: ");
            string cel = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();

            ag.Write(nome + ";" + cel + ";" + email);
            ag.Close();//primeiro o objeto streamWriter tem que ser fechado para que o objeto fileStream seja fechado depois
            relatorio.Close();
        }
        static void ler(string c)
        {
            FileStream relatorio = new FileStream(c, FileMode.Open/*abre o arquivo no começo para a leitura*/, FileAccess.Read/*ação de ler o arquivo*/);
            StreamReader ag = new StreamReader(relatorio);

            string linha = ag.ReadLine();
            Console.WriteLine(linha);//puxa e mostra tudo direto do arquivo

            int pos1 = linha.IndexOf(";") + 1;
            int pos2 = linha.IndexOf(";",pos1) + 1;

            string nome = linha.Substring(0, pos1 - 1);
            string cel = linha.Substring(pos1, pos2 - pos1 - 1);
            string email = linha.Substring(pos2);

            Console.WriteLine("Nome: {0}, Cel: {1}, Email: {2}", nome, cel, email);
            Console.ReadKey();

            ag.Close();
            relatorio.Close();
        }
        static void sobrescrever(string c)
        {
            if (!File.Exists(c))
            {
                FileStream relatorio = new FileStream(c, FileMode.CreateNew, FileAccess.ReadWrite);
                relatorio.Close();
            }
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda");
                Console.WriteLine("1-Cadastrar");
                Console.WriteLine("2-Listar");
                Console.WriteLine("3-Consultar por nome");
                Console.WriteLine("4-Sair");
                Console.WriteLine("Digite a sua operação");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: cadastrar(c); break;
                    case 2: listar(c); break;
                    case 3: consultar(c); break;
                }
                Console.ReadKey();
            } while (op != 4);
        }
        static void cadastrar(string c)
        {
            FileStream relatorio = new FileStream(c, FileMode.Append, FileAccess.Write);
            StreamWriter ag = new StreamWriter(relatorio);

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o celular: ");
            string cel = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();

            ag.WriteLine(nome + ";" + cel + ";" + email);
            ag.Close();
            relatorio.Close();
        }
        static void listar(string c)
        {
            FileStream relatorio = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader ag = new StreamReader(relatorio);
            int i=1;
            while (ag.Peek() != -1)//peek é a função que percorre o arquivo e pega os dados e -1 é o que retorna quando ele não acha mais dados
            {
                string linha = ag.ReadLine();
                int pos1 = linha.IndexOf(";") + 1;
                int pos2 = linha.IndexOf(";", pos1) + 1;

                string nome = linha.Substring(0, pos1 - 1);
                string cel = linha.Substring(pos1, pos2 - pos1 - 1);
                string email = linha.Substring(pos2);

                Console.WriteLine("\n{0}ºPessoa",i);
                Console.WriteLine("Nome: {0}", nome);
                Console.WriteLine("Celular: {0}", cel);
                Console.WriteLine("Email: {0}", email);
                i++;
            }
            ag.Close();
            relatorio.Close();
        }
        static void consultar(string c)
        {
            Console.WriteLine("Qual nome deseja procurar? ");
            string pesq = Console.ReadLine();

            FileStream relatorio = new FileStream(c, FileMode.Open, FileAccess.Read);
            StreamReader ag = new StreamReader(relatorio);
            int x = 0;
            while (ag.Peek() != -1)
            {
                string linha = ag.ReadLine();
                int pos1 = linha.IndexOf(";")+1;
                int pos2 = linha.IndexOf(";", pos1) + 1;

                string nome = linha.Substring(0, pos1 - 1);
                string cel = linha.Substring(pos1, pos2 - pos1 - 1);
                string email = linha.Substring(pos2);
                if (pesq==nome)
                {
                    Console.WriteLine("Nome: {0}", nome);
                    Console.WriteLine("Celular: {0}", cel);
                    Console.WriteLine("Email: {0}", email);
                    x = 1;
                }     
            }
            if (x == 0)
            {
                Console.WriteLine("O nome digitado não foi encontrado");
            }
            ag.Close();
            relatorio.Close();
        }
    }
}
