using Logica;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Pad_de_sonido.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pad_de_sonido
{
    public partial class Pad : Form
    {
        #region variables
        Configuraciones cfg = new Configuraciones();
        CD_Archivos archivos = new CD_Archivos();
        ListaSonidos listaSonidos = new ListaSonidos();

        string GITHUB = "www.github.com/TutozGhub";
        string LINKEDIN = "www.linkedin.com/in/agustin-fizzano/";

        bool load = false;
        #endregion
        public Pad()
        {
            if (!cfg.EsAdministrador())
            {
                cfg.EjecutarComoAdministrador();
                this.Dispose();
            }
            InitializeComponent();
            this.Icon = Resources.Icono;
            cmbSalida.Items.AddRange (cfg.GetCanales());
            cfg.GetConfig(ref cmbSalida, ref trcVolumen, ref archivos, this);
            archivos.ValidarDirectorio();
            archivos.Refresh(ref cmbCategoria, ref lstArchivos);
            lblVolumen.Text = trcVolumen.Value + "%";
            load = true;
        }

        private void trcVolumen_Scroll(object sender, EventArgs e)
        {
            cfg.Volumen = trcVolumen.Value;
            listaSonidos.Volumen(trcVolumen.Value);
            cfg.Save();
            lblVolumen.Text = trcVolumen.Value + "%";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            archivos.Filtro = "";
            archivos.Carpeta = cmbCategoria.Text;
            archivos.GetArchivos(ref lstArchivos);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reproducir play = new Reproducir();
            play.DirectorioSonido = archivos.Archivos[lstArchivos.SelectedIndex];
            Task reproducir = play.ReproducirAudio(cfg, listaSonidos, lstArchivos, nmrTimer.Value);
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            listaSonidos.Stop();
        }

        private void audacityDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cfg.SetAudacityDir();
        }

        private void audacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstArchivos.Items.Count > 0)
            {
                cfg.DirectorioAudio = archivos.Archivos[lstArchivos.SelectedIndex];
                cfg.OpenAudacity(lstArchivos.Items.Count);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbCategoria.Text = "Todo";
            archivos.Carpeta = "Todo";
            archivos.Filtro = txtBuscar.Text;
            archivos.GetArchivos(ref lstArchivos);
            txtBuscar.Clear();
            lstArchivos.Focus();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void lstArchivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnPlay_Click(sender, e);
                e.Handled = true;
            }
        }

        private void audiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivos.ValidarDirectorio();
            Process.Start("explorer.exe", archivos.Directorio);
        }

        private void cmbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                cfg.Canal = cmbSalida.SelectedIndex;
                cfg.Save();
            }
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software desarrollado por Agustin Fizzano");
        }

        private void linkedinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(LINKEDIN);
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(GITHUB);
        }

        private void Pad_Resize(object sender, EventArgs e)
        {
            cfg.Height = this.Height;
            cfg.Width = this.Width;
            if (load)
            {
                cfg.Save();
            }
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            archivos.Refresh(ref cmbCategoria, ref lstArchivos);
        }

        private void directorioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            archivos.ModificarDirectorio();
        }
    }
}
