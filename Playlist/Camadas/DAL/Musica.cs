using Playlist.Camadas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public Model.Musica SelectPorID(int id)
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
    }
}
