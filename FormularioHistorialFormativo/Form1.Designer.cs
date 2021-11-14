namespace FormularioHistorialFormativo
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.panel5 = new Controles.panel();
            this.panel6 = new Controles.panel();
            this.etiqueta20 = new Controles.etiqueta();
            this.dtgMostrarHF = new Controles.dataG();
            this.txtBusqueda = new Controles.texto();
            this.txtEvaluacionSumativa = new Controles.numeroConPunto();
            this.txtLecciones = new Controles.numeroConPunto();
            this.txtActividadesGrupales = new Controles.numeroConPunto();
            this.txtActividadesIndividuales = new Controles.numeroConPunto();
            this.txtTrabajoIndependiente = new Controles.numeroConPunto();
            this.dtpHora = new Controles.dataFecha();
            this.dtpFecha = new Controles.dataFecha();
            this.cbbEstudiantes = new Controles.combo();
            this.etiqueta19 = new Controles.etiqueta();
            this.etiqueta18 = new Controles.etiqueta();
            this.etiqueta17 = new Controles.etiqueta();
            this.etiqueta16 = new Controles.etiqueta();
            this.etiqueta15 = new Controles.etiqueta();
            this.etiqueta14 = new Controles.etiqueta();
            this.etiqueta13 = new Controles.etiqueta();
            this.etiqueta12 = new Controles.etiqueta();
            this.etiqueta11 = new Controles.etiqueta();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarHF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 527);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.etiqueta20);
            this.panel6.Controls.Add(this.dtgMostrarHF);
            this.panel6.Controls.Add(this.txtBusqueda);
            this.panel6.Controls.Add(this.txtEvaluacionSumativa);
            this.panel6.Controls.Add(this.txtLecciones);
            this.panel6.Controls.Add(this.txtActividadesGrupales);
            this.panel6.Controls.Add(this.txtActividadesIndividuales);
            this.panel6.Controls.Add(this.txtTrabajoIndependiente);
            this.panel6.Controls.Add(this.dtpHora);
            this.panel6.Controls.Add(this.dtpFecha);
            this.panel6.Controls.Add(this.cbbEstudiantes);
            this.panel6.Controls.Add(this.etiqueta19);
            this.panel6.Controls.Add(this.etiqueta18);
            this.panel6.Controls.Add(this.etiqueta17);
            this.panel6.Controls.Add(this.etiqueta16);
            this.panel6.Controls.Add(this.etiqueta15);
            this.panel6.Controls.Add(this.etiqueta14);
            this.panel6.Controls.Add(this.etiqueta13);
            this.panel6.Controls.Add(this.etiqueta12);
            this.panel6.Controls.Add(this.etiqueta11);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(942, 519);
            this.panel6.TabIndex = 0;
            // 
            // etiqueta20
            // 
            this.etiqueta20.AutoSize = true;
            this.etiqueta20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta20.Location = new System.Drawing.Point(80, 303);
            this.etiqueta20.Name = "etiqueta20";
            this.etiqueta20.Size = new System.Drawing.Size(73, 16);
            this.etiqueta20.TabIndex = 19;
            this.etiqueta20.Text = "Busqueda:";
            // 
            // dtgMostrarHF
            // 
            this.dtgMostrarHF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarHF.Location = new System.Drawing.Point(83, 325);
            this.dtgMostrarHF.Name = "dtgMostrarHF";
            this.dtgMostrarHF.ReadOnly = true;
            this.dtgMostrarHF.Size = new System.Drawing.Size(758, 189);
            this.dtgMostrarHF.TabIndex = 18;
            this.dtgMostrarHF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMostrarHF_CellClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(159, 299);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(682, 20);
            this.txtBusqueda.TabIndex = 17;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // txtEvaluacionSumativa
            // 
            this.txtEvaluacionSumativa.Enabled = false;
            this.txtEvaluacionSumativa.Location = new System.Drawing.Point(641, 217);
            this.txtEvaluacionSumativa.Name = "txtEvaluacionSumativa";
            this.txtEvaluacionSumativa.Size = new System.Drawing.Size(200, 20);
            this.txtEvaluacionSumativa.TabIndex = 16;
            // 
            // txtLecciones
            // 
            this.txtLecciones.Location = new System.Drawing.Point(641, 183);
            this.txtLecciones.Name = "txtLecciones";
            this.txtLecciones.Size = new System.Drawing.Size(200, 20);
            this.txtLecciones.TabIndex = 15;
            // 
            // txtActividadesGrupales
            // 
            this.txtActividadesGrupales.Location = new System.Drawing.Point(641, 148);
            this.txtActividadesGrupales.Name = "txtActividadesGrupales";
            this.txtActividadesGrupales.Size = new System.Drawing.Size(200, 20);
            this.txtActividadesGrupales.TabIndex = 14;
            // 
            // txtActividadesIndividuales
            // 
            this.txtActividadesIndividuales.Location = new System.Drawing.Point(641, 113);
            this.txtActividadesIndividuales.Name = "txtActividadesIndividuales";
            this.txtActividadesIndividuales.Size = new System.Drawing.Size(200, 20);
            this.txtActividadesIndividuales.TabIndex = 13;
            // 
            // txtTrabajoIndependiente
            // 
            this.txtTrabajoIndependiente.Location = new System.Drawing.Point(234, 217);
            this.txtTrabajoIndependiente.Name = "txtTrabajoIndependiente";
            this.txtTrabajoIndependiente.Size = new System.Drawing.Size(200, 20);
            this.txtTrabajoIndependiente.TabIndex = 12;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(234, 183);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 20);
            this.dtpHora.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(234, 148);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // cbbEstudiantes
            // 
            this.cbbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstudiantes.FormattingEnabled = true;
            this.cbbEstudiantes.Location = new System.Drawing.Point(234, 112);
            this.cbbEstudiantes.Name = "cbbEstudiantes";
            this.cbbEstudiantes.Size = new System.Drawing.Size(200, 21);
            this.cbbEstudiantes.TabIndex = 9;
            // 
            // etiqueta19
            // 
            this.etiqueta19.AutoSize = true;
            this.etiqueta19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta19.Location = new System.Drawing.Point(478, 221);
            this.etiqueta19.Name = "etiqueta19";
            this.etiqueta19.Size = new System.Drawing.Size(135, 16);
            this.etiqueta19.TabIndex = 8;
            this.etiqueta19.Text = "Evaluación sumativa:";
            // 
            // etiqueta18
            // 
            this.etiqueta18.AutoSize = true;
            this.etiqueta18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta18.Location = new System.Drawing.Point(478, 187);
            this.etiqueta18.Name = "etiqueta18";
            this.etiqueta18.Size = new System.Drawing.Size(73, 16);
            this.etiqueta18.TabIndex = 7;
            this.etiqueta18.Text = "Lecciones:";
            // 
            // etiqueta17
            // 
            this.etiqueta17.AutoSize = true;
            this.etiqueta17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta17.Location = new System.Drawing.Point(478, 152);
            this.etiqueta17.Name = "etiqueta17";
            this.etiqueta17.Size = new System.Drawing.Size(138, 16);
            this.etiqueta17.TabIndex = 6;
            this.etiqueta17.Text = "Actividades grupales:";
            // 
            // etiqueta16
            // 
            this.etiqueta16.AutoSize = true;
            this.etiqueta16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta16.Location = new System.Drawing.Point(478, 117);
            this.etiqueta16.Name = "etiqueta16";
            this.etiqueta16.Size = new System.Drawing.Size(157, 16);
            this.etiqueta16.TabIndex = 5;
            this.etiqueta16.Text = "Actividades individuales:";
            // 
            // etiqueta15
            // 
            this.etiqueta15.AutoSize = true;
            this.etiqueta15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta15.Location = new System.Drawing.Point(80, 221);
            this.etiqueta15.Name = "etiqueta15";
            this.etiqueta15.Size = new System.Drawing.Size(148, 16);
            this.etiqueta15.TabIndex = 4;
            this.etiqueta15.Text = "Trabajo independiente:";
            // 
            // etiqueta14
            // 
            this.etiqueta14.AutoSize = true;
            this.etiqueta14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta14.Location = new System.Drawing.Point(80, 187);
            this.etiqueta14.Name = "etiqueta14";
            this.etiqueta14.Size = new System.Drawing.Size(41, 16);
            this.etiqueta14.TabIndex = 3;
            this.etiqueta14.Text = "Hora:";
            // 
            // etiqueta13
            // 
            this.etiqueta13.AutoSize = true;
            this.etiqueta13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta13.Location = new System.Drawing.Point(80, 152);
            this.etiqueta13.Name = "etiqueta13";
            this.etiqueta13.Size = new System.Drawing.Size(49, 16);
            this.etiqueta13.TabIndex = 2;
            this.etiqueta13.Text = "Fecha:";
            // 
            // etiqueta12
            // 
            this.etiqueta12.AutoSize = true;
            this.etiqueta12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta12.Location = new System.Drawing.Point(80, 117);
            this.etiqueta12.Name = "etiqueta12";
            this.etiqueta12.Size = new System.Drawing.Size(74, 16);
            this.etiqueta12.TabIndex = 1;
            this.etiqueta12.Text = "Estudiante:";
            // 
            // etiqueta11
            // 
            this.etiqueta11.AutoSize = true;
            this.etiqueta11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta11.Location = new System.Drawing.Point(209, 32);
            this.etiqueta11.Name = "etiqueta11";
            this.etiqueta11.Size = new System.Drawing.Size(541, 42);
            this.etiqueta11.TabIndex = 0;
            this.etiqueta11.Text = "HISTORIALES FORMATIVOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarHF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.panel panel5;
        private Controles.panel panel6;
        private Controles.etiqueta etiqueta19;
        private Controles.etiqueta etiqueta18;
        private Controles.etiqueta etiqueta17;
        private Controles.etiqueta etiqueta16;
        private Controles.etiqueta etiqueta15;
        private Controles.etiqueta etiqueta14;
        private Controles.etiqueta etiqueta13;
        private Controles.etiqueta etiqueta12;
        private Controles.etiqueta etiqueta11;
        private Controles.combo cbbEstudiantes;
        private Controles.dataFecha dtpHora;
        private Controles.dataFecha dtpFecha;
        private Controles.numeroConPunto txtTrabajoIndependiente;
        private Controles.numeroConPunto txtEvaluacionSumativa;
        private Controles.numeroConPunto txtLecciones;
        private Controles.numeroConPunto txtActividadesGrupales;
        private Controles.numeroConPunto txtActividadesIndividuales;
        private Controles.dataG dtgMostrarHF;
        private Controles.texto txtBusqueda;
        private Controles.etiqueta etiqueta20;
    }
}

