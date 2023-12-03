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
        Menu menu;
        public bool isFile = false;
        public string rutaActual = Properties.Resources.Ruta_Directorio;
        public string fileActualName ;
        public string fileRutaActual;
        public string lastCreated;
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
            this.Text = rutaActual;
            menu.Text = fileActualName;
        }
        public void CrearArchivo()
        {
            isFile = true;
            MostrarFormularioCreacion();
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
            menu.Text = fileActualName;
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
            AgregarMenuContextual(button);
            
            return button;
        }
            private void buttonFolder_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            rutaActual = Path.Combine(rutaActual, clickedButton.Name);

            actualizarFlowLayoutPanel();
        }
        private void AgregarMenuContextual(Button boton)
        {
            ContextMenuStrip menuContextual = new ContextMenuStrip();
            ToolStripMenuItem itemMenu = new ToolStripMenuItem("Borrar");
            itemMenu.Click += (sender, e) => MenuItem_Click(sender, e, boton); 
            menuContextual.Items.Add(itemMenu);
            boton.ContextMenuStrip = menuContextual;
            boton.MouseClick += Boton_Click;
        }
        private void Boton_Click(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
               
                Button boton = sender as Button;             
                if (boton != null && boton.ContextMenuStrip != null)
                {
                    boton.ContextMenuStrip.Show(boton, e.Location);
                }
            }
        }
        private void MenuItem_Click(object sender, EventArgs e, Button botonAsociado)
        {
            string ruta = Path.Combine(rutaActual, botonAsociado.Name);
            if (EsDirectorio(ruta))
            {
                try
                {
                    Directory.Delete(ruta);
                }catch (Exception ex) {
                    MostrarOpcion(ruta);
                }
                
            }else if (EsArchivo(ruta))
            {
                File.Delete(ruta);
            }
            else
            {
                return;
            }
            
            actualizarFlowLayoutPanel();
        }
        private void MostrarOpcion(string ruta)
        {
            DialogResult resultado = MessageBox.Show("Está usted completamente seguro, \n puede perder a su familia si acepta.", "Confirmación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                Directory.Delete(ruta,true);
            }
            else
            {
                return;
            }
        }

        public bool EsDirectorio(string ruta)
        {
            return Directory.Exists(ruta);
        }

        public bool EsArchivo(string ruta)
        {
            return File.Exists(ruta);
        }
        private void buttonFile_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            try
            {
                fileActualName = clickedButton.Name;

                fileRutaActual = Path.Combine(rutaActual, clickedButton.Name);
                string contenido = File.ReadAllText(fileRutaActual);
                if (contenido == string.Empty)
                {
                    contenido = "Esta vacio";
                }
                menu.ActualizarNombreForm(fileActualName);
                menu.setTexto(contenido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }
        
        




        private void Form1_MouseDown(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
                menuClickD.Show(this, (e as MouseEventArgs).Location);

        }

        private void CrearArchivo_Click(object sender, EventArgs e)
        {
            isFile = true;
            MostrarFormularioCreacion();
        }
        private void CrearDirectorio_Click(object sender, EventArgs e)
        {
            isFile = false;
            MostrarFormularioCreacion();
        }

        public void MostrarFormularioCreacion()
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
                        lastCreated = nombre;
                        fileActualName = nombre;
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

        public void Guardar(string texto)
        {
               
               File.WriteAllText(Path.Combine(rutaActual, fileActualName), texto);
              
        }

    }
}

