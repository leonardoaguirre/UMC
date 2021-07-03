using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao
{
    class Agenda
    {
        public struct reg_agenda
        {
            public string nome;
            public string endereco;
            public string tel;
            public string cel;
        }
        public void dados()
        {
            reg_agenda agenda;

            Console.WriteLine("Aramazenamento do contato de 1 pessoa");
            Console.Write("Digite o nome: ");
            agenda.nome = Console.ReadLine();

            Console.Write("Digite o endereco: ");
            agenda.endereco = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            agenda.tel = Console.ReadLine();

            Console.Write("Digite o celular: ");
            agenda.cel = Console.ReadLine();

            Console.Clear();
            Console.Write("Nome: {0}\nEndereço: {1}\nTelefone: {2}\nCelular: {3}",agenda.nome,agenda.endereco,agenda.tel,agenda.cel);
            Console.ReadKey();
        }
    }
}
