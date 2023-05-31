namespace Ejercicio_20___Visuales_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox1.Text.Length <= 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled=true;
            }

            if( textBox1.Text.Length == 4)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Length <= 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

            if (textBox2.Text.Length == 4)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text.Length <= 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

            if (textBox3.Text.Length == 4)
            {
                textBox4.Focus();
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text.Length <= 3)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == 8))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

            if(textBox1.Text.Length == 4 && textBox2.Text.Length == 4 && textBox3.Text.Length == 4 && textBox4.Text.Length == 4)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string creditCard = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;

            int[] array = new int[16];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(creditCard[i].ToString());

            }
            for (int i = 1; i < array.Length; i = i + 2)
            {
                array[i] = array[i] * 2;
                if (array[i] >= 10)
                {
                    array[i] = array[i] - 9;
                }

            }
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            if (suma % 10 == 0)
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Inválido");
            }
        }
    }
}