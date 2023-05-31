namespace Ejercicio_6___Visuales
{
    public partial class Form1 : Form
    {
        List<string> esp = new List<string>();
        List<string> ing = new List<string>();

        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("traduccion.txt");
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] words = line.Split(", ");

                esp.Add(words[0]);
                ing.Add(words[1]);

            }



            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingles_Español_Click(object sender, EventArgs e)
        {
            string palabra = textBox2.Text;

            for (int i = 0; i < ing.Count; i++)
            {
                if (ing[i] == palabra)
                {
                    textBox1.Text = esp[i];
                }
            }
        }

        private void Español_Ingles_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;

            for(int i = 0; i < esp.Count; i++)
            {
                if(esp[i] == palabra)
                {
                    textBox2.Text = ing[i];
                }
            }
        }
    }
}