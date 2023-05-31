namespace Ejercicio_21___Visuales_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if(DialogResult.OK == f2.ShowDialog())
            {
                ListViewItem item = new ListViewItem(f2.nombre);
                item.SubItems.Add(f2.fechanacimiento);
                item.SubItems.Add(f2.sexo);
                item.SubItems.Add(f2.repetidor.ToString());
                item.SubItems.Add(f2.notafinal);

                listView1.Items.Add(item);
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            string nombre = listView1.SelectedItems[0].Text;
            string fechanacimiento = listView1.SelectedItems[0].SubItems[1].Text;
            string sexo = listView1.SelectedItems[0].SubItems[2].Text;
            string repetidor = listView1.SelectedItems[0].SubItems[3].Text;
            string notafinal = listView1.SelectedItems[0].SubItems[4].Text;
            Form2 f2 = new Form2();

            if (DialogResult.OK == f2.ShowDialog())
            {
                ListViewItem item = new ListViewItem(f2.nombre);
                item.SubItems.Add(f2.fechanacimiento);
                item.SubItems.Add(f2.sexo);
                item.SubItems.Add(f2.repetidor.ToString());
                item.SubItems.Add(f2.notafinal);

                listView1.Items.Add(item);
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}