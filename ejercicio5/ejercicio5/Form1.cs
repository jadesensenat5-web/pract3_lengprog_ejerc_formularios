namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroPrimo.Text, out int n))
            {
                if (n < 2) { MessageBox.Show("No es primo"); return; }
                bool esPrimo = true;
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0) { esPrimo = false; break; }
                }
                MessageBox.Show(esPrimo ? "Es un número Primo" : "No es Primo");
            }
        }
    }
    }

