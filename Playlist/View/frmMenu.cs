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
            frmUsuarioLogin frmUser = new frmUsuarioLogin();
            frmUser.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario frmUser = new frmUsuario();
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Camadas.Model.Conexao.usuario != null)
            {
                frmMusicaCadastro frmMsc = new frmMusicaCadastro();
                frmMsc.Show();
            } else
            {
                MessageBox.Show("Você deve estar logado para esta funççao", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
           
        }
    }
}
