using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using WMPLib;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.IO;
using System.CodeDom;
using System.Threading;
using System.Diagnostics;
using NAudio.Wave.SampleProviders;
using NAudio.Gui;
using System.Security.Policy;
using Microsoft.VisualBasic;

namespace Pad_de_sonido
{
    public partial class Form1 : Form
    {
        #region variables
        WaveOutCapabilities capabilities;
        string path = Application.StartupPath + @"\son\"; //La ruta de los sonidos
        string rutaAudacity, rutaArchivo; //La ruta del audacity y el sonido
        int canal = -1, count = 0; //canal default, contador, backup contador
        List<string> archivos = new List<string>(); //Lista para los files
        List<string> carpetas = new List<string>(); //Lista para las folders
        List<WaveOutCapabilities> devices = new List<WaveOutCapabilities>(); // Lista de los devices
        #endregion

        #region funciones

        public void cargaLista(string carpeta = "", string filtro = "") //Carga la lista de canciones de cargaCarpetas() carpeta en la listbox
        {
            lstSonidos.Items.Clear();
            try
            {
                lstSonidos.Items.Clear();
                if (carpeta == "Sin categoria")
                {
                    archivos = Directory.GetFiles(path, $"*{filtro}*", SearchOption.TopDirectoryOnly).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstSonidos.Items.Add(archivos[i].Replace(path, ""));
                    }
                }
                else if (carpeta == "Todo")
                {
                    archivos = Directory.GetFiles(path, $"*{filtro}*", SearchOption.AllDirectories).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstSonidos.Items.Add(archivos[i].Replace(path, ""));
                    }
                }
                else
                {
                    archivos = Directory.GetFiles(path + $@"{carpeta}", $"*{filtro}*", SearchOption.TopDirectoryOnly).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstSonidos.Items.Add(archivos[i].Replace($@"{path}{carpeta}\", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            try { lstSonidos.SelectedIndex = 0; } catch { }
            
        }

        public void cargaCarpetas() //Carga la lista de carpetas en la combobox
        {
            cmbCarpeta.Items.Clear();
            cmbCarpeta.Items.Add("Todo");
            cmbCarpeta.Items.Add("Sin categoria");
            try
            {
                carpetas = Directory.GetDirectories(path).ToList();

                for (var i = 0; i < carpetas.Count; i++)
                {
                    cmbCarpeta.Items.Add(carpetas[i].Replace(path, ""));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void sonido() //Reproduce un sonido
        {
            if (lstSonidos.Items.Count > 0)
            {
                count = Convert.ToInt16(nmrContador.Value);
                while (count > 0) //Si el contador esta activado entra en el bucle
                {
                    Console.WriteLine(count);
                    count--;
                    nmrContador.Refresh();
                    Thread.Sleep(1000);
                }

                /*Selecciona el archivo de la listbox y lo ejecuta
                    con el volumen y por el canal deceado */
                var audioFile = rutaArchivo;
                AudioFileReader sonido = new AudioFileReader(audioFile);
                WaveOutEvent device = new WaveOutEvent();

                device.DeviceNumber = canal;
                device.Init(sonido);
                sonido.Volume = ((float)trcVolumen.Value) / 100;
                device.Play();
            }

        }

        public void save() //Guarda las variables 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("carga.txt"))
                {
                    sw.WriteLine(canal); //canal
                    sw.WriteLine(trcVolumen.Value); //volumen
                    sw.Close();
                }
            }
            catch
            {
            }
        }

        #endregion
        public Form1()
        {

            InitializeComponent();
            #region canales
            // carga los canales en la combobox
            for (var i = 0; i < WaveOut.DeviceCount; i++)
            {
                capabilities = WaveOut.GetCapabilities(i);
                devices.Add(capabilities);
                cmbDevice.Items.Add(capabilities.ProductName);
            }
            #endregion
            #region cargar canal y volumen
            try
            {
                using (StreamReader sr = new StreamReader("carga.txt"))
                {
                    try
                    {
                        canal = int.Parse(sr.ReadLine());
                        cmbDevice.SelectedIndex = canal;
                    }
                    catch
                    {
                        canal = -1;
                        cmbDevice.SelectedIndex = canal;
                    }
                    try
                    {
                        trcVolumen.Value = int.Parse(sr.ReadLine());
                    }
                    catch
                    {
                        trcVolumen.Value = 100;
                    }
                }
            }
            catch (IOException)
            {
                using (StreamWriter sw = new StreamWriter("carga.txt"))
                {
                    sw.WriteLine(0); //canal
                    sw.WriteLine(100); //volumen
                }
            }
            lblVolumen.Text = trcVolumen.Value + "%";
            #endregion
            cargaCarpetas();
            cmbCarpeta.SelectedIndex = 0;
            cargaLista(cmbCarpeta.Text);
            try { lstSonidos.SelectedIndex = 0; } catch { }
        }

        private void btnWtf_Click(object sender, EventArgs e)
        {
            try
            {
                sonido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            canal = cmbDevice.SelectedIndex;
            save();
        }

        private void trcVolumen_Scroll(object sender, EventArgs e)
        {
            save();
            lblVolumen.Text = trcVolumen.Value + "%";
        }

        private void lstSonidos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                sonido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";
                filePath = openFileDialog.FileName;
                File.Move(filePath, path + openFileDialog.SafeFileName);
                cargaLista(cmbCarpeta.Text);
            }
        }

        private void pctBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", path);
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }

        private void cmbCarpeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaLista(cmbCarpeta.Text);
        }

        private void lstSonidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    sonido();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cargaLista(cmbCarpeta.Text, txtBuscar.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    cmbCarpeta.SelectedIndex = 0;
                    cargaLista(cmbCarpeta.Text, txtBuscar.Text);
                }
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void lstSonidos_SelectedValueChanged(object sender, EventArgs e)
        {
            rutaArchivo = $@"{archivos[lstSonidos.SelectedIndex]}";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            #region carga de audacity
            try
            {
                using (StreamReader sr = new StreamReader("audacity_direct.txt"))
                {
                    rutaAudacity = sr.ReadLine();
                }
                ProcessStartInfo startInfo = new ProcessStartInfo(rutaAudacity);
                startInfo.Arguments = "\"" + rutaArchivo + "\"";
                Process.Start(startInfo);
            }
            catch
            {
                using (StreamWriter sw = new StreamWriter("audacity_direct.txt"))
                {
                    rutaAudacity = Interaction.InputBox("Ingrese la direccion del audacity");
                    sw.WriteLine(rutaAudacity);
                }
            }
            #endregion
        }

        private void mouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        private void pctTroll_Click(object sender, EventArgs e)
        {
            cargaLista(cmbCarpeta.Text);
        }
    }
}
