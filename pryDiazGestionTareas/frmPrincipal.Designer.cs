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
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYAsignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTareas = new System.Windows.Forms.TabControl();
            this.tabPendientes = new System.Windows.Forms.TabPage();
            this.txtIdPendientes = new System.Windows.Forms.TextBox();
            this.lblIdPendientes = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.tabCompletadas = new System.Windows.Forms.TabPage();
            this.txtIdCompletadas = new System.Windows.Forms.TextBox();
            this.lblIdCompletadas = new System.Windows.Forms.Label();
            this.btnReabrir = new System.Windows.Forms.Button();
            this.dgvCompletadas = new System.Windows.Forms.DataGridView();
            this.stpEstado = new System.Windows.Forms.StatusStrip();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.mnuInicio.SuspendLayout();
            this.tabTareas.SuspendLayout();
            this.tabPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.tabCompletadas.SuspendLayout();
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
            this.crearYAsignarToolStripMenuItem.Click += new System.EventHandler(this.crearYAsignarToolStripMenuItem_Click);
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
            this.verToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
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
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
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
            this.tabPendientes.Controls.Add(this.btnActualizar);
            this.tabPendientes.Controls.Add(this.txtIdPendientes);
            this.tabPendientes.Controls.Add(this.lblIdPendientes);
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
            // txtIdPendientes
            // 
            this.txtIdPendientes.Location = new System.Drawing.Point(129, 23);
            this.txtIdPendientes.Name = "txtIdPendientes";
            this.txtIdPendientes.Size = new System.Drawing.Size(69, 20);
            this.txtIdPendientes.TabIndex = 16;
            // 
            // lblIdPendientes
            // 
            this.lblIdPendientes.AutoSize = true;
            this.lblIdPendientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPendientes.Location = new System.Drawing.Point(19, 23);
            this.lblIdPendientes.Name = "lblIdPendientes";
            this.lblIdPendientes.Size = new System.Drawing.Size(95, 17);
            this.lblIdPendientes.TabIndex = 15;
            this.lblIdPendientes.Text = "ID de la tarea:";
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
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Location = new System.Drawing.Point(18, 67);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(514, 185);
            this.dgvPendientes.TabIndex = 0;
            // 
            // tabCompletadas
            // 
            this.tabCompletadas.Controls.Add(this.txtIdCompletadas);
            this.tabCompletadas.Controls.Add(this.lblIdCompletadas);
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
            // txtIdCompletadas
            // 
            this.txtIdCompletadas.Location = new System.Drawing.Point(127, 27);
            this.txtIdCompletadas.Name = "txtIdCompletadas";
            this.txtIdCompletadas.Size = new System.Drawing.Size(69, 20);
            this.txtIdCompletadas.TabIndex = 18;
            // 
            // lblIdCompletadas
            // 
            this.lblIdCompletadas.AutoSize = true;
            this.lblIdCompletadas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCompletadas.Location = new System.Drawing.Point(17, 27);
            this.lblIdCompletadas.Name = "lblIdCompletadas";
            this.lblIdCompletadas.Size = new System.Drawing.Size(95, 17);
            this.lblIdCompletadas.TabIndex = 17;
            this.lblIdCompletadas.Text = "ID de la tarea:";
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
            this.btnReabrir.Click += new System.EventHandler(this.btnReabrir_Click);
            // 
            // dgvCompletadas
            // 
            this.dgvCompletadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletadas.Location = new System.Drawing.Point(15, 66);
            this.dgvCompletadas.Name = "dgvCompletadas";
            this.dgvCompletadas.Size = new System.Drawing.Size(519, 197);
            this.dgvCompletadas.TabIndex = 0;
            // 
            // stpEstado
            // 
            this.stpEstado.Location = new System.Drawing.Point(0, 419);
            this.stpEstado.Name = "stpEstado";
            this.stpEstado.Size = new System.Drawing.Size(592, 22);
            this.stpEstado.TabIndex = 2;
            this.stpEstado.Text = "Estado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(399, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 36);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuInicio.ResumeLayout(false);
            this.mnuInicio.PerformLayout();
            this.tabTareas.ResumeLayout(false);
            this.tabPendientes.ResumeLayout(false);
            this.tabPendientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.tabCompletadas.ResumeLayout(false);
            this.tabCompletadas.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIdPendientes;
        private System.Windows.Forms.Label lblIdPendientes;
        private System.Windows.Forms.TextBox txtIdCompletadas;
        private System.Windows.Forms.Label lblIdCompletadas;
        private System.Windows.Forms.Button btnActualizar;
    }
}