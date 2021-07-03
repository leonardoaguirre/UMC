using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_aula2_procedimentos_funções_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            /*int n1; double n2, n3;
            Console.Write("Digite o 1º numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º numero: ");
            n3 = double.Parse(Console.ReadLine());
            exercicio1(ref n1,ref n2,n3);
            Console.Write("N1= {0} N2={1} N3={2}",n1,n2,n3);
            Console.ReadLine();*/

            //Exercicio 2
            /*int a; double b, c;
            Console.Write("Digite o 1º numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º numero: ");
            c = double.Parse(Console.ReadLine());
            exercicio2(ref a, b, ref c);
            c*/

            //Exercicio 3
            /*double a, b;
            Console.Write("Digite o 1º numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            exercicio3(ref a, b);
            Console.Write("A={0} B={1}", a, b);
            Console.ReadKey();*/

            //Exercicio 4
            /*double a, b;
            Console.Write("Digite o 1º numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Saida:{0}", exercicio4(a,b));
            Console.ReadKey();*/

            //Exercicio 5
            /*double a, b;
            Console.Write("Digite o 1º numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            exercicio5(ref a, ref b);
            Console.Write("A={0} B={1}", a, b);
            Console.ReadKey();*/

            //Exercicio6
            /*double a, b;
            Console.Write("Digite o 1º numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Saida:{0}",exercicio6(a, b));
            Console.ReadKey();*/

            //Exericio7
            /*int x,m; double y, k;
            Console.Write("Digite o 1º numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º numero: ");
            k = double.Parse(Console.ReadLine());
            exercicio7(ref x, ref y, k);
            m = calc7(x);
            Console.Write("X={0} Y={1} K={2} M={3}", x, y, k, m);
            Console.ReadKey();*/

            //Exercicio8
            double a,b,c,m;
            Console.Write("Digite o 1º numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º numero: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º numero: ");
            c = double.Parse(Console.ReadLine());
            exercicio8(ref a,ref b, ref c);
            m = result8(b);
            Console.Write("A={0} B={1} C={2} M={3}", a, b, c, m);
            Console.ReadKey();
        }
        static void exercicio1(ref int a, double b,double c)
        {
            c = a + 4;
            a = a * 4;
            b = c / 2;

        }
        static void exercicio2(ref int x, double m, ref double y)
        {
            y = x + 3;
            x = x * 3;
            m = y / 2;
        }
        static void exercicio3(ref double x, double y)
        {
            x = 1 + y;
            y = 20 - y;

        }
        static double exercicio4(double x, double y)
        {
            x = 1 - y;
            y = 20 - x;
            return x + y;
        }
        static void exercicio5(ref double x, ref double y)
        {
            x = 100 / y;
            y = x * x;

        }
        static double exercicio6(double x, double y)
        {
            x = 100 / y;
            y = x * x;
            return x + y;
        }
        static void exercicio7(ref int a,ref double b, double c)
        {
            c = a * 4;
            b = c + 5;
            c = a / 2;
        }
        static int calc7(int num)
        {
            int s;
            s = num * 2;
            return s;

        }
        static void exercicio8(ref double x, ref double y, ref double t)
        {
            y = y * 2;
            x = t + y;
            t = x / 2;
        }
        static double result8(double n)
        {
            return n * 2;
        }
    }
}
