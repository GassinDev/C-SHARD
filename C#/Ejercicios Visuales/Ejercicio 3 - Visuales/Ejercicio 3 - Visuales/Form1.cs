namespace Ejercicio_3___Visuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTsuma_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            int n1, n2, n3;

            if (int.TryParse(TBoperador1.Text,out n1) && int.TryParse(TBoperador2.Text, out n2))
            {
                n3 = n1 + n2;
                TBresultado.Text = n3.ToString();
            }
            else
            {
                MessageBox.Show("Introduce numeros");
            }            
        }

        private void BTresta_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            int n1, n2, n3;

            if (int.TryParse(TBoperador1.Text, out n1) && int.TryParse(TBoperador2.Text, out n2))
            {
                n3 = n1 - n2;
                TBresultado.Text = n3.ToString();
            }
            else
            {
                MessageBox.Show("Introduce numeros");
            }
        }

        private void BTmultiplicacion_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            int n1, n2, n3;

            if (int.TryParse(TBoperador1.Text, out n1) && int.TryParse(TBoperador2.Text, out n2))
            {
                n3 = n1 * n2;
                TBresultado.Text = n3.ToString();
            }
            else
            {
                MessageBox.Show("Introduce numeros");
            }
        }

        private void BTdivision_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            int n1, n2;
            double n3;

            if (int.TryParse(TBoperador1.Text, out n1) && int.TryParse(TBoperador2.Text, out n2))
            {
                n3 = (double)n1 / (double)n2;
                TBresultado.Text = n3.ToString();
            }
            else
            {
                MessageBox.Show("Introduce numeros");
            }
        }

        private void TBoperador1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoperador2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}