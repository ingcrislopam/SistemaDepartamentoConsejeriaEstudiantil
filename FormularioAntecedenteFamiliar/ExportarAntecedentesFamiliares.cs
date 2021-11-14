using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAntecedenteFamiliar
{
    public partial class ExportarAntecedentesFamiliares : Form
    {
        Negocio.Gestiones.GestionAntecedentesFamiliares gestionAntecedenteFamiliar;
        Negocio.Clases.exportar expor;

        public ExportarAntecedentesFamiliares()
        {
            InitializeComponent();
            gestionAntecedenteFamiliar = new Negocio.Gestiones.GestionAntecedentesFamiliares();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionAntecedenteFamiliar.Nuevo();
            dtgAntecedentesFamiliares.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionAntecedenteFamiliar.FechaDesde = dtpFechaDesde.Text;
                gestionAntecedenteFamiliar.FechaHasta = dtpFechaHasta.Text;
                dtgAntecedentesFamiliares.DataSource = gestionAntecedenteFamiliar.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgAntecedentesFamiliares);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
