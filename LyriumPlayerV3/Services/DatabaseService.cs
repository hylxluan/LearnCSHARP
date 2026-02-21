using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using LyriumPlayerV3.Models;
using System.Data;


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

        public DataTable ListarMusicas() 
        {
            DataTable musicas = new DataTable();


            using (var conexao = GetConexao()) 
            {
                string query = @"SELECT id, nome_arquivo, artista, album, duracao, numero_reproducoes FROM musicas";
                using (var cmd = new SQLiteCommand(query, conexao))
                using (var reader = cmd.ExecuteReader()) 
                {
                    musicas.Load(reader);
                   
                }


            }

            return musicas;

        }
       


    }
}
