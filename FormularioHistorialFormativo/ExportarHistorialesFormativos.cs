using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHistorialFormativo
{
    public partial class ExportarHistorialesFormativos : Form
    {
        Negocio.Gestiones.GestionHistorialesFormativos gestionHistorialFormativo;
        Negocio.Clases.exportar expor;

        public ExportarHistorialesFormativos()
        {
            InitializeComponent();
            gestionHistorialFormativo = new Negocio.Gestiones.GestionHistorialesFormativos();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionHistorialFormativo.Nuevo();
            dtgHistorialesFormativos.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionHistorialFormativo.FechaDesde = dtpFechaDesde.Text;
                gestionHistorialFormativo.FechaHasta = dtpFechaHasta.Text;
                dtgHistorialesFormativos.DataSource = gestionHistorialFormativo.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgHistorialesFormativos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
