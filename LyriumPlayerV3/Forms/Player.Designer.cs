namespace LyriumPlayerV3
{
    partial class frmPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.PanelControles = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnMusicasSalvas = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnRepetirFaixa = new System.Windows.Forms.Button();
            this.btnFaixaAleatoria = new System.Windows.Forms.Button();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.TabPaginas = new System.Windows.Forms.TabControl();
            this.TabInicio = new System.Windows.Forms.TabPage();
            this.TabPlaylist = new System.Windows.Forms.TabPage();
            this.TabSalvas = new System.Windows.Forms.TabPage();
            this.TabManual = new System.Windows.Forms.TabPage();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabPaginas.SuspendLayout();
            this.TabInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControles
            // 
            this.PanelControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelControles.BackColor = System.Drawing.Color.DimGray;
            this.PanelControles.Controls.Add(this.btnConfig);
            this.PanelControles.Controls.Add(this.btnManual);
            this.PanelControles.Controls.Add(this.btnMusicasSalvas);
            this.PanelControles.Controls.Add(this.btnPlaylist);
            this.PanelControles.Controls.Add(this.btnInicio);
            this.PanelControles.Controls.Add(this.pnlIndicador);
            this.PanelControles.Controls.Add(this.Logo);
            this.PanelControles.Location = new System.Drawing.Point(-2, -2);
            this.PanelControles.Name = "PanelControles";
            this.PanelControles.Size = new System.Drawing.Size(197, 630);
            this.PanelControles.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::LyriumPlayerV3.Properties.Resources.icons8_configurações_24;
            this.btnConfig.Location = new System.Drawing.Point(14, 548);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(170, 45);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Image = global::LyriumPlayerV3.Properties.Resources.icons8_manual_do_usuário_24;
            this.btnManual.Location = new System.Drawing.Point(34, 450);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(131, 45);
            this.btnManual.TabIndex = 2;
            this.btnManual.Text = "Manual";
            this.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnMusicasSalvas
            // 
            this.btnMusicasSalvas.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicasSalvas.FlatAppearance.BorderSize = 0;
            this.btnMusicasSalvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicasSalvas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicasSalvas.Image = global::LyriumPlayerV3.Properties.Resources.icons8_pasta_de_música_24__1_;
            this.btnMusicasSalvas.Location = new System.Drawing.Point(34, 352);
            this.btnMusicasSalvas.Name = "btnMusicasSalvas";
            this.btnMusicasSalvas.Size = new System.Drawing.Size(131, 45);
            this.btnMusicasSalvas.TabIndex = 2;
            this.btnMusicasSalvas.Text = "Salvas";
            this.btnMusicasSalvas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusicasSalvas.UseVisualStyleBackColor = false;
            this.btnMusicasSalvas.Click += new System.EventHandler(this.btnMusicasSalvas_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Image = global::LyriumPlayerV3.Properties.Resources.icons8_lista_de_reprodução_de_vídeo_24;
            this.btnPlaylist.Location = new System.Drawing.Point(34, 254);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(131, 45);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::LyriumPlayerV3.Properties.Resources.icons8_casa_24;
            this.btnInicio.Location = new System.Drawing.Point(34, 156);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(131, 45);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(3, 156);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(5, 45);
            this.pnlIndicador.TabIndex = 1;
            this.pnlIndicador.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIndicador_Paint);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::LyriumPlayerV3.Properties.Resources.icons8_lírio_64;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(197, 97);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PanelInicio
            // 
            this.PanelInicio.BackColor = System.Drawing.Color.Transparent;
            this.PanelInicio.Controls.Add(this.pictureBox1);
            this.PanelInicio.Controls.Add(this.label1);
            this.PanelInicio.Controls.Add(this.btnProxima);
            this.PanelInicio.Controls.Add(this.btnPlayPause);
            this.PanelInicio.Controls.Add(this.btnRepetirFaixa);
            this.PanelInicio.Controls.Add(this.btnFaixaAleatoria);
            this.PanelInicio.Controls.Add(this.btnVoltarInicio);
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicio.Location = new System.Drawing.Point(3, 3);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(918, 617);
            this.PanelInicio.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LyriumPlayerV3.Properties.Resources.tocar_musica;
            this.pictureBox1.Location = new System.Drawing.Point(200, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fila de Reprodução";
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProxima.BackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatAppearance.BorderSize = 0;
            this.btnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.Color.Transparent;
            this.btnProxima.Image = global::LyriumPlayerV3.Properties.Resources.icons8_end_50;
            this.btnProxima.Location = new System.Drawing.Point(521, 520);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(61, 100);
            this.btnProxima.TabIndex = 2;
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Image = global::LyriumPlayerV3.Properties.Resources.icons8_play_dentro_de_um_círculo_50;
            this.btnPlayPause.Location = new System.Drawing.Point(392, 520);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(61, 100);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnRepetirFaixa
            // 
            this.btnRepetirFaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRepetirFaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.FlatAppearance.BorderSize = 0;
            this.btnRepetirFaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepetirFaixa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepetirFaixa.Image = global::LyriumPlayerV3.Properties.Resources.icons8_repetir_50;
            this.btnRepetirFaixa.Location = new System.Drawing.Point(650, 520);
            this.btnRepetirFaixa.Name = "btnRepetirFaixa";
            this.btnRepetirFaixa.Size = new System.Drawing.Size(61, 100);
            this.btnRepetirFaixa.TabIndex = 2;
            this.btnRepetirFaixa.UseVisualStyleBackColor = false;
            this.btnRepetirFaixa.Click += new System.EventHandler(this.btnRepetirFaixa_Click_1);
            // 
            // btnFaixaAleatoria
            // 
            this.btnFaixaAleatoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFaixaAleatoria.BackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.FlatAppearance.BorderSize = 0;
            this.btnFaixaAleatoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaixaAleatoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaixaAleatoria.Image = global::LyriumPlayerV3.Properties.Resources.icons8_shuffle_50_desativado;
            this.btnFaixaAleatoria.Location = new System.Drawing.Point(134, 520);
            this.btnFaixaAleatoria.Name = "btnFaixaAleatoria";
            this.btnFaixaAleatoria.Size = new System.Drawing.Size(61, 100);
            this.btnFaixaAleatoria.TabIndex = 2;
            this.btnFaixaAleatoria.UseVisualStyleBackColor = false;
            this.btnFaixaAleatoria.Click += new System.EventHandler(this.btnFaixaAleatoria_Click);
            this.btnFaixaAleatoria.MouseLeave += new System.EventHandler(this.btnFaixaAleatoria_MouseLeave);
            this.btnFaixaAleatoria.MouseHover += new System.EventHandler(this.btnFaixaAleatoria_MouseHover);
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.FlatAppearance.BorderSize = 0;
            this.btnVoltarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarInicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.Image = global::LyriumPlayerV3.Properties.Resources.icons8_skip_to_start_50;
            this.btnVoltarInicio.Location = new System.Drawing.Point(263, 520);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(61, 100);
            this.btnVoltarInicio.TabIndex = 2;
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // TabPaginas
            // 
            this.TabPaginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabPaginas.Controls.Add(this.TabInicio);
            this.TabPaginas.Controls.Add(this.TabPlaylist);
            this.TabPaginas.Controls.Add(this.TabSalvas);
            this.TabPaginas.Controls.Add(this.TabManual);
            this.TabPaginas.Controls.Add(this.TabConfig);
            this.TabPaginas.Location = new System.Drawing.Point(188, -2);
            this.TabPaginas.Name = "TabPaginas";
            this.TabPaginas.SelectedIndex = 0;
            this.TabPaginas.Size = new System.Drawing.Size(932, 649);
            this.TabPaginas.TabIndex = 2;
            // 
            // TabInicio
            // 
            this.TabInicio.BackgroundImage = global::LyriumPlayerV3.Properties.Resources.gradiente;
            this.TabInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabInicio.Controls.Add(this.PanelInicio);
            this.TabInicio.Location = new System.Drawing.Point(4, 4);
            this.TabInicio.Name = "TabInicio";
            this.TabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabInicio.Size = new System.Drawing.Size(924, 623);
            this.TabInicio.TabIndex = 0;
            this.TabInicio.Text = "TabInicio";
            this.TabInicio.UseVisualStyleBackColor = true;
            // 
            // TabPlaylist
            // 
            this.TabPlaylist.Location = new System.Drawing.Point(4, 4);
            this.TabPlaylist.Name = "TabPlaylist";
            this.TabPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlaylist.Size = new System.Drawing.Size(924, 623);
            this.TabPlaylist.TabIndex = 1;
            this.TabPlaylist.Text = "TabPlaylist";
            this.TabPlaylist.UseVisualStyleBackColor = true;
            // 
            // TabSalvas
            // 
            this.TabSalvas.Location = new System.Drawing.Point(4, 4);
            this.TabSalvas.Name = "TabSalvas";
            this.TabSalvas.Size = new System.Drawing.Size(924, 623);
            this.TabSalvas.TabIndex = 2;
            this.TabSalvas.Text = "TabSalvas";
            this.TabSalvas.UseVisualStyleBackColor = true;
            // 
            // TabManual
            // 
            this.TabManual.Location = new System.Drawing.Point(4, 4);
            this.TabManual.Name = "TabManual";
            this.TabManual.Size = new System.Drawing.Size(924, 623);
            this.TabManual.TabIndex = 3;
            this.TabManual.Text = "TabManual";
            this.TabManual.UseVisualStyleBackColor = true;
            // 
            // TabConfig
            // 
            this.TabConfig.Location = new System.Drawing.Point(4, 4);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Size = new System.Drawing.Size(924, 623);
            this.TabConfig.TabIndex = 4;
            this.TabConfig.Text = "TabConfig";
            this.TabConfig.UseVisualStyleBackColor = true;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LyriumPlayerV3.Properties.Resources.gradiente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 620);
            this.Controls.Add(this.PanelControles);
            this.Controls.Add(this.TabPaginas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyrium Player";
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            this.PanelControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabPaginas.ResumeLayout(false);
            this.TabInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControles;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnMusicasSalvas;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel PanelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnFaixaAleatoria;
        private System.Windows.Forms.Button btnRepetirFaixa;
        private System.Windows.Forms.TabControl TabPaginas;
        private System.Windows.Forms.TabPage TabInicio;
        private System.Windows.Forms.TabPage TabPlaylist;
        private System.Windows.Forms.TabPage TabSalvas;
        private System.Windows.Forms.TabPage TabManual;
        private System.Windows.Forms.TabPage TabConfig;
    }
}

