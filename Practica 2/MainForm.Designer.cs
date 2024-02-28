namespace Practica_SICXE
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.archivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.CargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.Compilar = new System.Windows.Forms.ToolStripButton();
            this.MostrarErrores = new System.Windows.Forms.ToolStripButton();
            this.NumErrores = new System.Windows.Forms.ToolStripButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.codigo = new Practica_SICXE.controles.TextBoxEnumerado();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivo
            // 
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(0, 16);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo});
            this.statusStrip.Location = new System.Drawing.Point(0, 651);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CargarArchivo,
            this.Compilar,
            this.MostrarErrores,
            this.NumErrores});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1062, 35);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CargarArchivo.Image = global::SICXE.Properties.Resources.folder;
            this.CargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(163, 32);
            this.CargarArchivo.Text = "Cargar archivo";
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // Compilar
            // 
            this.Compilar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Compilar.Image = global::SICXE.Properties.Resources.compilar;
            this.Compilar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(116, 32);
            this.Compilar.Text = "Compilar";
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // MostrarErrores
            // 
            this.MostrarErrores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MostrarErrores.Image = global::SICXE.Properties.Resources.error;
            this.MostrarErrores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MostrarErrores.Name = "MostrarErrores";
            this.MostrarErrores.Size = new System.Drawing.Size(97, 32);
            this.MostrarErrores.Text = "Errores";
            this.MostrarErrores.Click += new System.EventHandler(this.MostrarErrores_Click);
            // 
            // NumErrores
            // 
            this.NumErrores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NumErrores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumErrores.Image = ((System.Drawing.Image)(resources.GetObject("NumErrores.Image")));
            this.NumErrores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NumErrores.Name = "NumErrores";
            this.NumErrores.Size = new System.Drawing.Size(29, 32);
            this.NumErrores.Text = "0";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.codigo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.mainPanel.Size = new System.Drawing.Size(1062, 616);
            this.mainPanel.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.Window;
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigo.Location = new System.Drawing.Point(8, 8);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(1046, 600);
            this.codigo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "SICXE";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel archivo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton CargarArchivo;
        private System.Windows.Forms.ToolStripButton Compilar;
        private System.Windows.Forms.ToolStripButton NumErrores;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton MostrarErrores;
        private System.Windows.Forms.Panel mainPanel;
        private controles.TextBoxEnumerado codigo;
    }
}

