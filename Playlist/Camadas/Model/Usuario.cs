using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string nomeUsuario { get; set; }
        public string nomeTela { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataRegistro { get; set; }
        public string imagemPerfil { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
    }
}
