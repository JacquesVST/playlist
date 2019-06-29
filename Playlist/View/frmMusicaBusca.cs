using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist.View
{
    public partial class frmMusicaBusca : Form
    {
        private SoundPlayer player;
        Camadas.Model.Musica musicaAtual = new Camadas.Model.Musica();

        public frmMusicaBusca()
        {
            InitializeComponent();

            lblArtista.Text = "";
            lblTitulo.Text = "";
            lblBpm.Text = "BPM: ";
            lblDuracao.Text = "Duração: ";
            rtbDescricao.Text = "";
        }

        private void NaoEncontrado()
        {
            MessageBox.Show("Usuário não Encontrado", "Erro de busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void Atribuir()
        {
            lblArtista.Text = musicaAtual.artista;
            lblTitulo.Text = musicaAtual.titulo;
            lblBpm.Text = "BPM: " + musicaAtual.bpm.ToString();
            lblDuracao.Text = "Duração: " + musicaAtual.duracao.ToString();
            rtbDescricao.Text = musicaAtual.descricao;
            try
            {
                player = new SoundPlayer(@""+musicaAtual.local);
            }
            catch
            {

            }
            
        }

        private void frmMusicaBusca_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltroId_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Musica bllMusica = new Camadas.BLL.Musica();

            int id = Convert.ToInt32(txtFiltroId.Text);
            try
            {
                musicaAtual = bllMusica.Select(id);
                Atribuir();
            }
            catch
            {
                NaoEncontrado();
            }
        }

        private void dsbPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (musicaAtual.local == null)
            {
                if (dsbPlay.Checked)
                {
                    MessageBox.Show("Escolha um arquivo primeiro", "Erro ao reproduzir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                dsbPlay.Checked = false;

            }
            else
            {
                if (dsbPlay.Checked)
                {
                    dsbPlay.Text = "Pause";
                    player.Play();
                }
                else
                {
                    dsbPlay.Text = "Play";
                    player.Stop();
                }
            }

        }
    }
}
