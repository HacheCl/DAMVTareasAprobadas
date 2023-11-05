namespace DivisasGodTierSPlus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_Importe = new Label();
            lbl_Combo1 = new Label();
            lbl_Comb2 = new Label();
            comboOrigen = new ComboBox();
            comboDestino = new ComboBox();
            btn_Ejecutar = new Button();
            txtResultado = new Label();
            txtImporte = new TextBox();
            listaResultados = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Importe
            // 
            lbl_Importe.AutoSize = true;
            lbl_Importe.Location = new Point(141, 112);
            lbl_Importe.Name = "lbl_Importe";
            lbl_Importe.Size = new Size(62, 20);
            lbl_Importe.TabIndex = 0;
            lbl_Importe.Text = "Importe";
            // 
            // lbl_Combo1
            // 
            lbl_Combo1.AutoSize = true;
            lbl_Combo1.Location = new Point(423, 111);
            lbl_Combo1.Name = "lbl_Combo1";
            lbl_Combo1.Size = new Size(31, 20);
            lbl_Combo1.TabIndex = 1;
            lbl_Combo1.Text = "De:";
            // 
            // lbl_Comb2
            // 
            lbl_Comb2.AutoSize = true;
            lbl_Comb2.Location = new Point(663, 111);
            lbl_Comb2.Name = "lbl_Comb2";
            lbl_Comb2.Size = new Size(22, 20);
            lbl_Comb2.TabIndex = 2;
            lbl_Comb2.Text = "A:";
            // 
            // comboOrigen
            // 
            comboOrigen.FormattingEnabled = true;
            comboOrigen.Location = new Point(397, 135);
            comboOrigen.Margin = new Padding(3, 4, 3, 4);
            comboOrigen.Name = "comboOrigen";
            comboOrigen.Size = new Size(138, 28);
            comboOrigen.TabIndex = 3;
            // 
            // comboDestino
            // 
            comboDestino.FormattingEnabled = true;
            comboDestino.Location = new Point(602, 135);
            comboDestino.Margin = new Padding(3, 4, 3, 4);
            comboDestino.Name = "comboDestino";
            comboDestino.Size = new Size(138, 28);
            comboDestino.TabIndex = 4;
            // 
            // btn_Ejecutar
            // 
            btn_Ejecutar.Location = new Point(658, 233);
            btn_Ejecutar.Margin = new Padding(3, 4, 3, 4);
            btn_Ejecutar.Name = "btn_Ejecutar";
            btn_Ejecutar.Size = new Size(86, 31);
            btn_Ejecutar.TabIndex = 6;
            btn_Ejecutar.Text = "Cambiar";
            btn_Ejecutar.UseVisualStyleBackColor = true;
            btn_Ejecutar.Click += btn_Ejecutar_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(141, 235);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(129, 29);
            txtResultado.TabIndex = 7;
            txtResultado.Text = "Historico:";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(141, 136);
            txtImporte.Margin = new Padding(3, 4, 3, 4);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(114, 27);
            txtImporte.TabIndex = 8;
            // 
            // listaResultados
            // 
            listaResultados.FormattingEnabled = true;
            listaResultados.ItemHeight = 20;
            listaResultados.Location = new Point(141, 334);
            listaResultados.Name = "listaResultados";
            listaResultados.Size = new Size(603, 184);
            listaResultados.TabIndex = 9;
            listaResultados.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(541, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 54);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(listaResultados);
            Controls.Add(txtImporte);
            Controls.Add(txtResultado);
            Controls.Add(btn_Ejecutar);
            Controls.Add(comboDestino);
            Controls.Add(comboOrigen);
            Controls.Add(lbl_Comb2);
            Controls.Add(lbl_Combo1);
            Controls.Add(lbl_Importe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Importe;
        private Label lbl_Combo1;
        private Label lbl_Comb2;
        private ComboBox comboOrigen;
        private ComboBox comboDestino;
        private Button btn_Ejecutar;
        private Label txtResultado;
        private TextBox txtImporte;
        private ListBox listaResultados;
        private PictureBox pictureBox1;
    }
}