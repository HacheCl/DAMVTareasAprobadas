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
            menuGuardar.Size = new Size(180, 24);
            menuGuardar.Text = "Guardar";
            menuGuardar.Click += menuGuardar_Click;
            // 
            // menuBorrar
            // 
            menuBorrar.Name = "menuBorrar";
            menuBorrar.Size = new Size(180, 24);
            menuBorrar.Text = "Borrar";
            // 
            // menuAbrir
            // 
            menuAbrir.Name = "menuAbrir";
            menuAbrir.Size = new Size(180, 24);
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
            // panel1
            // 
            panel1.Controls.Add(lblClickMe);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 375);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 75);
            panel1.TabIndex = 4;
            // 
            // lblClickMe
            // 
            lblClickMe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblClickMe.AutoSize = true;
            lblClickMe.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClickMe.Location = new Point(455, 48);
            lblClickMe.Name = "lblClickMe";
            lblClickMe.Size = new Size(99, 18);
            lblClickMe.TabIndex = 4;
            lblClickMe.Text = "CLICK ME -->";
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 348);
            panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 348);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(300, 298);
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
    }
}