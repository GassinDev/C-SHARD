namespace Ejercicio_7___Visuales
{
    public partial class Form1 : Form
    {
        DateTime fecha = DateTime.Now;
        bool modificado = false;

        public Form1()
        {
            InitializeComponent();
            update();
            cargafichero();
            
        }
        void creaficheros()
        {
            string dia = fecha.Day.ToString();
            string mes = fecha.Month.ToString();
            string anno = fecha.Year.ToString();
            string fechacompleta = dia + mes + anno + ".txt";

                StreamWriter sw = new StreamWriter(fechacompleta);
                sw.WriteLine(TextBoxGordo.Text);

                sw.Close();
            
        }

        void cargafichero()
        {
            string dia = fecha.Day.ToString();
            string mes = fecha.Month.ToString();
            string anno = fecha.Year.ToString();
            string fechacompleta = dia + mes + anno + ".txt";

            string linea1;

            if (File.Exists(fechacompleta))
            {
                StreamReader sr = new StreamReader(fechacompleta);

                while (!sr.EndOfStream)
                {
                    linea1 = sr.ReadLine();
                    TextBoxGordo.Text = linea1;
                }

                sr.Close();
            }
            else
            {
                TextBoxGordo.Text = "";
            }
           
        }

        void update()
        {
            textBoxRead2.Text = fecha.Day.ToString();
            textBoxRead3.Text = fecha.Month.ToString();
            textBoxRead4.Text = fecha.Year.ToString();

        }
        private void TextBoxGordo_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBoxRead3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRead2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRead4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiaSiguiente_Click(object sender, EventArgs e)
        {
            creaficheros();
            fecha = fecha.AddDays(1);
            update();
            cargafichero();


        }

        private void DiaAnterior_Click(object sender, EventArgs e)
        {
            creaficheros();
            fecha = fecha.AddDays(-1);
            update();
            cargafichero();
        }
    }
}