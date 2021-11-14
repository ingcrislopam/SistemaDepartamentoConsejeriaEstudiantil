namespace FormularioAntecedenteFamiliar
{
    partial class ExportarAntecedentesFamiliares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarAntecedentesFamiliares));
            this.btnExportar = new Controles.boton();
            this.btnBuscar = new Controles.boton();
            this.btnNuevo = new Controles.boton();
            this.dtgAntecedentesFamiliares = new Controles.dataG();
            this.dtpFechaHasta = new Controles.dataFecha();
            this.dtpFechaDesde = new Controles.dataFecha();
            this.etiqueta2 = new Controles.etiqueta();
            this.etiqueta1 = new Controles.etiqueta();
            this.btnSalir = new Controles.boton();
            this.etiqueta5 = new Controles.etiqueta();
            this.etiqueta4 = new Controles.etiqueta();
            this.etiqueta3 = new Controles.etiqueta();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAntecedentesFamiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(694, 382);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 59);
            this.btnExportar.TabIndex = 23;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(694, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 59);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(694, 142);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 59);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtgAntecedentesFamiliares
            // 
            this.dtgAntecedentesFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAntecedentesFamiliares.Location = new System.Drawing.Point(12, 123);
            this.dtgAntecedentesFamiliares.Name = "dtgAntecedentesFamiliares";
            this.dtgAntecedentesFamiliares.ReadOnly = true;
            this.dtgAntecedentesFamiliares.Size = new System.Drawing.Size(676, 318);
            this.dtgAntecedentesFamiliares.TabIndex = 20;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(459, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaHasta.TabIndex = 19;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(188, 88);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaDesde.TabIndex = 18;
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(368, 92);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(85, 16);
            this.etiqueta2.TabIndex = 17;
            this.etiqueta2.Text = "Fecha hasta:";
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(91, 92);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(91, 16);
            this.etiqueta1.TabIndex = 16;
            this.etiqueta1.Text = "Fecha desde:";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(694, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // etiqueta5
            // 
            this.etiqueta5.AutoSize = true;
            this.etiqueta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta5.Location = new System.Drawing.Point(707, 123);
            this.etiqueta5.Name = "etiqueta5";
            this.etiqueta5.Size = new System.Drawing.Size(51, 16);
            this.etiqueta5.TabIndex = 25;
            this.etiqueta5.Text = "Nuevo:";
            // 
            // etiqueta4
            // 
            this.etiqueta4.AutoSize = true;
            this.etiqueta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta4.Location = new System.Drawing.Point(707, 241);
            this.etiqueta4.Name = "etiqueta4";
            this.etiqueta4.Size = new System.Drawing.Size(53, 16);
            this.etiqueta4.TabIndex = 26;
            this.etiqueta4.Text = "Buscar:";
            // 
            // etiqueta3
            // 
            this.etiqueta3.AutoSize = true;
            this.etiqueta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta3.Location = new System.Drawing.Point(701, 363);
            this.etiqueta3.Name = "etiqueta3";
            this.etiqueta3.Size = new System.Drawing.Size(61, 16);
            this.etiqueta3.TabIndex = 27;
            this.etiqueta3.Text = "Exportar:";
            // 
            // ExportarAntecedentesFamiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.etiqueta3);
            this.Controls.Add(this.etiqueta4);
            this.Controls.Add(this.etiqueta5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgAntecedentesFamiliares);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.etiqueta2);
            this.Controls.Add(this.etiqueta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportarAntecedentesFamiliares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgAntecedentesFamiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.boton btnExportar;
        private Controles.boton btnBuscar;
        private Controles.boton btnNuevo;
        private Controles.dataG dtgAntecedentesFamiliares;
        private Controles.dataFecha dtpFechaHasta;
        private Controles.dataFecha dtpFechaDesde;
        private Controles.etiqueta etiqueta2;
        private Controles.etiqueta etiqueta1;
        private Controles.boton btnSalir;
        private Controles.etiqueta etiqueta5;
        private Controles.etiqueta etiqueta4;
        private Controles.etiqueta etiqueta3;
    }
}