using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Ambientes_visuais
{
    class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public double custo { get; set; }
        public string departamento { get; set; }
        public bool cadastrar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "insert into produto(nome,descricao,preco,custo,departamento) values (@nome,@descricao,@preco,@custo,@departamento)";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@nome", this.nome);
                com.Parameters.AddWithValue("@descricao", this.descricao);
                com.Parameters.AddWithValue("@preco", this.preco);
                com.Parameters.AddWithValue("@custo", this.custo);
                com.Parameters.AddWithValue("@departamento", this.departamento);

                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conex.Close();
            }
        }
    }
}
