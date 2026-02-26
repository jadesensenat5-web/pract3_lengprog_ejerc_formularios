namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarPerfecto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPerfecto.Text, out int n))
            {
                int suma = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0) suma += i;
                }

                if (suma == n && n != 0)
                    MessageBox.Show($"{n} es un número perfecto.");
                else
                    MessageBox.Show($"{n} no es un número perfecto.");
            }
        }
    }
}
