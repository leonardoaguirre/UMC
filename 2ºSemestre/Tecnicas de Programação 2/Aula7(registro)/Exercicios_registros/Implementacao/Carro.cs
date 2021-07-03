using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao
{
    class Carro
    {
        public struct reg_carro
        {
            public string placa;
            public string tipo_combustivel;
            public string chassi;
            public string modelo;
            public int ano;
            public string cor;
            public string proprietario;
        }
        public void dados()
        {
            reg_carro carro;

            Console.WriteLine("Aramazenamento de informações de 1 carro");
            Console.Write("Digite a placa: ");
            carro.placa = Console.ReadLine();

            Console.Write("Digite o tipo de combustivel: ");
            carro.tipo_combustivel = Console.ReadLine();

            Console.Write("Digite o chassi: ");
            carro.chassi = Console.ReadLine();

            Console.Write("Digite o modelo: ");
            carro.modelo = Console.ReadLine();

            Console.Write("Digite o ano: ");
            carro.ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a cor: ");
            carro.cor = Console.ReadLine();

            Console.Write("Digite o nome do proprietario: ");
            carro.proprietario = Console.ReadLine();

            Console.Clear();
            Console.Write("Placa: {0}\nTipo de combustivel: {1}\nchassi: {2}\nModelo: {3}\nAno: {4}\nCor: {5}\nProprietario: {6}",carro.placa,carro.tipo_combustivel,carro.chassi,carro.modelo,carro.ano,carro.cor,carro.proprietario);
            Console.ReadKey();
        }
    }
}
