namespace GestorDeSugarDaddies
{
    partial class ExploradorArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuClickD = new ContextMenuStrip(components);
            cREARARCHIVOToolStripMenuItem = new ToolStripMenuItem();
            cREARFICHEROToolStripMenuItem = new ToolStripMenuItem();
            menuClickD.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(914, 600);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // menuClickD
            // 
            menuClickD.ImageScalingSize = new Size(20, 20);
            menuClickD.Items.AddRange(new ToolStripItem[] { cREARARCHIVOToolStripMenuItem, cREARFICHEROToolStripMenuItem });
            menuClickD.Name = "contextMenuStrip1";
            menuClickD.Size = new Size(295, 72);
            // 
            // cREARARCHIVOToolStripMenuItem
            // 
            cREARARCHIVOToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cREARARCHIVOToolStripMenuItem.Name = "cREARARCHIVOToolStripMenuItem";
            cREARARCHIVOToolStripMenuItem.Size = new Size(294, 34);
            cREARARCHIVOToolStripMenuItem.Text = "CREAR ARCHIVO";
            cREARARCHIVOToolStripMenuItem.Click += cREARARCHIVOToolStripMenuItem_Click;
            // 
            // cREARFICHEROToolStripMenuItem
            // 
            cREARFICHEROToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cREARFICHEROToolStripMenuItem.Name = "cREARFICHEROToolStripMenuItem";
            cREARFICHEROToolStripMenuItem.Size = new Size(294, 34);
            cREARFICHEROToolStripMenuItem.Text = "CREAR CARPETA";
            cREARFICHEROToolStripMenuItem.Click += cREARFICHEROToolStripMenuItem_Click;
            // 
            // ExploradorArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExploradorArchivo";
            menuClickD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip menuClickD;
        private ToolStripMenuItem cREARARCHIVOToolStripMenuItem;
        private ToolStripMenuItem cREARFICHEROToolStripMenuItem;
    }
}