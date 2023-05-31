namespace Ejercicio_4___Visuales
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
            this.Mayor = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mayor
            // 
            this.Mayor.Location = new System.Drawing.Point(78, 286);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(75, 57);
            this.Mayor.TabIndex = 0;
            this.Mayor.Text = "Mayor";
            this.Mayor.UseVisualStyleBackColor = true;
            this.Mayor.Click += new System.EventHandler(this.Mayor_Click);
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(208, 286);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(75, 57);
            this.Igual.TabIndex = 1;
            this.Igual.Text = "Igual";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Menor
            // 
            this.Menor.Location = new System.Drawing.Point(329, 286);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(75, 57);
            this.Menor.TabIndex = 2;
            this.Menor.Text = "Menor";
            this.Menor.UseVisualStyleBackColor = true;
            this.Menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numero.Location = new System.Drawing.Point(231, 89);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(41, 54);
            this.numero.TabIndex = 3;
            this.numero.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Mayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Mayor;
        private Button Igual;
        private Button Menor;
        private Label numero;
    }
}