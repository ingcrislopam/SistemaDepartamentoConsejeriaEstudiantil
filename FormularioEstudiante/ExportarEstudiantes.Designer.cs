namespace FormularioEstudiante
{
    partial class ExportarEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarEstudiantes));
            this.etiqueta1 = new Controles.etiqueta();
            this.etiqueta2 = new Controles.etiqueta();
            this.dtpFechaDesde = new Controles.dataFecha();
            this.dtpFechaHasta = new Controles.dataFecha();
            this.dtgEstudiantes = new Controles.dataG();
            this.btnNuevo = new Controles.boton();
            this.btnBuscar = new Controles.boton();
            this.btnExportar = new Controles.boton();
            this.btnSalir = new Controles.boton();
            this.etiqueta3 = new Controles.etiqueta();
            this.etiqueta4 = new Controles.etiqueta();
            this.etiqueta5 = new Controles.etiqueta();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(83, 92);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(91, 16);
            this.etiqueta1.TabIndex = 0;
            this.etiqueta1.Text = "Fecha desde:";
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(360, 92);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(85, 16);
            this.etiqueta2.TabIndex = 1;
            this.etiqueta2.Text = "Fecha hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(180, 88);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(451, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaHasta.TabIndex = 3;
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Location = new System.Drawing.Point(12, 123);
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.ReadOnly = true;
            this.dtgEstudiantes.Size = new System.Drawing.Size(676, 318);
            this.dtgEstudiantes.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(694, 142);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 59);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(694, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 62);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(694, 376);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 65);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(694, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // etiqueta3
            // 
            this.etiqueta3.AutoSize = true;
            this.etiqueta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta3.Location = new System.Drawing.Point(700, 357);
            this.etiqueta3.Name = "etiqueta3";
            this.etiqueta3.Size = new System.Drawing.Size(61, 16);
            this.etiqueta3.TabIndex = 9;
            this.etiqueta3.Text = "Exportar:";
            // 
            // etiqueta4
            // 
            this.etiqueta4.AutoSize = true;
            this.etiqueta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta4.Location = new System.Drawing.Point(705, 236);
            this.etiqueta4.Name = "etiqueta4";
            this.etiqueta4.Size = new System.Drawing.Size(53, 16);
            this.etiqueta4.TabIndex = 10;
            this.etiqueta4.Text = "Buscar:";
            // 
            // etiqueta5
            // 
            this.etiqueta5.AutoSize = true;
            this.etiqueta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta5.Location = new System.Drawing.Point(704, 123);
            this.etiqueta5.Name = "etiqueta5";
            this.etiqueta5.Size = new System.Drawing.Size(51, 16);
            this.etiqueta5.TabIndex = 11;
            this.etiqueta5.Text = "Nuevo:";
            // 
            // ExportarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.etiqueta5);
            this.Controls.Add(this.etiqueta4);
            this.Controls.Add(this.etiqueta3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.etiqueta2);
            this.Controls.Add(this.etiqueta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportarEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.etiqueta etiqueta1;
        private Controles.etiqueta etiqueta2;
        private Controles.dataFecha dtpFechaDesde;
        private Controles.dataFecha dtpFechaHasta;
        private Controles.dataG dtgEstudiantes;
        private Controles.boton btnNuevo;
        private Controles.boton btnBuscar;
        private Controles.boton btnExportar;
        private Controles.boton btnSalir;
        private Controles.etiqueta etiqueta3;
        private Controles.etiqueta etiqueta4;
        private Controles.etiqueta etiqueta5;
    }
}