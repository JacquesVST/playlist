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

namespace Playlist
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        Camadas.DAL.Usuario dalUsuario = new Camadas.DAL.Usuario();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = "";
            dgvUsuarios.DataSource = dalUsuario.Select();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camadas.Model.Usuario usuario = new Camadas.Model.Usuario();
            usuario.nomeUsuario = txtUsername.Text;
            usuario.nomeTela = txtScreenname.Text;
            usuario.email = txtEmail.Text;
            usuario.dataNascimento = dtpNascimento.Value;
            usuario.dataRegistro = DateTime.Now;
            usuario.categoria = cboCategoria.Text;
            usuario.descricao = null;

            string dirImg = @"C:\imagensPerfil\" + txtUsername.Text + ".bmp";

            ImageConverter converter = new ImageConverter();
            byte[] img = (byte[])converter.ConvertTo(picPerfil.Image, typeof(byte[]));

            System.IO.File.WriteAllBytes(dirImg, img);

            usuario.imagemPerfil = dirImg;

            try
            {
                dalUsuario.Insert(usuario);
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }

            dgvUsuarios.DataSource = "";
            dgvUsuarios.DataSource = dalUsuario.Select();
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
