﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace Logica
{
    public class Configuraciones
    {
        #region Atributos
        private int canal;
        private int volumen;
        private WaveOutCapabilities capacidades;
        private List<WaveOutCapabilities> canales = new List<WaveOutCapabilities>(); // Lista de los canales
        private readonly string config = "Config.cfg";
        private readonly string audacity = "audacity_direct.cfg";
        private string audacityDir = "";
        private string directorioAudio;
        #endregion
        #region Propiedades
        public int Canal
        {
            get => canal;
            set => canal = value;
        }
        public int Volumen
        {
            get => volumen;
            set => volumen = value;
        }
        public string DirectorioAudio
        {
            get => directorioAudio;
            set => directorioAudio = value;
        }
        #endregion
        public Configuraciones()
        {
            GetAudacityDir();
        }
        #region Metodos
        public string[] GetCanales() // carga los canales en el combobox
        {
            List<string> cmbCanales = new List<string>();
            for (int i = 0, len = WaveOut.DeviceCount; i < len; i++)
            {
                capacidades = WaveOut.GetCapabilities(i);
                canales.Add(capacidades);
                cmbCanales.Add(capacidades.ProductName.ToString());
            }
            return cmbCanales.ToArray();
        }
        public void Save() //Guarda las variables 
        {
            using (StreamWriter sw = new StreamWriter(config))
            {
                sw.WriteLine(canal); //canal
                sw.WriteLine(volumen); //volumen
            }
        }
        public void GetConfig(ref ComboBox cmb, ref TrackBar trc)
        {
            try
            {
                using (StreamReader sr = new StreamReader(config))
                {
                    try
                    {
                        canal = int.Parse(sr.ReadLine());
                        cmb.SelectedIndex = canal;
                    }
                    catch
                    {
                        canal = -1;
                        cmb.SelectedIndex = canal;
                    }
                    try
                    {
                        int _temp = int.Parse(sr.ReadLine());
                        volumen = _temp;
                        trc.Value = _temp;
                    }
                    catch
                    {
                        volumen = 100;
                        trc.Value = 100;
                    }
                }
            }
            catch (IOException)
            {
                using (StreamWriter sw = new StreamWriter(config))
                {
                    sw.WriteLine(-1); //canal
                    sw.WriteLine(100); //volumen
                }
            }
        }
        public void OpenAudacity(int sonidosCount)
        {
            try
            { //Abre el audio en el Audacity y de no ser posible pide un directorio valido
                if (sonidosCount > 0)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(audacityDir);
                    startInfo.Arguments = "\"" + directorioAudio + "\"";
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("No hay ninguna canción seleccionada");
                }
            }
            catch
            {
                SetAudacityDir();
            }
        }
        public void GetAudacityDir()
        {
            try
            {
                using (StreamReader sr = new StreamReader(audacity))
                {
                    audacityDir = sr.ReadLine();
                }
            }
            catch (IOException)
            {
                using (StreamWriter sw = new StreamWriter(audacity))
                {
                    sw.WriteLine("");
                }
            }
        }
        public void SetAudacityDir() //Invoca una ventana para definir el directorio del Audacity
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Establecer las propiedades del cuadro de diálogo
                openFileDialog.InitialDirectory = audacity;
                openFileDialog.Filter = "Archivos ejecutables (*.exe)|*.exe|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) // Si el usuario selecciona un archivo
                {
                    audacityDir = openFileDialog.FileName; // Obtener la ubicación del archivo seleccionado
                    using (StreamWriter sw = new StreamWriter(audacity))
                    {
                        sw.WriteLine(audacityDir);
                    }
                }
            }
        }
        #endregion
    }
}
