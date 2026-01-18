using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using LyriumPlayerV3.Models;

namespace LyriumPlayerV3.Services
{
    internal class DatabaseService
    {

        private readonly string _caminhoBanco;
        private readonly string _conexaoString;

        public DatabaseService()
        {
            _caminhoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB", "lyrium.db");

            _conexaoString = $"Data Source={_caminhoBanco};Version=3;";
        }


        public SQLiteConnection GetConexao()
        {
            var conexao = new SQLiteConnection(_conexaoString);
            conexao.Open(); 
            return conexao;
        }

        public string GetCaminhoBanco()
        {
            return _caminhoBanco;
        }

        public List<Musica> ListarMusicas() 
        {
            List<Musica> musicas = new List<Musica>();

            using (var conexao = GetConexao()) 
            {
                string query = @"SELECT Id, NomeArquivo, Artista, Album, Duracao FROM Musicas";
                using (var cmd = new SQLiteCommand(query, conexao))
                using (var reader = cmd.ExecuteReader()) 
                { 
                    while (reader.Read())
                    {
                        musicas.Add(new Musica
                        {
                            Id = reader.GetInt32(0),
                            NomeArquivo = reader.GetString(1),
                            Artista = reader.GetString(2),
                            Album = reader.GetString(3),
                            Duracao = TimeSpan.FromSeconds(reader.GetInt32(4))
                        });
                    }
                }


            }

            return musicas;

        }
       


    }
}
