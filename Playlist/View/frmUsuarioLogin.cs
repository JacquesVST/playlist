using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist.View
{
    public partial class frmUsuarioLogin : Form
    {
        public frmUsuarioLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            Camadas.DAL.Usuario dalUser = new Camadas.DAL.Usuario();
            Camadas.Model.Usuario usuario = new Camadas.Model.Usuario();
            List<string> usuariosCadastrados = dalUser.SelectNomeUsuario();
            if (user == null || user == "")
            {
                MessageBox.Show("Insira o nome de usuário", "Erro ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                usuario = bllUser.Select(user);
                if (!usuariosCadastrados.Contains(usuario.nomeUsuario))
                {
                    MessageBox.Show("Nome de usuário não encontrado", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    Camadas.Model.Conexao.usuario = usuario;
                    this.Close();
                }
            }
            txtUsername.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Camadas.Model.Conexao.usuario = new Camadas.Model.Usuario();
            this.Close();
        }
    }
}
