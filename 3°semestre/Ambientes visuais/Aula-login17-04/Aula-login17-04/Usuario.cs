using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Security.Cryptography;

namespace Aula_login17_04
{
    class Usuario
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        

        public Usuario()
        {

        }
        public bool logar()
        {
            
        }
        public static string GerarHashMd5(string input)
        {
            MD5
        }
        public bool logar()
        {
            return true;
        }
    }
}
