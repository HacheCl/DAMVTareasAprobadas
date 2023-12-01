using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        string rutaActual = Properties.Resources.Ruta_Directorio;
        Menu menu;
        string fileName = "";
        public ExploradorArchivo(Menu menu)
        {
            this.menu = menu;
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

            Directory.CreateDirectory(rutaActual);
            DirectoryInfo di = new DirectoryInfo(rutaActual);
            di.GetDirectories().ToList().ForEach(di2 => addFolder(di2));
            di.GetFiles().ToList().ForEach(fi => addFile(fi));

        }



        private void addFile(FileInfo fi)
        {
            Button buttonTrue = addButton();
            buttonTrue.Image = Properties.Resources.File;
            buttonTrue.Name = fi.Name;
            string nombre = fi.Name;
            nombre = nombre.Substring(0, nombre.Length - 4);
            nombre = cortarNombre(nombre);
            buttonTrue.Text = nombre;

            buttonTrue.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonTrue.Click += buttonFile_Click;
            flowLayoutPanel1.Controls.Add(buttonTrue);
        }

        private void addFolder(DirectoryInfo di2)
        {
            Button buttonTrue = addButton();
            buttonTrue.Image = Properties.Resources.Folder;
            buttonTrue.Name = di2.Name;
            string nombre = di2.Name;
            nombre = cortarNombre(nombre);
            buttonTrue.Text = nombre;
            buttonTrue.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonTrue.Click += buttonFolder_Click;
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
        private void buttonFile_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            try
            {
                fileName = clickedButton.Name;
                string ruta = Path.Combine(rutaActual, clickedButton.Name);
                string contenido = File.ReadAllText(ruta);
                if (contenido == string.Empty)
                {
                    contenido = "Esta vacio";
                }
                
                menu.setTexto(contenido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            rutaActual = Path.Combine(rutaActual, clickedButton.Name);

            actualizarFlowLayoutPanel();
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
            string ruta = rutaActual + "\\" + nombreArchivo + ".txt";
            if (!File.Exists(ruta))
            {

                File.Create(ruta).Close();
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
            string ruta = rutaActual + "\\" + nombreCarpeta;
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



        private void buttVolver_Click(object sender, EventArgs e)
        {
           
            
            if(rutaActual != Properties.Resources.Ruta_Directorio)
            {
                rutaActual = Path.GetDirectoryName(rutaActual);
                actualizarFlowLayoutPanel();
               
            }
            else
            {
                MessageBox.Show("No se puede volver más atrás");
            }
            
        }

        internal void Guardar(string texto)
        {
            if (rutaActual!=Properties.Resources.Ruta_Directorio)
            {
                File.WriteAllText(Path.Combine(rutaActual, fileName), texto);
            }
            
        }
    }
}

