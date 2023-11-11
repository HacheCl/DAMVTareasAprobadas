using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeSugarDaddies
{
    public partial class ExploradorArchivo : Form
    {
        Creacion creacion;
        bool isFile = false;
        public ExploradorArchivo()
        {

            InitializeComponent();
            this.Text = "";
            mostrarArchivosDirectorios();
            flowLayoutPanel1.Click -= Form1_MouseDown;
            flowLayoutPanel1.Click += Form1_MouseDown;
            creacion = new Creacion();
            this.TopMost = true;

        }

        public void mostrarArchivosDirectorios()
        {

            Directory.CreateDirectory(Properties.Resources.Ruta_Directorio);
            DirectoryInfo di = new DirectoryInfo(Properties.Resources.Ruta_Directorio);
            di.GetDirectories().ToList().ForEach(di2 => addFolder(di2));
            di.GetFiles().ToList().ForEach(fi => addFile(fi));

        }



        private void addFile(FileInfo fi)
        {
            Button buttonTrue = addButton();
            buttonTrue.Image = Properties.Resources.File;
            string nombre = fi.Name;
            nombre = nombre.Substring(0, nombre.Length - 4);
            nombre = cortarNombre(nombre);
            buttonTrue.Text = nombre;

            buttonTrue.TextImageRelation = TextImageRelation.ImageAboveText;
            flowLayoutPanel1.Controls.Add(buttonTrue);
        }
        private string cortarNombre(string nombre)
        {
            if (nombre.Length >= 12)
            {
                nombre = nombre.Substring(0, 8) + "...";
            }
            return nombre;
        }
        private void addFolder(DirectoryInfo di2)
        {
            Button buttonTrue = addButton();
            buttonTrue.Image = Properties.Resources.Folder;
            string nombre = di2.Name;
            nombre = cortarNombre(nombre);
            buttonTrue.Text = nombre;
            buttonTrue.TextImageRelation = TextImageRelation.ImageAboveText;
            flowLayoutPanel1.Controls.Add(buttonTrue);
        }
        private Button addButton()
        {
            Button button = new Button();
            button.ImageAlign = ContentAlignment.TopCenter;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.Size = new Size(100, 100);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = Color.LightGray;

            return button;
        }


        private void Form1_MouseDown(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
                menuClickD.Show(this, (e as MouseEventArgs).Location);

        }

        private void cREARARCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFile = true;
            MostrarFormularioCreacion();
        }
        private void cREARFICHEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFile = false;
            MostrarFormularioCreacion();
        }

        private void MostrarFormularioCreacion()
        {
            creacion.TopMost = true;
            DialogResult result = creacion.ShowDialog();


            if (result == DialogResult.OK)
            {

                string nombre = creacion.GetNombre();
                if (!string.IsNullOrEmpty(nombre))
                {
                    if (isFile)
                    {
                        CrearArchivo(nombre);
                    }
                    else
                    {
                        CrearCarpeta(nombre);
                    }
                }
            }
            
            creacion.ResetNombre();
            
        }

        private void CrearArchivo(string nombreArchivo)
        {
            string ruta = Properties.Resources.Ruta_Directorio + "\\" + nombreArchivo + ".txt";
            if (!File.Exists(ruta))
            {
                
                File.Create(ruta);
                actualizarFlowLayoutPanel();
            }
            else
            {
                MessageBox.Show("El archivo ya existe");
            }
        }
        public void actualizarFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            mostrarArchivosDirectorios();
        }

        private void CrearCarpeta(string nombreCarpeta)
        {
            string ruta = Properties.Resources.Ruta_Directorio + "\\" + nombreCarpeta;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                    actualizarFlowLayoutPanel();
                }
                else
                {
                    MessageBox.Show("La carpeta ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la carpeta: {ex.Message}");
            }
        }
    }
}

