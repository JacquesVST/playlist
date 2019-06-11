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
    public class Artista
    {

        private string strCon = Conexao.getConexao();
        private Usuario dalUsuario = new Usuario();

        public List<Model.Artista> Select()
        {
            List<Model.Artista> artistas = new List<Model.Artista>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Artista";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Artista artista = new Model.Artista();
                    artista.id = Convert.ToInt32(dados["id"].ToString());
                    artista.nome = dados["nome"].ToString();
                    artista.tipo = dados["tipo"].ToString();
                    artista.descricao = dados["descricao"].ToString();
                    artista.usuario = dalUsuario.SelectPorID(Convert.ToInt32(dados["id"].ToString()));
                    artistas.Add(artista);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar artistas");
            }
            finally
            {
                conexao.Close();
            }
            return artistas;
        }

        public Model.Artista SelectPorID(int id)
        {
            Model.Artista artista = new Model.Artista();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Artista where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    artista.id = Convert.ToInt32(dados["id"].ToString());
                    artista.nome = dados["nome"].ToString();
                    artista.tipo = dados["tipo"].ToString();
                    artista.descricao = dados["descricao"].ToString();
                    artista.usuario = dalUsuario.SelectPorID(Convert.ToInt32(dados["id_usuario"].ToString()));
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar artista");
            }
            finally
            {
                conexao.Close();
            }
            return artista;
        }
    }
}
