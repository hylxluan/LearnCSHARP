using LyriumPlayerV3.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace LyriumPlayerV3
{
    public partial class frmPlayer : Form
    {
        private Button _botaoAtivo;
        private string _caminhoMusicaSalva;
        private AudioPlayerService _audioPlayerService = new AudioPlayerService();
        private DatabaseService _databaseService = new DatabaseService();
        private List<string> musicFiles = new List<string>();

        public frmPlayer()
        {
            InitializeComponent();
            
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
            dgListaSalvas.DataSource = _databaseService.ListarMusicas();
            PintarBotaoDeBuscarMusica();
        }

        private void pnlIndicador_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 3;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(panel.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void AtivarBotao(Button botao)
        {
            if (_botaoAtivo != null)
            {
                _botaoAtivo.BackColor = Color.Transparent;
                _botaoAtivo.ForeColor = Color.White;
            }

            _botaoAtivo = botao;
            _botaoAtivo.BackColor = Color.FromArgb(60, 60, 65);
            _botaoAtivo.ForeColor = Color.White;

            AnimarIndicador(pnlIndicador.Top, botao.Top);

            if (!pnlIndicador.Visible)
                pnlIndicador.Visible = true;
        }

        private void AnimarIndicador(int posicaoAtual, int posicaoFinal)
        {
            Timer animationTimer = new Timer { Interval = 10 };
            int distancia = posicaoFinal - posicaoAtual;
            int passos = 20;
            int incremento = distancia / passos;
            int contador = 0;

            animationTimer.Tick += (s, e) =>
            {
                if (contador++ < passos)
                    pnlIndicador.Top += incremento;
                else
                {
                    pnlIndicador.Top = posicaoFinal;
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };

            animationTimer.Start();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabInicio;
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabPlaylist;
        }

        private void btnMusicasSalvas_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabSalvas;
            dgListaSalvas.ClearSelection();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabManual;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabConfig;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_audioPlayerService.IsPlaying)
            {
                //_audioPlayerService.PausarReproducao();
                btnPlayPause.Image = Properties.Resources.icons8_play_dentro_de_um_círculo_50;
            }
            else
            {
                if (_audioPlayerService.IsPlaying == false && string.IsNullOrEmpty(_audioPlayerService.MusicaAtual))
                {
                    //_audioPlayerService.TocarReproducao(musicFiles[0]);
                    btnPlayPause.Image = Properties.Resources.icons8_pausa_circular_50;

                }
                else
                {
                    //_audioPlayerService.RetomarReproducao();
                    btnPlayPause.Image = Properties.Resources.icons8_pausa_circular_50;
                }
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {

        }

        private bool isRandom = false;
        private void btnFaixaAleatoria_Click(object sender, EventArgs e)
        {
            isRandom = !isRandom;

            if (isRandom)
            {
                btnFaixaAleatoria.Image = Properties.Resources.icons8_shuffle_50;
            }
            else
            {
                btnFaixaAleatoria.Image = Properties.Resources.icons8_shuffle_50_desativado;
            }
        }

        private bool isRepeat = false;
        private void btnRepetirFaixa_Click_1(object sender, EventArgs e)
        {
            isRepeat = !isRepeat;

            if (isRepeat)
            {
                btnRepetirFaixa.Image = Properties.Resources.icons8_repetir_50_ativado;
            }
            else
            {
                btnRepetirFaixa.Image = Properties.Resources.icons8_repetir_50;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabDashboard;
        }

        private void PintarBotaoDeBuscarMusica()
        {
            btnBuscarMusica.FlatStyle = FlatStyle.Flat;
            btnBuscarMusica.FlatAppearance.BorderColor = Color.Gray;
            btnBuscarMusica.FlatAppearance.BorderSize = 1;
            btnBuscarMusica.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 220, 220);
            btnBuscarMusica.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 180, 180);
        }

        private void btnBuscarMusica_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Selecione uma música";
            fileDialog.Filter = "Arquivos de Áudio|*.mp3;*.wav";
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _caminhoMusicaSalva = fileDialog.FileName;
            }

        }

        private void CopiarMusicaParaPasta(string caminhoMusica)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string musicDirectory = Path.Combine(baseDirectory, "Musicas");
            if (!Directory.Exists(musicDirectory))
            {
                Directory.CreateDirectory(musicDirectory);
            }
            string fileName = Path.GetFileName(caminhoMusica);
            string destinationPath = Path.Combine(musicDirectory, fileName);
            File.Copy(caminhoMusica, destinationPath, true);
        }

        private void btnSalvarMusica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtista.Text) ||
                string.IsNullOrWhiteSpace(txtAlbum.Text) ||
                string.IsNullOrWhiteSpace(_caminhoMusicaSalva)) 
            { 
                MessageBox.Show("Por favor, preencha todos os campos e selecione uma música antes de salvar.", "Campos Obrigatórios!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CopiarMusicaParaPasta(_caminhoMusicaSalva);

            _databaseService.SalvarMusica(txtArtista.Text, txtAlbum.Text, _caminhoMusicaSalva);

        }

        private void btnEditarMusica_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletarMusica_Click(object sender, EventArgs e)
        {

        }

        private void TabSalvas_Click(object sender, EventArgs e)
        {
            dgListaSalvas.ClearSelection();
        }

        private void groupDataSongs_Enter(object sender, EventArgs e)
        {
            dgListaSalvas.ClearSelection();
        }
    }
}