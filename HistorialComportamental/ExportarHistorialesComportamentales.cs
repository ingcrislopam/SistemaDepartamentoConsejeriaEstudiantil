using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistorialComportamental
{
    public partial class ExportarHistorialesComportamentales : Form
    {
        Negocio.Gestiones.GestionHistorialesComportamentales gestionHistorialComportamental;
        Negocio.Clases.exportar expor;

        public ExportarHistorialesComportamentales()
        {
            InitializeComponent();
            gestionHistorialComportamental = new Negocio.Gestiones.GestionHistorialesComportamentales();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionHistorialComportamental.Nuevo();
            dtgHistorialesComportamentales.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionHistorialComportamental.FechaDesde = dtpFechaDesde.Text;
                gestionHistorialComportamental.FechaHasta = dtpFechaHasta.Text;
                dtgHistorialesComportamentales.DataSource = gestionHistorialComportamental.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgHistorialesComportamentales);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
