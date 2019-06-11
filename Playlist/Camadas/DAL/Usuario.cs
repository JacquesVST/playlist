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
                    usuario.dataRegistro = Convert.ToDateTime(dados["data_registro"].ToString());
                    usuario.categoria = dados["categoria"].ToString();
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

        public Model.Usuario SelectPorID(int id)
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
                    usuario.dataNascimento = Convert.ToDateTime(dados["data_registro"].ToString());
                    usuario.categoria = dados["categoria"].ToString();
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

        public void Insert(Model.Usuario usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Usuario (nome_usuario, nome_tela, email, data_nascimento, data_registro, imagem_perfil, categoria) values (@nome_usuario, @nome_tela, @email, @data_nascimento, @data_registro, @imagem_perfil, @categoria);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome_usuario", usuario.nomeUsuario);
            cmd.Parameters.AddWithValue("@nome_tela", usuario.nomeTela);
            cmd.Parameters.AddWithValue("@email", usuario.email);
            cmd.Parameters.AddWithValue("@data_nascimento", usuario.dataNascimento);
            cmd.Parameters.AddWithValue("@data_registro", usuario.dataRegistro);
            cmd.Parameters.AddWithValue("@categoria", usuario.categoria);
            cmd.Parameters.AddWithValue("@imagem_perfil", usuario.imagemPerfil);
            //cmd.Parameters.AddWithValue("@descricao", usuario.descricao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("sucesso");
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
    }
}
