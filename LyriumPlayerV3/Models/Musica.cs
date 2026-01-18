using System;

namespace LyriumPlayerV3.Models
{

    [Serializable]
    internal class Musica
    {
        public int Id { get; set; }
        public string? NomeArquivo { get; set; }
        public string? CaminhoArquivo { get; set; }
        public string? Artista { get; set; }
        public string? Album { get; set; }
        public TimeSpan? Duracao { get; set; }
        public int? NumeroReproducoes { get; set; }
    }
}