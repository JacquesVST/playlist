using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist.Camadas.BLL
{
    class Musica
    {
        public List<Model.Musica> Select()
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.Select();
        }

        public Model.Musica Select(int id)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.Select(id);
        }

        public void Insert(Model.Musica musica)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            if (musica.local == null) 
            {
                MessageBox.Show("Você deve escolher um arquivo", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                dalMusica.Insert(musica);
            }
        }

        public void Update(Model.Musica musica)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            dalMusica.Update(musica);
        }

        public void Delete(int id)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            dalMusica.Delete(id);
        }

        public List<Model.Musica> SelectPorUsuario(int id)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.SelectPorUsuario(id);
        }

        public List<Model.Musica> SelectPorTitulo(string titulo)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.SelectPorTitulo(titulo);
        }

        public List<Model.Musica> SelectPorArtista(string artista)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.SelectPorArtista(artista);
        }
    }
}
