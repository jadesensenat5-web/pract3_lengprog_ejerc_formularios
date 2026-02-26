namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", "");
            string inversa = new string(palabra.Reverse().ToArray());
            if (palabra != "" && palabra == inversa)
                MessageBox.Show("¡Es un Palíndromo!");
            else
                MessageBox.Show("No es un Palíndromo.");
        }
    }
}
