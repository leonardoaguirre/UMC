using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Ambientes_visuais
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public int id { get; set; }
        public int idcli { get; set; }

        public List<Endereco> listarEstados()
        {
            List<Endereco> est = new List<Endereco>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from estado;";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Endereco en = new Endereco();
                    en.estado = dr["nome"].ToString();
                    est.Add(en);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return est;
        }
        public bool cadastrar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "insert into endereco(cep,logradouro,numero,estado,bairro,cidade,id_cli_fk) values (@cep,@logradouro,@numero,@estado,@bairro,@cidade,@idcli);";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@cep", this.cep);
                com.Parameters.AddWithValue("@logradouro", this.logradouro);
                com.Parameters.AddWithValue("@numero", this.numero);
                com.Parameters.AddWithValue("@estado", this.estado);
                com.Parameters.AddWithValue("@bairro", this.bairro);
                com.Parameters.AddWithValue("@cidade", this.cidade);
                com.Parameters.AddWithValue("@idcli",Pessoa.idclifk);

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
        public List<Endereco> preencher()
        {
            NpgsqlConnection conex = null;
            List<Endereco> end = new List<Endereco>();
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from endereco ;";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {

                    Endereco en = new Endereco();
                    en.id = Convert.ToInt16(dr["id"].ToString());
                    en.cep = dr["cep"].ToString();
                    en.logradouro = dr["logradouro"].ToString();
                    en.numero = Convert.ToInt32(dr["numero"].ToString());
                    en.estado = dr["estado"].ToString();
                    en.bairro = dr["bairro"].ToString();
                    en.cidade = dr["cidade"].ToString();
                    en.idcli = Convert.ToInt32(dr["id_cli_fk"].ToString());


                    //en.pessoa = pes;
                    end.Add(en);
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
            return end;
        }
        public List<Endereco> buscarEndereco()
        {
            List<Endereco> end = new List<Endereco>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from endereco where id_cli_fk=" + this.idcli + ";";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Endereco en = new Endereco();
                    en.id = Convert.ToInt16(dr["id"].ToString());
                    en.cep = dr["cep"].ToString();
                    en.logradouro = dr["logradouro"].ToString();
                    en.numero = Convert.ToInt32(dr["numero"].ToString());
                    en.estado = dr["estado"].ToString();
                    en.bairro = dr["bairro"].ToString();
                    en.cidade = dr["cidade"].ToString();
                    en.idcli = this.idcli;
                    Pessoa pes = new Pessoa();

                    end.Add(en);
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
            return end;
        }
        public bool excluir()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "delete from endereco where id=" + this.id + ";";
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

                string sql = "update cliente set cep=@cep,logradouro=@logradouro,numero=@numero,estado=@estado,bairro=@bairro,cidade=@cidade where id=@id";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@cep", this.cep);
                com.Parameters.AddWithValue("@logradouro", this.logradouro);
                com.Parameters.AddWithValue("@numero", this.numero);
                com.Parameters.AddWithValue("@estado", this.estado);
                com.Parameters.AddWithValue("@bairro", this.bairro);
                com.Parameters.AddWithValue("@cidade", this.cidade);
                com.Parameters.AddWithValue("@id", this.id);

                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
        public List<Endereco> buscarUnicoEndereco()
        {
            List<Endereco> end = new List<Endereco>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from endereco where id=" + this.id + ";";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Endereco en = new Endereco();
                    en.id = Convert.ToInt16(dr["id"].ToString());
                    en.cep = dr["cep"].ToString();
                    en.logradouro = dr["logradouro"].ToString();
                    en.numero = Convert.ToInt32(dr["numero"].ToString());
                    en.estado = dr["estado"].ToString();
                    en.bairro = dr["bairro"].ToString();
                    en.cidade = dr["cidade"].ToString();


                    //en.pessoa = pes;
                    end.Add(en);
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
            return end;
        }
    }
}
