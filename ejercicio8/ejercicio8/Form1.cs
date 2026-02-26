namespace ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtOracion.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                lblResultado.Text = "Palabras: 0";
                return;
            }

            // Dividimos por espacios y eliminamos entradas vacías
            string[] palabras = texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lblResultado.Text = $"Palabras: {palabras.Length}";
        }
    }
}
