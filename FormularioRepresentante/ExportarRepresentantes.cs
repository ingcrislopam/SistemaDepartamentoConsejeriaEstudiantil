using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRepresentante
{
    public partial class ExportarRepresentantes : Form
    {
        Negocio.Gestiones.GestionRepresentantes gestionRepresentantes;
        Negocio.Clases.exportar expor;

        public ExportarRepresentantes()
        {
            InitializeComponent();
            gestionRepresentantes = new Negocio.Gestiones.GestionRepresentantes();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionRepresentantes.Nuevo();
            dtgRepresentantes.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionRepresentantes.FechaDesde = dtpFechaDesde.Text;
                gestionRepresentantes.FechaHasta = dtpFechaHasta.Text;
                dtgRepresentantes.DataSource = gestionRepresentantes.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgRepresentantes);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
