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

        }

        private void ActualizarPosicionFormConImagen()
        {
            int offsetX = -this.Width;
            int offsetY = -this.Height - 132;


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
            this.MouseDown += Menu_MouseDown;
        }
        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            ActualizarPosicionFormConImagen();
            formConImagen.Focus();
        }
        private void FormImagen_Load(object sender, EventArgs e)
        {
            formConImagen.Focus();
        }
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BringToFront();
            }
        }
    }
}