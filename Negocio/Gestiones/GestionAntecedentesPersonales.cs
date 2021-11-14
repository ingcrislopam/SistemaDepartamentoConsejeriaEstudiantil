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
    public class GestionAntecedentesPersonales:antecedentesPersonales,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;

        public GestionAntecedentesPersonales()
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
            this.FechaNacimiento = "";
            this.Residencia = "";
            this.Religion = "";
            this.Telefono = "";
            this.Ocupacion = "";
            this.NumeroHermanos = 0;
            this.MotivosVisitaDepartamento = "";
        }

        public void Agregar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                this.Id = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Insert into [antecedentesPersonales] (idEstudiante, fecha, hora, fechaNacimiento, residencia, religion, telefono, ocupacion, numeroHermanos, motivosVisitaDepartamento) values (" + this.IdEstudiante.Id + ", '" + this.Fecha + "', '" + this.Hora + "', '" + this.FechaNacimiento + "', '" + this.Residencia + "', '" + this.Religion + "', '" + this.Telefono + "', '" + this.Ocupacion + "', " + this.NumeroHermanos + ", '" + this.MotivosVisitaDepartamento + "')" + "SELECT SCOPE_IDENTITY()"));
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente personal ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select (nombres+ ' ' +apellidos)as nombresCompletos, antecedentesPersonales.fecha, antecedentesPersonales.hora, fechaNacimiento, residencia, religion, telefono, ocupacion, numeroHermanos, motivosVisitaDepartamento from estudiantes inner join antecedentesPersonales on estudiantes.id=antecedentesPersonales.idEstudiante " + datos + ";");
                baseDeDatos.confirmarTransaccion();
                return dtBuscar;
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
                baseDeDatos.ejecutarEscalar("Update antecedentesPersonales set fechaNacimiento='" + this.FechaNacimiento + "', residencia='" + this.Residencia + "', religion='" + this.Religion + "', telefono='" + this.Telefono + "', ocupacion='" + this.Ocupacion + "', numeroHermanos=" + this.NumeroHermanos + ", motivosVisitaDepartamento='" + this.MotivosVisitaDepartamento + "' where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente personal editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                baseDeDatos.ejecutarEscalar("Delete from [antecedentesPersonales] where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente personal eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, fechaNacimiento, residencia, religion, telefono, ocupacion, numeroHermanos, motivosVisitaDepartamento from antecedentesPersonales inner join estudiantes on estudiantes.id=antecedentesPersonales.idEstudiante where (fecha>='" + this.FechaDesde.ToString() + "' and fecha<='" + this.FechaHasta.ToString() + "')");
                this.Fecha = dtBuscar.Rows[0]["fecha"].ToString();
                this.Hora = dtBuscar.Rows[0]["hora"].ToString();
                this.IdEstudiante.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                this.IdEstudiante.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.FechaNacimiento = dtBuscar.Rows[0]["fechaNacimiento"].ToString();
                this.Residencia = dtBuscar.Rows[0]["residencia"].ToString();
                this.Religion = dtBuscar.Rows[0]["religion"].ToString();
                this.Telefono = dtBuscar.Rows[0]["telefono"].ToString();
                this.Ocupacion = dtBuscar.Rows[0]["ocupacion"].ToString();
                this.NumeroHermanos = Convert.ToInt32(dtBuscar.Rows[0]["numeroHermanos"].ToString());
                this.MotivosVisitaDepartamento = dtBuscar.Rows[0]["motivosVisitaDepartamento"].ToString();
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
                DataTable tablaIndividual;
                tablaIndividual = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, fechaNacimiento, residencia, religion, telefono, ocupacion, numeroHermanos, motivosVisitaDepartamento from estudiantes inner join antecedentesPersonales on estudiantes.id=antecedentesPersonales.idEstudiante where (nombres='" + IdEstudiante.Nombres + "' and apellidos='" + IdEstudiante.Apellidos + "' and antecedentesPersonales.fecha>='" + this.FechaDesde + "' and antecedentesPersonales.fecha<='" + this.FechaHasta + "')");
                baseDeDatos.confirmarTransaccion();
                return tablaIndividual;
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
