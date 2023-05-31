namespace Ejercicio_9___Visuales
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
            this.Letras = new System.Windows.Forms.Label();
            this.palabras = new System.Windows.Forms.Label();
            this.espacios = new System.Windows.Forms.Label();
            this.vocales = new System.Windows.Forms.Label();
            this.consonantes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Letras
            // 
            this.Letras.AutoSize = true;
            this.Letras.Location = new System.Drawing.Point(553, 137);
            this.Letras.Name = "Letras";
            this.Letras.Size = new System.Drawing.Size(32, 15);
            this.Letras.TabIndex = 0;
            this.Letras.Text = "label";
            this.Letras.Click += new System.EventHandler(this.Letras_Click);
            // 
            // palabras
            // 
            this.palabras.AutoSize = true;
            this.palabras.Location = new System.Drawing.Point(553, 174);
            this.palabras.Name = "palabras";
            this.palabras.Size = new System.Drawing.Size(32, 15);
            this.palabras.TabIndex = 1;
            this.palabras.Text = "label";
            this.palabras.Click += new System.EventHandler(this.palabras_Click);
            // 
            // espacios
            // 
            this.espacios.AutoSize = true;
            this.espacios.Location = new System.Drawing.Point(553, 207);
            this.espacios.Name = "espacios";
            this.espacios.Size = new System.Drawing.Size(32, 15);
            this.espacios.TabIndex = 2;
            this.espacios.Text = "label";
            this.espacios.Click += new System.EventHandler(this.espacios_Click);
            // 
            // vocales
            // 
            this.vocales.AutoSize = true;
            this.vocales.Location = new System.Drawing.Point(553, 240);
            this.vocales.Name = "vocales";
            this.vocales.Size = new System.Drawing.Size(32, 15);
            this.vocales.TabIndex = 3;
            this.vocales.Text = "label";
            this.vocales.Click += new System.EventHandler(this.vocales_Click);
            // 
            // consonantes
            // 
            this.consonantes.AutoSize = true;
            this.consonantes.Location = new System.Drawing.Point(553, 279);
            this.consonantes.Name = "consonantes";
            this.consonantes.Size = new System.Drawing.Size(32, 15);
            this.consonantes.TabIndex = 4;
            this.consonantes.Text = "label";
            this.consonantes.Click += new System.EventHandler(this.consonantes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.consonantes);
            this.Controls.Add(this.vocales);
            this.Controls.Add(this.espacios);
            this.Controls.Add(this.palabras);
            this.Controls.Add(this.Letras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Letras;
        private Label palabras;
        private Label espacios;
        private Label vocales;
        private Label consonantes;
        private TextBox textBox1;
    }
}