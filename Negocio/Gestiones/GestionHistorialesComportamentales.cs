using Negocio.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Gestiones
{
    public class GestionHistorialesComportamentales:historialesComportamentales,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;

        public GestionHistorialesComportamentales()
        {
            baseDeDatos = new BaseDeDatos.BaseDeDatos();
            IdEstudiante = new estudiantes();
        }

        public void Nuevo()
        {
            this.FechaDesde = "";
            this.FechaHasta = "";
            this.IdEstudiante.Id = 0;
            this.Fecha = "";
            this.Hora = "";
            this.RespetoEstudiantes = "";
            this.CalificacionRespeto = 0;
            this.DestrezasComunicacionales = "";
            this.CalificacionDestrezas = 0;
            this.DesafioIntelectual = "";
            this.CalificacionDesafio = 0;
            this.CumplimientoCompromisos = "";
            this.CalificacionCumplimiento = 0;
            this.Puntualidad = "";
            this.CalificacionPuntualidad = 0;
            this.Asistencia = "";
            this.CalificacionAsistencia = 0;
            this.Limpieza = "";
            this.CalificacionLimpieza = 0;
        }

        public void Agregar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                this.Id = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Insert into [historialesComportamentales] (idEstudiante, fecha, hora, respetoEstudiantes, calificacionRespeto, destrezasComunicacionales, calificacionDestrezas, desafioIntelectual, calificacionDesafio, cumplimientoCompromisos, calificacionCumplimiento, puntualidad, calificacionPuntualidad, asistencia, calificacionAsistencia, limpieza, calificacionLimpieza) values (" + this.IdEstudiante.Id + ", '" + this.Fecha + "', '" + this.Hora + "', '" + this.RespetoEstudiantes + "', " + this.CalificacionRespeto + ", '" + this.DestrezasComunicacionales + "', " + this.CalificacionDestrezas + ", '" + this.DesafioIntelectual + "', " + this.CalificacionDesafio + ", '" + this.CumplimientoCompromisos + "', " + this.CalificacionCumplimiento + ", '" + this.Puntualidad + "', " + this.CalificacionPuntualidad + ", '" + this.Asistencia + "', " + this.CalificacionAsistencia + ", '" + this.Limpieza + "', " + this.CalificacionLimpieza + ")" + "SELECT SCOPE_IDENTITY()"));
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial comportamental agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                baseDeDatos.cancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.desconectar();
            }
        }

        public DataTable Buscar(string datos)
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtBuscar;
                dtBuscar = baseDeDatos.ejecutarDataTable("Select (nombres+ ' ' +apellidos)as nombresCompletos, fecha, hora, respetoEstudiantes, calificacionRespeto, destrezasComunicacionales, calificacionDestrezas, desafioIntelectual, calificacionDesafio, cumplimientoCompromisos, calificacionCumplimiento, puntualidad, calificacionPuntualidad, asistencia, calificacionAsistencia, limpieza, calificacionLimpieza from [estudiantes] inner join [historialesComportamentales] on estudiantes.id=historialesComportamentales.idEstudiante " + datos + ";");
                baseDeDatos.confirmarTransaccion();
                return dtBuscar;
            }
            catch (Exception ex)
            {
                baseDeDatos.desconectar();
                throw new Exception(ex.Message);
            }
            finally
            {
                baseDeDatos.desconectar();
            }
        }

        public void Editar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                baseDeDatos.ejecutarEscalar("Update historialesComportamentales set respetoEstudiantes='" + this.RespetoEstudiantes + "', calificacionRespeto=" + this.CalificacionRespeto + ", destrezasComunicacionales='" + this.DestrezasComunicacionales + "', calificacionDestrezas=" + this.CalificacionDestrezas + ", desafioIntelectual='" + this.DesafioIntelectual + "', calificacionDesafio=" + this.CalificacionDesafio + ", cumplimientoCompromisos='" + this.CumplimientoCompromisos + "', calificacionCumplimiento=" + this.CalificacionCumplimiento + ", puntualidad='" + this.Puntualidad + "', calificacionPuntualidad=" + this.CalificacionPuntualidad + ", asistencia='" + this.Asistencia + "', calificacionAsistencia=" + this.CalificacionAsistencia + ", limpieza='" + this.Limpieza + "', calificacionLimpieza=" + this.CalificacionLimpieza + " where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial comportamental editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                baseDeDatos.cancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.desconectar();
            }
        }

        public void Eliminar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                baseDeDatos.ejecutarEscalar("Delete from historialesComportamentales where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial comportamental eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                baseDeDatos.cancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.desconectar();
            }
        }

        public DataTable Exportar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtBuscar;
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, respetoEstudiantes, calificacionRespeto, destrezasComunicacionales, calificacionDestrezas, desafioIntelectual, calificacionDesafio, cumplimientoCompromisos, calificacionCumplimiento, puntualidad, CalificacionPuntualidad, asistencia, calificacionAsistencia, limpieza, calificacionLimpieza from historialesComportamentales inner join estudiantes on estudiantes.id=historialesComportamentales.idEstudiante where (fecha>='" + this.FechaDesde.ToString() + "' and fecha<='" + this.FechaHasta.ToString() + "')");
                this.Fecha = dtBuscar.Rows[0]["fecha"].ToString();
                this.Hora = dtBuscar.Rows[0]["hora"].ToString();
                this.IdEstudiante.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                this.IdEstudiante.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.RespetoEstudiantes = dtBuscar.Rows[0]["respetoEstudiantes"].ToString();
                this.CalificacionRespeto = Convert.ToInt32(dtBuscar.Rows[0]["calificacionRespeto"].ToString());
                this.DestrezasComunicacionales = dtBuscar.Rows[0]["destrezasComunicacionales"].ToString();
                this.CalificacionDestrezas = Convert.ToInt32(dtBuscar.Rows[0]["calificacionDestrezas"].ToString());
                this.DesafioIntelectual = dtBuscar.Rows[0]["desafioIntelectual"].ToString();
                this.CalificacionDesafio = Convert.ToInt32(dtBuscar.Rows[0]["calificacionDesafio"].ToString());
                this.CumplimientoCompromisos = dtBuscar.Rows[0]["cumplimientoCompromisos"].ToString();
                this.CalificacionCumplimiento = Convert.ToInt32(dtBuscar.Rows[0]["calificacionCumplimiento"].ToString());
                this.Puntualidad = dtBuscar.Rows[0]["puntualidad"].ToString();
                this.CalificacionPuntualidad = Convert.ToInt32(dtBuscar.Rows[0]["calificacionPuntualidad"].ToString());
                this.Asistencia = dtBuscar.Rows[0]["asistencia"].ToString();
                this.CalificacionAsistencia = Convert.ToInt32(dtBuscar.Rows[0]["calificacionAsistencia"].ToString());
                this.Limpieza = dtBuscar.Rows[0]["limpieza"].ToString();
                this.CalificacionLimpieza = Convert.ToInt32(dtBuscar.Rows[0]["calificacionLimpieza"].ToString());
                baseDeDatos.confirmarTransaccion();
                return dtBuscar;
            }
            catch (Exception ex)
            {
                baseDeDatos.cancelarTransaccion();
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                baseDeDatos.desconectar();
            }
        }

        public DataTable ExportarIndividual() 
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable tablaHistorialesIndividual;
                tablaHistorialesIndividual = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, respetoEstudiantes, calificacionRespeto, destrezasComunicacionales, calificacionDestrezas, desafioIntelectual, calificacionDesafio, cumplimientoCompromisos, calificacionCumplimiento, puntualidad, calificacionPuntualidad, asistencia, calificacionAsistencia, limpieza, calificacionLimpieza from estudiantes inner join historialesComportamentales on estudiantes.id=historialesComportamentales.idEstudiante where (nombres='" + IdEstudiante.Nombres + "' and apellidos='" + IdEstudiante.Apellidos + "' and historialesComportamentales.fecha>='" + this.FechaDesde + "' and historialesComportamentales.fecha<='" + this.FechaHasta + "')");
                baseDeDatos.confirmarTransaccion();
                return tablaHistorialesIndividual;
            }
            catch (Exception ex)
            {
                baseDeDatos.cancelarTransaccion();
                throw new Exception(ex.Message, ex);
            }
            finally 
            {
                baseDeDatos.desconectar();
            }
        }

    }
}
