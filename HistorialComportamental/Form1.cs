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

namespace HistorialComportamental
{
    public partial class Form1 : Cabecera
    {
        Negocio.Gestiones.GestionHistorialesComportamentales gestionHistorialComportamental;
        Negocio.Gestiones.GestionEstudiantes gestionEstudiante;
        public DataTable tablaHC { get; set; }

        public Form1()
        {
            InitializeComponent();
            InicializarComboRespeto();
            InicializarComboCalifRespeto();
            InicializarComboDestrezas();
            InicializarComboCalifDestrezas();
            InicializarComboDesafio();
            InicializarComboCalifDesafio();
            InicializarComboCumplimiento();
            InicializarComboCalifCumplimiento();
            InicializarComboPuntualidad();
            InicializarComboCalifPuntualidad();
            InicializarComboAsistencia();
            InicializarComboCalifAsistencia();
            InicializarComboLimpieza();
            InicializarComboCalifLimpieza();
            gestionHistorialComportamental = new Negocio.Gestiones.GestionHistorialesComportamentales();
            gestionEstudiante = new Negocio.Gestiones.GestionEstudiantes();
            LlamarEstudiantes();
        }

        public override void Nuevo()
        {
            gestionHistorialComportamental.Nuevo();
            dtpFecha.Text = gestionHistorialComportamental.Fecha;
            dtpHora.Text = gestionHistorialComportamental.Hora;
            InicializarComboRespeto();
            InicializarComboDestrezas();
            InicializarComboDesafio();
            InicializarComboCumplimiento();
            InicializarComboPuntualidad();
            InicializarComboAsistencia();
            InicializarComboLimpieza();
            Puntero();
        }

