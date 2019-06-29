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
            picPerfil.Image = Image.FromFile(@"C:\playlist\imagensPerfil\padrao.bmp");
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUsuario = new Camadas.BLL.Usuario();
            dgvUsuarios.DataSource = "";
            dgvUsuarios.DataSource = bllUsuario.Select();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUsuario = new Camadas.BLL.Usuario();
            Camadas.Model.Usuario usuario = new Camadas.Model.Usuario();
            usuario.nomeUsuario = txtUsername.Text;
            usuario.nomeTela = txtScreenname.Text;
            usuario.email = txtEmail.Text;
            usuario.dataNascimento = dtpNascimento.Value;
            usuario.descricao = null;
            
            string dirImg = @"" + txtUsername.Text + ".bmp";

                ImageConverter converter = new ImageConverter();
                byte[] img = (byte[])converter.ConvertTo(picPerfil.Image, typeof(byte[]));
                System.IO.File.WriteAllBytes(dirImg, img);

            usuario.imagemPerfil = dirImg;
            try
            {
                bllUsuario.Insert(usuario);
                Camadas.Model.Conexao.usuario = usuario;
            }
            catch (SqlTypeException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }

            dgvUsuarios.DataSource = bllUsuario.Select();

            txtUsername.Clear();
            txtScreenname.Clear();
            txtEmail.Clear();
            dtpNascimento.ResetText();
            picPerfil.Image = Image.FromFile(@"C:\playlist\imagensPerfil\padrao.bmp");
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picPerfil.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtScreenname.Clear();
            txtEmail.Clear();
            dtpNascimento.ResetText();
            picPerfil.Image = Image.FromFile(@"C:\playlist\imagensPerfil\padrao.bmp");
        }

    }
}
