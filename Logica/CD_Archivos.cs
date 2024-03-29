﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Logica
{
    public class CD_Archivos
    {
        #region Atributos
        private string carpeta = "Todo";
        private string filtro = "";
        private List<string> archivos = new List<string>(); //Lista para los archivos
        private List<string> carpetas = new List<string>(); //Lista para las carpetas
        private static string raiz = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        private string directorio = raiz + @"\PDS\Audios\"; //La ruta de los sonidos
        #endregion
        #region Propiedades
        public string Carpeta
        {
            get => carpeta;
            set => carpeta = value;
        }
        public string Filtro
        {
            get => filtro;
            set => filtro = value;
        }
        public string Directorio
        {
            set => directorio = value;
            get => directorio;
        }
        public List<string> Archivos
        {
            get => archivos;
        }
        #endregion
        #region Metodos
        public void GetArchivos(ref ListBox lstAudios) //Carga la lista de canciones en la listbox
        {
            try
            {
                lstAudios.Items.Clear();
                if (carpeta == "Sin categoria")
                {
                    archivos = Directory.GetFiles(directorio, $"*{filtro}*", SearchOption.TopDirectoryOnly).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstAudios.Items.Add(archivos[i].Replace(directorio, ""));
                    }
                }
                else if (carpeta == "Todo")
                {
                    archivos = Directory.GetFiles(directorio, $"*{filtro}*", SearchOption.AllDirectories).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstAudios.Items.Add(archivos[i].Replace(directorio, ""));
                    }
                }
                else
                {
                    archivos = Directory.GetFiles(directorio + $@"{carpeta}", $"*{filtro}*", SearchOption.TopDirectoryOnly).ToList();
                    for (var i = 0; i < archivos.Count; i++)
                    {
                        lstAudios.Items.Add(archivos[i].Replace($@"{directorio}{carpeta}\", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            try { lstAudios.SelectedIndex = 0; } catch { }

        }
        private void GetCarpetas(ref ComboBox cmbCarpetas) //Carga la lista de carpetas en la combobox
        {
            cmbCarpetas.Items.Clear();
            cmbCarpetas.Items.Add("Todo");
            cmbCarpetas.Items.Add("Sin categoria");
            cmbCarpetas.SelectedItem = "Sin categoria";
            try
            {
                carpetas = Directory.GetDirectories(directorio).ToList();

                for (var i = 0; i < carpetas.Count; i++)
                {
                    cmbCarpetas.Items.Add(carpetas[i].Replace(directorio, ""));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void Refresh(ref ComboBox cmbCarpetas, ref ListBox lstAudios)
        {
            GetCarpetas(ref cmbCarpetas);
            GetArchivos(ref lstAudios);
        }
        public void ValidarDirectorio()
        {
            try
            {
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                    Console.WriteLine("La carpeta se ha creado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar crear la carpeta: " + ex.Message);
            }
        }
        public void ModificarDirectorio()
        {
            using (OpenFileDialog explorador = new OpenFileDialog())
            {
                explorador.Title = "Selecciona una carpeta";
                explorador.CheckFileExists = false;
                explorador.FileName = "Carpeta"; 
                explorador.Filter = "|Folders";
                explorador.ValidateNames = false;
                ValidarDirectorio();
                explorador.InitialDirectory = directorio;

                DialogResult result = explorador.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string carpeta = System.IO.Path.GetDirectoryName(explorador.FileName);
                    directorio = carpeta;
                }
            }
        }
        #endregion
    }
}
