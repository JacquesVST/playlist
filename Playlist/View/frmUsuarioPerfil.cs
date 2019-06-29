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
    public partial class frmUsuarioPerfil : Form
    {
        public Camadas.Model.Usuario usuarioAtual;
        public frmUsuarioPerfil()
        {
            InitializeComponent();


            Camadas.BLL.Usuario bllUsuario = new Camadas.BLL.Usuario();
            Camadas.Model.Usuario usuarioAtual = Camadas.Model.Conexao.usuario;

            picPerfil.Image = Image.FromFile(@"" + usuarioAtual.imagemPerfil);

            lblScreenName.Text = usuarioAtual.nomeTela;
            lblEmail.Text = usuarioAtual.email;

            DateTime dataAtual = DateTime.Now;
            lblIdade.Text = "Idade: " + (dataAtual.Year - usuarioAtual.dataNascimento.Year).ToString();

            rtbDescricao.Text = usuarioAtual.descricao;

            lblCompras.Text = "Músicas Compradas: " + bllUsuario.SelectCompras(usuarioAtual.id).ToString();
            lblEnvio.Text = "Músicas Enviadas: " + bllUsuario.SelectUploads(usuarioAtual.id).ToString();
            lblPlaylist.Text = "Playlists Criadas: " + bllUsuario.SelectListas(usuarioAtual.id).ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmUsuarioAtualizacao frmUsusarioAtualizacao = new frmUsuarioAtualizacao();
            frmUsusarioAtualizacao.ShowDialog();
            this.Dispose();
        }
    }
}
