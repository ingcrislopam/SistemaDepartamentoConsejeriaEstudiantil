using Controles;
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
    public partial class Form1 : Cabecera
    {
        Negocio.Gestiones.GestionHistorialesFormativos gestionHistorialesFormativos;
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        public DataTable tablaHF { get; set; }

        public Form1()
        {
            InitializeComponent();
            gestionHistorialesFormativos = new Negocio.Gestiones.GestionHistorialesFormativos();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            LlamarEstudiantes();
        }

        public override void Nuevo()
        {
            gestionHistorialesFormativos.Nuevo();
            dtpFecha.Text = gestionHistorialesFormativos.Fecha;
            dtpHora.Text = gestionHistorialesFormativos.Hora;
            txtTrabajoIndependiente.Text = "";
            txtActividadesIndividuales.Text = "";
            txtActividadesGrupales.Text = "";
            txtLecciones.Text = "";
            txtEvaluacionSumativa.Text = "";
        }

        public override void Agregar()
        {
            try
            {
                gestionHistorialesFormativos.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialesFormativos.Fecha = dtpFecha.Text;
                gestionHistorialesFormativos.Hora = dtpHora.Text;
                gestionHistorialesFormativos.TrabajoIndependiente = Convert.ToDouble(txtTrabajoIndependiente.Text);
                gestionHistorialesFormativos.ActividadesIndividuales = Convert.ToDouble(txtActividadesIndividuales.Text);
                gestionHistorialesFormativos.ActividadesGrupales = Convert.ToDouble(txtActividadesGrupales.Text);
                gestionHistorialesFormativos.Lecciones = Convert.ToDouble(txtLecciones.Text);
                gestionHistorialesFormativos.EvaluacionSumativa = gestionHistorialesFormativos.Sumatoria(gestionHistorialesFormativos.TrabajoIndependiente, gestionHistorialesFormativos.ActividadesIndividuales, gestionHistorialesFormativos.ActividadesGrupales, gestionHistorialesFormativos.Lecciones);
                gestionHistorialesFormativos.Agregar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial formativo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            FormularioEleccionHistorialFormativo formularioEleccionHistorialFormativo = new FormularioEleccionHistorialFormativo();
            formularioEleccionHistorialFormativo.Show();
        }

        public override void Editar()
        {
            try
            {
                gestionHistorialesFormativos.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialesFormativos.Fecha = dtpFecha.Text;
                gestionHistorialesFormativos.Hora = dtpHora.Text;
                gestionHistorialesFormativos.TrabajoIndependiente = Convert.ToDouble(txtTrabajoIndependiente.Text);
                gestionHistorialesFormativos.ActividadesIndividuales = Convert.ToDouble(txtActividadesIndividuales.Text);
                gestionHistorialesFormativos.ActividadesGrupales = Convert.ToDouble(txtActividadesGrupales.Text);
                gestionHistorialesFormativos.Lecciones = Convert.ToDouble(txtLecciones.Text);
                gestionHistorialesFormativos.EvaluacionSumativa = gestionHistorialesFormativos.Sumatoria(gestionHistorialesFormativos.TrabajoIndependiente, gestionHistorialesFormativos.ActividadesIndividuales, gestionHistorialesFormativos.ActividadesGrupales, gestionHistorialesFormativos.Lecciones);
                gestionHistorialesFormativos.Editar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial formativo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gestionHistorialesFormativos.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialesFormativos.Fecha = dtpFecha.Text;
                gestionHistorialesFormativos.Hora = dtpHora.Text;
                gestionHistorialesFormativos.Eliminar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial formativo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Salir()
        {
            this.Close();
        }

        private void MostrarDatos()
        {
            tablaHF = gestionHistorialesFormativos.Buscar("where (nombres+ ' ' +apellidos) like '%" + txtBusqueda.Text.Trim() + "%' order by nombresCompletos");
            dtgMostrarHF.DataSource = tablaHF;
        }

        private void LlamarEstudiantes()
        {
            gestionEstudiante.CargarEstudiantes();
            this.cbbEstudiantes.DataSource = gestionEstudiante.TablaEstudiantes;
            cbbEstudiantes.DisplayMember = "nombresCompletos";
            cbbEstudiantes.ValueMember = "id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarDatos();
            if (dtgMostrarHF.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles");
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

        private void dtgMostrarHF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbEstudiantes.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[0].Value);
            dtpFecha.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[1].Value);
            dtpHora.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[2].Value);
            txtTrabajoIndependiente.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[3].Value);
            txtActividadesIndividuales.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[4].Value);
            txtActividadesGrupales.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[5].Value);
            txtLecciones.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[6].Value);
            txtEvaluacionSumativa.Text = Convert.ToString(dtgMostrarHF.Rows[e.RowIndex].Cells[7].Value);
        }

    }
}
