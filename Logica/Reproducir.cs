using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Reproducir
    {
        #region Atributos
        private string directorioSonido;
        #endregion
        #region Propiedades
        public string DirectorioSonido
        {
            get => directorioSonido;
            set => directorioSonido = value;
        }
        #endregion
        #region Metodos
        public void ReproducirAudio(Configuraciones cfg, ListaSonidos lst, ListBox lstArchivos) //Reproduce un sonido
        {
            if (lstArchivos.Items.Count > 0)
            {
                using (AudioFileReader sonido = new AudioFileReader(directorioSonido))
                {
                    WaveOutEvent reproductor = new WaveOutEvent();
                    reproductor.DeviceNumber = cfg.Canal;
                    reproductor.Init(sonido);
                    sonido.Volume = ((float)(cfg.Volumen)) / 100;
                    reproductor.Play();
                    lst.AddAudio(reproductor);
                }
            }
        }
        #endregion
    }
}
