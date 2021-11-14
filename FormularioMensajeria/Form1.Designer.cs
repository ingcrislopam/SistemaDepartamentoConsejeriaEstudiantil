namespace FormularioMensajeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiqueta1 = new Controles.etiqueta();
            this.etiqueta2 = new Controles.etiqueta();
            this.etiqueta3 = new Controles.etiqueta();
            this.etiqueta4 = new Controles.etiqueta();
            this.etiqueta5 = new Controles.etiqueta();
            this.etiqueta6 = new Controles.etiqueta();
            this.etiqueta7 = new Controles.etiqueta();
            this.txtCorreo = new Controles.textoCompleto();
            this.txtContrasenia = new Controles.textoCompleto();
            this.txtNombres = new Controles.textoCompleto();
            this.txtApellidos = new Controles.textoCompleto();
            this.txtPara = new Controles.textoCompleto();
            this.txtAsunto = new Controles.textoCompleto();
            this.txtDatoAdjunto = new Controles.texto();
            this.etiqueta8 = new Controles.etiqueta();
            this.etiqueta9 = new Controles.etiqueta();
            this.btnExaminar = new Controles.boton();
            this.txtMensaje = new Controles.textoCompleto();
            this.btnEnviar = new Controles.boton();
            this.txtBusqueda = new Controles.texto();
            this.dtMostrarRepresentantes = new Controles.dataG();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.etiqueta10 = new Controles.etiqueta();
            this.panel1 = new Controles.panel();
            this.panel2 = new Controles.panel();
            this.panel3 = new Controles.panel();
            this.panel4 = new Controles.panel();
            this.etiqueta11 = new Controles.etiqueta();
            this.panel5 = new Controles.panel();
            this.panel6 = new Controles.panel();
            this.btnSalir = new Controles.boton();
            this.imagen1 = new Controles.imagen();
            this.imagen2 = new Controles.imagen();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarRepresentantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.etiqueta1.Location = new System.Drawing.Point(217, 16);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(341, 55);
            this.etiqueta1.TabIndex = 0;
            this.etiqueta1.Text = "MENSAJERÍA";
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(10, 24);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(52, 16);
            this.etiqueta2.TabIndex = 1;
            this.etiqueta2.Text = "Correo:";
            // 
            // etiqueta3
            // 
            this.etiqueta3.AutoSize = true;
            this.etiqueta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta3.Location = new System.Drawing.Point(10, 50);
            this.etiqueta3.Name = "etiqueta3";
            this.etiqueta3.Size = new System.Drawing.Size(80, 16);
            this.etiqueta3.TabIndex = 2;
            this.etiqueta3.Text = "Contraseña:";
            // 
            // etiqueta4
            // 
            this.etiqueta4.AutoSize = true;
            this.etiqueta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta4.Location = new System.Drawing.Point(10, 129);
            this.etiqueta4.Name = "etiqueta4";
            this.etiqueta4.Size = new System.Drawing.Size(40, 16);
            this.etiqueta4.TabIndex = 3;
            this.etiqueta4.Text = "Para:";
            // 
            // etiqueta5
            // 
            this.etiqueta5.AutoSize = true;
            this.etiqueta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta5.Location = new System.Drawing.Point(10, 155);
            this.etiqueta5.Name = "etiqueta5";
            this.etiqueta5.Size = new System.Drawing.Size(52, 16);
            this.etiqueta5.TabIndex = 4;
            this.etiqueta5.Text = "Asunto:";
            // 
            // etiqueta6
            // 
            this.etiqueta6.AutoSize = true;
            this.etiqueta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta6.Location = new System.Drawing.Point(10, 181);
            this.etiqueta6.Name = "etiqueta6";
            this.etiqueta6.Size = new System.Drawing.Size(87, 16);
            this.etiqueta6.TabIndex = 5;
            this.etiqueta6.Text = "Dato adjunto:";
            // 
            // etiqueta7
            // 
            this.etiqueta7.AutoSize = true;
            this.etiqueta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta7.Location = new System.Drawing.Point(10, 245);
            this.etiqueta7.Name = "etiqueta7";
            this.etiqueta7.Size = new System.Drawing.Size(63, 16);
            this.etiqueta7.TabIndex = 6;
            this.etiqueta7.Text = "Mensaje:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(140, 20);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(243, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(140, 46);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(243, 20);
            this.txtContrasenia.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(140, 73);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(243, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 99);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(243, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(140, 125);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(243, 20);
            this.txtPara.TabIndex = 11;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(140, 151);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(243, 20);
            this.txtAsunto.TabIndex = 12;
            // 
            // txtDatoAdjunto
            // 
            this.txtDatoAdjunto.Location = new System.Drawing.Point(140, 177);
            this.txtDatoAdjunto.Name = "txtDatoAdjunto";
            this.txtDatoAdjunto.Size = new System.Drawing.Size(243, 20);
            this.txtDatoAdjunto.TabIndex = 15;
            // 
            // etiqueta8
            // 
            this.etiqueta8.AutoSize = true;
            this.etiqueta8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta8.Location = new System.Drawing.Point(10, 77);
            this.etiqueta8.Name = "etiqueta8";
            this.etiqueta8.Size = new System.Drawing.Size(67, 16);
            this.etiqueta8.TabIndex = 17;
            this.etiqueta8.Text = "Nombres:";
            // 
            // etiqueta9
            // 
            this.etiqueta9.AutoSize = true;
            this.etiqueta9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta9.Location = new System.Drawing.Point(10, 103);
            this.etiqueta9.Name = "etiqueta9";
            this.etiqueta9.Size = new System.Drawing.Size(68, 16);
            this.etiqueta9.TabIndex = 18;
            this.etiqueta9.Text = "Apellidos:";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(140, 203);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(243, 23);
            this.btnExaminar.TabIndex = 19;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(13, 264);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(370, 168);
            this.txtMensaje.TabIndex = 20;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(88, 36);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(163, 135);
            this.btnEnviar.TabIndex = 21;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(77, 10);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(261, 20);
            this.txtBusqueda.TabIndex = 22;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dtMostrarRepresentantes
            // 
            this.dtMostrarRepresentantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMostrarRepresentantes.Location = new System.Drawing.Point(3, 37);
            this.dtMostrarRepresentantes.Name = "dtMostrarRepresentantes";
            this.dtMostrarRepresentantes.Size = new System.Drawing.Size(335, 187);
            this.dtMostrarRepresentantes.TabIndex = 23;
            this.dtMostrarRepresentantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMostrarRepresentantes_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // etiqueta10
            // 
            this.etiqueta10.AutoSize = true;
            this.etiqueta10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta10.Location = new System.Drawing.Point(3, 14);
            this.etiqueta10.Name = "etiqueta10";
            this.etiqueta10.Size = new System.Drawing.Size(71, 16);
            this.etiqueta10.TabIndex = 24;
            this.etiqueta10.Text = "Contactos:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 455);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.etiqueta2);
            this.panel2.Controls.Add(this.etiqueta3);
            this.panel2.Controls.Add(this.etiqueta4);
            this.panel2.Controls.Add(this.etiqueta5);
            this.panel2.Controls.Add(this.txtMensaje);
            this.panel2.Controls.Add(this.etiqueta6);
            this.panel2.Controls.Add(this.btnExaminar);
            this.panel2.Controls.Add(this.etiqueta7);
            this.panel2.Controls.Add(this.etiqueta9);
            this.panel2.Controls.Add(this.txtContrasenia);
            this.panel2.Controls.Add(this.etiqueta8);
            this.panel2.Controls.Add(this.txtNombres);
            this.panel2.Controls.Add(this.txtDatoAdjunto);
            this.panel2.Controls.Add(this.txtApellidos);
            this.panel2.Controls.Add(this.txtAsunto);
            this.panel2.Controls.Add(this.txtPara);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 447);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(423, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 202);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.etiqueta11);
            this.panel4.Controls.Add(this.btnEnviar);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 194);
            this.panel4.TabIndex = 0;
            // 
            // etiqueta11
            // 
            this.etiqueta11.AutoSize = true;
            this.etiqueta11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta11.Location = new System.Drawing.Point(142, 17);
            this.etiqueta11.Name = "etiqueta11";
            this.etiqueta11.Size = new System.Drawing.Size(49, 16);
            this.etiqueta11.TabIndex = 22;
            this.etiqueta11.Text = "Enviar:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(423, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 247);
            this.panel5.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dtMostrarRepresentantes);
            this.panel6.Controls.Add(this.txtBusqueda);
            this.panel6.Controls.Add(this.etiqueta10);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 239);
            this.panel6.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(706, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 62);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imagen1
            // 
            this.imagen1.Image = ((System.Drawing.Image)(resources.GetObject("imagen1.Image")));
            this.imagen1.Location = new System.Drawing.Point(143, 5);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(82, 73);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen1.TabIndex = 29;
            this.imagen1.TabStop = false;
            // 
            // imagen2
            // 
            this.imagen2.Image = ((System.Drawing.Image)(resources.GetObject("imagen2.Image")));
            this.imagen2.Location = new System.Drawing.Point(551, 5);
            this.imagen2.Name = "imagen2";
            this.imagen2.Size = new System.Drawing.Size(82, 73);
            this.imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen2.TabIndex = 30;
            this.imagen2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(786, 547);
            this.Controls.Add(this.imagen2);
            this.Controls.Add(this.imagen1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.etiqueta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarRepresentantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.etiqueta etiqueta1;
        private Controles.etiqueta etiqueta2;
        private Controles.etiqueta etiqueta3;
        private Controles.etiqueta etiqueta4;
        private Controles.etiqueta etiqueta5;
        private Controles.etiqueta etiqueta6;
        private Controles.etiqueta etiqueta7;
        private Controles.textoCompleto txtCorreo;
        private Controles.textoCompleto txtContrasenia;
        private Controles.textoCompleto txtNombres;
        private Controles.textoCompleto txtApellidos;
        private Controles.textoCompleto txtPara;
        private Controles.textoCompleto txtAsunto;
        private Controles.texto txtDatoAdjunto;
        private Controles.etiqueta etiqueta8;
        private Controles.etiqueta etiqueta9;
        private Controles.boton btnExaminar;
        private Controles.textoCompleto txtMensaje;
        private Controles.boton btnEnviar;
        private Controles.texto txtBusqueda;
        private Controles.dataG dtMostrarRepresentantes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controles.etiqueta etiqueta10;
        private Controles.panel panel1;
        private Controles.panel panel2;
        private Controles.panel panel3;
        private Controles.panel panel4;
        private Controles.etiqueta etiqueta11;
        private Controles.panel panel5;
        private Controles.panel panel6;
        private Controles.boton btnSalir;
        private Controles.imagen imagen1;
        private Controles.imagen imagen2;
    }
}

