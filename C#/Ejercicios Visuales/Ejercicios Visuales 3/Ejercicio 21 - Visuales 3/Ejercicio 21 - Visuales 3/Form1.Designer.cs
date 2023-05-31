namespace Ejercicio_21___Visuales_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.modificar = new System.Windows.Forms.ToolStripButton();
            this.eliminar = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nombrecolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.datecolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.sexocolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.repetidorcolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.notafinalcolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.modificar,
            this.eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Añadir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(78, 22);
            this.modificar.Text = "Modificar";
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(70, 22);
            this.eliminar.Text = "Eliminar";
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombrecolumnHeader1,
            this.datecolumnHeader1,
            this.sexocolumnHeader1,
            this.repetidorcolumnHeader1,
            this.notafinalcolumnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 344);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nombrecolumnHeader1
            // 
            this.nombrecolumnHeader1.Text = "Nombre";
            this.nombrecolumnHeader1.Width = 150;
            // 
            // datecolumnHeader1
            // 
            this.datecolumnHeader1.Text = "Fecha de nacimiento";
            this.datecolumnHeader1.Width = 180;
            // 
            // sexocolumnHeader1
            // 
            this.sexocolumnHeader1.Text = "Sexo";
            // 
            // repetidorcolumnHeader1
            // 
            this.repetidorcolumnHeader1.Text = "Repetidor";
            this.repetidorcolumnHeader1.Width = 80;
            // 
            // notafinalcolumnHeader1
            // 
            this.notafinalcolumnHeader1.Text = "Nota Final";
            this.notafinalcolumnHeader1.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton modificar;
        private ToolStripButton eliminar;
        private ListView listView1;
        private ColumnHeader nombrecolumnHeader1;
        private ColumnHeader datecolumnHeader1;
        private ColumnHeader sexocolumnHeader1;
        private ColumnHeader repetidorcolumnHeader1;
        private ColumnHeader notafinalcolumnHeader1;
    }
}