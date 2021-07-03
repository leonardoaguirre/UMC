using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Security.Cryptography;

namespace Projeto_Ambientes_visuais
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public static string nomeUsu { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }

        public bool logar()
        {
            NpgsqlConnection npgsqlConnection = null;
            try
            {
                Conexao objCon = new Conexao();
                npgsqlConnection = objCon.getConexao();
                npgsqlConnection.Open();

                string sql = "select * from usuario where usuario='" + this.usuario + "' and senha='" + gerarMD5(this.senha) + "'LIMIT 1;";
                NpgsqlCommand command = new NpgsqlCommand(sql, npgsqlConnection);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    if (this.usuario == dataReader["usuario"].ToString() && gerarMD5(this.senha) == dataReader["senha"].ToString())
                    {
                        nomeUsu = dataReader["nome"].ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                npgsqlConnection.Close();
            }
        }
        public static string gerarMD5(string senha)
        {
            MD5 md5 = MD5.Create();

            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }
        public bool cadastrar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "insert into usuario(usuario,nome,senha,cpf,rg) values (@usuario,@nome,@senha,@cpf,@rg);";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                com.Parameters.AddWithValue("@usuario", this.usuario);
                com.Parameters.AddWithValue("@nome", this.nome);
                com.Parameters.AddWithValue("@senha", gerarMD5(this.senha));
                com.Parameters.AddWithValue("@cpf",this.cpf);
                com.Parameters.AddWithValue("@rg", this.rg);

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
        public bool procurar()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from usuario where usuario=@usuario and rg=@rg and cpf=@cpf;";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                com.Parameters.AddWithValue("@usuario", this.usuario);
                com.Parameters.AddWithValue("@cpf", this.cpf);
                com.Parameters.AddWithValue("@rg", this.rg);

                NpgsqlDataReader rd = com.ExecuteReader();
                if (rd.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
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
        }
        public void recuperar()
        {
            NpgsqlConnection conex=null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "update usuario set senha=@senha where usuario=@usuario and rg=@rg and cpf=@cpf";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                com.Parameters.AddWithValue("@usuario", this.usuario);
                com.Parameters.AddWithValue("@cpf", this.cpf);
                com.Parameters.AddWithValue("@rg", this.rg);
                com.Parameters.AddWithValue("@senha", gerarMD5(this.senha));

                com.ExecuteNonQuery();
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
        public List<Usuario> listarUsuarios()
        {
            List<Usuario> us = new List<Usuario>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from usuario order by nome";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);
                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Usuario usu = new Usuario();
                    usu.id = Convert.ToInt16(dr["id"].ToString());
                    usu.nome = dr["nome"].ToString();
                    usu.usuario = dr["usuario"].ToString();
                    usu.rg = dr["rg"].ToString();
                    usu.cpf = dr["cpf"].ToString();

                    us.Add(usu);
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
            return us;
        }
        public List<Usuario> buscarUsuario(string busca, string tipo)
        {
            List<Usuario> us = new List<Usuario>();
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "select * from usuario where " + tipo + " ilike('%" + busca + "%');";

                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                NpgsqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
                {
                    Usuario usu = new Usuario();
                    usu.id = Convert.ToInt16(dr["id"].ToString());
                    usu.nome = dr["nome"].ToString();
                    usu.usuario = dr["usuario"].ToString();
                    usu.rg = dr["rg"].ToString();
                    usu.cpf = dr["cpf"].ToString();


                    us.Add(usu);
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
            return us;
        }
        public bool excluir()
        {
            NpgsqlConnection conex = null;
            try
            {
                Conexao con = new Conexao();
                conex = con.getConexao();
                conex.Open();

                string sql = "delete from usuario where id=" + this.id + ";";
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

                string sql = "update usuario set nome=@nome ,usuario=@email ,cpf=@cpf ,rg=@rg where id=@id";
                NpgsqlCommand com = new NpgsqlCommand(sql, conex);

                com.Parameters.AddWithValue("@nome", this.nome);
                com.Parameters.AddWithValue("@email", this.usuario);
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

                string sql = "select * from usuario where id=" + this.id + ";";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.nome = dr["nome"].ToString();
                this.usuario = dr["usuario"].ToString();
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
