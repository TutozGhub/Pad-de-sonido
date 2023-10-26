namespace Pad_de_sonido
{
    partial class programa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programa));
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.lstSonidos = new System.Windows.Forms.ListBox();
            this.trcVolumen = new System.Windows.Forms.TrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.pctTroll = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.nmrContador = new System.Windows.Forms.NumericUpDown();
            this.pctBoton = new System.Windows.Forms.PictureBox();
            this.cmbCarpeta = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbrirDirectorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAudacity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditarAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambiarDirectorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLinkedin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tmrContador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trcVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrContador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoton)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(631, 526);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 32);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Reproducir";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnWtf_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(100, 92);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(232, 21);
            this.cmbDevice.TabIndex = 1;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // lstSonidos
            // 
            this.lstSonidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSonidos.ColumnWidth = 200;
            this.lstSonidos.FormattingEnabled = true;
            this.lstSonidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstSonidos.Location = new System.Drawing.Point(12, 119);
            this.lstSonidos.MultiColumn = true;
            this.lstSonidos.Name = "lstSonidos";
            this.lstSonidos.Size = new System.Drawing.Size(700, 329);
            this.lstSonidos.TabIndex = 4;
            this.lstSonidos.SelectedIndexChanged += new System.EventHandler(this.lstSonidos_SelectedIndexChanged);
            this.lstSonidos.SelectedValueChanged += new System.EventHandler(this.lstSonidos_SelectedValueChanged);
            this.lstSonidos.DoubleClick += new System.EventHandler(this.lstSonidos_DoubleClick);
            this.lstSonidos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstSonidos_KeyUp);
            // 
            // trcVolumen
            // 
            this.trcVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trcVolumen.Location = new System.Drawing.Point(718, 119);
            this.trcVolumen.Maximum = 200;
            this.trcVolumen.Name = "trcVolumen";
            this.trcVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcVolumen.Size = new System.Drawing.Size(45, 329);
            this.trcVolumen.TabIndex = 6;
            this.trcVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcVolumen.Value = 100;
            this.trcVolumen.Scroll += new System.EventHandler(this.trcVolumen_Scroll);
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(715, 103);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(33, 13);
            this.lblVolumen.TabIndex = 7;
            this.lblVolumen.Text = "100%";
            // 
            // pctTroll
            // 
            this.pctTroll.ImageLocation = "D:\\Users\\Tutoz\\Desktop\\Programacion\\Pad de sonido\\Pad de sonido\\bin\\Debug\\ico\\tro" +
    "ll.png";
            this.pctTroll.Location = new System.Drawing.Point(18, 37);
            this.pctTroll.Name = "pctTroll";
            this.pctTroll.Size = new System.Drawing.Size(76, 76);
            this.pctTroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTroll.TabIndex = 10;
            this.pctTroll.TabStop = false;
            this.pctTroll.Click += new System.EventHandler(this.pctTroll_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(100, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 52);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = " EL TROLEAINADOR\r\n5000";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrContador
            // 
            this.nmrContador.Location = new System.Drawing.Point(125, 20);
            this.nmrContador.Name = "nmrContador";
            this.nmrContador.Size = new System.Drawing.Size(39, 20);
            this.nmrContador.TabIndex = 12;
            this.nmrContador.ValueChanged += new System.EventHandler(this.nmrContador_ValueChanged);
            // 
            // pctBoton
            // 
            this.pctBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBoton.ImageLocation = "D:\\Users\\Tutoz\\Desktop\\Programacion\\Pad de sonido\\Pad de sonido\\bin\\Debug\\ico\\Sel" +
    "f-destruction.png";
            this.pctBoton.InitialImage = null;
            this.pctBoton.Location = new System.Drawing.Point(625, 37);
            this.pctBoton.Name = "pctBoton";
            this.pctBoton.Size = new System.Drawing.Size(76, 76);
            this.pctBoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoton.TabIndex = 13;
            this.pctBoton.TabStop = false;
            this.pctBoton.Click += new System.EventHandler(this.pctBoton_Click);
            this.pctBoton.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.pctBoton.MouseHover += new System.EventHandler(this.mouseHover);
            // 
            // cmbCarpeta
            // 
            this.cmbCarpeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarpeta.FormattingEnabled = true;
            this.cmbCarpeta.Items.AddRange(new object[] {
            "",
            "valo"});
            this.cmbCarpeta.Location = new System.Drawing.Point(6, 20);
            this.cmbCarpeta.Name = "cmbCarpeta";
            this.cmbCarpeta.Size = new System.Drawing.Size(113, 21);
            this.cmbCarpeta.TabIndex = 15;
            this.cmbCarpeta.SelectedIndexChanged += new System.EventHandler(this.cmbCarpeta_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFiltros.Controls.Add(this.txtBuscar);
            this.grpFiltros.Controls.Add(this.cmbCarpeta);
            this.grpFiltros.Controls.Add(this.nmrContador);
            this.grpFiltros.Location = new System.Drawing.Point(12, 470);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(178, 88);
            this.grpFiltros.TabIndex = 18;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(560, 526);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 32);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbrirDirectorio});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "Archivo";
            // 
            // tsmAbrirDirectorio
            //
            this.tsmAbrirDirectorio.Name = "tsmAbrirDirectorio";
            this.tsmAbrirDirectorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmAbrirDirectorio.Size = new System.Drawing.Size(226, 22);
            this.tsmAbrirDirectorio.Text = "Directorio de sonidos";
            this.tsmAbrirDirectorio.Click += new System.EventHandler(this.abrirDirectorioToolStripMenuItem_Click);
            // 
            // tsmAudacity
            // 
            this.tsmAudacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditarAudio,
            this.tsmCambiarDirectorio});
            this.tsmAudacity.Name = "tsmAudacity";
            this.tsmAudacity.Size = new System.Drawing.Size(66, 20);
            this.tsmAudacity.Text = "Audacity";
            // 
            // tsmEditarAudio
            // 
            this.tsmEditarAudio.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditarAudio.Image")));
            this.tsmEditarAudio.Name = "tsmEditarAudio";
            this.tsmEditarAudio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmEditarAudio.Size = new System.Drawing.Size(179, 22);
            this.tsmEditarAudio.Text = "Editar audio";
            this.tsmEditarAudio.Click += new System.EventHandler(this.tsmEditarAudio_Click);
            // 
            // tsmCambiarDirectorio
            //
            this.tsmCambiarDirectorio.Name = "tsmCambiarDirectorio";
            this.tsmCambiarDirectorio.Size = new System.Drawing.Size(179, 22);
            this.tsmCambiarDirectorio.Text = "Cambiar directorio";
            this.tsmCambiarDirectorio.Click += new System.EventHandler(this.tsmCambiarDirectorio_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAcercaDe,
            this.tsmLinkedin,
            this.tsmGithub});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            this.tsmAcercaDe.Size = new System.Drawing.Size(126, 22);
            this.tsmAcercaDe.Text = "Acerca de";
            this.tsmAcercaDe.Click += new System.EventHandler(this.tsmAcercaDe_Click);
            // 
            // tsmLinkedin
            // 
            this.tsmLinkedin.Name = "tsmLinkedin";
            this.tsmLinkedin.Size = new System.Drawing.Size(126, 22);
            this.tsmLinkedin.Text = "Linkedin";
            this.tsmLinkedin.Click += new System.EventHandler(this.tsmLinkedin_Click);
            // 
            // tsmGithub
            // 
            this.tsmGithub.Name = "tsmGithub";
            this.tsmGithub.Size = new System.Drawing.Size(126, 22);
            this.tsmGithub.Text = "GitHub";
            this.tsmGithub.Click += new System.EventHandler(this.tsmGithub_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmAudacity,
            this.tsmAyuda});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(751, 24);
            this.mnsMenu.TabIndex = 20;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tmrContador
            // 
            this.tmrContador.Interval = 1;
            this.tmrContador.Tick += new System.EventHandler(this.tmrContador_Tick);
            // 
            // programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 570);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.trcVolumen);
            this.Controls.Add(this.lstSonidos);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pctTroll);
            this.Controls.Add(this.pctBoton);
            this.Controls.Add(this.mnsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "programa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL TROLEAINADOR 5000";
            ((System.ComponentModel.ISupportInitialize)(this.trcVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrContador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoton)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.ListBox lstSonidos;
        private System.Windows.Forms.TrackBar trcVolumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.PictureBox pctTroll;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nmrContador;
        private System.Windows.Forms.PictureBox pctBoton;
        private System.Windows.Forms.ComboBox cmbCarpeta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrirDirectorio;
        private System.Windows.Forms.ToolStripMenuItem tsmAudacity;
        private System.Windows.Forms.ToolStripMenuItem tsmEditarAudio;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarDirectorio;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmLinkedin;
        private System.Windows.Forms.ToolStripMenuItem tsmGithub;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.Timer tmrContador;
    }
}

