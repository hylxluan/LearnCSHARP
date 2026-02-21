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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.PanelControles = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMusicasSalvas = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.labelMusica = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupDataSongs = new System.Windows.Forms.GroupBox();
            this.btnBuscarMusica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.dgListaSalvas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_reproducoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabDashboard = new System.Windows.Forms.TabPage();
            this.TabManual = new System.Windows.Forms.TabPage();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabPaginas.SuspendLayout();
            this.TabInicio.SuspendLayout();
            this.TabSalvas.SuspendLayout();
            this.groupDataSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSalvas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControles
            // 
            this.PanelControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelControles.BackColor = System.Drawing.Color.DimGray;
            this.PanelControles.Controls.Add(this.btnConfig);
            this.PanelControles.Controls.Add(this.btnManual);
            this.PanelControles.Controls.Add(this.btnDashboard);
            this.PanelControles.Controls.Add(this.btnMusicasSalvas);
            this.PanelControles.Controls.Add(this.btnPlaylist);
            this.PanelControles.Controls.Add(this.btnInicio);
            this.PanelControles.Controls.Add(this.pnlIndicador);
            this.PanelControles.Controls.Add(this.Logo);
            this.PanelControles.Location = new System.Drawing.Point(-2, -2);
            this.PanelControles.Name = "PanelControles";
            this.PanelControles.Size = new System.Drawing.Size(197, 780);
            this.PanelControles.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConfig.Image = global::LyriumPlayerV3.Properties.Resources.icons8_configurações_24;
            this.btnConfig.Location = new System.Drawing.Point(14, 621);
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
            this.btnManual.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnManual.Image = global::LyriumPlayerV3.Properties.Resources.icons8_manual_do_usuário_24;
            this.btnManual.Location = new System.Drawing.Point(34, 528);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(131, 45);
            this.btnManual.TabIndex = 2;
            this.btnManual.Text = "Manual";
            this.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDashboard.Image = global::LyriumPlayerV3.Properties.Resources.icons8_gráfico_de_barras_24;
            this.btnDashboard.Location = new System.Drawing.Point(34, 435);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMusicasSalvas
            // 
            this.btnMusicasSalvas.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicasSalvas.FlatAppearance.BorderSize = 0;
            this.btnMusicasSalvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicasSalvas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicasSalvas.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMusicasSalvas.Image = global::LyriumPlayerV3.Properties.Resources.icons8_pasta_de_música_24__1_;
            this.btnMusicasSalvas.Location = new System.Drawing.Point(34, 342);
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
            this.btnPlaylist.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPlaylist.Image = global::LyriumPlayerV3.Properties.Resources.icons8_lista_de_reprodução_de_vídeo_24;
            this.btnPlaylist.Location = new System.Drawing.Point(34, 249);
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
            this.btnInicio.ForeColor = System.Drawing.Color.AliceBlue;
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
            this.PanelInicio.Controls.Add(this.label3);
            this.PanelInicio.Controls.Add(this.lblSeg);
            this.PanelInicio.Controls.Add(this.lblMin);
            this.PanelInicio.Controls.Add(this.labelMusica);
            this.PanelInicio.Controls.Add(this.label2);
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
            this.PanelInicio.Size = new System.Drawing.Size(918, 691);
            this.PanelInicio.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(821, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeg.Location = new System.Drawing.Point(850, 596);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(48, 31);
            this.lblSeg.TabIndex = 6;
            this.lblSeg.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(767, 596);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(48, 31);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "00";
            // 
            // labelMusica
            // 
            this.labelMusica.AutoSize = true;
            this.labelMusica.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusica.Location = new System.Drawing.Point(163, 450);
            this.labelMusica.Name = "labelMusica";
            this.labelMusica.Size = new System.Drawing.Size(332, 21);
            this.labelMusica.TabIndex = 4;
            this.labelMusica.Text = "Não há nenhum som tocando, meu nobre!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tocando:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LyriumPlayerV3.Properties.Resources.tocar_musica;
            this.pictureBox1.Location = new System.Drawing.Point(204, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reprodução";
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProxima.BackColor = System.Drawing.Color.Transparent;
            this.btnProxima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProxima.FlatAppearance.BorderSize = 0;
            this.btnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.Color.Transparent;
            this.btnProxima.Image = global::LyriumPlayerV3.Properties.Resources.icons8_end_50;
            this.btnProxima.Location = new System.Drawing.Point(523, 550);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(61, 126);
            this.btnProxima.TabIndex = 2;
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Image = global::LyriumPlayerV3.Properties.Resources.icons8_play_dentro_de_um_círculo_50;
            this.btnPlayPause.Location = new System.Drawing.Point(394, 550);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(61, 126);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnRepetirFaixa
            // 
            this.btnRepetirFaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRepetirFaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepetirFaixa.FlatAppearance.BorderSize = 0;
            this.btnRepetirFaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRepetirFaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepetirFaixa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepetirFaixa.Image = global::LyriumPlayerV3.Properties.Resources.icons8_repetir_50;
            this.btnRepetirFaixa.Location = new System.Drawing.Point(652, 550);
            this.btnRepetirFaixa.Name = "btnRepetirFaixa";
            this.btnRepetirFaixa.Size = new System.Drawing.Size(61, 126);
            this.btnRepetirFaixa.TabIndex = 2;
            this.btnRepetirFaixa.UseVisualStyleBackColor = false;
            this.btnRepetirFaixa.Click += new System.EventHandler(this.btnRepetirFaixa_Click_1);
            // 
            // btnFaixaAleatoria
            // 
            this.btnFaixaAleatoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFaixaAleatoria.BackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaixaAleatoria.FlatAppearance.BorderSize = 0;
            this.btnFaixaAleatoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFaixaAleatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaixaAleatoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaixaAleatoria.Image = global::LyriumPlayerV3.Properties.Resources.icons8_shuffle_50_desativado;
            this.btnFaixaAleatoria.Location = new System.Drawing.Point(136, 550);
            this.btnFaixaAleatoria.Name = "btnFaixaAleatoria";
            this.btnFaixaAleatoria.Size = new System.Drawing.Size(61, 126);
            this.btnFaixaAleatoria.TabIndex = 2;
            this.btnFaixaAleatoria.UseVisualStyleBackColor = false;
            this.btnFaixaAleatoria.Click += new System.EventHandler(this.btnFaixaAleatoria_Click);
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarInicio.FlatAppearance.BorderSize = 0;
            this.btnVoltarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarInicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.Image = global::LyriumPlayerV3.Properties.Resources.icons8_skip_to_start_50;
            this.btnVoltarInicio.Location = new System.Drawing.Point(265, 550);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(61, 126);
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
            this.TabPaginas.Controls.Add(this.TabDashboard);
            this.TabPaginas.Controls.Add(this.TabManual);
            this.TabPaginas.Controls.Add(this.TabConfig);
            this.TabPaginas.Location = new System.Drawing.Point(188, -2);
            this.TabPaginas.Name = "TabPaginas";
            this.TabPaginas.SelectedIndex = 0;
            this.TabPaginas.Size = new System.Drawing.Size(932, 723);
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
            this.TabInicio.Size = new System.Drawing.Size(924, 697);
            this.TabInicio.TabIndex = 0;
            this.TabInicio.Text = "TabInicio";
            this.TabInicio.UseVisualStyleBackColor = true;
            // 
            // TabPlaylist
            // 
            this.TabPlaylist.Location = new System.Drawing.Point(4, 4);
            this.TabPlaylist.Name = "TabPlaylist";
            this.TabPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlaylist.Size = new System.Drawing.Size(924, 697);
            this.TabPlaylist.TabIndex = 1;
            this.TabPlaylist.Text = "TabPlaylist";
            this.TabPlaylist.UseVisualStyleBackColor = true;
            // 
            // TabSalvas
            // 
            this.TabSalvas.BackgroundImage = global::LyriumPlayerV3.Properties.Resources.gradiente;
            this.TabSalvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabSalvas.Controls.Add(this.groupDataSongs);
            this.TabSalvas.Controls.Add(this.dgListaSalvas);
            this.TabSalvas.Location = new System.Drawing.Point(4, 4);
            this.TabSalvas.Name = "TabSalvas";
            this.TabSalvas.Size = new System.Drawing.Size(924, 697);
            this.TabSalvas.TabIndex = 2;
            this.TabSalvas.Text = "TabSalvas";
            this.TabSalvas.UseVisualStyleBackColor = true;
            // 
            // groupDataSongs
            // 
            this.groupDataSongs.Controls.Add(this.btnBuscarMusica);
            this.groupDataSongs.Controls.Add(this.label5);
            this.groupDataSongs.Controls.Add(this.label4);
            this.groupDataSongs.Controls.Add(this.txtAlbum);
            this.groupDataSongs.Controls.Add(this.txtArtista);
            this.groupDataSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupDataSongs.Location = new System.Drawing.Point(9, 10);
            this.groupDataSongs.Name = "groupDataSongs";
            this.groupDataSongs.Size = new System.Drawing.Size(900, 161);
            this.groupDataSongs.TabIndex = 4;
            this.groupDataSongs.TabStop = false;
            this.groupDataSongs.Text = "Dados da Música";
            // 
            // btnBuscarMusica
            // 
            this.btnBuscarMusica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMusica.BackColor = System.Drawing.Color.White;
            this.btnBuscarMusica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMusica.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMusica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBuscarMusica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBuscarMusica.Location = new System.Drawing.Point(738, 48);
            this.btnBuscarMusica.Name = "btnBuscarMusica";
            this.btnBuscarMusica.Size = new System.Drawing.Size(156, 35);
            this.btnBuscarMusica.TabIndex = 8;
            this.btnBuscarMusica.TabStop = false;
            this.btnBuscarMusica.Text = "Buscar Música";
            this.btnBuscarMusica.UseVisualStyleBackColor = false;
            this.btnBuscarMusica.Click += new System.EventHandler(this.btnBuscarMusica_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome do Álbum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do Artista";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbum.Location = new System.Drawing.Point(271, 53);
            this.txtAlbum.MaximumSize = new System.Drawing.Size(255, 40);
            this.txtAlbum.MaxLength = 255;
            this.txtAlbum.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(255, 20);
            this.txtAlbum.TabIndex = 4;
            // 
            // txtArtista
            // 
            this.txtArtista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtista.Location = new System.Drawing.Point(6, 53);
            this.txtArtista.MaximumSize = new System.Drawing.Size(255, 40);
            this.txtArtista.MaxLength = 255;
            this.txtArtista.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(255, 20);
            this.txtArtista.TabIndex = 5;
            // 
            // dgListaSalvas
            // 
            this.dgListaSalvas.AllowUserToAddRows = false;
            this.dgListaSalvas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.dgListaSalvas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaSalvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaSalvas.BackgroundColor = System.Drawing.Color.White;
            this.dgListaSalvas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaSalvas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaSalvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaSalvas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.artista,
            this.album,
            this.duracao,
            this.numero_reproducoes});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListaSalvas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgListaSalvas.EnableHeadersVisualStyles = false;
            this.dgListaSalvas.GridColor = System.Drawing.Color.DimGray;
            this.dgListaSalvas.Location = new System.Drawing.Point(9, 190);
            this.dgListaSalvas.Name = "dgListaSalvas";
            this.dgListaSalvas.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListaSalvas.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgListaSalvas.RowHeadersVisible = false;
            this.dgListaSalvas.RowHeadersWidth = 4;
            this.dgListaSalvas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaSalvas.Size = new System.Drawing.Size(900, 347);
            this.dgListaSalvas.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "N°";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "nome_arquivo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 500;
            // 
            // artista
            // 
            this.artista.DataPropertyName = "artista";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.artista.DefaultCellStyle = dataGridViewCellStyle5;
            this.artista.HeaderText = "Artista";
            this.artista.Name = "artista";
            this.artista.ReadOnly = true;
            this.artista.Width = 250;
            // 
            // album
            // 
            this.album.DataPropertyName = "album";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.album.DefaultCellStyle = dataGridViewCellStyle6;
            this.album.HeaderText = "Álbum";
            this.album.Name = "album";
            this.album.ReadOnly = true;
            this.album.Width = 250;
            // 
            // duracao
            // 
            this.duracao.DataPropertyName = "duracao";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.duracao.DefaultCellStyle = dataGridViewCellStyle7;
            this.duracao.HeaderText = "Duração";
            this.duracao.Name = "duracao";
            this.duracao.ReadOnly = true;
            // 
            // numero_reproducoes
            // 
            this.numero_reproducoes.DataPropertyName = "numero_reproducoes";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.numero_reproducoes.DefaultCellStyle = dataGridViewCellStyle8;
            this.numero_reproducoes.HeaderText = "N° Reproduções";
            this.numero_reproducoes.Name = "numero_reproducoes";
            this.numero_reproducoes.ReadOnly = true;
            // 
            // TabDashboard
            // 
            this.TabDashboard.Location = new System.Drawing.Point(4, 4);
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.Size = new System.Drawing.Size(924, 697);
            this.TabDashboard.TabIndex = 5;
            this.TabDashboard.Text = "TabDashboard";
            this.TabDashboard.UseVisualStyleBackColor = true;
            // 
            // TabManual
            // 
            this.TabManual.Location = new System.Drawing.Point(4, 4);
            this.TabManual.Name = "TabManual";
            this.TabManual.Size = new System.Drawing.Size(924, 697);
            this.TabManual.TabIndex = 3;
            this.TabManual.Text = "TabManual";
            this.TabManual.UseVisualStyleBackColor = true;
            // 
            // TabConfig
            // 
            this.TabConfig.Location = new System.Drawing.Point(4, 4);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Size = new System.Drawing.Size(924, 697);
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
            this.ClientSize = new System.Drawing.Size(1113, 770);
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
            this.TabSalvas.ResumeLayout(false);
            this.groupDataSongs.ResumeLayout(false);
            this.groupDataSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaSalvas)).EndInit();
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TabPage TabDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMusica;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgListaSalvas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn album;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_reproducoes;
        private System.Windows.Forms.GroupBox groupDataSongs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Button btnBuscarMusica;
    }
}

