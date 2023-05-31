using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_21___Visuales_3
{
    public partial class Form2 : Form
    {
        public string nombre, fechanacimiento, sexo, notafinal;
        public bool repetidor;
        
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nombre,string fecha2,string sexo,string repetidor,string notafinal)
        {
            InitializeComponent();
            nombreBox.Text = nombre;
            fecha.Value = DateTime.Parse(fecha2);            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = nombreBox.Text;
            fechanacimiento = fecha.Value.ToShortDateString();
            
            if(masculino.Checked)
            {
                sexo = "masculino";
            }
            else
            {
                sexo = "femenino";
            }

            notafinal = notaFinalBox.Text;

            if (checkBox1.Checked)
            {
                repetidor = true;
            }
            else
            {
                repetidor = false;
            }
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void nombreBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void notaFinalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBoxNota = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == ','))
            {
                e.Handled = true;

            }
            else
            {
                if (e.KeyChar == ',')
                {

                    if (textBoxNota.SelectionStart == 0 || !char.IsDigit(textBoxNota.Text[textBoxNota.SelectionStart - 1]) || textBoxNota.Text.Contains(','))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        
                    }

                }


            }

            if (textBoxNota.Text.Contains(","))
            {
                textBoxNota.MaxLength = 4;
            }
            else
            {
                if(textBoxNota.Text.Length == 1)
                {
                    textBoxNota.MaxLength = 2;
                }
                

            }

            
        }
    }
}
