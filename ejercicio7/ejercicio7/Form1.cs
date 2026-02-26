namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerPrimos_Click(object sender, EventArgs e)
        {
            lstPrimos.Items.Clear();
            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin))
            {
                for (int n = inicio; n <= fin; n++)
                {
                    if (n < 2) continue;
                    bool esPrimo = true;
                    for (int i = 2; i * i <= n; i++)
                    {
                        if (n % i == 0) { esPrimo = false; break; }
                    }
                    if (esPrimo) lstPrimos.Items.Add(n);
                }
            }
        }
    }
}
