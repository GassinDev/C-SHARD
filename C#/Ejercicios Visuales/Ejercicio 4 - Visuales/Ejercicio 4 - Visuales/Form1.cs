namespace Ejercicio_4___Visuales
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        int min = 1;
        int max = 100;

        public Form1()
        {
            InitializeComponent();
            numero.Text = r.Next(min, max + 1).ToString();
        }

        private void Mayor_Click(object sender, EventArgs e)
        {
            min = int.Parse(numero.Text);
            Random r = new Random();
            numero.Text = r.Next(min, max + 1).ToString();

        }

        private void Igual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESE ES TU NÚMERO, SOY LA PUTA POLLA");
        }

        private void Menor_Click(object sender, EventArgs e)
        {
            max = int.Parse(numero.Text);
            Random r = new Random();
            numero.Text = r.Next(min, max + 1).ToString();
        }
    }
}