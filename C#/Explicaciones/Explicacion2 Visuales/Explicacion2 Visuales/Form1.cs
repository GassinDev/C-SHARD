namespace Explicacion2_Visuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ' && textBox1.SelectionStart == textBox1.Text.Length)
            {
                e.Handled = true;
            }

            if(e.KeyChar == 13)
            {
                label1.Text = textBox1.Text;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.T && e.Control && e.Alt)
            {
                textBox1.SelectAll();
                e.SuppressKeyPress = true;
            }

            if(e.KeyValue == null)
            {

            }
        }
    }
}