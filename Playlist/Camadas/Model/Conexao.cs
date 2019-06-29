 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Camadas.Model
{
    public class Conexao
    {
        public static Usuario usuario;
        public static string getConexao()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=PLAYLIST2019;Integrated Security=True";
        }
    }
}
