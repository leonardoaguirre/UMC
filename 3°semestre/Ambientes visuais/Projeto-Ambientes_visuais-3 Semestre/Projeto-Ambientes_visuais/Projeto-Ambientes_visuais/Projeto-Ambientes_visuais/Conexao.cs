using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Ambientes_visuais
{
    class Conexao
    {
        public NpgsqlConnection getConexao()
        {
            string server = "127.0.0.1";
            string port = "5432";
            string user = "postgres";
            string pass = "postgres";
            string bd = "Sistema";

            NpgsqlConnection npgsqlConnection = null;
            string conString = String.Format("Server ={0}; Port ={1}; User Id = {2}; Password ={3}; Database ={4}; ", server, port, user, pass, bd);

            npgsqlConnection = new NpgsqlConnection(conString);

            return npgsqlConnection;
        }
    }
}
