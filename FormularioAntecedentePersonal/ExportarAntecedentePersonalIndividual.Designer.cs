namespace FormularioAntecedentePersonal
{
    partial class ExportarAntecedentePersonalIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarAntecedentePersonalIndividual));
            this.txtBusqueda = new Controles.texto();
            this.dtgSoloNombres = new Controles.dataG();
            this.etiqueta1 = new Controles.etiqueta();
            this.etiqueta2 = new Controles.etiqueta();
            this.etiqueta3 = new Controles.etiqueta();
            this.etiqueta4 = new Controles.etiqueta();
            this.txtNombres = new Controles.texto();
            this.txtApellidos = new Controles.texto();
            this.dtpFechaDesde = new Controles.dataFecha();
            this.dtpFechaHasta = new Controles.dataFecha();
            this.btnBuscar = new Controles.boton();
            this.btnExportar = new Controles.boton();
            this.dtgAntecedentesPersonales = new System.Windows.Forms.DataGridView();
            this.btnSalir = new Controles.boton();
            this.etiqueta5 = new Controles.etiqueta();
            this.etiqueta6 = new Controles.etiqueta();
            this.etiqueta7 = new Controles.etiqueta();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoloNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAntecedentesPersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(91, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(260, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dtgSoloNombres
            // 
            this.dtgSoloNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSoloNombres.Location = new System.Drawing.Point(12, 38);
            this.dtgSoloNombres.Name = "dtgSoloNombres";
            this.dtgSoloNombres.Size = new System.Drawing.Size(339, 78);
            this.dtgSoloNombres.TabIndex = 1;
            this.dtgSoloNombres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSoloNombres_CellClick);
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(70, 166);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(67, 16);
            this.etiqueta1.TabIndex = 2;
            this.etiqueta1.Text = "Nombres:";
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(294, 166);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(68, 16);
            this.etiqueta2.TabIndex = 3;
            this.etiqueta2.Text = "Apellidos:";
            // 
            // etiqueta3
            // 
            this.etiqueta3.AutoSize = true;
            this.etiqueta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta3.Location = new System.Drawing.Point(496, 166);
            this.etiqueta3.Name = "etiqueta3";
            this.etiqueta3.Size = new System.Drawing.Size(91, 16);
            this.etiqueta3.TabIndex = 4;
            this.etiqueta3.Text = "Fecha desde:";
            // 
            // etiqueta4
            // 
            this.etiqueta4.AutoSize = true;
            this.etiqueta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta4.Location = new System.Drawing.Point(688, 166);
            this.etiqueta4.Name = "etiqueta4";
            this.etiqueta4.Size = new System.Drawing.Size(85, 16);
            this.etiqueta4.TabIndex = 5;
            this.etiqueta4.Text = "Fecha hasta:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(12, 185);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(196, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(230, 185);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(196, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(462, 185);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(161, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(648, 185);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(161, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(390, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 59);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(499, 38);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 59);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dtgAntecedentesPersonales
            // 
            this.dtgAntecedentesPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAntecedentesPersonales.Location = new System.Drawing.Point(12, 211);
            this.dtgAntecedentesPersonales.Name = "dtgAntecedentesPersonales";
            this.dtgAntecedentesPersonales.Size = new System.Drawing.Size(797, 255);
            this.dtgAntecedentesPersonales.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(734, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // etiqueta5
            // 
            this.etiqueta5.AutoSize = true;
            this.etiqueta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta5.Location = new System.Drawing.Point(403, 19);
            this.etiqueta5.Name = "etiqueta5";
            this.etiqueta5.Size = new System.Drawing.Size(53, 16);
            this.etiqueta5.TabIndex = 15;
            this.etiqueta5.Text = "Buscar:";
            // 
            // etiqueta6
            // 
            this.etiqueta6.AutoSize = true;
            this.etiqueta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta6.Location = new System.Drawing.Point(506, 19);
            this.etiqueta6.Name = "etiqueta6";
            this.etiqueta6.Size = new System.Drawing.Size(61, 16);
            this.etiqueta6.TabIndex = 16;
            this.etiqueta6.Text = "Exportar:";
            // 
            // etiqueta7
            // 
            this.etiqueta7.AutoSize = true;
            this.etiqueta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta7.Location = new System.Drawing.Point(12, 16);
            this.etiqueta7.Name = "etiqueta7";
            this.etiqueta7.Size = new System.Drawing.Size(73, 16);
            this.etiqueta7.TabIndex = 17;
            this.etiqueta7.Text = "Busqueda:";
            // 
            // ExportarAntecedentePersonalIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 478);
            this.Controls.Add(this.etiqueta7);
            this.Controls.Add(this.etiqueta6);
            this.Controls.Add(this.etiqueta5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgAntecedentesPersonales);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.etiqueta4);
            this.Controls.Add(this.etiqueta3);
            this.Controls.Add(this.etiqueta2);
            this.Controls.Add(this.etiqueta1);
            this.Controls.Add(this.dtgSoloNombres);
            this.Controls.Add(this.txtBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportarAntecedentePersonalIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ExportarAntecedentePersonalIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoloNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAntecedentesPersonales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.texto txtBusqueda;
        private Controles.dataG dtgSoloNombres;
        private Controles.etiqueta etiqueta1;
        private Controles.etiqueta etiqueta2;
        private Controles.etiqueta etiqueta3;
        private Controles.etiqueta etiqueta4;
        private Controles.texto txtNombres;
        private Controles.texto txtApellidos;
        private Controles.dataFecha dtpFechaDesde;
        private Controles.dataFecha dtpFechaHasta;
        private Controles.boton btnBuscar;
        private Controles.boton btnExportar;
        private System.Windows.Forms.DataGridView dtgAntecedentesPersonales;
        private Controles.boton btnSalir;
        private Controles.etiqueta etiqueta5;
        private Controles.etiqueta etiqueta6;
        private Controles.etiqueta etiqueta7;
    }
}