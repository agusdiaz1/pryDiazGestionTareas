namespace pryDiazGestionTareas
{
    partial class frmPrincipal
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
            this.mnuInicio = new System.Windows.Forms.MenuStrip();
            this.tabTareas = new System.Windows.Forms.TabControl();
            this.tabPendientes = new System.Windows.Forms.TabPage();
            this.tabCompletadas = new System.Windows.Forms.TabPage();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYAsignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.dgvCompletadas = new System.Windows.Forms.DataGridView();
            this.btnReabrir = new System.Windows.Forms.Button();
            this.stpEstado = new System.Windows.Forms.StatusStrip();
            this.mnuInicio.SuspendLayout();
            this.tabTareas.SuspendLayout();
            this.tabPendientes.SuspendLayout();
            this.tabCompletadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletadas)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuInicio
            // 
            this.mnuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.mnuInicio.Location = new System.Drawing.Point(0, 0);
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(592, 24);
            this.mnuInicio.TabIndex = 0;
            this.mnuInicio.Text = "menuStrip1";
            // 
            // tabTareas
            // 
            this.tabTareas.Controls.Add(this.tabPendientes);
            this.tabTareas.Controls.Add(this.tabCompletadas);
            this.tabTareas.Location = new System.Drawing.Point(12, 42);
            this.tabTareas.Name = "tabTareas";
            this.tabTareas.SelectedIndex = 0;
            this.tabTareas.Size = new System.Drawing.Size(561, 365);
            this.tabTareas.TabIndex = 1;
            // 
            // tabPendientes
            // 
            this.tabPendientes.Controls.Add(this.btnCompletar);
            this.tabPendientes.Controls.Add(this.btnAgregar);
            this.tabPendientes.Controls.Add(this.dgvPendientes);
            this.tabPendientes.Location = new System.Drawing.Point(4, 22);
            this.tabPendientes.Name = "tabPendientes";
            this.tabPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendientes.Size = new System.Drawing.Size(553, 339);
            this.tabPendientes.TabIndex = 0;
            this.tabPendientes.Text = "Tareas pendientes";
            this.tabPendientes.UseVisualStyleBackColor = true;
            // 
            // tabCompletadas
            // 
            this.tabCompletadas.Controls.Add(this.btnReabrir);
            this.tabCompletadas.Controls.Add(this.dgvCompletadas);
            this.tabCompletadas.Location = new System.Drawing.Point(4, 22);
            this.tabCompletadas.Name = "tabCompletadas";
            this.tabCompletadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompletadas.Size = new System.Drawing.Size(553, 339);
            this.tabCompletadas.TabIndex = 1;
            this.tabCompletadas.Text = "Tareas completadas";
            this.tabCompletadas.UseVisualStyleBackColor = true;
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearYAsignarToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tareasToolStripMenuItem.Text = "Archivo";
            // 
            // crearYAsignarToolStripMenuItem
            // 
            this.crearYAsignarToolStripMenuItem.Name = "crearYAsignarToolStripMenuItem";
            this.crearYAsignarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearYAsignarToolStripMenuItem.Text = "Salir";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar reporte";
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Location = new System.Drawing.Point(18, 15);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(514, 237);
            this.dgvPendientes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(18, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 36);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar tareas";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.Location = new System.Drawing.Point(384, 283);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(148, 36);
            this.btnCompletar.TabIndex = 14;
            this.btnCompletar.Text = "Completar tarea";
            this.btnCompletar.UseVisualStyleBackColor = true;
            // 
            // dgvCompletadas
            // 
            this.dgvCompletadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletadas.Location = new System.Drawing.Point(15, 15);
            this.dgvCompletadas.Name = "dgvCompletadas";
            this.dgvCompletadas.Size = new System.Drawing.Size(519, 248);
            this.dgvCompletadas.TabIndex = 0;
            // 
            // btnReabrir
            // 
            this.btnReabrir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabrir.Location = new System.Drawing.Point(408, 283);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(126, 36);
            this.btnReabrir.TabIndex = 13;
            this.btnReabrir.Text = "Reabrir tarea";
            this.btnReabrir.UseVisualStyleBackColor = true;
            // 
            // stpEstado
            // 
            this.stpEstado.Location = new System.Drawing.Point(0, 419);
            this.stpEstado.Name = "stpEstado";
            this.stpEstado.Size = new System.Drawing.Size(592, 22);
            this.stpEstado.TabIndex = 2;
            this.stpEstado.Text = "Estado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(592, 441);
            this.Controls.Add(this.stpEstado);
            this.Controls.Add(this.tabTareas);
            this.Controls.Add(this.mnuInicio);
            this.MainMenuStrip = this.mnuInicio;
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            this.mnuInicio.ResumeLayout(false);
            this.mnuInicio.PerformLayout();
            this.tabTareas.ResumeLayout(false);
            this.tabPendientes.ResumeLayout(false);
            this.tabCompletadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuInicio;
        private System.Windows.Forms.TabControl tabTareas;
        private System.Windows.Forms.TabPage tabPendientes;
        private System.Windows.Forms.TabPage tabCompletadas;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearYAsignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReabrir;
        private System.Windows.Forms.DataGridView dgvCompletadas;
        private System.Windows.Forms.StatusStrip stpEstado;
    }
}