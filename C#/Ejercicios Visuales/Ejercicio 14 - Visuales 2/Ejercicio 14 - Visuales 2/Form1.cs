namespace Ejercicio_14___Visuales_2
{
    public partial class Form1 : Form
    {
        void leerFicheros1()
        {
            StreamReader sr = new StreamReader("PrimerosNombres.txt");
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] words1 = line.Split(" ");
                comboBox1.Items.Add(words1[0]);
            }
        }

        void leerFicheros2()
        {
            StreamReader sr = new StreamReader("SegundosNombres.txt");
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] words2 = line.Split(" ");
                comboBox2.Items.Add(words2[0]);

            }
        }

        public Form1()
        {
            InitializeComponent();
            leerFicheros1();
            leerFicheros2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
           titulo.Text = comboBox1.SelectedItem + " " + comboBox2.SelectedItem;
        }

        private void Aleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int titu1 = r.Next(0, comboBox1.Items.Count);

            Random r2 = new Random();
            int titu2 = r2.Next(0, comboBox2.Items.Count);

            comboBox1.SelectedItem = comboBox1.Items[titu1];
            comboBox2.SelectedItem = comboBox2.Items[titu2];

            titulo.Text = comboBox1.SelectedItem + " " + comboBox2.SelectedItem;
        }
    }
}