using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.BLL
{
    class Lista
    {

        public List<Model.Lista> Select()
        {
            DAL.Lista dalLista = new DAL.Lista();
            return dalLista.Select();
        }

        public Model.Lista SelectPorID(int id)
        {
            DAL.Lista dalLista = new DAL.Lista();
            return dalLista.SelectPorID(id);
        }
    }
}
