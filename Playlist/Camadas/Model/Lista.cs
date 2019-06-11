using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.Model
{
    public class Lista
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Usuario usuario { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public int tamanho { get; set; }
    }
}
