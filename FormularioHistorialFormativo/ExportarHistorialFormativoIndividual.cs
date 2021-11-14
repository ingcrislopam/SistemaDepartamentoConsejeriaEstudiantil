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
    public partial class ExportarHistorialFormativoIndividual : Form
    {
        Negocio.Gestiones.GestionEstudiantes gesEstudiantes;
        Negocio.Gestiones.GestionHistorialesFormativos gesHistorialesFormativos;
        Negocio.Clases.exportar Exportar;

        public DataTable tablaNombres { get; set; }
        public DataTable HistorialesIndividual { get; set; }

        public ExportarHistorialFormativoIndividual()
        {
            InitializeComponent();
            gesEstudiantes = new Negocio.Gestiones.GestionEstudiantes();
            gesHistorialesFormativos = new Negocio.Gestiones.GestionHistorialesFormativos();
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
                gesHistorialesFormativos.IdEstudiante.Nombres = txtNombres.Text;
                gesHistorialesFormativos.IdEstudiante.Apellidos = txtApellidos.Text;
                gesHistorialesFormativos.FechaDesde = dtpFechaDesde.Text;
                gesHistorialesFormativos.FechaHasta = dtpFechaHasta.Text;
                HistorialesIndividual = gesHistorialesFormativos.ExportarIndividual();
                dtgHistorialesFormativos.DataSource = HistorialesIndividual;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere mientras se procesan bien los datos", "Procesando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Exportar.llenarExcel(dtgHistorialesFormativos);
        }

        private void ExportarHistorialFormativoIndividual_Load(object sender, EventArgs e)
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
