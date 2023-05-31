namespace Ejercicio_5___Visuales
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
            this.CENTIMETROS = new System.Windows.Forms.TextBox();
            this.PULGADAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CENTIMETROS
            // 
            this.CENTIMETROS.Location = new System.Drawing.Point(193, 148);
            this.CENTIMETROS.Name = "CENTIMETROS";
            this.CENTIMETROS.Size = new System.Drawing.Size(100, 23);
            this.CENTIMETROS.TabIndex = 0;
            this.CENTIMETROS.TextChanged += new System.EventHandler(this.CENTIMETROS_TextChanged);
            // 
            // PULGADAS
            // 
            this.PULGADAS.Location = new System.Drawing.Point(420, 148);
            this.PULGADAS.Name = "PULGADAS";
            this.PULGADAS.Size = new System.Drawing.Size(100, 23);
            this.PULGADAS.TabIndex = 1;
            this.PULGADAS.TextChanged += new System.EventHandler(this.PULGADAS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "PULGADAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CENTÍMETROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PULGADAS);
            this.Controls.Add(this.CENTIMETROS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CENTIMETROS;
        private TextBox PULGADAS;
        private Label label1;
        private Label label2;
    }
}