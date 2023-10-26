using Logica;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pad_de_sonido
{
    public partial class Pad : Form
    {
        #region variables
        Configuraciones cfg = new Configuraciones();
        Arcivos archivos = new Arcivos();
        ListaSonidos listaSonidos = new ListaSonidos();

        string VERSION = "2.0";
        string GITHUB = "www.github.com/TutozGhub";
        string LINKENIN = "www.linkedin.com/in/agustin-fizzano/";
        string rutaAudacity, rutaArchivo; //La ruta del audacity y el sonido

        int count = 0; //contador
        bool load = false;
        #endregion
        public Pad()
        {
            InitializeComponent();
            cmbSalida.Items.AddRange (cfg.GetCanales());
            cfg.GetConfig(ref cmbSalida, ref trcVolumen);
            archivos.Refresh(ref cmbCategoria, ref lstArchivos);
            lblVolumen.Text = trcVolumen.Value + "%";
            load = true;
        }

        private void trcVolumen_Scroll(object sender, EventArgs e)
        {
            //for (int i = 0; i < soundFiles.Count; i++)
            //{
            //    soundFiles[i].Volume = ((float)trcVolumen.Value) / 100;
            //}
            cfg.Canal = cmbSalida.SelectedIndex;
            cfg.Volumen = trcVolumen.Value;
            cfg.Save();
            lblVolumen.Text = trcVolumen.Value + "%";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            archivos.Carpeta = cmbCategoria.Text;
            archivos.GetArchivos(ref lstArchivos);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reproducir play = new Reproducir();
            play.DirectorioSonido = archivos.Archivos[lstArchivos.SelectedIndex];
            play.ReproducirAudio(cfg, listaSonidos, lstArchivos);
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
            cfg.DirectorioAudio = archivos.Archivos[lstArchivos.SelectedIndex];
            cfg.OpenAudacity(lstArchivos.Items.Count);
        }

        private void cmbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                cfg.Canal = cmbSalida.SelectedIndex;
                cfg.Volumen = trcVolumen.Value;
                cfg.Save();
            }
        }
    }
}
