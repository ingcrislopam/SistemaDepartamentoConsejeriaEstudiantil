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

namespace FormularioRepresentante
{
    public partial class Form1 : Cabecera
    {
        Negocio.Clases.imagenConversiones imagenConver;
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        Negocio.Gestiones.GestionRepresentantes gestionRepresentante;
        public DataTable tablaRepresentantes { get; set; }

        public Form1()
        {
            InitializeComponent();
            InicializarComboSexo();
            InicializarComboStatus();
            imagenConver = new Negocio.Clases.imagenConversiones();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            gestionRepresentante = new Negocio.Gestiones.GestionRepresentantes();
            LlamarEstudiantes();
        }

        private void InicializarComboSexo() 
        {
            this.cbbSexo.SelectedItem = "Masculino";
        }

        private void InicializarComboStatus() 
        {
            this.cbbStatusCorreo.SelectedItem = "Si";
        }

        private void LlamarEstudiantes()
        {
            gestionEstudiante.CargarEstudiantes();
            this.cbbEstudiantes.DataSource = gestionEstudiante.TablaEstudiantes;
            cbbEstudiantes.DisplayMember = "nombresCompletos";
            cbbEstudiantes.ValueMember = "id";
        }

        private void MostrarDatos()
        {
            tablaRepresentantes = gestionRepresentante.BuscarRepresen();
            dtgMostrarRepresentantes.DataSource = tablaRepresentantes;
        }

        public override void Nuevo()
        {
            gestionRepresentante.Nuevo();
            dtpFecha.Text=gestionRepresentante.Fecha;
            dtpHora.Text=gestionRepresentante.Hora;
            txtCedula.Text=gestionRepresentante.CedulaRepresentante;
            txtNombres.Text=gestionRepresentante.NombresRepresentante;
            txtApellidos.Text=gestionRepresentante.ApellidosRepresentante;
            txtParentescoAlumno.Text=gestionRepresentante.ParentescoAlumno;
            InicializarComboSexo();
            txtTelefono.Text=gestionRepresentante.Telefono;
            txtLugarNacimiento.Text=gestionRepresentante.LugarNacimiento;
            txtEstadoCivil.Text=gestionRepresentante.EstadoCivil;
            ptbFoto.Image=null;
            txtDireccionDomiciliaria.Text=gestionRepresentante.DireccionDomiciliaria;
            txtOcupacion.Text=gestionRepresentante.Ocupacion;
            txtLugarTrabajo.Text=gestionRepresentante.LugarTrabajo;
            txtCargo.Text=gestionRepresentante.Cargo;
            txtCorreoElectronico.Text=gestionRepresentante.CorreoElectronico;
            InicializarComboStatus();
            MostrarDatos();
        }

        public override void Agregar()
        {
            try
            {
                gestionRepresentante.Fecha = dtpFecha.Text;
                gestionRepresentante.Hora = dtpHora.Text;
                gestionRepresentante.Estudiante = cbbEstudiantes.SelectedItem.ToString();
                gestionRepresentante.IdEstud = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionRepresentante.CedulaRepresentante = txtCedula.Text;
                gestionRepresentante.NombresRepresentante = txtNombres.Text;
                gestionRepresentante.ApellidosRepresentante = txtApellidos.Text;
                gestionRepresentante.ParentescoAlumno = txtParentescoAlumno.Text;
                gestionRepresentante.Sexo = cbbSexo.SelectedItem.ToString();
                gestionRepresentante.Telefono = txtTelefono.Text;
                gestionRepresentante.LugarNacimiento = txtLugarNacimiento.Text;
                gestionRepresentante.EstadoCivil = txtEstadoCivil.Text;
                gestionRepresentante.BytesFoto = imagenConver.bytesAString(imagenConver.ImagenABytes(ptbFoto.Image));
                gestionRepresentante.DireccionDomiciliaria = txtDireccionDomiciliaria.Text;
                gestionRepresentante.Ocupacion = txtOcupacion.Text;
                gestionRepresentante.LugarTrabajo = txtLugarTrabajo.Text;
                gestionRepresentante.Cargo = txtCargo.Text;
                gestionRepresentante.CorreoElectronico = txtCorreoElectronico.Text;
                gestionRepresentante.StatusCorreo = cbbStatusCorreo.SelectedItem.ToString();
                gestionRepresentante.Agregar();
                MostrarDatos();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public override void Buscar()
        {
            ExportarRepresentantes exportarRepresentantes = new ExportarRepresentantes();
            exportarRepresentantes.Show();
        }

        public override void Editar()
        {
            try
            {
                gestionRepresentante.Fecha = dtpFecha.Text;
                gestionRepresentante.Hora = dtpHora.Text;
                gestionRepresentante.Estudiante = cbbEstudiantes.SelectedItem.ToString();
                gestionRepresentante.IdEstud = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionRepresentante.CedulaRepresentante = txtCedula.Text;
                gestionRepresentante.NombresRepresentante = txtNombres.Text;
                gestionRepresentante.ApellidosRepresentante = txtApellidos.Text;
                gestionRepresentante.ParentescoAlumno = txtParentescoAlumno.Text;
                gestionRepresentante.Sexo = cbbSexo.SelectedItem.ToString();
                gestionRepresentante.Telefono = txtTelefono.Text;
                gestionRepresentante.LugarNacimiento = txtLugarNacimiento.Text;
                gestionRepresentante.EstadoCivil = txtEstadoCivil.Text;
                gestionRepresentante.BytesFoto = imagenConver.bytesAString(imagenConver.ImagenABytes(ptbFoto.Image));
                gestionRepresentante.DireccionDomiciliaria = txtDireccionDomiciliaria.Text;
                gestionRepresentante.Ocupacion = txtOcupacion.Text;
                gestionRepresentante.LugarTrabajo = txtLugarTrabajo.Text;
                gestionRepresentante.Cargo = txtCargo.Text;
                gestionRepresentante.CorreoElectronico = txtCorreoElectronico.Text;
                gestionRepresentante.StatusCorreo = cbbStatusCorreo.SelectedItem.ToString();
                gestionRepresentante.Editar();
                MostrarDatos();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gestionRepresentante.Fecha = dtpFecha.Text;
                gestionRepresentante.Hora = dtpHora.Text;
                gestionRepresentante.IdEstud = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionRepresentante.CedulaRepresentante = txtCedula.Text;
                gestionRepresentante.Eliminar();
                MostrarDatos();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public override void Salir()
        {
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbFoto.Image = Image.FromFile(dialogo.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            if (dtgMostrarRepresentantes.Rows.Count == 0)
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

        private void dtgMostrarRepresentantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[0].Value);
            dtpHora.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[1].Value);
            cbbEstudiantes.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[2].Value);
            txtCedula.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[3].Value);
            txtNombres.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[4].Value);
            txtApellidos.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[5].Value);
            txtParentescoAlumno.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[6].Value);
            cbbSexo.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[7].Value);
            txtTelefono.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[8].Value);
            txtLugarNacimiento.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[9].Value);
            txtEstadoCivil.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[10].Value);
            ptbFoto.Image = imagenConver.BytesAImagen(imagenConver.consultaByte(Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[11].Value)));
            txtDireccionDomiciliaria.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[12].Value);
            txtOcupacion.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[13].Value);
            txtLugarTrabajo.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[14].Value);
            txtCargo.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[15].Value);
            txtCorreoElectronico.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[16].Value);
            cbbStatusCorreo.Text = Convert.ToString(dtgMostrarRepresentantes.Rows[e.RowIndex].Cells[17].Value);
        }
    }
}
