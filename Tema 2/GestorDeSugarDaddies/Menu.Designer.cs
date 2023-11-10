namespace GestorDeSugarDaddies
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuGuardar = new ToolStripMenuItem();
            menuBorrar = new ToolStripMenuItem();
            menuAbrir = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuGuardar, menuBorrar, menuAbrir });
            menuFile.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(49, 23);
            menuFile.Text = "File";
            // 
            // menuGuardar
            // 
            menuGuardar.Name = "menuGuardar";
            menuGuardar.Size = new Size(145, 24);
            menuGuardar.Text = "Guardar";
            // 
            // menuBorrar
            // 
            menuBorrar.Name = "menuBorrar";
            menuBorrar.Size = new Size(145, 24);
            menuBorrar.Text = "Borrar";
            // 
            // menuAbrir
            // 
            menuAbrir.Name = "menuAbrir";
            menuAbrir.Size = new Size(145, 24);
            menuAbrir.Text = "Abrir";
            menuAbrir.Click += menuAbrir_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(53, 23);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(300, 300);
            Name = "Menu";
            Text = "Form1";
            Load += FormImagen_Load;
            MdiChildActivate += FormImagen_Load;
            Shown += FormImagen_Load;
            ResizeBegin += FormImagen_Load;
            ResizeEnd += FormImagen_Load;
            Click += FormImagen_Load;
            PaddingChanged += FormImagen_Load;
            DoubleClick += FormImagen_Load;
            MouseEnter += FormImagen_Load;
            MouseLeave += FormImagen_Load;
            MouseHover += FormImagen_Load;
            Move += FormImagen_Load;
            Resize += FormImagen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuGuardar;
        private ToolStripMenuItem menuBorrar;
        private ToolStripMenuItem menuAbrir;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}