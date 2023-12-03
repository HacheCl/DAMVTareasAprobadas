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
            panel1 = new Panel();
            lblClickMe = new Label();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            nuevoArchivoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuGuardar, menuBorrar, menuAbrir, nuevoArchivoToolStripMenuItem });
            menuFile.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(64, 29);
            menuFile.Text = "File";
            // 
            // menuGuardar
            // 
            menuGuardar.Name = "menuGuardar";
            menuGuardar.Size = new Size(253, 30);
            menuGuardar.Text = "Guardar";
            menuGuardar.Click += menuGuardar_Click;
            // 
            // menuBorrar
            // 
            menuBorrar.Name = "menuBorrar";
            menuBorrar.Size = new Size(253, 30);
            menuBorrar.Text = "Borrar";
            // 
            // menuAbrir
            // 
            menuAbrir.Name = "menuAbrir";
            menuAbrir.Size = new Size(253, 30);
            menuAbrir.Text = "Abrir";
            menuAbrir.Click += menuAbrir_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(70, 29);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblClickMe);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 500);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 100);
            panel1.TabIndex = 4;
            // 
            // lblClickMe
            // 
            lblClickMe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblClickMe.AutoSize = true;
            lblClickMe.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClickMe.Location = new Point(520, 64);
            lblClickMe.Name = "lblClickMe";
            lblClickMe.Size = new Size(121, 20);
            lblClickMe.TabIndex = 4;
            lblClickMe.Text = "CLICK ME -->";
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 465);
            panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(914, 465);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            nuevoArchivoToolStripMenuItem.Size = new Size(253, 30);
            nuevoArchivoToolStripMenuItem.Text = "Nuevo Archivo";
            nuevoArchivoToolStripMenuItem.Click += nuevoArchivoToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(340, 382);
            Name = "Menu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Label lblClickMe;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem nuevoArchivoToolStripMenuItem;
    }
}