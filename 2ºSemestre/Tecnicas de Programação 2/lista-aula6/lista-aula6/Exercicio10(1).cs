using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_aula6
{
    class Exercicio10
    {
        public void valida(ref int n, int max)
        {
            while(n<1 || n > max)
            {
                Console.Write("\nNumero inválido! Por favor digite um numero válido entre 1 e {0}: ");
                n = int.Parse(Console.ReadLine());
            }
        }
        public void vendas(int[]jan,int[]cor)
        {
            char resp;
            int num_polt;
            if (lotado(jan)==true || lotado(cor)==true)
            {
                Console.Write("\nO ônibus está lotado!");
            }
            else
            {
                Console.Write("\nVocê prefere o assento na janela ou corredor? (j/c) ");
                resp = char.Parse(Console.ReadLine());
                while(resp!='j' && resp!='J' && resp!='c' && resp != 'C')
                {
                    Console.Write("\nOpção incorreta!Digite novamente;");
                    Console.Write("\nVocê prefere o assento na janela ou corredor? (j/c) ");
                    resp = char.Parse(Console.ReadLine());
                }
                if (resp == 'j' || resp=='J')
                {
                    if (lotado(jan) == true)
                    {
                        Console.Write("\nNão há lugares disponiveis na janela!");
                    }
                    else
                    {
                        listaLugares(jan);
                        Console.Write("\nQual poltrona você deseja? ");
                        num_polt = int.Parse(Console.ReadLine());
                        valida(ref num_polt, 24);
                        if (jan[num_polt] == 0)
                        {
                            jan[num_polt] = 1;
                            Console.Write("\nVenda realizada com sucesso!");
                        }
                        else
                        {
                            Console.Write("Poltrona ocupada!");
                        }
                    }
                }
                else
                {
                    if (lotado(cor) == true)
                    {
                        Console.Write("\nNão há lugares disponiveis no corredor!");
                    }
                    else
                    {
                        listaLugares(cor);
                        Console.Write("\nQual poltrona você deseja? ");
                        num_polt = int.Parse(Console.ReadLine());
                        valida(ref num_polt, 24);
                        if (cor[num_polt] == 0)
                        {
                            cor[num_polt] = 1;
                            Console.Write("\nVenda realizada com sucesso!");
                        }
                        else
                        {
                            Console.Write("Poltrona ocupada!");
                        }
                    }
                }
            }
        }
        public bool lotado(int[]lugar)
        {
            bool achou = true;
            for(int i = 0; i < 24; i++)
            {
                if (lugar[i] == 0)
                {
                    achou = false;
                }
            }
            return achou;
        }
        public void listaLugares(int[] lugar)
        {
            int cont = 0;
            Console.Write("Lugares: ");
            for(int i = 0; i < 24; i++)
            {
                if (lugar[i] == 0)
                {
                    Console.Write(" |{0}| ", i);
                    cont++;
                }
            }
            Console.Write("estão disponíveis!\nTotalizando {0} lugares disponíveis", cont);
        }
    }
}
