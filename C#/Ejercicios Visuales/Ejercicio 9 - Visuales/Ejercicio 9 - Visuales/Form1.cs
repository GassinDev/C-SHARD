namespace Ejercicio_9___Visuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Letras.Text = "Tiene " + 0 + " letras.";
            palabras.Text = "Tiene " + 0 + " palabras.";
            espacios.Text = "Tiene " + 0 + " espacios.";
            vocales.Text = "Tiene " + 0 + " vocales.";
            consonantes.Text = "Tiene " + 0 + " consonantes.";
        }

        private void Letras_Click(object sender, EventArgs e)
        {
            

        }

        private void palabras_Click(object sender, EventArgs e)
        {
            
        }

        private void espacios_Click(object sender, EventArgs e)
        {
            
        }

        private void vocales_Click(object sender, EventArgs e)
        {
            
        }
        private void consonantes_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vocal();
            conson();
            word();
            space();
            letter();
        }

        void vocal()
        {
            int i;
            string con = "aeiouAEIOU·ÈÌÛ˙¡…Õ”⁄";
            string s = " ";
            s = textBox1.Text;

            int cont = 0;

            for (i = 0; i < s.Length; i++)
            {

                if (con.Contains(s[i]))
                {

                    cont++;
                }
            }

            vocales.Text = "Tiene " + cont.ToString() + " vocales.";
        }

        void conson()
        {
            int i;
            string con = "qwrtypsdfghjklÒzxcvbnmQWERTYPSDFGHJKL—ZXCVBNM";
            string s = " ";
            s = textBox1.Text;

            int cont = 0;

            for (i = 0; i < s.Length; i++)
            {

                if (con.Contains(s[i]))
                {

                    cont++;
                }
            }
            consonantes.Text = "Tiene " + cont.ToString() + " consonantes.";
        }

        void word()
        {
            int i, cont = 0;
            string s = " ";
            s = textBox1.Text;

            for (i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] != ' ')
                {
                    cont++;
                }
            }

                palabras.Text = "Tiene " + cont.ToString() + " palabras.";
        }

        void space()
        {
            int i, cont = 0;

            string s = " ";
            s = textBox1.Text;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    cont++;
                }
            }

            espacios.Text = "Tiene " + cont.ToString() + " espacios.";
        }

        void letter()
        {
            int i, cont = 0;

            string s = " ";
            s = textBox1.Text;

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    cont++;
                }
            }

            Letras.Text = "Tiene " + cont.ToString() + " letras.";
        }


    }
}