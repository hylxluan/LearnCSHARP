using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyriumPlayerV3.Models
{
    [Serializable]
    internal class Playlist
    {
        public int Id { get; set; }
        public string? NomePlaylist { get; set; }
        public string? DescricaoPlaylist { get; set; }
        public List<Musica>? MusicasPlaylist { get; set; }
    }
}
