using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAntecedentePersonal
{
    public partial class ExportarAntecedentesPersonales : Form
    {
        Negocio.Gestiones.GestionAntecedentesPersonales gestionAntecentePersona;
        Negocio.Clases.exportar expor;

        public ExportarAntecedentesPersonales()
        {
            InitializeComponent();
            gestionAntecentePersona = new Negocio.Gestiones.GestionAntecedentesPersonales();
            expor = new Negocio.Clases.exportar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gestionAntecentePersona.Nuevo();
            dtgAntecedentesPersonales.DataSource = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gestionAntecentePersona.FechaDesde = dtpFechaDesde.Text;
                gestionAntecentePersona.FechaHasta = dtpFechaHasta.Text;
                dtgAntecedentesPersonales.DataSource = gestionAntecentePersona.Exportar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expor.llenarExcel(dtgAntecedentesPersonales);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
