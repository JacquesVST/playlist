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
    public class Lista
    {
        private string strCon = Conexao.getConexao();
        private Usuario dalUsuario = new Usuario();

        public List<Model.Lista> Select()
        {
            List<Model.Lista> listas = new List<Model.Lista>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Lista";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Lista lista = new Model.Lista();
                    lista.id = Convert.ToInt32(dados["id"].ToString());
                    lista.nome = dados["nome"].ToString();
                    lista.usuario = dalUsuario.SelectPorID(Convert.ToInt32(dados["id_usuario"].ToString()));
                    lista.data = Convert.ToDateTime(dados["data"].ToString());
                    lista.descricao = dados["descricao"].ToString();
                    lista.tamanho = Convert.ToInt32(dados["tamanho"].ToString());
                    listas.Add(lista);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao listar listas");
            }
            finally
            {
                conexao.Close();
            }
            return listas;
        }

        public Model.Lista SelectPorID(int id)
        {
            Model.Lista lista = new Model.Lista();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Lista where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    lista.id = Convert.ToInt32(dados["id"].ToString());
                    lista.nome = dados["nome"].ToString();
                    lista.usuario = dalUsuario.SelectPorID(Convert.ToInt32(dados["id_usuario"].ToString()));
                    lista.data = Convert.ToDateTime(dados["data"].ToString());
                    lista.descricao = dados["descricao"].ToString();
                    lista.tamanho = Convert.ToInt32(dados["tamanho"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Erro ao buscar lista");
            }
            finally
            {
                conexao.Close();
            }
            return lista;
        }
    }
}
