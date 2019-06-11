using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.Model
{
    public class Musica
    {
        public int id { get; set; }
        public Artista artista { get; set; }
        public string titulo { get; set; }
        public Album album { get; set; }
        public int duracao { get; set; }
        public int bpm { get; set; }
        public Genero genero { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public string local { get; set; }
    }
}
