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
        #endregion
        #region Metodos
        public void AddAudio(WaveOutEvent reproductor)
        {
            reproductores.Add(reproductor);
        }
        public void Stop()
        {
            foreach (WaveOutEvent reproductor in reproductores)
            {
                reproductor.Stop();
            }
        }
        #endregion

    }
}
