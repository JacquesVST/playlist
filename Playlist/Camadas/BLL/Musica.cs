using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.BLL
{
    class Musica
    {
        public List<Model.Musica> Select()
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.Select();
        }

        public Model.Musica SelectPorID(int id)
        {
            DAL.Musica dalMusica = new DAL.Musica();
            return dalMusica.SelectPorID(id);
        }
    }
}
