using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Ambientes_visuais
{
    class Celular
    {
        public int id { get; set; }
        public string numero { get; set; }
        public int idcli { get; set; }

        public List<Celular> listarCelulares()
        {
            List<Celular> cli = new List<Celular>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from celular";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Celular cel = new Celular();
                    cel.id = Convert.ToInt16(dr["id"].ToString());
                    cel.numero = dr["numero"].ToString();
                    cel.idcli =Convert.ToInt32(dr["id_cli_fk"]);
                    cli.Add(cel);
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
        public List<Celular> buscarCelulares()
        {
            List<Celular> cli = new List<Celular>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from celular where id_cli_fk=" + this.idcli + ";";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Celular cel = new Celular();
                    cel.id = Convert.ToInt16(dr["id"].ToString());
                    cel.numero = dr["numero"].ToString();
                    cel.idcli = this.idcli;
                    cli.Add(cel);
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
        public bool excluir()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "delete from celular where id=" + this.id + ";";
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
        public List<Celular> buscarUnicoCelular()
        {
            List<Celular> cli = new List<Celular>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from celular where id=" + this.id + ";";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();


                dr.Read();
                Celular cel = new Celular();
                cel.id = Convert.ToInt16(dr["id"].ToString());
                cel.numero = dr["numero"].ToString();

                cli.Add(cel);

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
            public bool cadastrar()
            {
                NpgsqlConnection conex = null;
                try
                {
                    Conexao con = new Conexao();
                    conex = con.getConexao();
                    conex.Open();

                    string sql = "insert into celular(numero,id_cli_fk) values (@numero,@idcli);";

                    NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                    com.Parameters.AddWithValue("@numero", this.numero);
                    com.Parameters.AddWithValue("@idcli", Pessoa.idclifk);

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
        public bool alterar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "update celular set numero=@numero where id=@id";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@numero", this.numero);
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
    }
    }


