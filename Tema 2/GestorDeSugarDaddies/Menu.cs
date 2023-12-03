using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace GestorDeSugarDaddies
{
    public partial class Menu : Form
    {
        FormConImagen formConImagen;
        ExploradorArchivo exploradorArchivo;
        public Menu()
        {
            InitializeComponent();
            this.Text = "";
            SuscribirEventos();
            InicializarFormulario();

        }

        private void menuAbrir_Click(object sender, EventArgs e)
        {
            exploradorArchivo = new ExploradorArchivo(this);
            exploradorArchivo.Show();

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info form1 = new Info();
            form1.Show();
        }
        private void InicializarFormulario()
        {

            formConImagen = new FormConImagen();

            MostrarFormConImagen();

            ActualizarPosicionFormConImagen();
            formConImagen.TopMost = true;
        }

        private void ActualizarPosicionFormConImagen()
        {

            int offsetX = -this.Width;
            int offsetY = -this.Height - 130;

            formConImagen.Location = new Point(
                this.Location.X - formConImagen.Width - offsetX,
                this.Location.Y - formConImagen.Height - offsetY
            );

        }

        private void FormPrincipal_LocationChanged(object sender, EventArgs e)
        {
            ActualizarPosicionFormConImagen();
        }

        private void MostrarFormConImagen()
        {
            formConImagen.Show();
        }

        private void SuscribirEventos()
        {
            this.LocationChanged += FormPrincipal_LocationChanged;
            this.SizeChanged += FormPrincipal_Resize;

        }
        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            ActualizarPosicionFormConImagen();
        }
        public void setTexto(string texto)
        {
            richTextBox1.Text = texto;
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            if (ExisteExplorador())
            {
                if (exploradorArchivo.fileActualName != null)
                {
                    exploradorArchivo.Guardar(richTextBox1.Text);

                }
                else
                {
                    exploradorArchivo.CrearArchivo();

                }

            }
        }
        private bool ExisteExplorador()
        {
            if (exploradorArchivo == null)
            {
                exploradorArchivo = new ExploradorArchivo(this);
                
            }
            return true;
        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteExplorador())
            {
                exploradorArchivo.CrearArchivo();
                richTextBox1.Text = "Escriba aqui";
                exploradorArchivo.actualizarFlowLayoutPanel();
                Text = exploradorArchivo.fileActualName;
            }
            
            
        }
        public void ActualizarNombreForm(string nombre) { 
            Text = nombre;
        }

    }
}