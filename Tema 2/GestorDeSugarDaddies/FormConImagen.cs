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
    public partial class FormConImagen : Form
    {
        private bool imagenOriginal = true;
        public FormConImagen()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {

            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackgroundImage = Properties.Resources.bobTrue;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(303, 404);


        }




        private void Form1_Click(object sender, EventArgs e)
        {
            if (imagenOriginal)
            {
                this.BackgroundImage.Dispose();
                this.BackgroundImage = Properties.Resources.patricio; // Cambia a la nueva imagen

            }
            else
            {
                this.BackgroundImage.Dispose();
                this.BackgroundImage = Properties.Resources.bobTrue; // Cambia de nuevo a la imagen original

            }

            imagenOriginal = !imagenOriginal; // Cambia el estado para la próxima vez

        }
    }
}
