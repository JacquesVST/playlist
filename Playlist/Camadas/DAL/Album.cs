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
    public class Album
    {
        private string strCon = Conexao.getConexao();
        private Artista dalArtista = new Artista();

        public List<Model.Album> Select()
        {
            List<Model.Album> albuns = new List<Model.Album>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Album";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Album album = new Model.Album();
                    album.id = Convert.ToInt32(dados["id"].ToString());
                    album.nome = dados["nome"].ToString();
                    album.artista = dalArtista.SelectPorID(Convert.ToInt32(dados["id_artista"].ToString()));
                    album.data = Convert.ToDateTime(dados["data"].ToString());
                    album.preco = Convert.ToDouble(dados["preco"].ToString());
                    album.descricao = dados["descricao"].ToString();
                    album.vendas = Convert.ToInt32(dados["vendas"].ToString());
                    albuns.Add(album);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar albuns");
            }
            finally
            {
                conexao.Close();
            }
            return albuns;
        }

        public Model.Album SelectPorID(int id)
        {
            Model.Album album = new Model.Album();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Album where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    album.id = Convert.ToInt32(dados["id"].ToString());
                    album.nome = dados["nome"].ToString();
                    album.artista = dalArtista.SelectPorID(Convert.ToInt32(dados["id_artista"].ToString()));
                    album.data = Convert.ToDateTime(dados["data"].ToString());
                    album.preco = Convert.ToDouble(dados["preco"].ToString());
                    album.descricao = dados["descricao"].ToString();
                    album.vendas = Convert.ToInt32(dados["vendas"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar album");
            }
            finally
            {
                conexao.Close();
            }
            return album;
        }
    }
}
