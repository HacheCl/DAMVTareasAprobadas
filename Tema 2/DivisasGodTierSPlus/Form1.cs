namespace DivisasGodTierSPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarOpciones(comboOrigen);
            CargarOpciones(comboDestino);
            CargarHistorial();
        }
        public void CargarHistorial()
        {
            try
            {
                StreamReader sr = new StreamReader("historial.txt");


                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    txtResultado.Text += linea + "\n";
                }
            }catch(Exception e)
            {
                MessageBox.Show("No se ha podido cargar el historial");
            }
        }
        public void CargarOpciones(ComboBox combo)
        {
            combo.Items.Add(new Moneda("Dolar", 1));
            combo.Items.Add(new Moneda("Euro", 1.05));
            combo.Items.Add(new Moneda("Libra", 1.30));
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            Moneda origen = comboOrigen.SelectedItem as Moneda;
            Moneda destino = comboDestino.SelectedItem as Moneda;
            double cantidad = double.Parse(txtImporte.Text);
            double resultado = (cantidad * origen.Valor) / destino.Valor;
            txtResultado.Text += resultado.ToString() + "\n";
            using (StreamWriter sw = new StreamWriter("historial.txt", true))
            {
                sw.WriteLine(resultado.ToString() + "\n");
            }



        }
    }
}