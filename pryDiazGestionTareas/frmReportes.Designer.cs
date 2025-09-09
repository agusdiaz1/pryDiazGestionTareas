namespace pryDiazGestionTareas
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.optPendientes = new System.Windows.Forms.RadioButton();
            this.optCompletadas = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.optCompletadas);
            this.panel1.Controls.Add(this.optPendientes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 79);
            this.panel1.TabIndex = 0;
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(12, 114);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(455, 251);
            this.dgvReportes.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(314, 390);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(153, 36);
            this.btnExportar.TabIndex = 16;
            this.btnExportar.Text = "Exportar reporte";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // optPendientes
            // 
            this.optPendientes.AutoSize = true;
            this.optPendientes.Location = new System.Drawing.Point(32, 29);
            this.optPendientes.Name = "optPendientes";
            this.optPendientes.Size = new System.Drawing.Size(78, 17);
            this.optPendientes.TabIndex = 0;
            this.optPendientes.TabStop = true;
            this.optPendientes.Text = "Pendientes";
            this.optPendientes.UseVisualStyleBackColor = true;
            // 
            // optCompletadas
            // 
            this.optCompletadas.AutoSize = true;
            this.optCompletadas.Location = new System.Drawing.Point(170, 29);
            this.optCompletadas.Name = "optCompletadas";
            this.optCompletadas.Size = new System.Drawing.Size(86, 17);
            this.optCompletadas.TabIndex = 1;
            this.optCompletadas.TabStop = true;
            this.optCompletadas.Text = "Completadas";
            this.optCompletadas.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(326, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(106, 52);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Filtrar tareas";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton optCompletadas;
        private System.Windows.Forms.RadioButton optPendientes;
        private System.Windows.Forms.Button btnExportar;
    }
}