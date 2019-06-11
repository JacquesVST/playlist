using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.Model
{
    public class Album
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Artista artista { get; set; }
        public DateTime data { get; set; }
        public double preco { get; set; }
        public string descricao { get; set; }
        public string capa { get; set; }
        public int vendas { get; set; }
    }
}
