namespace ExplicacionVariosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label1.Text = textBox1.Text;
            DialogResult dr = f2.ShowDialog();
           

            //if (f == DialogResult.OK)
            //{
            //    Message.Equals("Feo");
            //}
            //else
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.cadena = textBox2.Text;
            f2.ShowDialog();
            string s = f2.cadena;
            MessageBox.Show(s);
        }
    }
}