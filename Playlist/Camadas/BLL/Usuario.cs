using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist.Camadas.BLL
{
    class Usuario
    {
        public List<Model.Usuario> Select()
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            return dalUser.Select();
        }

        public Model.Usuario Select(int id)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            return dalUser.Select(id);
        }

        public Model.Usuario Select(string user)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            return dalUser.Select(user);
        }

        public void Insert(Model.Usuario usuario)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            List<string> nomesIndisponiveis = dalUser.SelectNomeUsuario();
            usuario.nomeUsuario = usuario.nomeUsuario.Trim();
            if (nomesIndisponiveis.Contains(usuario.nomeUsuario))
            {
                MessageBox.Show("Nome de usuário Indisponível", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            } else
            {
                dalUser.Insert(usuario);
            }
            
        }

        public void Update(Model.Usuario usuario)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            dalUser.Update(usuario);
        }

        public void Delete(int id)
        {
            DAL.Usuario dalUser = new DAL.Usuario();
            dalUser.Delete(id);
        }
    
    }
}
 