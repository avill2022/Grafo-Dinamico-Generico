namespace Grafo_Generico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Nodo = new System.Windows.Forms.ToolStripButton();
            this.ListaDirigida = new System.Windows.Forms.ToolStripButton();
            this.ListaNoDirigida = new System.Windows.Forms.ToolStripButton();
            this.Arista_Generica = new System.Windows.Forms.ToolStripButton();
            this.Mueve_Nodo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nodo,
            this.ListaDirigida,
            this.ListaNoDirigida,
            this.Arista_Generica,
            this.Mueve_Nodo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Nodo
            // 
            this.Nodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Nodo.Image = ((System.Drawing.Image)(resources.GetObject("Nodo.Image")));
            this.Nodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nodo.Name = "Nodo";
            this.Nodo.Size = new System.Drawing.Size(41, 22);
            this.Nodo.Text = "Nodo";
            this.Nodo.Click += new System.EventHandler(this.Nodo_Click);
            // 
            // ListaDirigida
            // 
            this.ListaDirigida.AccessibleDescription = "ListaDirigida";
            this.ListaDirigida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListaDirigida.Image = ((System.Drawing.Image)(resources.GetObject("ListaDirigida.Image")));
            this.ListaDirigida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListaDirigida.Name = "ListaDirigida";
            this.ListaDirigida.Size = new System.Drawing.Size(76, 22);
            this.ListaDirigida.Text = "ListaDirigida";
            this.ListaDirigida.Click += new System.EventHandler(this.Lista_Dirigida_Click);
            // 
            // ListaNoDirigida
            // 
            this.ListaNoDirigida.AccessibleName = "ListaNoDirigida";
            this.ListaNoDirigida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListaNoDirigida.Image = ((System.Drawing.Image)(resources.GetObject("ListaNoDirigida.Image")));
            this.ListaNoDirigida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListaNoDirigida.Name = "ListaNoDirigida";
            this.ListaNoDirigida.Size = new System.Drawing.Size(92, 22);
            this.ListaNoDirigida.Text = "ListaNoDirigida";
            this.ListaNoDirigida.Click += new System.EventHandler(this.ListaNoDirigida_Click);
            // 
            // Arista_Generica
            // 
            this.Arista_Generica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Arista_Generica.Image = ((System.Drawing.Image)(resources.GetObject("Arista_Generica.Image")));
            this.Arista_Generica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Arista_Generica.Name = "Arista_Generica";
            this.Arista_Generica.Size = new System.Drawing.Size(90, 22);
            this.Arista_Generica.Text = "Arista Generica";
            this.Arista_Generica.Click += new System.EventHandler(this.Arista_Generica_Click);
            // 
            // Mueve_Nodo
            // 
            this.Mueve_Nodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Mueve_Nodo.Image = ((System.Drawing.Image)(resources.GetObject("Mueve_Nodo.Image")));
            this.Mueve_Nodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mueve_Nodo.Name = "Mueve_Nodo";
            this.Mueve_Nodo.Size = new System.Drawing.Size(80, 22);
            this.Mueve_Nodo.Text = "Mueve Nodo";
            this.Mueve_Nodo.Click += new System.EventHandler(this.Mueve_Nodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 484);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo dinámico y genérico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Nodo;
        private System.Windows.Forms.ToolStripButton ListaDirigida;
        private System.Windows.Forms.ToolStripButton ListaNoDirigida;
        private System.Windows.Forms.ToolStripButton Arista_Generica;
        private System.Windows.Forms.ToolStripButton Mueve_Nodo;
    }
}

