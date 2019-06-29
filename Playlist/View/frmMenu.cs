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
    public partial class frmMenu : Form
    {
        public static frmMenu frmAtual;
        public frmMenu()
        {
            InitializeComponent();
            frmAtual = this;
            frmUsuarioLogin frmUsusarioLogin = new frmUsuarioLogin();
            frmUsusarioLogin.ShowDialog();
        }

        private void NotLogged()
        {
            MessageBox.Show("Você deve estar logado para esta função", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void FecharTodos()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodos();
            frmUsuarioLogin frmUsusarioLogin = new frmUsuarioLogin();
            frmUsusarioLogin.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FecharTodos();
            frmUsuario frmUsuarioCadastro = new frmUsuario();
            frmUsuarioCadastro.MdiParent = this;
            frmUsuarioCadastro.Show();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodos();
            if (Camadas.Model.Conexao.usuario != null)
            {
                frmMusicaCadastro frmMusicaCadastro = new frmMusicaCadastro();
                frmMusicaCadastro.MdiParent = this;
                frmMusicaCadastro.Show();
            }
            else
            {
                NotLogged();
            }
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodos();
            if (Camadas.Model.Conexao.usuario != null)
            {
                frmUsuarioPerfil frmUsuarioPerfil = new frmUsuarioPerfil();
                frmUsuarioPerfil.MdiParent = this;
                frmUsuarioPerfil.Show();
            }
            else
            {
                NotLogged();
            }

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodos();
            frmUsuarioBusca frmUsuarioBusca = new frmUsuarioBusca();
            frmUsuarioBusca.MdiParent = this;
            frmUsuarioBusca.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FecharTodos();
            if (Camadas.Model.Conexao.usuario != null)
            {
                frmMusicaBusca frmMusicaBusca = new frmMusicaBusca();
                frmMusicaBusca.MdiParent = this;
                frmMusicaBusca.Show();
            }
            else
            {
                NotLogged();
            }
        }
    }
}
