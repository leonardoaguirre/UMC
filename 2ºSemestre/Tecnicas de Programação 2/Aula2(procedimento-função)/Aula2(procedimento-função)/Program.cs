using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_procedimento_função_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da média de dois numeros");
            double n1, n2, m;
            Console.Write("Digite o 1º valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = double.Parse(Console.ReadLine());
            //calcMediaComParametroPorReferencia(n1,n2,/*ref ou out*/out m);
            Console.Write("A média é: {0}", calcMediaFuncaoComParametro(n1,n2));
            Console.ReadKey();
        }
        static void calcMediaSemParametro()
        {
            double n1,n2,m;
            Console.Write("Digite o 1º valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = double.Parse(Console.ReadLine());
            m = (n1 + n2) / 2;
            Console.Write("A média é: {0}", m);
            Console.ReadKey();
        }
        static void calcMediaComParametro(double n1, double n2)
        {
            double m;
            m = (n1 + n2) / 2;
            Console.Write("A média é: {0}", m);
            Console.ReadKey();
        }
        static void calcMediaComParametroPorReferencia(double n1, double n2,/*ref ou*/out double m)
        {
            m = (n1 + n2) / 2;
            /*Ref - quando a variável inicializada no programa principal
            Out - quando a variável não recebeu nenhum valor no programa principal

            PS* sempre usar o tipo de dado na variável referenciada usada no método
            (Ex: double, int, string e etc) quando usar out ou ref.*/

        }
        static double calcMediaFuncao()
        {
            double n1,n2;
            Console.Write("Digite o 1º valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = double.Parse(Console.ReadLine());
            return (n1 + n2) / 2;
        }
        static double calcMediaFuncaoComParametro(double n1, double n2)
        {
            return (n1 + n2) / 2;
        }
    }
}
