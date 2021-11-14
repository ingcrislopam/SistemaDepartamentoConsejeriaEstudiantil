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

namespace FormularioAntecedentePersonal
{
    public partial class Form1 : Cabecera
    {
        Negocio.Gestiones.GestionAntecedentesPersonales gestionAntecedentePersonal;
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        public DataTable tablaAntePerso { get; set; }

        public Form1()
        {
            InitializeComponent();
            gestionAntecedentePersonal = new Negocio.Gestiones.GestionAntecedentesPersonales();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            LlamarEstudiantes();
        }

        private void MostrarDatos()
        {
            tablaAntePerso = gestionAntecedentePersonal.Buscar("where (nombres+ ' ' +apellidos) like '%" + txtBusqueda.Text.Trim() + "%' order by nombresCompletos");
            dtgMostrarAP.DataSource = tablaAntePerso;
        }

        private void Puntero() 
        {
            this.cbbEstudiantes.Focus();
        }

        public override void Nuevo()
        {
            gestionAntecedentePersonal.Nuevo();
            dtpFecha.Text = gestionAntecedentePersonal.Fecha;
            dtpHora.Text = gestionAntecedentePersonal.Hora;
            dtpFechaNacimiento.Text = gestionAntecedentePersonal.FechaNacimiento;
            txtResidencia.Text = gestionAntecedentePersonal.Residencia;
            txtReligion.Text = gestionAntecedentePersonal.Religion;
            txtTelefono.Text = gestionAntecedentePersonal.Telefono;
            txtOcupacion.Text = gestionAntecedentePersonal.Ocupacion;
            txtNumeroHermanos.Text = "";
            txtMotivosVisitaDepartamento.Text = gestionAntecedentePersonal.MotivosVisitaDepartamento;
            Puntero();
        }

        public override void Agregar()
        {
            try
            {
                gestionAntecedentePersonal.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionAntecedentePersonal.Fecha = dtpFecha.Text;
                gestionAntecedentePersonal.Hora = dtpHora.Text;
                gestionAntecedentePersonal.FechaNacimiento = dtpFechaNacimiento.Text;
                gestionAntecedentePersonal.Residencia = txtResidencia.Text;
                gestionAntecedentePersonal.Religion = txtReligion.Text;
                gestionAntecedentePersonal.Telefono = txtTelefono.Text;
                gestionAntecedentePersonal.Ocupacion = txtOcupacion.Text;
                gestionAntecedentePersonal.NumeroHermanos = Convert.ToInt32(txtNumeroHermanos.Text);
                gestionAntecedentePersonal.MotivosVisitaDepartamento = txtMotivosVisitaDepartamento.Text;
                gestionAntecedentePersonal.Agregar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente personal", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            FormularioEleccionAntecedentePersonal formularioEleccionAntecedentePersonal = new FormularioEleccionAntecedentePersonal();
            formularioEleccionAntecedentePersonal.Show();
        }

        public override void Editar()
        {
            try
            {
                gestionAntecedentePersonal.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionAntecedentePersonal.Fecha = dtpFecha.Text;
                gestionAntecedentePersonal.Hora = dtpHora.Text;
                gestionAntecedentePersonal.FechaNacimiento = dtpFechaNacimiento.Text;
                gestionAntecedentePersonal.Residencia = txtResidencia.Text;
                gestionAntecedentePersonal.Religion = txtReligion.Text;
                gestionAntecedentePersonal.Telefono = txtTelefono.Text;
                gestionAntecedentePersonal.Ocupacion = txtOcupacion.Text;
                gestionAntecedentePersonal.NumeroHermanos = Convert.ToInt32(txtNumeroHermanos.Text);
                gestionAntecedentePersonal.MotivosVisitaDepartamento = txtMotivosVisitaDepartamento.Text;
                gestionAntecedentePersonal.Editar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente personal", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gestionAntecedentePersonal.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue);
                gestionAntecedentePersonal.Fecha = dtpFecha.Text;
                gestionAntecedentePersonal.Hora = dtpHora.Text;
                gestionAntecedentePersonal.Eliminar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del antecedente personal", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Salir()
        {
            this.Close();
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
            if (dtgMostrarAP.Rows.Count == 0)
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

        private void dtgMostrarAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbEstudiantes.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[0].Value);
            dtpFecha.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[1].Value);
            dtpHora.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[2].Value);
            dtpFechaNacimiento.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[3].Value);
            txtResidencia.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[4].Value);
            txtReligion.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[5].Value);
            txtTelefono.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[6].Value);
            txtOcupacion.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[7].Value);
            txtNumeroHermanos.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[8].Value);
            txtMotivosVisitaDepartamento.Text = Convert.ToString(dtgMostrarAP.Rows[e.RowIndex].Cells[9].Value);
        }
    }

    
}
