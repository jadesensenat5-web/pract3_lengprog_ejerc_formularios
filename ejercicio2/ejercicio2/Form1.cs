namespace ejercicio2
{
    public partial class Form1 : Form
    {
        int segundosTotales;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            segundosTotales = ((int)numMinutos.Value * 60) + (int)numSegundos.Value;

            if (segundosTotales > 0)
            {
                timerReloj.Start(); 
                btnIniciar.Enabled = false; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (segundosTotales > 0)
            {
                segundosTotales--; 

               
                int min = segundosTotales / 60;
                int seg = segundosTotales % 60;
                lblTiempo.Text = $"{min:00}:{seg:00}";
            }
            else
            {
                timerReloj.Stop(); 
                btnIniciar.Enabled = true; 
                MessageBox.Show("¡El tiempo se ha agotado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numSegundos_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


    

