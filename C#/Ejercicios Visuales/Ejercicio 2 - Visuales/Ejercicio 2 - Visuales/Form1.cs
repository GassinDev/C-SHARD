namespace Ejercicio_2___Visuales
{
    public partial class Form1 : Form
    {
        string fichero = "bloc.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("bloc.txt");

            sw.Write(textBox1.Text);

            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("bloc.txt");

            List<string> lineas = new List<string>();

            while (!sr.EndOfStream)
            {
                lineas.Add(sr.ReadLine());
            }

            textBox1.Lines = lineas.ToArray();

            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}