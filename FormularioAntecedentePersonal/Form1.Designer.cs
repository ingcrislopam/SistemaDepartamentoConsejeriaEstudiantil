namespace FormularioAntecedentePersonal
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.etiqueta22 = new Controles.etiqueta();
            this.dtgMostrarAP = new Controles.dataG();
            this.txtBusqueda = new Controles.texto();
            this.txtMotivosVisitaDepartamento = new Controles.texto();
            this.txtNumeroHermanos = new Controles.numero();
            this.txtOcupacion = new Controles.texto();
            this.txtTelefono = new Controles.numero();
            this.txtReligion = new Controles.texto();
            this.txtResidencia = new Controles.texto();
            this.dtpFechaNacimiento = new Controles.dataFecha();
            this.dtpHora = new Controles.dataFecha();
            this.dtpFecha = new Controles.dataFecha();
            this.cbbEstudiantes = new Controles.combo();
            this.etiqueta21 = new Controles.etiqueta();
            this.etiqueta20 = new Controles.etiqueta();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarAP)).BeginInit();
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
            this.panel6.Controls.Add(this.etiqueta22);
            this.panel6.Controls.Add(this.dtgMostrarAP);
            this.panel6.Controls.Add(this.txtBusqueda);
            this.panel6.Controls.Add(this.txtMotivosVisitaDepartamento);
            this.panel6.Controls.Add(this.txtNumeroHermanos);
            this.panel6.Controls.Add(this.txtOcupacion);
            this.panel6.Controls.Add(this.txtTelefono);
            this.panel6.Controls.Add(this.txtReligion);
            this.panel6.Controls.Add(this.txtResidencia);
            this.panel6.Controls.Add(this.dtpFechaNacimiento);
            this.panel6.Controls.Add(this.dtpHora);
            this.panel6.Controls.Add(this.dtpFecha);
            this.panel6.Controls.Add(this.cbbEstudiantes);
            this.panel6.Controls.Add(this.etiqueta21);
            this.panel6.Controls.Add(this.etiqueta20);
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
            // etiqueta22
            // 
            this.etiqueta22.AutoSize = true;
            this.etiqueta22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta22.Location = new System.Drawing.Point(87, 327);
            this.etiqueta22.Name = "etiqueta22";
            this.etiqueta22.Size = new System.Drawing.Size(73, 16);
            this.etiqueta22.TabIndex = 23;
            this.etiqueta22.Text = "Busqueda:";
            // 
            // dtgMostrarAP
            // 
            this.dtgMostrarAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarAP.Location = new System.Drawing.Point(90, 349);
            this.dtgMostrarAP.Name = "dtgMostrarAP";
            this.dtgMostrarAP.ReadOnly = true;
            this.dtgMostrarAP.Size = new System.Drawing.Size(764, 165);
            this.dtgMostrarAP.TabIndex = 22;
            this.dtgMostrarAP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMostrarAP_CellClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(166, 323);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(688, 20);
            this.txtBusqueda.TabIndex = 21;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // txtMotivosVisitaDepartamento
            // 
            this.txtMotivosVisitaDepartamento.Location = new System.Drawing.Point(483, 229);
            this.txtMotivosVisitaDepartamento.Name = "txtMotivosVisitaDepartamento";
            this.txtMotivosVisitaDepartamento.Size = new System.Drawing.Size(371, 20);
            this.txtMotivosVisitaDepartamento.TabIndex = 20;
            // 
            // txtNumeroHermanos
            // 
            this.txtNumeroHermanos.Location = new System.Drawing.Point(697, 163);
            this.txtNumeroHermanos.Name = "txtNumeroHermanos";
            this.txtNumeroHermanos.Size = new System.Drawing.Size(157, 20);
            this.txtNumeroHermanos.TabIndex = 19;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(697, 127);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(157, 20);
            this.txtOcupacion.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(697, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(157, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(229, 261);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(204, 20);
            this.txtReligion.TabIndex = 16;
            // 
            // txtResidencia
            // 
            this.txtResidencia.Location = new System.Drawing.Point(229, 229);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(204, 20);
            this.txtResidencia.TabIndex = 15;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(229, 197);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(229, 163);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(204, 20);
            this.dtpHora.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(229, 127);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(204, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // cbbEstudiantes
            // 
            this.cbbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstudiantes.FormattingEnabled = true;
            this.cbbEstudiantes.Location = new System.Drawing.Point(229, 93);
            this.cbbEstudiantes.Name = "cbbEstudiantes";
            this.cbbEstudiantes.Size = new System.Drawing.Size(204, 21);
            this.cbbEstudiantes.TabIndex = 11;
            // 
            // etiqueta21
            // 
            this.etiqueta21.AutoSize = true;
            this.etiqueta21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta21.Location = new System.Drawing.Point(480, 201);
            this.etiqueta21.Name = "etiqueta21";
            this.etiqueta21.Size = new System.Drawing.Size(374, 16);
            this.etiqueta21.TabIndex = 10;
            this.etiqueta21.Text = "Motivos de la visita al departamento de consejería estudiantil:";
            // 
            // etiqueta20
            // 
            this.etiqueta20.AutoSize = true;
            this.etiqueta20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta20.Location = new System.Drawing.Point(480, 167);
            this.etiqueta20.Name = "etiqueta20";
            this.etiqueta20.Size = new System.Drawing.Size(141, 16);
            this.etiqueta20.TabIndex = 9;
            this.etiqueta20.Text = "Número de hermanos:";
            // 
            // etiqueta19
            // 
            this.etiqueta19.AutoSize = true;
            this.etiqueta19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta19.Location = new System.Drawing.Point(480, 131);
            this.etiqueta19.Name = "etiqueta19";
            this.etiqueta19.Size = new System.Drawing.Size(76, 16);
            this.etiqueta19.TabIndex = 8;
            this.etiqueta19.Text = "Ocupación:";
            // 
            // etiqueta18
            // 
            this.etiqueta18.AutoSize = true;
            this.etiqueta18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta18.Location = new System.Drawing.Point(480, 98);
            this.etiqueta18.Name = "etiqueta18";
            this.etiqueta18.Size = new System.Drawing.Size(65, 16);
            this.etiqueta18.TabIndex = 7;
            this.etiqueta18.Text = "Teléfono:";
            // 
            // etiqueta17
            // 
            this.etiqueta17.AutoSize = true;
            this.etiqueta17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta17.Location = new System.Drawing.Point(87, 265);
            this.etiqueta17.Name = "etiqueta17";
            this.etiqueta17.Size = new System.Drawing.Size(61, 16);
            this.etiqueta17.TabIndex = 6;
            this.etiqueta17.Text = "Religión:";
            // 
            // etiqueta16
            // 
            this.etiqueta16.AutoSize = true;
            this.etiqueta16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta16.Location = new System.Drawing.Point(87, 233);
            this.etiqueta16.Name = "etiqueta16";
            this.etiqueta16.Size = new System.Drawing.Size(80, 16);
            this.etiqueta16.TabIndex = 5;
            this.etiqueta16.Text = "Residencia:";
            // 
            // etiqueta15
            // 
            this.etiqueta15.AutoSize = true;
            this.etiqueta15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta15.Location = new System.Drawing.Point(87, 201);
            this.etiqueta15.Name = "etiqueta15";
            this.etiqueta15.Size = new System.Drawing.Size(136, 16);
            this.etiqueta15.TabIndex = 4;
            this.etiqueta15.Text = "Fecha de nacimiento:";
            // 
            // etiqueta14
            // 
            this.etiqueta14.AutoSize = true;
            this.etiqueta14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta14.Location = new System.Drawing.Point(87, 167);
            this.etiqueta14.Name = "etiqueta14";
            this.etiqueta14.Size = new System.Drawing.Size(41, 16);
            this.etiqueta14.TabIndex = 3;
            this.etiqueta14.Text = "Hora:";
            // 
            // etiqueta13
            // 
            this.etiqueta13.AutoSize = true;
            this.etiqueta13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta13.Location = new System.Drawing.Point(87, 131);
            this.etiqueta13.Name = "etiqueta13";
            this.etiqueta13.Size = new System.Drawing.Size(49, 16);
            this.etiqueta13.TabIndex = 2;
            this.etiqueta13.Text = "Fecha:";
            // 
            // etiqueta12
            // 
            this.etiqueta12.AutoSize = true;
            this.etiqueta12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta12.Location = new System.Drawing.Point(87, 98);
            this.etiqueta12.Name = "etiqueta12";
            this.etiqueta12.Size = new System.Drawing.Size(74, 16);
            this.etiqueta12.TabIndex = 1;
            this.etiqueta12.Text = "Estudiante:";
            // 
            // etiqueta11
            // 
            this.etiqueta11.AutoSize = true;
            this.etiqueta11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta11.Location = new System.Drawing.Point(172, 23);
            this.etiqueta11.Name = "etiqueta11";
            this.etiqueta11.Size = new System.Drawing.Size(609, 42);
            this.etiqueta11.TabIndex = 0;
            this.etiqueta11.Text = "ANTECEDENTES PERSONALES";
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Controles.etiqueta etiqueta11;
        private Controles.etiqueta etiqueta21;
        private Controles.etiqueta etiqueta20;
        private Controles.etiqueta etiqueta19;
        private Controles.etiqueta etiqueta18;
        private Controles.etiqueta etiqueta17;
        private Controles.etiqueta etiqueta16;
        private Controles.etiqueta etiqueta15;
        private Controles.etiqueta etiqueta14;
        private Controles.etiqueta etiqueta13;
        private Controles.etiqueta etiqueta12;
        private Controles.texto txtMotivosVisitaDepartamento;
        private Controles.numero txtNumeroHermanos;
        private Controles.texto txtOcupacion;
        private Controles.numero txtTelefono;
        private Controles.texto txtReligion;
        private Controles.texto txtResidencia;
        private Controles.dataFecha dtpFechaNacimiento;
        private Controles.dataFecha dtpHora;
        private Controles.dataFecha dtpFecha;
        private Controles.combo cbbEstudiantes;
        private Controles.dataG dtgMostrarAP;
        private Controles.texto txtBusqueda;
        private Controles.etiqueta etiqueta22;
    }
}

