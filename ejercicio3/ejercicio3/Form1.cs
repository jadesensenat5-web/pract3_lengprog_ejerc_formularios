namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            var factores = new Dictionary<string, double> {
        { "Metros", 1.0 },
        { "Centimetros", 0.01 },
        { "Pulgadas", 0.0254 }
    };
            if (double.TryParse(txtValor.Text, out double valor) &&
                cmbOrigen.SelectedItem != null && cmbDestino.SelectedItem != null)
            {
                double resultado = (valor * factores[cmbOrigen.Text]) / factores[cmbDestino.Text];

                MessageBox.Show($"Resultado: {resultado:N2}");
            }
            else
            {
                MessageBox.Show("Asegúrate de ingresar un número y seleccionar las unidades.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;
        }
    }
}
