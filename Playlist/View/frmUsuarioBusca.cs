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
    public partial class frmUsuarioBusca : Form
    {
        private Camadas.Model.Usuario usuarioAtual = new Camadas.Model.Usuario();
        public frmUsuarioBusca()
        {
            InitializeComponent();

            lblScreenName.Text = "";
            lblEmail.Text = "";
        }

        private void NaoEncontrado()
        {
            MessageBox.Show("Usuário não Encontrado", "Erro de busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void Atribuir()
        {
            picPerfil.Image = Image.FromFile(@"" + usuarioAtual.imagemPerfil);

            lblScreenName.Text = usuarioAtual.nomeTela;
            lblEmail.Text = usuarioAtual.email;

            DateTime dataAtual = DateTime.Now;
            lblIdade.Text = "Idade: " + (dataAtual.Year - usuarioAtual.dataNascimento.Year).ToString();

            rtbDescricao.Text = usuarioAtual.descricao;
        }

        private void btnFiltroId_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUsuario = new Camadas.BLL.Usuario();
            Camadas.DAL.Usuario dalUsuario = new Camadas.DAL.Usuario();
            List<string> usuariosPossiveis = dalUsuario.SelectNomeUsuario();

            int id;
            string user = txtFiltroId.Text;
            if (usuariosPossiveis.Contains(user))
            {
                usuarioAtual = bllUsuario.Select(user);
                this.Atribuir();
            }
            else if (int.TryParse(txtFiltroId.Text, out id))
            {
                try
                {
                    usuarioAtual = bllUsuario.Select(id);
                    this.Atribuir();
                }
                catch
                {
                    NaoEncontrado();
                }
            }
            else
            {
                NaoEncontrado();
            }
        }
    }
}
