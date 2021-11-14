using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEstudiante
{
    public partial class ExportarEstudiantes : Form
    {
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        Negocio.Clases.exportar expor;

        public ExportarEstudiantes()
        {
            InitializeComponent();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionEstudiante.Nuevo();
            dtgEstudiantes.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionEstudiante.FechaDesde = dtpFechaDesde.Text;
                gestionEstudiante.FechaHasta = dtpFechaHasta.Text;
                dtgEstudiantes.DataSource = gestionEstudiante.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgEstudiantes);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
