using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Ambientes_visuais
{
    
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public static int idclifk;

        public Pessoa()
        {

        }
        public Pessoa(int id,string nome,string email,string cpf,string rg)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.rg = rg;
        }
        public List<Pessoa> listarClientes()
        {
            List<Pessoa> cli = new List<Pessoa>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from cliente order by nome";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                NpgsqlDataReader dr = com.ExecuteReader();
               


                while (dr.Read())
                {
                    Pessoa pes = new Pessoa();
                    pes.id = Convert.ToInt16(dr["id"].ToString());
                    pes.nome = dr["nome"].ToString();
                    pes.email = dr["email"].ToString();
                    pes.rg = dr["rg"].ToString();
                    pes.cpf = dr["cpf"].ToString();

                    //Endereco en = new Endereco();
                    //en.preencher();

                    //pes.endereco = en;

                    cli.Add(pes);
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }
            return cli;
        }
        public List<Pessoa> buscarCli(string busca,string tipo)
        {
            List<Pessoa> pe = new List<Pessoa>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from cliente where " + tipo+" ilike('%" + busca + "%');";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Pessoa pes = new Pessoa();
                    pes.id = Convert.ToInt16(dr["id"].ToString());
                    pes.nome = dr["nome"].ToString();
                    pes.email = dr["email"].ToString();
                    pes.rg = dr["rg"].ToString();
                    pes.cpf = dr["cpf"].ToString();


                    pe.Add(pes);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }
            return pe;
        }
    
        public bool cadastrar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "insert into cliente(nome,email,cpf,rg) values (@nome,@email,@cpf,@rg) returning id;";
                NpgsqlCommand com = new NpgsqlCommand(sql,conex);
                com.Parameters.AddWithValue("@nome", this.nome);
                com.Parameters.AddWithValue("@email", this.email);
                com.Parameters.AddWithValue("@cpf", this.cpf);
                com.Parameters.AddWithValue("@rg", this.rg);
                com.Parameters.AddWithValue("@id", this.id);

                idclifk=Convert.ToInt32(com.ExecuteScalar());
                
                    return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool excluir()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex=con.getConexao();
                conex.Open();

                string sql = "delete from cliente where id=" + this.id + ";";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conex.Close();
            }
            
        }
        public bool alterar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "update cliente set nome=@nome ,email=@email ,cpf=@cpf ,rg=@rg where id=@id";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@nome", this.nome);
                com.Parameters.AddWithValue("@email", this.email);
                com.Parameters.AddWithValue("@cpf", this.cpf);
                com.Parameters.AddWithValue("@rg", this.rg);
                com.Parameters.AddWithValue("id", this.id);

                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public void preencher()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "select * from cliente where id=" + this.id + ";";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.nome = dr["nome"].ToString();
                this.email = dr["email"].ToString();
                this.rg = dr["rg"].ToString();
                this.cpf = dr["cpf"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
