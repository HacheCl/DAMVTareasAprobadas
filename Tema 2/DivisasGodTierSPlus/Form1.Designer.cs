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
            lbl_Importe = new Label();
            lbl_Combo1 = new Label();
            lbl_Comb2 = new Label();
            comboOrigen = new ComboBox();
            comboDestino = new ComboBox();
            btn_CambioCombo = new Button();
            btn_Ejecutar = new Button();
            txtResultado = new Label();
            txtImporte = new TextBox();
            SuspendLayout();
            // 
            // lbl_Importe
            // 
            lbl_Importe.AutoSize = true;
            lbl_Importe.Location = new Point(123, 84);
            lbl_Importe.Name = "lbl_Importe";
            lbl_Importe.Size = new Size(49, 15);
            lbl_Importe.TabIndex = 0;
            lbl_Importe.Text = "Importe";
            // 
            // lbl_Combo1
            // 
            lbl_Combo1.AutoSize = true;
            lbl_Combo1.Location = new Point(370, 83);
            lbl_Combo1.Name = "lbl_Combo1";
            lbl_Combo1.Size = new Size(24, 15);
            lbl_Combo1.TabIndex = 1;
            lbl_Combo1.Text = "De:";
            // 
            // lbl_Comb2
            // 
            lbl_Comb2.AutoSize = true;
            lbl_Comb2.Location = new Point(580, 83);
            lbl_Comb2.Name = "lbl_Comb2";
            lbl_Comb2.Size = new Size(18, 15);
            lbl_Comb2.TabIndex = 2;
            lbl_Comb2.Text = "A:";
            // 
            // comboOrigen
            // 
            comboOrigen.FormattingEnabled = true;
            comboOrigen.Location = new Point(326, 101);
            comboOrigen.Name = "comboOrigen";
            comboOrigen.Size = new Size(121, 23);
            comboOrigen.TabIndex = 3;
            // 
            // comboDestino
            // 
            comboDestino.FormattingEnabled = true;
            comboDestino.Location = new Point(530, 101);
            comboDestino.Name = "comboDestino";
            comboDestino.Size = new Size(121, 23);
            comboDestino.TabIndex = 4;
            // 
            // btn_CambioCombo
            // 
            btn_CambioCombo.BackColor = SystemColors.ActiveCaptionText;
            btn_CambioCombo.ForeColor = SystemColors.ControlText;
            btn_CambioCombo.Location = new Point(466, 101);
            btn_CambioCombo.Name = "btn_CambioCombo";
            btn_CambioCombo.Size = new Size(44, 23);
            btn_CambioCombo.TabIndex = 5;
            btn_CambioCombo.UseVisualStyleBackColor = false;
            // 
            // btn_Ejecutar
            // 
            btn_Ejecutar.Location = new Point(580, 254);
            btn_Ejecutar.Name = "btn_Ejecutar";
            btn_Ejecutar.Size = new Size(75, 23);
            btn_Ejecutar.TabIndex = 6;
            btn_Ejecutar.Text = "Enter";
            btn_Ejecutar.UseVisualStyleBackColor = true;
            btn_Ejecutar.Click += btn_Ejecutar_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Font = new Font("Noto Naskh Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(123, 243);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(113, 34);
            txtResultado.TabIndex = 7;
            txtResultado.Text = "Historico:";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(123, 102);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImporte);
            Controls.Add(txtResultado);
            Controls.Add(btn_Ejecutar);
            Controls.Add(btn_CambioCombo);
            Controls.Add(comboDestino);
            Controls.Add(comboOrigen);
            Controls.Add(lbl_Comb2);
            Controls.Add(lbl_Combo1);
            Controls.Add(lbl_Importe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Importe;
        private Label lbl_Combo1;
        private Label lbl_Comb2;
        private ComboBox comboOrigen;
        private ComboBox comboDestino;
        private Button btn_CambioCombo;
        private Button btn_Ejecutar;
        private Label txtResultado;
        private TextBox txtImporte;
    }
}