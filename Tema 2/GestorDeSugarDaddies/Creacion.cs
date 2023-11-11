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
    public partial class Creacion : Form
    {
        public Creacion()
        {
            InitializeComponent();
            this.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        public string GetNombre()
        {
            return nombre.Text;
        }

        private void textClick(object sender, EventArgs e)
        {
            nombre.Text = "";
            nombre.ForeColor = Color.Black;
        }
        public void ResetNombre()
        {
            nombre.Text = "Introduzca el nombre...";
            nombre.ForeColor = Color.Gray;
        }
    }
}
