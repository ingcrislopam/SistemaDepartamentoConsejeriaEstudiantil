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
    public class GestionHistorialesFormativos:historialesFormativos,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;

        public GestionHistorialesFormativos()
        {
            baseDeDatos = new BaseDeDatos.BaseDeDatos();
            IdEstudiante = new estudiantes();
        }

        public void Nuevo()
        {
            this.FechaDesde = "";
            this.FechaHasta = "";
            this.TrabajoIndependiente = 0;
            this.ActividadesIndividuales = 0;
            this.ActividadesGrupales = 0;
            this.Lecciones = 0;
            this.EvaluacionSumativa = 0;
        }

        public void Agregar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                this.Id = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Insert into [historialesFormativos] (idEstudiante, fecha, hora, trabajoIndependiente, actividadesIndividuales, actividadesGrupales, lecciones, evaluacionSumativa) values ("+this.IdEstudiante.Id+", '"+this.Fecha+"', '"+this.Hora+"', " + this.TrabajoIndependiente + ", " + this.ActividadesIndividuales + ", " + this.ActividadesGrupales + ", " + this.Lecciones + ", " + this.EvaluacionSumativa + ")" + "SELECT SCOPE_IDENTITY()"));
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial formativo se ha agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DataTable dtResultado;
                dtResultado = baseDeDatos.ejecutarDataTable("Select (nombres+ ' ' +apellidos)as nombresCompletos, historialesFormativos.fecha, historialesFormativos.hora, trabajoIndependiente, actividadesIndividuales, actividadesGrupales, lecciones, evaluacionSumativa from estudiantes inner join historialesFormativos on estudiantes.id=historialesFormativos.idEstudiante " + datos + ";");
                baseDeDatos.confirmarTransaccion();
                return dtResultado;
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

        public void Editar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                baseDeDatos.ejecutarEscalar("Update historialesFormativos set trabajoIndependiente=" + this.TrabajoIndependiente + ", actividadesIndividuales=" + this.ActividadesIndividuales + ", actividadesGrupales=" + this.ActividadesGrupales + ", lecciones=" + this.Lecciones + ", evaluacionSumativa=" + this.EvaluacionSumativa + " where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial formativo se ha editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                baseDeDatos.ejecutarEscalar("Delete from historialesFormativos where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Historial formativo eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, trabajoIndependiente, actividadesIndividuales, actividadesGrupales, lecciones, evaluacionSumativa from historialesFormativos inner join estudiantes on estudiantes.id=historialesFormativos.idEstudiante where (fecha>='" + this.FechaDesde.ToString() + "' and fecha<='" + this.FechaHasta.ToString() + "')");
                this.Fecha = dtBuscar.Rows[0]["fecha"].ToString();
                this.Hora = dtBuscar.Rows[0]["hora"].ToString();
                this.IdEstudiante.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                this.IdEstudiante.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.TrabajoIndependiente = Convert.ToDouble(dtBuscar.Rows[0]["trabajoIndependiente"].ToString());
                this.ActividadesIndividuales = Convert.ToDouble(dtBuscar.Rows[0]["actividadesIndividuales"].ToString());
                this.ActividadesGrupales = Convert.ToDouble(dtBuscar.Rows[0]["actividadesGrupales"].ToString());
                this.Lecciones = Convert.ToDouble(dtBuscar.Rows[0]["lecciones"].ToString());
                this.EvaluacionSumativa = Convert.ToDouble(dtBuscar.Rows[0]["evaluacionSumativa"].ToString());
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
                tablaHistorialesIndividual = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, trabajoIndependiente, actividadesIndividuales, actividadesGrupales, lecciones, evaluacionSumativa from estudiantes inner join historialesFormativos on estudiantes.id=historialesFormativos.idEstudiante where (nombres='" + IdEstudiante.Nombres + "' and apellidos='" + IdEstudiante.Apellidos + "' and historialesFormativos.fecha>='" + this.FechaDesde + "' and historialesFormativos.fecha<='" + this.FechaHasta + "')");
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