        public override void Agregar()
        {
            try
            {
                gestionHistorialComportamental.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialComportamental.Fecha = dtpFecha.Text;
                gestionHistorialComportamental.Hora = dtpHora.Text;
                gestionHistorialComportamental.RespetoEstudiantes = cbbRespeto.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionRespeto = Convert.ToInt32(cbbCalifRespeto.SelectedItem.ToString());
                gestionHistorialComportamental.DestrezasComunicacionales = cbbDestrezas.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionDestrezas = Convert.ToInt32(cbbCalifDestrezas.SelectedItem.ToString());
                gestionHistorialComportamental.DesafioIntelectual = cbbDesafio.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionDesafio = Convert.ToInt32(cbbCalifDesafio.SelectedItem.ToString());
                gestionHistorialComportamental.CumplimientoCompromisos = cbbCumplimiento.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionCumplimiento = Convert.ToInt32(cbbCalifCumplimiento.SelectedItem.ToString());
                gestionHistorialComportamental.Puntualidad = cbbPuntualidad.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionPuntualidad = Convert.ToInt32(cbbCalifPuntualidad.SelectedItem.ToString());
                gestionHistorialComportamental.Asistencia = cbbAsistencia.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionAsistencia = Convert.ToInt32(cbbCalifAsistencia.SelectedItem.ToString());
                gestionHistorialComportamental.Limpieza = cbbLimpieza.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionLimpieza = Convert.ToInt32(cbbCalifLimpieza.SelectedItem.ToString());
                gestionHistorialComportamental.Agregar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial comportamental", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            FormularioEleccionHistorialComportamental formularioEleccionHistorialComportamental = new FormularioEleccionHistorialComportamental();
            formularioEleccionHistorialComportamental.Show();
        }

        public override void Editar()
        {
            try
            {
                gestionHistorialComportamental.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialComportamental.Fecha = dtpFecha.Text;
                gestionHistorialComportamental.Hora = dtpHora.Text;
                gestionHistorialComportamental.RespetoEstudiantes = cbbRespeto.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionRespeto = Convert.ToInt32(cbbCalifRespeto.SelectedItem.ToString());
                gestionHistorialComportamental.DestrezasComunicacionales = cbbDestrezas.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionDestrezas = Convert.ToInt32(cbbCalifDestrezas.SelectedItem.ToString());
                gestionHistorialComportamental.DesafioIntelectual = cbbDesafio.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionDesafio = Convert.ToInt32(cbbCalifDesafio.SelectedItem.ToString());
                gestionHistorialComportamental.CumplimientoCompromisos = cbbCumplimiento.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionCumplimiento = Convert.ToInt32(cbbCalifCumplimiento.SelectedItem.ToString());
                gestionHistorialComportamental.Puntualidad = cbbPuntualidad.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionPuntualidad = Convert.ToInt32(cbbCalifPuntualidad.SelectedItem.ToString());
                gestionHistorialComportamental.Asistencia = cbbAsistencia.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionAsistencia = Convert.ToInt32(cbbCalifAsistencia.SelectedItem.ToString());
                gestionHistorialComportamental.Limpieza = cbbLimpieza.SelectedItem.ToString();
                gestionHistorialComportamental.CalificacionLimpieza = Convert.ToInt32(cbbCalifLimpieza.SelectedItem.ToString());
                gestionHistorialComportamental.Editar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial comportamental", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            try
            {
                gestionHistorialComportamental.IdEstudiante.Id = Convert.ToInt32(cbbEstudiantes.SelectedValue.ToString());
                gestionHistorialComportamental.Fecha = dtpFecha.Text;
                gestionHistorialComportamental.Hora = dtpHora.Text;
                gestionHistorialComportamental.Eliminar();
                MostrarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de completar todos los datos del historial comportamental", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MostrarDatos()
        {
            tablaHC = gestionHistorialComportamental.Buscar("where (nombres+ ' ' +apellidos) like '%" + txtBusqueda.Text.Trim() + "%' order by nombresCompletos");
            dgvMostrar.DataSource = tablaHC;
        }

        private void Puntero() 
        {
            this.cbbEstudiantes.Focus();
        }

        private void InicializarComboRespeto() 
        {
            this.cbbRespeto.SelectedItem = "A";
        }

        private void InicializarComboCalifRespeto() 
        {
            this.cbbCalifRespeto.SelectedIndex = 0;
        }

        private void InicializarComboDestrezas() 
        {
            this.cbbDestrezas.SelectedItem = "A";
        }

        private void InicializarComboCalifDestrezas() 
        {
            this.cbbCalifDestrezas.SelectedIndex = 0;
        }

        private void InicializarComboDesafio() 
        {
            this.cbbDesafio.SelectedItem = "A";
        }

        private void InicializarComboCalifDesafio() 
        {
            this.cbbCalifDesafio.SelectedIndex = 0;
        }

        private void InicializarComboCumplimiento() 
        {
            this.cbbCumplimiento.SelectedItem = "A";
        }

        private void InicializarComboCalifCumplimiento() 
        {
            this.cbbCalifCumplimiento.SelectedIndex = 0;
        }

        private void InicializarComboPuntualidad() 
        {
            this.cbbPuntualidad.SelectedItem = "A";
        }

        private void InicializarComboCalifPuntualidad() 
        {
            this.cbbCalifPuntualidad.SelectedIndex = 0;
        }

        private void InicializarComboAsistencia() 
        {
            this.cbbAsistencia.SelectedItem = "A";
        }

        private void InicializarComboCalifAsistencia() 
        {
            this.cbbCalifAsistencia.SelectedIndex = 0;
        }

        private void InicializarComboLimpieza() 
        {
            this.cbbLimpieza.SelectedItem = "A";
        }

        private void InicializarComboCalifLimpieza() 
        {
            this.cbbCalifLimpieza.SelectedIndex = 0;
        }

        private void cbbRespeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRespeto.SelectedItem.ToString() == "A")
            {
                cbbCalifRespeto.Items.Clear();
                cbbCalifRespeto.Items.Add(10);
                cbbCalifRespeto.Items.Add(9);
                InicializarComboCalifRespeto();
            }
            else 
            {
                if (cbbRespeto.SelectedItem.ToString() == "B")
                {
                    cbbCalifRespeto.Items.Clear();
                    cbbCalifRespeto.Items.Add(8);
                    cbbCalifRespeto.Items.Add(7);
                    InicializarComboCalifRespeto(); 
                }
                else 
                {
                    if (cbbRespeto.SelectedItem.ToString() == "C")
                    {
                        cbbCalifRespeto.Items.Clear();
                        cbbCalifRespeto.Items.Add(6);
                        cbbCalifRespeto.Items.Add(5);
                        InicializarComboCalifRespeto(); 
                    }
                    else 
                    {
                        if (cbbRespeto.SelectedItem.ToString() == "D")
                        {
                            cbbCalifRespeto.Items.Clear();
                            cbbCalifRespeto.Items.Add(4);
                            cbbCalifRespeto.Items.Add(3);
                            InicializarComboCalifRespeto();
                        }
                        else 
                        {
                            cbbCalifRespeto.Items.Clear();
                            cbbCalifRespeto.Items.Add(2);
                            cbbCalifRespeto.Items.Add(1);
                            InicializarComboCalifRespeto();
                        }
                    }
                }
            }
        }

        private void cbbDestrezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDestrezas.SelectedItem.ToString() == "A")
            {
                cbbCalifDestrezas.Items.Clear();
                cbbCalifDestrezas.Items.Add(10);
                cbbCalifDestrezas.Items.Add(9);
                InicializarComboCalifDestrezas(); 
            }
            else
            {
                if (cbbDestrezas.SelectedItem.ToString() == "B")
                {
                    cbbCalifDestrezas.Items.Clear();
                    cbbCalifDestrezas.Items.Add(8);
                    cbbCalifDestrezas.Items.Add(7);
                    InicializarComboCalifDestrezas(); 
                }
                else
                {
                    if (cbbDestrezas.SelectedItem.ToString() == "C")
                    {
                        cbbCalifDestrezas.Items.Clear();
                        cbbCalifDestrezas.Items.Add(6);
                        cbbCalifDestrezas.Items.Add(5);
                        InicializarComboCalifDestrezas();
                    }
                    else
                    {
                        if (cbbDestrezas.SelectedItem.ToString() == "D")
                        {
                            cbbCalifDestrezas.Items.Clear();
                            cbbCalifDestrezas.Items.Add(4);
                            cbbCalifDestrezas.Items.Add(3);
                            InicializarComboCalifDestrezas(); 
                        }
                        else
                        {
                            cbbCalifDestrezas.Items.Clear();
                            cbbCalifDestrezas.Items.Add(2);
                            cbbCalifDestrezas.Items.Add(1);
                            InicializarComboCalifDestrezas(); 
                        }
                    }
                }
            }
        }

