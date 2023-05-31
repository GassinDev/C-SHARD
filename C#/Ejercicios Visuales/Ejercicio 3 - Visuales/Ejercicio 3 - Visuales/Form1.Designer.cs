namespace Ejercicio_3___Visuales
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
            this.BTsuma = new System.Windows.Forms.Button();
            this.BTresta = new System.Windows.Forms.Button();
            this.BTmultiplicacion = new System.Windows.Forms.Button();
            this.BTdivision = new System.Windows.Forms.Button();
            this.TBoperador1 = new System.Windows.Forms.TextBox();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.TBoperador2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTsuma
            // 
            this.BTsuma.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTsuma.Location = new System.Drawing.Point(77, 316);
            this.BTsuma.Name = "BTsuma";
            this.BTsuma.Size = new System.Drawing.Size(75, 45);
            this.BTsuma.TabIndex = 0;
            this.BTsuma.Text = "+";
            this.BTsuma.UseVisualStyleBackColor = true;
            this.BTsuma.Click += new System.EventHandler(this.BTsuma_Click);
            // 
            // BTresta
            // 
            this.BTresta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTresta.Location = new System.Drawing.Point(341, 316);
            this.BTresta.Name = "BTresta";
            this.BTresta.Size = new System.Drawing.Size(75, 45);
            this.BTresta.TabIndex = 1;
            this.BTresta.Text = "-";
            this.BTresta.UseVisualStyleBackColor = true;
            this.BTresta.Click += new System.EventHandler(this.BTresta_Click);
            // 
            // BTmultiplicacion
            // 
            this.BTmultiplicacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTmultiplicacion.Location = new System.Drawing.Point(208, 316);
            this.BTmultiplicacion.Name = "BTmultiplicacion";
            this.BTmultiplicacion.Size = new System.Drawing.Size(75, 45);
            this.BTmultiplicacion.TabIndex = 2;
            this.BTmultiplicacion.Text = "*";
            this.BTmultiplicacion.UseVisualStyleBackColor = true;
            this.BTmultiplicacion.Click += new System.EventHandler(this.BTmultiplicacion_Click);
            // 
            // BTdivision
            // 
            this.BTdivision.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTdivision.Location = new System.Drawing.Point(208, 233);
            this.BTdivision.Name = "BTdivision";
            this.BTdivision.Size = new System.Drawing.Size(75, 45);
            this.BTdivision.TabIndex = 3;
            this.BTdivision.Text = "/";
            this.BTdivision.UseVisualStyleBackColor = true;
            this.BTdivision.Click += new System.EventHandler(this.BTdivision_Click);
            // 
            // TBoperador1
            // 
            this.TBoperador1.Location = new System.Drawing.Point(62, 119);
            this.TBoperador1.Name = "TBoperador1";
            this.TBoperador1.Size = new System.Drawing.Size(100, 23);
            this.TBoperador1.TabIndex = 4;
            this.TBoperador1.TextChanged += new System.EventHandler(this.TBoperador1_TextChanged);
            // 
            // TBresultado
            // 
            this.TBresultado.Location = new System.Drawing.Point(373, 119);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.Size = new System.Drawing.Size(100, 23);
            this.TBresultado.TabIndex = 5;
            this.TBresultado.TextChanged += new System.EventHandler(this.TBresultado_TextChanged);
            // 
            // TBoperador2
            // 
            this.TBoperador2.Location = new System.Drawing.Point(225, 119);
            this.TBoperador2.Name = "TBoperador2";
            this.TBoperador2.Size = new System.Drawing.Size(100, 23);
            this.TBoperador2.TabIndex = 6;
            this.TBoperador2.Tag = "";
            this.TBoperador2.TextChanged += new System.EventHandler(this.TBoperador2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoperador2);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.TBoperador1);
            this.Controls.Add(this.BTdivision);
            this.Controls.Add(this.BTmultiplicacion);
            this.Controls.Add(this.BTresta);
            this.Controls.Add(this.BTsuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTsuma;
        private Button BTresta;
        private Button BTmultiplicacion;
        private Button BTdivision;
        private TextBox TBoperador1;
        private TextBox TBresultado;
        private TextBox TBoperador2;
        private Label label1;
        private Label label2;
    }
}