namespace Ejercicio_19___Visuales_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numerico = new System.Windows.Forms.TextBox();
            this.numerosEnteros = new System.Windows.Forms.TextBox();
            this.numerosReales = new System.Windows.Forms.TextBox();
            this.letras = new System.Windows.Forms.TextBox();
            this.alfanumerico = new System.Windows.Forms.TextBox();
            this.nif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numerico
            // 
            this.numerico.Location = new System.Drawing.Point(210, 47);
            this.numerico.Name = "numerico";
            this.numerico.Size = new System.Drawing.Size(160, 23);
            this.numerico.TabIndex = 0;
            this.numerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerico_KeyPress);
            // 
            // numerosEnteros
            // 
            this.numerosEnteros.Location = new System.Drawing.Point(488, 109);
            this.numerosEnteros.Name = "numerosEnteros";
            this.numerosEnteros.Size = new System.Drawing.Size(160, 23);
            this.numerosEnteros.TabIndex = 1;
            this.numerosEnteros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerosEnteros_KeyPress);
            // 
            // numerosReales
            // 
            this.numerosReales.Location = new System.Drawing.Point(488, 164);
            this.numerosReales.Name = "numerosReales";
            this.numerosReales.Size = new System.Drawing.Size(160, 23);
            this.numerosReales.TabIndex = 2;
            this.numerosReales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerosReales_KeyPress);
            // 
            // letras
            // 
            this.letras.Location = new System.Drawing.Point(312, 222);
            this.letras.Name = "letras";
            this.letras.Size = new System.Drawing.Size(160, 23);
            this.letras.TabIndex = 3;
            this.letras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letras_KeyPress);
            // 
            // alfanumerico
            // 
            this.alfanumerico.Location = new System.Drawing.Point(312, 275);
            this.alfanumerico.Name = "alfanumerico";
            this.alfanumerico.Size = new System.Drawing.Size(160, 23);
            this.alfanumerico.TabIndex = 4;
            this.alfanumerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alfanumerico_KeyPress);
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(479, 335);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(160, 23);
            this.nif.TabIndex = 5;
            this.nif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nif_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numérico: sólo números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Números enteros: sólo números pero podemos escribir el símbolo “-“ delante.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Números reales: además de números negativos, nos permite poner decimales.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Letras: sólo letras (mayúsculas y minúsculas).";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alfanumérico: sólo letras y números.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "NIF: sólo NIF, es decir, 8 ó menos números y una letra (opcionalmente, que";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "compruebe que la letra sea correcta y no deje escribirla en caso contrario).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nif);
            this.Controls.Add(this.alfanumerico);
            this.Controls.Add(this.letras);
            this.Controls.Add(this.numerosReales);
            this.Controls.Add(this.numerosEnteros);
            this.Controls.Add(this.numerico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numerico;
        private TextBox numerosEnteros;
        private TextBox numerosReales;
        private TextBox letras;
        private TextBox alfanumerico;
        private TextBox nif;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}