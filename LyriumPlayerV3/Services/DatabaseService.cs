using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using LyriumPlayerV3.Models;
using System.Data;
using NAudio.Wave;
using System.Windows.Forms;


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

        public void SalvarMusica(string artista, string album, string caminhoMusicaSalva)
        {
            using (var conexao = GetConexao())
            using (var transacao = conexao.BeginTransaction())
            {
                try
                {
                    string nomeArquivo = Path.GetFileName(caminhoMusicaSalva);
                    TimeSpan duracao;

                    using (var reader = new AudioFileReader(caminhoMusicaSalva)) 
                    {
                        duracao = reader.TotalTime;
                    }

                    string query = @"INSERT INTO musicas (nome_arquivo, caminho_arquivo, artista, album, duracao, numero_reproducoes) 
                                     VALUES (@nomeArquivo, @caminhoArquivo, @artista, @album, @duracao, 0)";

                    using (var cmd = new SQLiteCommand(query, conexao))
                    {
                        cmd.Transaction = transacao;
                        cmd.Parameters.AddWithValue("@nomeArquivo", nomeArquivo);
                        cmd.Parameters.AddWithValue("@caminhoArquivo", caminhoMusicaSalva);
                        cmd.Parameters.AddWithValue("@artista", artista);
                        cmd.Parameters.AddWithValue("@album", album);
                        cmd.Parameters.AddWithValue("@duracao", Convert.ToInt32(duracao.TotalSeconds));
                        cmd.ExecuteNonQuery();
                    }
                    transacao.Commit();
                    MessageBox.Show("Música salva com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }


            }
        }
    }
}
