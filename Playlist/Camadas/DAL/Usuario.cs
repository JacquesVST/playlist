using Playlist.Camadas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.DAL
{
    public class Usuario
    {

        private string strCon = Conexao.getConexao();

        public List<Model.Usuario> Select()
        {
            List<Model.Usuario> usuarios = new List<Model.Usuario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Usuario usuario = new Model.Usuario();
                    usuario.id = Convert.ToInt32(dados["id"].ToString());
                    usuario.nomeUsuario = dados["nome_usuario"].ToString();
                    usuario.nomeTela = dados["nome_tela"].ToString();
                    usuario.email = dados["email"].ToString();
                    usuario.dataNascimento = Convert.ToDateTime(dados["data_nascimento"].ToString());
                    usuario.imagemPerfil = dados["imagem_perfil"].ToString();
                    usuario.descricao = dados["descricao"].ToString();
                    usuarios.Add(usuario);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar usuarios");
            }
            finally
            {
                conexao.Close();
            }
            return usuarios;
        }

        public Model.Usuario Select(int id)
        {
            Model.Usuario usuario = new Model.Usuario();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuario where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    usuario.id = Convert.ToInt32(dados["id"].ToString());
                    usuario.nomeUsuario = dados["nome_usuario"].ToString();
                    usuario.nomeTela = dados["nome_tela"].ToString();
                    usuario.email = dados["email"].ToString();
                    usuario.dataNascimento = Convert.ToDateTime(dados["data_nascimento"].ToString());
                    usuario.imagemPerfil = dados["imagem_perfil"].ToString();
                    usuario.descricao = dados["descricao"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar usuario");
            }
            finally
            {
                conexao.Close();
            }
            return usuario;
        }

        public Model.Usuario Select(string nomeUsuario)
        {
            Model.Usuario usuario = new Model.Usuario();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Usuario where nome_usuario=@nome_usuario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome_usuario", nomeUsuario);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    usuario.id = Convert.ToInt32(dados["id"].ToString());
                    usuario.nomeUsuario = dados["nome_usuario"].ToString();
                    usuario.nomeTela = dados["nome_tela"].ToString();
                    usuario.email = dados["email"].ToString();
                    usuario.dataNascimento = Convert.ToDateTime(dados["data_nascimento"].ToString());
                    usuario.imagemPerfil = dados["imagem_perfil"].ToString();
                    usuario.descricao = dados["descricao"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar usuario");
            }
            finally
            {
                conexao.Close();
            }
            return usuario;
        }

        public List<string> SelectNomeUsuario()
        {
            List<string> usuarios = new List<string>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select nome_usuario from Usuario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    string nomeUsuario = dados["nome_usuario"].ToString();
                    usuarios.Add(nomeUsuario);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar nomes utilizados");
            }
            finally
            {
                conexao.Close();
            }
            return usuarios;
        }

        public void Insert(Model.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Usuario (nome_usuario, nome_tela, email, data_nascimento, imagem_perfil) values (@nome_usuario, @nome_tela, @email, @data_nascimento, @imagem_perfil);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome_usuario", usuario.nomeUsuario);
            cmd.Parameters.AddWithValue("@nome_tela", usuario.nomeTela);
            cmd.Parameters.AddWithValue("@email", usuario.email);
            cmd.Parameters.AddWithValue("@data_nascimento", usuario.dataNascimento);
            cmd.Parameters.AddWithValue("@imagem_perfil", usuario.imagemPerfil);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(Model.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Usuario set nome_usuario=@nome_usuario, nome_tela=@nome_tela, email=@email, data_nascimento=@data_nascimento, imagem_perfil=@imagem_perfil, descricao=@descricao where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", usuario.id);
            cmd.Parameters.AddWithValue("@nome_usuario", usuario.nomeUsuario);
            cmd.Parameters.AddWithValue("@nome_tela", usuario.nomeTela);
            cmd.Parameters.AddWithValue("@email", usuario.email);
            cmd.Parameters.AddWithValue("@data_nascimento", usuario.dataNascimento);
            cmd.Parameters.AddWithValue("@imagem_perfil", usuario.imagemPerfil);
            cmd.Parameters.AddWithValue("@descricao", usuario.descricao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Usuario where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        public int SelectCompras(int id)
        {
            int musicasCompradas = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select count(id_usuario) as uploads from Venda_Musica where id_usuario=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    musicasCompradas = Convert.ToInt32(dados["uploads"]);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao contar compras");
            }
            finally
            {
                conexao.Close();
            }
            return musicasCompradas;
        }

        public int SelectUploads(int id)
        {
            int musicasUpadas = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select count(id_usuario) as compras from Musica where id_usuario=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    musicasUpadas = Convert.ToInt32(dados["compras"]);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao contar uploads");
            }
            finally
            {
                conexao.Close();
            }
            return musicasUpadas;
        }

        public int SelectListas(int id)
        {
            int playlistsCriadas = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select count(id_usuario) as listas from Lista where id_usuario=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    playlistsCriadas = Convert.ToInt32(dados["listas"]);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao contar listas");
            }
            finally
            {
                conexao.Close();
            }
            return playlistsCriadas;
        }
    }
}
