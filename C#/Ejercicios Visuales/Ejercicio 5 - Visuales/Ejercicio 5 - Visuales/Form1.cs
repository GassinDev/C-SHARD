namespace Ejercicio_5___Visuales
{
    public partial class Form1 : Form
    {
        bool semaforo = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void CENTIMETROS_TextChanged(object sender, EventArgs e)
        {
            if (semaforo)
            {
                semaforo = false;
                double cent;

                if (double.TryParse(CENTIMETROS.Text, out cent))
                {
                    PULGADAS.Text = (cent / 2.54).ToString();
                }
                else
                {
                    MessageBox.Show("NO PUEDO HACER ESO XURRA");
                }
                semaforo=true;
            }

            
            
        }

        private void PULGADAS_TextChanged(object sender, EventArgs e)
        {
            if (semaforo)
            {
                semaforo = false;
                double pul;

                if (double.TryParse(PULGADAS.Text, out pul))
                {
                    PULGADAS.Text = (pul * 2.54).ToString();
                }
                else
                {
                    MessageBox.Show("NO PUEDO HACER ESO XURRA");
                }
                semaforo = true;
            }
            
        }
    }
}