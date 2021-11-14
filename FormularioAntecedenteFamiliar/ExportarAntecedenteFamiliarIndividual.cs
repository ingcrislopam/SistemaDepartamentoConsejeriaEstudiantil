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
    public partial class ExportarAntecedenteFamiliarIndividual : Form
    {
        Negocio.Gestiones.GestionEstudiantes gesEstudiantes;
        Negocio.Gestiones.GestionAntecedentesFamiliares gesAntecedentesFamiliares;
        Negocio.Clases.exportar Exportar;

        public DataTable tablaNombres { get; set; }
        public DataTable AntedentesIndividual { get; set; }
        
        public ExportarAntecedenteFamiliarIndividual()
        {
            InitializeComponent();
            gesEstudiantes = new Negocio.Gestiones.GestionEstudiantes();
            gesAntecedentesFamiliares = new Negocio.Gestiones.GestionAntecedentesFamiliares();
            Exportar = new Negocio.Clases.exportar();
        }

        private void MostrarDatos()
        {
            tablaNombres = gesEstudiantes.SoloNombres("where nombres like '%" + txtBusqueda.Text.Trim() + "%' order by nombres");
            dtgSoloNombres.DataSource = tablaNombres;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gesAntecedentesFamiliares.IdEstudiante.Nombres = txtNombres.Text;
                gesAntecedentesFamiliares.IdEstudiante.Apellidos = txtApellidos.Text;
                gesAntecedentesFamiliares.FechaDesde = dtpFechaDesde.Text;
                gesAntecedentesFamiliares.FechaHasta = dtpFechaHasta.Text;
                AntedentesIndividual = gesAntecedentesFamiliares.ExportarIndividual();
                dtgAntecedentesFamiliares.DataSource = AntedentesIndividual;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Exportar.llenarExcel(dtgAntecedentesFamiliares);
        }

        private void ExportarAntecedenteFamiliarIndividual_Load(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarDatos();
            if (dtgSoloNombres.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    return;
                }
                if (e.KeyCode == Keys.Up)
                {
                    return;
                }
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgSoloNombres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombres.Text = Convert.ToString(dtgSoloNombres.Rows[e.RowIndex].Cells[0].Value);
            txtApellidos.Text = Convert.ToString(dtgSoloNombres.Rows[e.RowIndex].Cells[1].Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
