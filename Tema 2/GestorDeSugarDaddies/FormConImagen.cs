﻿using System;
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
        public FormConImagen()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
       
            this.BackgroundImage = Properties.Resources.bobTrue;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.White; 
            this.TransparencyKey = Color.White; 
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(303, 404);
        
        }
    }
}
