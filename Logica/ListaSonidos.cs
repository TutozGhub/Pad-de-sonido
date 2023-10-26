using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ListaSonidos
    {
        #region Atributos
        private List<WaveOutEvent> reproductores = new List<WaveOutEvent>();
        #endregion
        #region Propiedades
        public int Reproductores
        {
            get => reproductores.Count();
        }
        #endregion
        #region Metodos
        public void AddAudio(WaveOutEvent reproductor)
        {
            reproductores.Add(reproductor);
            Clear();
        }
        public void Stop()
        {
            foreach (WaveOutEvent reproductor in reproductores)
            {
                reproductor.Stop();
            }
            reproductores.Clear();
        }
        public void Volumen(int volumen)
        {
            foreach (WaveOutEvent reproductor in reproductores)
            {
                reproductor.Volume = (float)(volumen) / 100;
            }
        }
        private void Clear()
        {
            foreach (WaveOutEvent reproductor in reproductores)
            {
                if (reproductor.PlaybackState == PlaybackState.Stopped)
                {
                    reproductores.Remove(reproductor);
                    return;
                }
            }
        }
        #endregion

    }
}