        private void cbbDesafio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDesafio.SelectedItem.ToString() == "A")
            {
                cbbCalifDesafio.Items.Clear();
                cbbCalifDesafio.Items.Add(10);
                cbbCalifDesafio.Items.Add(9);
                InicializarComboCalifDesafio();
            }
            else
            {
                if (cbbDesafio.SelectedItem.ToString() == "B")
                {
                    cbbCalifDesafio.Items.Clear();
                    cbbCalifDesafio.Items.Add(8);
                    cbbCalifDesafio.Items.Add(7);
                    InicializarComboCalifDesafio();
                }
                else
                {
                    if (cbbDesafio.SelectedItem.ToString() == "C")
                    {
                        cbbCalifDesafio.Items.Clear();
                        cbbCalifDesafio.Items.Add(6);
                        cbbCalifDesafio.Items.Add(5);
                        InicializarComboCalifDesafio();
                    }
                    else
                    {
                        if (cbbDesafio.SelectedItem.ToString() == "D")
                        {
                            cbbCalifDesafio.Items.Clear();
                            cbbCalifDesafio.Items.Add(4);
                            cbbCalifDesafio.Items.Add(3);
                            InicializarComboCalifDesafio();
                        }
                        else
                        {
                            cbbCalifDesafio.Items.Clear();
                            cbbCalifDesafio.Items.Add(2);
                            cbbCalifDesafio.Items.Add(1);
                            InicializarComboCalifDesafio();
                        }
                    }
                }
            }
        }

        private void cbbCumplimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCumplimiento.SelectedItem.ToString() == "A")
            {
                cbbCalifCumplimiento.Items.Clear();
                cbbCalifCumplimiento.Items.Add(10);
                cbbCalifCumplimiento.Items.Add(9);
                InicializarComboCalifCumplimiento();
            }
            else
            {
                if (cbbCumplimiento.SelectedItem.ToString() == "B")
                {
                    cbbCalifCumplimiento.Items.Clear();
                    cbbCalifCumplimiento.Items.Add(8);
                    cbbCalifCumplimiento.Items.Add(7);
                    InicializarComboCalifCumplimiento();
                }
                else
                {
                    if (cbbCumplimiento.SelectedItem.ToString() == "C")
                    {
                        cbbCalifCumplimiento.Items.Clear();
                        cbbCalifCumplimiento.Items.Add(6);
                        cbbCalifCumplimiento.Items.Add(5);
                        InicializarComboCalifCumplimiento();
                    }
                    else
                    {
                        if (cbbCumplimiento.SelectedItem.ToString() == "D")
                        {
                            cbbCalifCumplimiento.Items.Clear();
                            cbbCalifCumplimiento.Items.Add(4);
                            cbbCalifCumplimiento.Items.Add(3);
                            InicializarComboCalifCumplimiento();
                        }
                        else
                        {
                            cbbCalifCumplimiento.Items.Clear();
                            cbbCalifCumplimiento.Items.Add(2);
                            cbbCalifCumplimiento.Items.Add(1);
                            InicializarComboCalifCumplimiento();
                        }
                    }
                }
            }
        }

        private void cbbPuntualidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPuntualidad.SelectedItem.ToString() == "A")
            {
                cbbCalifPuntualidad.Items.Clear();
                cbbCalifPuntualidad.Items.Add(10);
                cbbCalifPuntualidad.Items.Add(9);
                InicializarComboCalifPuntualidad(); 
            }
            else
            {
                if (cbbPuntualidad.SelectedItem.ToString() == "B")
                {
                    cbbCalifPuntualidad.Items.Clear();
                    cbbCalifPuntualidad.Items.Add(8);
                    cbbCalifPuntualidad.Items.Add(7);
                    InicializarComboCalifPuntualidad();
                }
                else
                {
                    if (cbbPuntualidad.SelectedItem.ToString() == "C")
                    {
                        cbbCalifPuntualidad.Items.Clear();
                        cbbCalifPuntualidad.Items.Add(6);
                        cbbCalifPuntualidad.Items.Add(5);
                        InicializarComboCalifPuntualidad();
                    }
                    else
                    {
                        if (cbbPuntualidad.SelectedItem.ToString() == "D")
                        {
                            cbbCalifPuntualidad.Items.Clear();
                            cbbCalifPuntualidad.Items.Add(4);
                            cbbCalifPuntualidad.Items.Add(3);
                            InicializarComboCalifPuntualidad();
                        }
                        else
                        {
                            cbbCalifPuntualidad.Items.Clear();
                            cbbCalifPuntualidad.Items.Add(2);
                            cbbCalifPuntualidad.Items.Add(1);
                            InicializarComboCalifPuntualidad();
                        }
                    }
                }
            }
        }

        private void cbbAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAsistencia.SelectedItem.ToString() == "A")
            {
                cbbCalifAsistencia.Items.Clear();
                cbbCalifAsistencia.Items.Add(10);
                cbbCalifAsistencia.Items.Add(9);
                InicializarComboCalifAsistencia();
            }
            else
            {
                if (cbbAsistencia.SelectedItem.ToString() == "B")
                {
                    cbbCalifAsistencia.Items.Clear();
                    cbbCalifAsistencia.Items.Add(8);
                    cbbCalifAsistencia.Items.Add(7);
                    InicializarComboCalifAsistencia();
                }
                else
                {
                    if (cbbAsistencia.SelectedItem.ToString() == "C")
                    {
                        cbbCalifAsistencia.Items.Clear();
                        cbbCalifAsistencia.Items.Add(6);
                        cbbCalifAsistencia.Items.Add(5);
                        InicializarComboCalifAsistencia();
                    }
                    else
                    {
                        if (cbbAsistencia.SelectedItem.ToString() == "D")
                        {
                            cbbCalifAsistencia.Items.Clear();
                            cbbCalifAsistencia.Items.Add(4);
                            cbbCalifAsistencia.Items.Add(3);
                            InicializarComboCalifAsistencia();
                        }
                        else
                        {
                            cbbCalifAsistencia.Items.Clear();
                            cbbCalifAsistencia.Items.Add(2);
                            cbbCalifAsistencia.Items.Add(1);
                            InicializarComboCalifAsistencia();
                        }
                    }
                }
            }
        }

        private void cbbLimpieza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLimpieza.SelectedItem.ToString() == "A")
            {
                cbbCalifLimpieza.Items.Clear();
                cbbCalifLimpieza.Items.Add(10);
                cbbCalifLimpieza.Items.Add(9);
                InicializarComboCalifLimpieza();
            }
            else
            {
                if (cbbLimpieza.SelectedItem.ToString() == "B")
                {
                    cbbCalifLimpieza.Items.Clear();
                    cbbCalifLimpieza.Items.Add(8);
                    cbbCalifLimpieza.Items.Add(7);
                    InicializarComboCalifLimpieza();
                }
                else
                {
                    if (cbbLimpieza.SelectedItem.ToString() == "C")
                    {
                        cbbCalifLimpieza.Items.Clear();
                        cbbCalifLimpieza.Items.Add(6);
                        cbbCalifLimpieza.Items.Add(5);
                        InicializarComboCalifLimpieza();
                    }
                    else
                    {
                        if (cbbLimpieza.SelectedItem.ToString() == "D")
                        {
                            cbbCalifLimpieza.Items.Clear();
                            cbbCalifLimpieza.Items.Add(4);
                            cbbCalifLimpieza.Items.Add(3);
                            InicializarComboCalifLimpieza();
                        }
                        else
                        {
                            cbbCalifLimpieza.Items.Clear();
                            cbbCalifLimpieza.Items.Add(2);
                            cbbCalifLimpieza.Items.Add(1);
                            InicializarComboCalifLimpieza();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarDatos();
            if (dgvMostrar.Rows.Count == 0)
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

        private void dgvMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbEstudiantes.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[0].Value);
            dtpFecha.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[1].Value);
            dtpHora.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[2].Value);
            cbbRespeto.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[3].Value);
            cbbCalifRespeto.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[4].Value);
            cbbDestrezas.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[5].Value);
            cbbCalifDestrezas.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[6].Value);
            cbbDesafio.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[7].Value);
            cbbCalifDesafio.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[8].Value);
            cbbCumplimiento.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[9].Value);
            cbbCalifCumplimiento.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[10].Value);
            cbbPuntualidad.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[11].Value);
            cbbCalifPuntualidad.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[12].Value);
            cbbAsistencia.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[13].Value);
            cbbCalifAsistencia.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[14].Value);
            cbbLimpieza.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[15].Value);
            cbbCalifLimpieza.Text = Convert.ToString(dgvMostrar.Rows[e.RowIndex].Cells[16].Value);
        }
    }
}
