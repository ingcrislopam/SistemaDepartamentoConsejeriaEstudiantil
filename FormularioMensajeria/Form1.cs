using Negocio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMensajeria
{
    public partial class Form1 : Form
    {
        private string Archivo;
        Negocio.Gestiones.GestionRepresentantes gestionRepresentante;
        public DataTable tabla { get; set; }

        public Form1()
        {
            InitializeComponent();
            gestionRepresentante = new Negocio.Gestiones.GestionRepresentantes();
        }

        private void MostrarDatos() 
        {
            tabla = gestionRepresentante.BuscarRepresentantes("where nombresRepresentante like '%" + txtBusqueda.Text.Trim() + "%' order by nombresRepresentante");
            dtMostrarRepresentantes.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            if (dtMostrarRepresentantes.Rows.Count == 0)
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

        private void dtMostrarRepresentantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombres.Text = Convert.ToString(dtMostrarRepresentantes.Rows[e.RowIndex].Cells[0].Value);
            txtApellidos.Text = Convert.ToString(dtMostrarRepresentantes.Rows[e.RowIndex].Cells[1].Value);
            txtPara.Text = Convert.ToString(dtMostrarRepresentantes.Rows[e.RowIndex].Cells[2].Value);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.FileName = "Seleccione el archivo";
            archivo.ShowDialog();
            Archivo = archivo.FileName;
            txtDatoAdjunto.Text = Archivo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SendMail m = new SendMail(txtCorreo.Text, txtContrasenia.Text);
            m.sendMail(txtPara.Text, txtAsunto.Text, txtDatoAdjunto.Text, txtMensaje.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
