using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist.View
{
    public partial class frmUsuarioAtualizacao : Form
    {
        public frmUsuarioAtualizacao()
        {
            InitializeComponent();
            Camadas.Model.Usuario usuarioAtual = Camadas.Model.Conexao.usuario;

            picPerfil.Image = Image.FromFile(@"" + usuarioAtual.imagemPerfil);
            lblUsername.Text = "Editar perfil de " + usuarioAtual.nomeUsuario;
            txtScreenname.Text = usuarioAtual.nomeTela;
            rtbDescricao.Text = usuarioAtual.descricao;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUsuario = new Camadas.BLL.Usuario();
            Camadas.Model.Usuario usuario = Camadas.Model.Conexao.usuario;
            usuario.nomeTela = txtScreenname.Text;
            usuario.descricao = rtbDescricao.Text;


            ImageConverter converter = new ImageConverter();
            byte[] img = (byte[])converter.ConvertTo(picPerfil.Image, typeof(byte[]));
            try
            {
                string path = @"" + usuario.nomeUsuario + ".bmp";
                System.IO.File.WriteAllBytes(path, img);
                usuario.imagemPerfil = path;
            }
            catch
            {
                string path = @"" + usuario.nomeUsuario + "update.bmp";
                System.IO.File.WriteAllBytes(path, img);
                usuario.imagemPerfil = path;
            }

            try
            {
                bllUsuario.Update(usuario);
                Camadas.Model.Conexao.usuario = usuario;
                DialogResult = DialogResult.OK;
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            this.Close();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picPerfil.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
