namespace Ejercicio_8___Visuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Left = 368;
            label1.Top = 281;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
        }

        private void Arriba_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
        }

        private void Abajo_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
        }

        private void Centro_Click(object sender, EventArgs e)
        {
            label1.Left = 368;
            label1.Top = 281;

        }

        private void DiagonalArrIzq_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
            label1.Top = label1.Top - 10;
        }

        private void DiagonalArrDere_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Top = label1.Top - 10;
        }

        private void DiagonalInfeIzqu_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
            label1.Top = label1.Top + 10;
        }

        private void DiagonalInfeDere_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Top = label1.Top + 10;
        }
    }
}