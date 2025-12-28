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
            this.PanelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.PanelControles.Size = new System.Drawing.Size(197, 766);
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
            this.Logo.Size = new System.Drawing.Size(197, 88);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LyriumPlayerV3.Properties.Resources.gradiente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 756);
            this.Controls.Add(this.PanelControles);
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
    }
}

