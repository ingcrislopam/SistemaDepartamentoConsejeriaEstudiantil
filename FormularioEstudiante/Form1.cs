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

namespace FormularioEstudiante
{
    public partial class Form1 : Cabecera
    {
        Negocio.Clases.imagenConversiones imagenConver;
        Negocio.Gestiones.GestionEstudiantes gesEstudiantes;
        public DataTable tablaEstu { get; set; }

        public Form1()
        {
            InitializeComponent();
            imagenConver = new Negocio.Clases.imagenConversiones();
            gesEstudiantes = new Negocio.Gestiones.GestionEstudiantes();
            Curso();
            Especialidad();
            Sexo();
            Seccion();
        }

        private void MostrarDatos()
        {
            tablaEstu = gesEstudiantes.Buscar("where nombres like '%" + txtBusqueda.Text.Trim() + "%' order by nombres");
            dtgMostrar.DataSource = tablaEstu;
        }

        private void Puntero() 
        {
            this.dtpFecha.Focus();
        }

        private void Curso() 
        {
            this.cbbCurso.SelectedItem = "4";
        }

        private void Especialidad() 
        {
            this.cbbEspecialidad.SelectedItem = "Ninguno";
        }

        private void Sexo() 
        {
            this.cbbSexo.SelectedItem = "Masculino";
        }

        private void Seccion() 
        {
            this.cbbSeccion.SelectedItem = "Matutina";
        }

        public override void Nuevo()
        {
            gesEstudiantes.Nuevo();
            dtpFecha.Text = gesEstudiantes.FechaRegistro;
            txtCedula.Text = gesEstudiantes.Cedula;
            txtNombres.Text = gesEstudiantes.Nombres;
            txtApellidos.Text = gesEstudiantes.Apellidos;
            Curso();
            txtParalelo.Text = gesEstudiantes.Paralelo;
            Especialidad();
            txtEdad.Text = "";
            Sexo();
            ptbFoto.Image = null;
            Seccion();
            txtLugarNacimiento.Text = gesEstudiantes.LugarNacimiento;
            txtCentroEducativoProviene.Text = gesEstudiantes.CentroEducativoProviene;
            txtCorreoElectronico.Text = gesEstudiantes.CorreoElectronico;
            txtBusqueda.Text = "";
            Puntero();
            MostrarDatos();
        }

        public override void Agregar()
        {
            try
            {
                gesEstudiantes.FechaRegistro = dtpFecha.Text;
                gesEstudiantes.Cedula = txtCedula.Text;
                gesEstudiantes.Nombres = txtNombres.Text;
                gesEstudiantes.Apellidos = txtApellidos.Text;
                gesEstudiantes.Curso = Convert.ToInt32(cbbCurso.SelectedItem.ToString());
                gesEstudiantes.Paralelo = txtParalelo.Text;
                gesEstudiantes.Especialidad = cbbEspecialidad.SelectedItem.ToString();
                gesEstudiantes.Edad = Convert.ToInt32(txtEdad.Text);
                gesEstudiantes.Sexo = cbbSexo.SelectedItem.ToString();
                gesEstudiantes.BytesFoto = imagenConver.bytesAString(imagenConver.ImagenABytes(ptbFoto.Image));
                gesEstudiantes.Seccion = cbbSeccion.SelectedItem.ToString();
                gesEstudiantes.LugarNacimiento = txtLugarNacimiento.Text;
                gesEstudiantes.CentroEducativoProviene = txtCentroEducativoProviene.Text;
                gesEstudiantes.CorreoElectronico = txtCorreoElectronico.Text;
                gesEstudiantes.Agregar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del estudiante", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            ExportarEstudiantes exportarEstudiantes = new ExportarEstudiantes();
            exportarEstudiantes.Show();
        }

        public override void Editar()
        {
            try
            {
                gesEstudiantes.FechaRegistro = dtpFecha.Text;
                gesEstudiantes.Cedula = txtCedula.Text;
                gesEstudiantes.Nombres = txtNombres.Text;
                gesEstudiantes.Apellidos = txtApellidos.Text;
                gesEstudiantes.Curso = Convert.ToInt32(cbbCurso.SelectedItem.ToString());
                gesEstudiantes.Paralelo = txtParalelo.Text;
                gesEstudiantes.Especialidad = cbbEspecialidad.SelectedItem.ToString();
                gesEstudiantes.Edad = Convert.ToInt32(txtEdad.Text);
                gesEstudiantes.Sexo = cbbSexo.SelectedItem.ToString();
                gesEstudiantes.BytesFoto = imagenConver.bytesAString(imagenConver.ImagenABytes(ptbFoto.Image));
                gesEstudiantes.Seccion = cbbSeccion.SelectedItem.ToString();
                gesEstudiantes.LugarNacimiento = txtLugarNacimiento.Text;
                gesEstudiantes.CentroEducativoProviene = txtCentroEducativoProviene.Text;
                gesEstudiantes.CorreoElectronico = txtCorreoElectronico.Text;
                gesEstudiantes.Editar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del estudiante", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gesEstudiantes.FechaRegistro = dtpFecha.Text;
                gesEstudiantes.Cedula = txtCedula.Text;
                if (gesEstudiantes.FechaRegistro == "" || gesEstudiantes.Cedula == "")
                {
                    MessageBox.Show("Datos en blancos para eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    gesEstudiantes.Eliminar();
                    MostrarDatos();
                }   
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar los campos solicitados para eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Salir()
        {
            this.Hide();
        }

        private void btnElegirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbFoto.Image = Image.FromFile(dialogo.FileName);
            }
        }

        private void cbbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEspecialidadesCurso(cbbCurso);
        }

        private void CargarEspecialidadesCurso(ComboBox combo) 
        {
            if (combo.SelectedItem.ToString() == "4")
            {
                cbbEspecialidad.Items.Clear();
                cbbEspecialidad.Items.Add("Ninguno");
                cbbEspecialidad.SelectedIndex = 0;
            }
            else 
            {
                if (combo.SelectedItem.ToString() == "5" || combo.SelectedItem.ToString() == "6")
                {
                    cbbEspecialidad.Items.Clear();
                    cbbEspecialidad.Items.Add("Climatizacion");
                    cbbEspecialidad.Items.Add("Electricidad");
                    cbbEspecialidad.Items.Add("Electronica");
                    cbbEspecialidad.Items.Add("Mecanica Automotriz");
                    cbbEspecialidad.Items.Add("Mecanica Industrial");
                    cbbEspecialidad.SelectedIndex = 0;
                }
                else 
                {
 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarDatos();
            if (dtgMostrar.Rows.Count == 0)
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

        private void dtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[0].Value);
            txtCedula.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[1].Value);
            txtNombres.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[2].Value);
            txtApellidos.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[3].Value);
            cbbCurso.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[4].Value);
            txtParalelo.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[5].Value);
            cbbEspecialidad.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[6].Value);
            txtEdad.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[7].Value);
            cbbSexo.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[8].Value);
            ptbFoto.Image = imagenConver.BytesAImagen(imagenConver.consultaByte(Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[9].Value)));
            cbbSeccion.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[10].Value);
            txtLugarNacimiento.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[11].Value);
            txtCentroEducativoProviene.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[12].Value);
            txtCorreoElectronico.Text = Convert.ToString(dtgMostrar.Rows[e.RowIndex].Cells[13].Value);
        }

    }
}
