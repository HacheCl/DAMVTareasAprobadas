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
            lblClickMe = new Label();
            menuStrip1.SuspendLayout();
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
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuGuardar, menuBorrar, menuAbrir });
            menuFile.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(64, 29);
            menuFile.Text = "File";
            // 
            // menuGuardar
            // 
            menuGuardar.Name = "menuGuardar";
            menuGuardar.Size = new Size(186, 30);
            menuGuardar.Text = "Guardar";
            // 
            // menuBorrar
            // 
            menuBorrar.Name = "menuBorrar";
            menuBorrar.Size = new Size(186, 30);
            menuBorrar.Text = "Borrar";
            // 
            // menuAbrir
            // 
            menuAbrir.Name = "menuAbrir";
            menuAbrir.Size = new Size(186, 30);
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
            // lblClickMe
            // 
            lblClickMe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblClickMe.AutoSize = true;
            lblClickMe.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClickMe.Location = new Point(558, 511);
            lblClickMe.Name = "lblClickMe";
            lblClickMe.Size = new Size(121, 20);
            lblClickMe.TabIndex = 1;
            lblClickMe.Text = "CLICK ME -->";
            lblClickMe.Click += lblClickMe_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblClickMe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(340, 384);
            Name = "Menu";
            Text = "Form1";
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
        private Label lblClickMe;
    }
}