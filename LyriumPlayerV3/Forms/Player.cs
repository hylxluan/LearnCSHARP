using LyriumPlayerV3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyriumPlayerV3
{
    public partial class frmPlayer : Form
    {
        private Button _botaoAtivo;
        private AudioPlayerService _audioPlayerService = new AudioPlayerService();
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void pnlIndicador_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Criar forma arredondada
            int radius = 3; // Raio das bordas
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Aplicar região arredondada
                panel.Region = new Region(path);

                // Preencher com a cor
                using (SolidBrush brush = new SolidBrush(panel.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }


        // ===== MÉTODOS PARA USAR DEPOIS (QUANDO CRIAR BOTÕES) =====
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

        private void frmPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabPlaylist;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabInicio;


        }

        private void btnMusicasSalvas_Click(object sender, EventArgs e)
        {
            AtivarBotao((Button)sender);
            TabPaginas.SelectedTab = TabSalvas;
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

        private void btnProxima_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {

        }

        private bool isPlaying = false;
        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            isPlaying = !isPlaying;

            if (isPlaying)
            {
                btnPlayPause.Image = Properties.Resources.icons8_pausa_circular_50;
            }
            else
            {
                btnPlayPause.Image = Properties.Resources.icons8_play_dentro_de_um_círculo_50; 
            }

        }


        private void btnFaixaAleatoria_MouseHover(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

        }

        private void btnFaixaAleatoria_MouseLeave(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
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

    }
}
