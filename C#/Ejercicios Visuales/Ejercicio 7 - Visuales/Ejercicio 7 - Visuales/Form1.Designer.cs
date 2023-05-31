namespace Ejercicio_7___Visuales
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
            this.TextBoxGordo = new System.Windows.Forms.TextBox();
            this.textBoxRead2 = new System.Windows.Forms.TextBox();
            this.textBoxRead3 = new System.Windows.Forms.TextBox();
            this.textBoxRead4 = new System.Windows.Forms.TextBox();
            this.DiaSiguiente = new System.Windows.Forms.Button();
            this.DiaAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxGordo
            // 
            this.TextBoxGordo.Location = new System.Drawing.Point(55, 67);
            this.TextBoxGordo.Multiline = true;
            this.TextBoxGordo.Name = "TextBoxGordo";
            this.TextBoxGordo.Size = new System.Drawing.Size(701, 311);
            this.TextBoxGordo.TabIndex = 0;
            this.TextBoxGordo.TextChanged += new System.EventHandler(this.TextBoxGordo_TextChanged);
            // 
            // textBoxRead2
            // 
            this.textBoxRead2.Location = new System.Drawing.Point(55, 22);
            this.textBoxRead2.Name = "textBoxRead2";
            this.textBoxRead2.ReadOnly = true;
            this.textBoxRead2.Size = new System.Drawing.Size(123, 23);
            this.textBoxRead2.TabIndex = 1;
            this.textBoxRead2.TextChanged += new System.EventHandler(this.textBoxRead2_TextChanged);
            // 
            // textBoxRead3
            // 
            this.textBoxRead3.Location = new System.Drawing.Point(219, 22);
            this.textBoxRead3.Name = "textBoxRead3";
            this.textBoxRead3.ReadOnly = true;
            this.textBoxRead3.Size = new System.Drawing.Size(114, 23);
            this.textBoxRead3.TabIndex = 1;
            this.textBoxRead3.TextChanged += new System.EventHandler(this.textBoxRead3_TextChanged);
            // 
            // textBoxRead4
            // 
            this.textBoxRead4.Location = new System.Drawing.Point(403, 22);
            this.textBoxRead4.Name = "textBoxRead4";
            this.textBoxRead4.ReadOnly = true;
            this.textBoxRead4.Size = new System.Drawing.Size(118, 23);
            this.textBoxRead4.TabIndex = 2;
            this.textBoxRead4.TextChanged += new System.EventHandler(this.textBoxRead4_TextChanged);
            // 
            // DiaSiguiente
            // 
            this.DiaSiguiente.Location = new System.Drawing.Point(456, 394);
            this.DiaSiguiente.Name = "DiaSiguiente";
            this.DiaSiguiente.Size = new System.Drawing.Size(96, 44);
            this.DiaSiguiente.TabIndex = 3;
            this.DiaSiguiente.Text = "Dia siguiente";
            this.DiaSiguiente.UseVisualStyleBackColor = true;
            this.DiaSiguiente.Click += new System.EventHandler(this.DiaSiguiente_Click);
            // 
            // DiaAnterior
            // 
            this.DiaAnterior.Location = new System.Drawing.Point(219, 394);
            this.DiaAnterior.Name = "DiaAnterior";
            this.DiaAnterior.Size = new System.Drawing.Size(112, 44);
            this.DiaAnterior.TabIndex = 4;
            this.DiaAnterior.Text = "Dia anterior";
            this.DiaAnterior.UseVisualStyleBackColor = true;
            this.DiaAnterior.Click += new System.EventHandler(this.DiaAnterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiaAnterior);
            this.Controls.Add(this.DiaSiguiente);
            this.Controls.Add(this.textBoxRead4);
            this.Controls.Add(this.textBoxRead3);
            this.Controls.Add(this.textBoxRead2);
            this.Controls.Add(this.TextBoxGordo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxGordo;
        private TextBox textBoxRead2;
        private TextBox textBoxRead3;
        private TextBox textBoxRead4;
        private Button DiaSiguiente;
        private Button DiaAnterior;
    }
}