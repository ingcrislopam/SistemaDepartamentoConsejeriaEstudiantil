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

namespace FormularioAntecedenteFamiliar
{
    public partial class Form1 : Cabecera
    {
        Negocio.Gestiones.GestionAntecedentesFamiliares gestionAntecedenteFamiliar;
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        public DataTable tablaAnteFami { get; set; }

        public Form1()
        {
            InitializeComponent();
            InicializarHogarCompleto();
            InicializarHogarDisfuncional();
            InicializarComboViolenciaIntrafamiliar();
            InicializarComboFarmaco();
            InicializarComboEnfermedad();
            gestionAntecedenteFamiliar = new Negocio.Gestiones.GestionAntecedentesFamiliares();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            LlamarEstudiantes();
        }

        private void MostrarDatos()
        {
            tablaAnteFami = gestionAntecedenteFamiliar.Buscar("where (nombres+ ' ' +apellidos) like '%" + txtBusqueda.Text.Trim() + "%' order by nombresCompletos");
            dtgMostrarAF.DataSource = tablaAnteFami;
        }

        private void InicializarHogarCompleto() 
        {
            this.cbbHogarCompleto.SelectedItem = "Si";
        }

        private void InicializarHogarDisfuncional() 
        {
            this.cbbHogarDisfuncional.SelectedItem = "Si";
        }

        private void InicializarComboViolenciaIntrafamiliar() 
        {
            this.cbbViolenciaIntrafamiliar.SelectedItem = "Si";
        }

        private void InicializarComboFarmaco() 
        {
            this.cbbFarmaco.SelectedItem = "Si";
        }

        private void InicializarComboEnfermedad() 
        {
            this.cbbEnfermedad.SelectedItem = "Si";
        }

