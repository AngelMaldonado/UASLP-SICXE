namespace PracticaSICXE
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
            this.archivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.CargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.Ensamblar = new System.Windows.Forms.ToolStripButton();
            this.MostrarErrores = new System.Windows.Forms.ToolStripButton();
            this.NumErrores = new System.Windows.Forms.ToolStripButton();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCodigo = new System.Windows.Forms.TabPage();
            this.SICXETabPage = new System.Windows.Forms.TabPage();
            this.SICTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TABSIMPanel = new System.Windows.Forms.Panel();
            this.TABSIMLabel = new System.Windows.Forms.Label();
            this.archivoIntermedioLabel = new System.Windows.Forms.Label();
            this.CONTLOCPanel = new System.Windows.Forms.Panel();
            this.CONTLOCDataGridView = new System.Windows.Forms.DataGridView();
            this.LN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETIQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMBOLO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABSIMDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new PracticaSICXE.controles.TextBoxEnumerado();
            this.longitudPrograma = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCodigo.SuspendLayout();
            this.SICXETabPage.SuspendLayout();
            this.SICTableLayoutPanel.SuspendLayout();
            this.TABSIMPanel.SuspendLayout();
            this.CONTLOCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CONTLOCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABSIMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // archivo
            // 
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(0, 18);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.longitudPrograma});
            this.statusStrip.Location = new System.Drawing.Point(0, 649);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1062, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CargarArchivo,
            this.Ensamblar,
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
            this.CargarArchivo.Image = global::SICXE.Properties.Resources.Archivo;
            this.CargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(163, 32);
            this.CargarArchivo.Text = "Cargar archivo";
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // Ensamblar
            // 
            this.Ensamblar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Ensamblar.Image = global::SICXE.Properties.Resources.Compilar;
            this.Ensamblar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ensamblar.Name = "Ensamblar";
            this.Ensamblar.Size = new System.Drawing.Size(126, 32);
            this.Ensamblar.Text = "Ensamblar";
            this.Ensamblar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // MostrarErrores
            // 
            this.MostrarErrores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MostrarErrores.Image = global::SICXE.Properties.Resources.Errores;
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
            this.NumErrores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NumErrores.Name = "NumErrores";
            this.NumErrores.Size = new System.Drawing.Size(29, 32);
            this.NumErrores.Text = "0";
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.tabControl);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsPanel.Location = new System.Drawing.Point(0, 35);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.tabsPanel.Size = new System.Drawing.Size(1062, 614);
            this.tabsPanel.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCodigo);
            this.tabControl.Controls.Add(this.SICXETabPage);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1046, 598);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCodigo
            // 
            this.tabPageCodigo.Controls.Add(this.codigo);
            this.tabPageCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageCodigo.Location = new System.Drawing.Point(4, 34);
            this.tabPageCodigo.Name = "tabPageCodigo";
            this.tabPageCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCodigo.Size = new System.Drawing.Size(1038, 562);
            this.tabPageCodigo.TabIndex = 0;
            this.tabPageCodigo.Text = "Código";
            this.tabPageCodigo.UseVisualStyleBackColor = true;
            // 
            // SICXETabPage
            // 
            this.SICXETabPage.Controls.Add(this.SICTableLayoutPanel);
            this.SICXETabPage.Location = new System.Drawing.Point(4, 34);
            this.SICXETabPage.Name = "SICXETabPage";
            this.SICXETabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SICXETabPage.Size = new System.Drawing.Size(1038, 560);
            this.SICXETabPage.TabIndex = 1;
            this.SICXETabPage.Text = "SIC/XE";
            this.SICXETabPage.UseVisualStyleBackColor = true;
            // 
            // SICTableLayoutPanel
            // 
            this.SICTableLayoutPanel.ColumnCount = 2;
            this.SICTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28294F));
            this.SICTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.71705F));
            this.SICTableLayoutPanel.Controls.Add(this.TABSIMPanel, 1, 1);
            this.SICTableLayoutPanel.Controls.Add(this.TABSIMLabel, 1, 0);
            this.SICTableLayoutPanel.Controls.Add(this.archivoIntermedioLabel, 0, 0);
            this.SICTableLayoutPanel.Controls.Add(this.CONTLOCPanel, 0, 1);
            this.SICTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SICTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.SICTableLayoutPanel.Name = "SICTableLayoutPanel";
            this.SICTableLayoutPanel.RowCount = 2;
            this.SICTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SICTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.SICTableLayoutPanel.Size = new System.Drawing.Size(1032, 554);
            this.SICTableLayoutPanel.TabIndex = 0;
            // 
            // TABSIMPanel
            // 
            this.TABSIMPanel.Controls.Add(this.TABSIMDataGridView);
            this.TABSIMPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABSIMPanel.Location = new System.Drawing.Point(718, 28);
            this.TABSIMPanel.Name = "TABSIMPanel";
            this.TABSIMPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.TABSIMPanel.Size = new System.Drawing.Size(311, 525);
            this.TABSIMPanel.TabIndex = 3;
            // 
            // TABSIMLabel
            // 
            this.TABSIMLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TABSIMLabel.AutoSize = true;
            this.TABSIMLabel.Location = new System.Drawing.Point(718, 0);
            this.TABSIMLabel.Name = "TABSIMLabel";
            this.TABSIMLabel.Size = new System.Drawing.Size(311, 25);
            this.TABSIMLabel.TabIndex = 1;
            this.TABSIMLabel.Text = "TABSIM";
            this.TABSIMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // archivoIntermedioLabel
            // 
            this.archivoIntermedioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.archivoIntermedioLabel.AutoSize = true;
            this.archivoIntermedioLabel.Location = new System.Drawing.Point(3, 0);
            this.archivoIntermedioLabel.Name = "archivoIntermedioLabel";
            this.archivoIntermedioLabel.Size = new System.Drawing.Size(709, 25);
            this.archivoIntermedioLabel.TabIndex = 0;
            this.archivoIntermedioLabel.Text = "Archivo Intermedio (CONTLOC)";
            this.archivoIntermedioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONTLOCPanel
            // 
            this.CONTLOCPanel.Controls.Add(this.CONTLOCDataGridView);
            this.CONTLOCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONTLOCPanel.Location = new System.Drawing.Point(3, 28);
            this.CONTLOCPanel.Name = "CONTLOCPanel";
            this.CONTLOCPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.CONTLOCPanel.Size = new System.Drawing.Size(709, 525);
            this.CONTLOCPanel.TabIndex = 2;
            // 
            // CONTLOCDataGridView
            // 
            this.CONTLOCDataGridView.AllowUserToAddRows = false;
            this.CONTLOCDataGridView.AllowUserToDeleteRows = false;
            this.CONTLOCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CONTLOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CONTLOCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LN,
            this.CP,
            this.ETIQ,
            this.INS,
            this.OPER,
            this.MODO});
            this.CONTLOCDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONTLOCDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CONTLOCDataGridView.Location = new System.Drawing.Point(0, 8);
            this.CONTLOCDataGridView.Name = "CONTLOCDataGridView";
            this.CONTLOCDataGridView.ReadOnly = true;
            this.CONTLOCDataGridView.RowHeadersWidth = 51;
            this.CONTLOCDataGridView.RowTemplate.Height = 24;
            this.CONTLOCDataGridView.Size = new System.Drawing.Size(709, 517);
            this.CONTLOCDataGridView.TabIndex = 0;
            // 
            // LN
            // 
            this.LN.HeaderText = "LN";
            this.LN.MinimumWidth = 6;
            this.LN.Name = "LN";
            this.LN.ReadOnly = true;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.MinimumWidth = 6;
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // ETIQ
            // 
            this.ETIQ.HeaderText = "ETIQ";
            this.ETIQ.MinimumWidth = 6;
            this.ETIQ.Name = "ETIQ";
            this.ETIQ.ReadOnly = true;
            // 
            // INS
            // 
            this.INS.HeaderText = "INS";
            this.INS.MinimumWidth = 6;
            this.INS.Name = "INS";
            this.INS.ReadOnly = true;
            // 
            // OPER
            // 
            this.OPER.HeaderText = "OPER";
            this.OPER.MinimumWidth = 6;
            this.OPER.Name = "OPER";
            this.OPER.ReadOnly = true;
            // 
            // MODO
            // 
            this.MODO.HeaderText = "MODO";
            this.MODO.MinimumWidth = 6;
            this.MODO.Name = "MODO";
            this.MODO.ReadOnly = true;
            // 
            // DIR
            // 
            this.DIR.HeaderText = "DIR";
            this.DIR.MinimumWidth = 6;
            this.DIR.Name = "DIR";
            this.DIR.ReadOnly = true;
            // 
            // SIMBOLO
            // 
            this.SIMBOLO.HeaderText = "SIMBOLO";
            this.SIMBOLO.MinimumWidth = 6;
            this.SIMBOLO.Name = "SIMBOLO";
            this.SIMBOLO.ReadOnly = true;
            // 
            // TABSIMDataGridView
            // 
            this.TABSIMDataGridView.AllowUserToAddRows = false;
            this.TABSIMDataGridView.AllowUserToDeleteRows = false;
            this.TABSIMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABSIMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABSIMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIMBOLO,
            this.DIR});
            this.TABSIMDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABSIMDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TABSIMDataGridView.Location = new System.Drawing.Point(0, 8);
            this.TABSIMDataGridView.Name = "TABSIMDataGridView";
            this.TABSIMDataGridView.ReadOnly = true;
            this.TABSIMDataGridView.RowHeadersWidth = 51;
            this.TABSIMDataGridView.RowTemplate.Height = 24;
            this.TABSIMDataGridView.Size = new System.Drawing.Size(311, 517);
            this.TABSIMDataGridView.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.Window;
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigo.Location = new System.Drawing.Point(3, 3);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(1032, 556);
            this.codigo.TabIndex = 4;
            // 
            // longitudPrograma
            // 
            this.longitudPrograma.Name = "longitudPrograma";
            this.longitudPrograma.Size = new System.Drawing.Size(0, 18);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tabsPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "SICXE";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageCodigo.ResumeLayout(false);
            this.SICXETabPage.ResumeLayout(false);
            this.SICTableLayoutPanel.ResumeLayout(false);
            this.SICTableLayoutPanel.PerformLayout();
            this.TABSIMPanel.ResumeLayout(false);
            this.CONTLOCPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CONTLOCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABSIMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel archivo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton CargarArchivo;
        private System.Windows.Forms.ToolStripButton Ensamblar;
        private System.Windows.Forms.ToolStripButton NumErrores;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton MostrarErrores;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCodigo;
        private controles.TextBoxEnumerado codigo;
        private System.Windows.Forms.TabPage SICXETabPage;
        private System.Windows.Forms.TableLayoutPanel SICTableLayoutPanel;
        private System.Windows.Forms.Label TABSIMLabel;
        private System.Windows.Forms.Label archivoIntermedioLabel;
        private System.Windows.Forms.Panel CONTLOCPanel;
        private System.Windows.Forms.Panel TABSIMPanel;
        private System.Windows.Forms.DataGridView CONTLOCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETIQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn INS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODO;
        private System.Windows.Forms.DataGridView TABSIMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIR;
        private System.Windows.Forms.ToolStripStatusLabel longitudPrograma;
    }
}

