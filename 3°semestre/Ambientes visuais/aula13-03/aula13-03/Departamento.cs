using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_03
{
    public class Departamento
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public List<Departamento> listar()
        {
            List<Departamento> arr = new List<Departamento>();

            Departamento obj1 = new Departamento();
            obj1.id = 1;
            obj1.descricao = "Brinquedos";
            arr.Add(obj1);

            Departamento obj2 = new Departamento();
            obj2.id = 2;
            obj2.descricao = "Eletrônicos";
            arr.Add(obj2);

            Departamento obj3 = new Departamento();
            obj3.id = 3;
            obj3.descricao = "Limpeza";
            arr.Add(obj3);

            return arr;
        }
    }
}