        private void cbbViolenciaIntrafamiliar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbViolenciaIntrafamiliar.SelectedItem.ToString() == "Si")
            {
                txtTipoViolencia.Enabled = true;
                txtTipoViolencia.Text = "";
            }
            else 
            {
                txtTipoViolencia.Enabled = false;
                txtTipoViolencia.Text = "Ninguna";
            }
        }

        private void cbbFarmaco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFarmaco.SelectedItem.ToString() == "Si")
            {
                txtTipoFarmaco.Enabled = true;
                txtTipoFarmaco.Text = "";
            }
            else 
            {
                txtTipoFarmaco.Enabled = false;
                txtTipoFarmaco.Text = "Ninguna";
            }
        }

        private void cbbEnfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEnfermedad.SelectedItem.ToString() == "Si")
            {
                txtTipoEnfermedad.Enabled = true;
                txtTipoEnfermedad.Text = "";
            }
            else 
            {
                txtTipoEnfermedad.Enabled = false;
                txtTipoEnfermedad.Text = "Ninguna";
            }
        }

        private void LlamarEstudiantes()
        {
            gestionEstudiante.CargarEstudiantes();
            this.cbbEstudiantes.DataSource = gestionEstudiante.TablaEstudiantes;
            cbbEstudiantes.DisplayMember = "nombresCompletos";
            cbbEstudiantes.ValueMember = "id";
        }

        public override void Nuevo()
        {
            gestionAntecedenteFamiliar.Nuevo();
            dtpFecha.Text = gestionAntecedenteFamiliar.Fecha;
            dtpHora.Text = gestionAntecedenteFamiliar.Hora;
            InicializarHogarCompleto();
            InicializarHogarDisfuncional();
            InicializarComboViolenciaIntrafamiliar();
            txtTipoViolencia.Text = gestionAntecedenteFamiliar.TipoViolencia;
            InicializarComboFarmaco();
            txtTipoFarmaco.Text = gestionAntecedenteFamiliar.TipoFarmaco;
            InicializarComboEnfermedad();
            txtTipoEnfermedad.Text = gestionAntecedenteFamiliar.TipoEnfermedad;
            txtDiagnosticoPresuntivo.Text = gestionAntecedenteFamiliar.DiagnosticoPresuntivo;
            txtDiagnosticoDefinitivo.Text = gestionAntecedenteFamiliar.DiagnosticoDefinitivo;
            txtRecomendaciones.Text = gestionAntecedenteFamiliar.Recomendaciones;
        }

        public override void Agregar()
        {
            try
            {
                gestionAntecedenteFamiliar.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionAntecedenteFamiliar.Fecha = dtpFecha.Text;
                gestionAntecedenteFamiliar.Hora = dtpHora.Text;
                gestionAntecedenteFamiliar.HogarCompleto = cbbHogarCompleto.SelectedItem.ToString();
                gestionAntecedenteFamiliar.HogarDisfuncional = cbbHogarDisfuncional.SelectedItem.ToString();
                gestionAntecedenteFamiliar.ViolenciaIntrafamiliar = cbbViolenciaIntrafamiliar.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoViolencia = txtTipoViolencia.Text;
                gestionAntecedenteFamiliar.Farmaco = cbbFarmaco.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoFarmaco = txtTipoFarmaco.Text;
                gestionAntecedenteFamiliar.Enfermedad = cbbEnfermedad.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoEnfermedad = txtTipoEnfermedad.Text;
                gestionAntecedenteFamiliar.DiagnosticoPresuntivo = txtDiagnosticoPresuntivo.Text;
                gestionAntecedenteFamiliar.DiagnosticoDefinitivo = txtDiagnosticoDefinitivo.Text;
                gestionAntecedenteFamiliar.Recomendaciones = txtRecomendaciones.Text;
                gestionAntecedenteFamiliar.Agregar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente familiar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            FomularioEleccionAntecedenteFamiliar formularioEleccionAntecedenteFamiliar = new FomularioEleccionAntecedenteFamiliar();
            formularioEleccionAntecedenteFamiliar.Show();
        }

        public override void Editar()
        {
            try
            {
                gestionAntecedenteFamiliar.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionAntecedenteFamiliar.Fecha = dtpFecha.Text;
                gestionAntecedenteFamiliar.Hora = dtpHora.Text;
                gestionAntecedenteFamiliar.HogarCompleto = cbbHogarCompleto.SelectedItem.ToString();
                gestionAntecedenteFamiliar.HogarDisfuncional = cbbHogarDisfuncional.SelectedItem.ToString();
                gestionAntecedenteFamiliar.ViolenciaIntrafamiliar = cbbViolenciaIntrafamiliar.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoViolencia = txtTipoViolencia.Text;
                gestionAntecedenteFamiliar.Farmaco = cbbFarmaco.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoFarmaco = txtTipoFarmaco.Text;
                gestionAntecedenteFamiliar.Enfermedad = cbbEnfermedad.SelectedItem.ToString();
                gestionAntecedenteFamiliar.TipoEnfermedad = txtTipoEnfermedad.Text;
                gestionAntecedenteFamiliar.DiagnosticoPresuntivo = txtDiagnosticoPresuntivo.Text;
                gestionAntecedenteFamiliar.DiagnosticoDefinitivo = txtDiagnosticoDefinitivo.Text;
                gestionAntecedenteFamiliar.Recomendaciones = txtRecomendaciones.Text;
                gestionAntecedenteFamiliar.Editar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente familiar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gestionAntecedenteFamiliar.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionAntecedenteFamiliar.Fecha = dtpFecha.Text;
                gestionAntecedenteFamiliar.Hora = dtpHora.Text;
                gestionAntecedenteFamiliar.Eliminar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente familiar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Salir()
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarDatos();
            if (dtgMostrarAF.Rows.Count == 0)
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

        private void dtgMostrarAF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbEstudiantes.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[0].Value);
            dtpFecha.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[1].Value);
            dtpHora.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[2].Value);
            cbbHogarCompleto.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[3].Value);
            cbbHogarDisfuncional.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[4].Value);
            cbbViolenciaIntrafamiliar.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[5].Value);
            txtTipoViolencia.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[6].Value);
            cbbFarmaco.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[7].Value);
            txtTipoFarmaco.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[8].Value);
            cbbEnfermedad.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[9].Value);
            txtTipoEnfermedad.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[10].Value);
            txtDiagnosticoPresuntivo.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[11].Value);
            txtDiagnosticoDefinitivo.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[12].Value);
            txtRecomendaciones.Text = Convert.ToString(dtgMostrarAF.Rows[e.RowIndex].Cells[13].Value);
        }
    }
}
