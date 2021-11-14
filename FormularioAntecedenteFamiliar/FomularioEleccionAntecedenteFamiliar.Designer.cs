namespace FormularioAntecedenteFamiliar
{
    partial class FomularioEleccionAntecedenteFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomularioEleccionAntecedenteFamiliar));
            this.btnPorConjunto = new Controles.boton();
            this.btnPorEstudiante = new Controles.boton();
            this.btnSalir = new Controles.boton();
            this.etiqueta1 = new Controles.etiqueta();
            this.etiqueta2 = new Controles.etiqueta();
            this.SuspendLayout();
            // 
            // btnPorConjunto
            // 
            this.btnPorConjunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorConjunto.Image = ((System.Drawing.Image)(resources.GetObject("btnPorConjunto.Image")));
            this.btnPorConjunto.Location = new System.Drawing.Point(12, 162);
            this.btnPorConjunto.Name = "btnPorConjunto";
            this.btnPorConjunto.Size = new System.Drawing.Size(140, 101);
            this.btnPorConjunto.TabIndex = 3;
            this.btnPorConjunto.UseVisualStyleBackColor = true;
            this.btnPorConjunto.Click += new System.EventHandler(this.btnPorConjunto_Click);
            // 
            // btnPorEstudiante
            // 
            this.btnPorEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnPorEstudiante.Image")));
            this.btnPorEstudiante.Location = new System.Drawing.Point(12, 33);
            this.btnPorEstudiante.Name = "btnPorEstudiante";
            this.btnPorEstudiante.Size = new System.Drawing.Size(140, 101);
            this.btnPorEstudiante.TabIndex = 2;
            this.btnPorEstudiante.UseVisualStyleBackColor = true;
            this.btnPorEstudiante.Click += new System.EventHandler(this.btnPorEstudiante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(197, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 60);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta1.Location = new System.Drawing.Point(48, 14);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(74, 16);
            this.etiqueta1.TabIndex = 6;
            this.etiqueta1.Text = "Estudiante:";
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta2.Location = new System.Drawing.Point(52, 143);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(59, 16);
            this.etiqueta2.TabIndex = 7;
            this.etiqueta2.Text = "General:";
            // 
            // FomularioEleccionAntecedenteFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.etiqueta2);
            this.Controls.Add(this.etiqueta1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPorConjunto);
            this.Controls.Add(this.btnPorEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FomularioEleccionAntecedenteFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.boton btnPorConjunto;
        private Controles.boton btnPorEstudiante;
        private Controles.boton btnSalir;
        private Controles.etiqueta etiqueta1;
        private Controles.etiqueta etiqueta2;
    }
}