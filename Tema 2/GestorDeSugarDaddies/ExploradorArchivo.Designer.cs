﻿namespace GestorDeSugarDaddies
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
            buttVolver = new Button();
            menuClickD.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(1, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(647, 403);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // menuClickD
            // 
            menuClickD.ImageScalingSize = new Size(20, 20);
            menuClickD.Items.AddRange(new ToolStripItem[] { cREARARCHIVOToolStripMenuItem, cREARFICHEROToolStripMenuItem });
            menuClickD.Name = "contextMenuStrip1";
            menuClickD.Size = new Size(247, 60);
            // 
            // cREARARCHIVOToolStripMenuItem
            // 
            cREARARCHIVOToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cREARARCHIVOToolStripMenuItem.Name = "cREARARCHIVOToolStripMenuItem";
            cREARARCHIVOToolStripMenuItem.Size = new Size(246, 28);
            cREARARCHIVOToolStripMenuItem.Text = "CREAR ARCHIVO";
            cREARARCHIVOToolStripMenuItem.Click += CrearArchivo_Click;
            // 
            // cREARFICHEROToolStripMenuItem
            // 
            cREARFICHEROToolStripMenuItem.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cREARFICHEROToolStripMenuItem.Name = "cREARFICHEROToolStripMenuItem";
            cREARFICHEROToolStripMenuItem.Size = new Size(246, 28);
            cREARFICHEROToolStripMenuItem.Text = "CREAR CARPETA";
            cREARFICHEROToolStripMenuItem.Click += CrearDirectorio_Click;
            // 
            // buttVolver
            // 
            buttVolver.Location = new Point(573, 1);
            buttVolver.Name = "buttVolver";
            buttVolver.Size = new Size(75, 23);
            buttVolver.TabIndex = 1;
            buttVolver.Text = "Volver";
            buttVolver.UseVisualStyleBackColor = true;
            buttVolver.Click += buttVolver_Click;
            // 
            // ExploradorArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 445);
            Controls.Add(buttVolver);
            Controls.Add(flowLayoutPanel1);
            Name = "ExploradorArchivo";
            menuClickD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip menuClickD;
        private ToolStripMenuItem cREARARCHIVOToolStripMenuItem;
        private ToolStripMenuItem cREARFICHEROToolStripMenuItem;
        private Button buttVolver;
    }
}