using System.Drawing.Drawing2D;

namespace GestorDeSugarDaddies
{
    public partial class Menu : Form
    {
        FormConImagen formConImagen;
        public Menu()
        {
            InitializeComponent();
            this.Text = "";
            SuscribirEventos();
            InicializarFormulario();

        }

        private void menuAbrir_Click(object sender, EventArgs e)
        {
            ExploradorArchivo exploradorArchivo = new ExploradorArchivo();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClickMe_Click(object sender, EventArgs e)
        {

        }
    }
}