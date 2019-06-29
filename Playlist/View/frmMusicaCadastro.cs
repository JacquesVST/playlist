using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data.SqlTypes;

namespace Playlist.View
{
    public partial class frmMusicaCadastro : Form
    {

        private Camadas.Model.Musica musicaAtual = new Camadas.Model.Musica();
        private SoundPlayer player;

        FileStream fileStream = null;

        public frmMusicaCadastro()
        {
            InitializeComponent();
            musicaAtual.local = null;
        }

        private void frmMusicaCadastro_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Musica bllMusica = new Camadas.BLL.Musica();
            dgvMusicas.DataSource = bllMusica.Select();
        }

        private void carregarExibicao() {
            fileStream = new FileStream(musicaAtual.local, FileMode.Open);
            player = new SoundPlayer(musicaAtual.local);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtArtista.Clear();
            nudBpm.Value = 0;
            rtbDescricao.Clear();
            musicaAtual.local = null;
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                musicaAtual.local = open.FileName;
                carregarExibicao();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Musica bllMusica = new Camadas.BLL.Musica();
            musicaAtual.artista = txtArtista.Text;
            musicaAtual.titulo = txtTitulo.Text;
            musicaAtual.bpm = Convert.ToInt32(nudBpm.Value);
            musicaAtual.descricao = rtbDescricao.Text;
            musicaAtual.data = DateTime.Now;
            musicaAtual.usuario = Camadas.Model.Conexao.usuario;

            string dirMsc = @"C:\playlist\arquivosMusica\" + musicaAtual.artista + "-" + musicaAtual.titulo + ".wav";

            using (FileStream output = new FileStream(dirMsc, FileMode.Create))
            {
                fileStream.CopyTo(output);
            }
            musicaAtual.local = dirMsc;

            try
            {
                bllMusica.Insert(musicaAtual);
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }

            dgvMusicas.DataSource = bllMusica.Select();

            txtTitulo.Clear();
            txtArtista.Clear();
            nudBpm.Value = 0;
            rtbDescricao.Clear();
            musicaAtual.local = null;
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
