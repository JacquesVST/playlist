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
    public class Musica
    {
        private string strCon = Conexao.getConexao();
        private Usuario dalUser = new Usuario();

        public List<Model.Musica> Select()
        {
            List<Model.Musica> musicas = new List<Model.Musica>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Musica";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Musica musica = new Model.Musica();
                    musica.id = Convert.ToInt32(dados["id"].ToString());
                    musica.artista = dados["artista"].ToString();
                    musica.titulo = dados["nome"].ToString();
                    musica.duracao = Convert.ToInt32(dados["duracao"].ToString());
                    musica.bpm = Convert.ToInt32(dados["bpm"].ToString());
                    musica.data = Convert.ToDateTime(dados["data"].ToString());
                    musica.descricao = dados["descricao"].ToString();
                    musica.local = dados["local"].ToString();
                    musica.usuario = dalUser.Select(Convert.ToInt32(dados["id_usuario"].ToString()));
                    musicas.Add(musica);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar musicas");
            }
            finally
            {
                conexao.Close();
            }
            return musicas;
        }

        public Model.Musica Select(int id)
        {
            Model.Musica musica = new Model.Musica();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Musica where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    musica.id = Convert.ToInt32(dados["id"].ToString());
                    musica.artista = dados["artista"].ToString();
                    musica.titulo = dados["nome"].ToString();
                    musica.duracao = Convert.ToInt32(dados["duracao"].ToString());
                    musica.bpm = Convert.ToInt32(dados["bpm"].ToString());
                    musica.data = Convert.ToDateTime(dados["data"].ToString());
                    musica.descricao = dados["descricao"].ToString();
                    musica.usuario = dalUser.Select(Convert.ToInt32(dados["id_usuario"].ToString()));
                    musica.local = dados["local"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar musica");
            }
            finally
            {
                conexao.Close();
            }
            return musica;
        }

        public void Insert(Model.Musica musica)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Musica (artista, titulo, duracao, bpm, data, descricao, local, id_usuario) values (@artista, @titulo, @duracao, @bpm, @data, @descricao, @local, @id_usuario);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@artista", musica.artista);
            cmd.Parameters.AddWithValue("@titulo", musica.titulo);
            cmd.Parameters.AddWithValue("@duracao", musica.duracao);
            cmd.Parameters.AddWithValue("@bpm", musica.bpm);
            cmd.Parameters.AddWithValue("@data", musica.data);
            cmd.Parameters.AddWithValue("@descricao", musica.descricao);
            cmd.Parameters.AddWithValue("@local", musica.local);
            cmd.Parameters.AddWithValue("@id_usuario", musica.usuario.id);
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

        public void Update(Model.Musica musica)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Musica set artista=@artista, titulo=@titulo, duracao=@duracao, bpm=@bpm, data=@data, descricao=@descricao, local=@local, id_usuario=@id_usuario where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", musica.id);
            cmd.Parameters.AddWithValue("@artista", musica.artista);
            cmd.Parameters.AddWithValue("@titulo", musica.titulo);
            cmd.Parameters.AddWithValue("@duracao", musica.duracao);
            cmd.Parameters.AddWithValue("@bpm", musica.bpm);
            cmd.Parameters.AddWithValue("@data", musica.data);
            cmd.Parameters.AddWithValue("@descricao", musica.descricao);
            cmd.Parameters.AddWithValue("@local", musica.local);
            cmd.Parameters.AddWithValue("@id_usuario", musica.usuario.id);
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
            string sql = "Delete from Musica where id=@id";
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

        public List<Model.Musica> SelectPorUsuario(int id)
        {
            List<Model.Musica> musicas = new List<Model.Musica>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Musica where id_usuario=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Musica musica = new Model.Musica();
                    musica.id = Convert.ToInt32(dados["id"].ToString());
                    musica.artista = dados["artista"].ToString();
                    musica.titulo = dados["nome"].ToString();
                    musica.duracao = Convert.ToInt32(dados["duracao"].ToString());
                    musica.bpm = Convert.ToInt32(dados["bpm"].ToString());
                    musica.data = Convert.ToDateTime(dados["data"].ToString());
                    musica.descricao = dados["descricao"].ToString();
                    musica.local = dados["local"].ToString();
                    musica.usuario = dalUser.Select(Convert.ToInt32(dados["id_usuario"].ToString()));
                    musicas.Add(musica);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar musicas");
            }
            finally
            {
                conexao.Close();
            }
            return musicas;
        }

        public List<Model.Musica> SelectPorTitulo(string titulo)
        {
            List<Model.Musica> musicas = new List<Model.Musica>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Musica where titulo like @titulo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@titulo", "%" + titulo + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Musica musica = new Model.Musica();
                    musica.id = Convert.ToInt32(dados["id"].ToString());
                    musica.artista = dados["artista"].ToString();
                    musica.titulo = dados["nome"].ToString();
                    musica.duracao = Convert.ToInt32(dados["duracao"].ToString());
                    musica.bpm = Convert.ToInt32(dados["bpm"].ToString());
                    musica.data = Convert.ToDateTime(dados["data"].ToString());
                    musica.descricao = dados["descricao"].ToString();
                    musica.local = dados["local"].ToString();
                    musica.usuario = dalUser.Select(Convert.ToInt32(dados["id_usuario"].ToString()));
                    musicas.Add(musica);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar musicas");
            }
            finally
            {
                conexao.Close();
            }
            return musicas;
        }

        public List<Model.Musica> SelectPorArtista(string artista)
        {
            List<Model.Musica> musicas = new List<Model.Musica>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Musica where artista like @artista";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@titulo", "%" + artista + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Musica musica = new Model.Musica();
                    musica.id = Convert.ToInt32(dados["id"].ToString());
                    musica.artista = dados["artista"].ToString();
                    musica.titulo = dados["nome"].ToString();
                    musica.duracao = Convert.ToInt32(dados["duracao"].ToString());
                    musica.bpm = Convert.ToInt32(dados["bpm"].ToString());
                    musica.data = Convert.ToDateTime(dados["data"].ToString());
                    musica.descricao = dados["descricao"].ToString();
                    musica.local = dados["local"].ToString();
                    musica.usuario = dalUser.Select(Convert.ToInt32(dados["id_usuario"].ToString()));
                    musicas.Add(musica);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar musicas");
            }
            finally
            {
                conexao.Close();
            }
            return musicas;
        }
    }
}
