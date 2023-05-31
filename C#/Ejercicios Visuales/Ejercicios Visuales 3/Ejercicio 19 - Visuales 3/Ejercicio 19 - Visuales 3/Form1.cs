namespace Ejercicio_19___Visuales_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numerico_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void numerosEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '-') && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '-')
                {
                    if (numerosReales.SelectionStart == 0 && numerosReales.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                   
                }

            }
        }


        private void alfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9')  && !(e.KeyChar == ',') && !(e.KeyChar == 8))
            {

                e.Handled = true;

            }
            else
            {

            }
        }

        private void numerosReales_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '-') && !(e.KeyChar == ',') && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '-')
                {
                    if (numerosEnteros.SelectionStart != 0 || numerosEnteros.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }

                }
                else
                {
                    if(e.KeyChar == ',')
                    {
                        if(numerosReales.SelectionStart == 0 || numerosReales.Text.Contains(',') || !char.IsDigit(numerosReales.Text[numerosReales.SelectionStart - 1]))
                        {
                            e.Handled = true;
                        }
                        
                    }
                }

                
            }
        }

    }
}