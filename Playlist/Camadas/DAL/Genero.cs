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
    public class Genero
    {

        private string strCon = Conexao.getConexao();

        public List<Model.Genero> Select()
        {
            List<Model.Genero> generos = new List<Model.Genero>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Genero";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Genero genero = new Model.Genero();
                    genero.id = Convert.ToInt32(dados["id"].ToString());
                    genero.nome = dados["nome"].ToString();
                    generos.Add(genero);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar generos");
            }
            finally
            {
                conexao.Close();
            }
            return generos;
        }

        public Model.Genero SelectPorID(int id)
        {
            Model.Genero genero = new Model.Genero();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Genero where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    genero.id = Convert.ToInt32(dados["id"].ToString());
                    genero.nome = dados["nome"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar genero");
            }
            finally
            {
                conexao.Close();
            }
            return genero;
        }
    }
}
