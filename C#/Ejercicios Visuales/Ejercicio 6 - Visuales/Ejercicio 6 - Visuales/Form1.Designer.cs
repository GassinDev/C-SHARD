namespace Ejercicio_6___Visuales
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ingles_Español = new System.Windows.Forms.Button();
            this.Español_Ingles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ingles_Español
            // 
            this.Ingles_Español.Location = new System.Drawing.Point(294, 261);
            this.Ingles_Español.Name = "Ingles_Español";
            this.Ingles_Español.Size = new System.Drawing.Size(165, 55);
            this.Ingles_Español.TabIndex = 2;
            this.Ingles_Español.Text = "Ingles --> Español";
            this.Ingles_Español.UseVisualStyleBackColor = true;
            this.Ingles_Español.Click += new System.EventHandler(this.Ingles_Español_Click);
            // 
            // Español_Ingles
            // 
            this.Español_Ingles.Location = new System.Drawing.Point(294, 337);
            this.Español_Ingles.Name = "Español_Ingles";
            this.Español_Ingles.Size = new System.Drawing.Size(165, 55);
            this.Español_Ingles.TabIndex = 3;
            this.Español_Ingles.Text = "Español ---> Ingles";
            this.Español_Ingles.UseVisualStyleBackColor = true;
            this.Español_Ingles.Click += new System.EventHandler(this.Español_Ingles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Español_Ingles);
            this.Controls.Add(this.Ingles_Español);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Ingles_Español;
        private Button Español_Ingles;
    }
}