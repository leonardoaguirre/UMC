using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_03
{
    public class Turmas
    {
        public int id { get; set; }
        public string curso { get; set; }
        public string periodo { get; set; }
        public List<Turmas> listarCursos()
        {
            List<Turmas> arr = new List<Turmas>();

            Turmas obj1 = new Turmas();
            obj1.id = 1;
            obj1.curso = "Sistemas de informação";
            arr.Add(obj1);

            Turmas obj2 = new Turmas();
            obj2.id = 2;
            obj2.curso = "Analise de sistemas";
            arr.Add(obj2);

            Turmas obj3 = new Turmas();
            obj3.id = 3;
            obj3.curso = "Jogos digitais";
            arr.Add(obj3);

            return arr;
        }
        public List<Turmas> listarPeriodos()
        {
            List<Turmas> arr2 = new List<Turmas>();

            Turmas obj1 = new Turmas();
            obj1.id = 1;
            obj1.periodo = "Manhã";
            arr2.Add(obj1);

            Turmas obj2 = new Turmas();
            obj2.id = 2;
            obj2.periodo = "Tarde";
            arr2.Add(obj2);

            Turmas obj3 = new Turmas();
            obj3.id = 3;
            obj3.periodo = "Noite";
            arr2.Add(obj3);

            return arr2;
        }

        
    }
}
