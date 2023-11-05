using Microsoft.Win32;

namespace DivisasGodTierSPlus
{
    public partial class Form1 : Form
    {
        List<string> listaHistorico = new List<string>();
        double cantidad;
        public Form1()
        {
            InitializeComponent();
            CargarOpciones(comboOrigen);
            CargarOpciones(comboDestino);
            CargarHistorialDesdeArchivo();
        }
        public void CargarHistorialDesdeArchivo()
        {
            try
            {
                if (File.Exists("historial.txt"))
                {
                    string[] lineas = File.ReadAllLines("historial.txt");
                    listaHistorico.AddRange(lineas);
                    Array.ForEach(lineas, linea => listaResultados.Items.Insert(0, linea));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar el historial: " + ex.Message);
            }
        }
        public void CargarOpciones(ComboBox combo)
        {
            combo.Items.Add(new Moneda("Dolar", 1));
            combo.Items.Add(new Moneda("Euro", 1.05));
            combo.Items.Add(new Moneda("Libra", 1.30));
        }

        public Boolean comprobarMonedas(Moneda origen, Moneda destino)
        {

            if (origen == null || destino == null)
            {
                MessageBox.Show("Por favor, selecciona una moneda de origen y destino.");
                return false;
            }

            if (origen.ToString() == destino.ToString())
            {
                MessageBox.Show("El origen y el destino no pueden ser iguales.");
                return false;
            }
            return true;
        }
        public Boolean Comprobar_Importe()
        {

            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("El campo de importe está vacío. Por favor, ingresa un valor válido.");
                return false;
            }

            if (!double.TryParse(txtImporte.Text, out cantidad))
            {
                MessageBox.Show("El valor ingresado en el campo de importe no es válido.");
                return false;
            }
            return true;
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            Moneda origen = comboOrigen.SelectedItem as Moneda;
            Moneda destino = comboDestino.SelectedItem as Moneda;
            if (comprobarMonedas(origen, destino) && Comprobar_Importe())
            {
                double resultado = (cantidad * origen.Valor) / destino.Valor;
                string registro = $"Fecha: {DateTime.Now} Importe inicial: {txtImporte.Text} Resultado: {Math.Round(resultado, 2)}";
                listaResultados.Items.Insert(0, registro);
                listaHistorico.Add(registro);
                // Guarda el registro en el archivo "historial.txt"
                File.AppendAllText("historial.txt", registro + Environment.NewLine);
            };

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int indiceOrigen = comboOrigen.SelectedIndex;
            int indiceDestino = comboDestino.SelectedIndex;

            comboOrigen.SelectedIndex = indiceDestino;
            comboDestino.SelectedIndex = indiceOrigen;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}