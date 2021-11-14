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
    public class GestionAntecedentesFamiliares:antecedentesFamiliares,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;

        public GestionAntecedentesFamiliares()
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
            this.HogarCompleto = "";
            this.HogarDisfuncional = "";
            this.ViolenciaIntrafamiliar = "";
            this.TipoViolencia = "";
            this.Farmaco = "";
            this.TipoFarmaco = "";
            this.Enfermedad = "";
            this.TipoEnfermedad = "";
            this.DiagnosticoPresuntivo = "";
            this.DiagnosticoDefinitivo = "";
            this.Recomendaciones = "";
        }

        public void Agregar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                this.Id = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Insert into [antecedentesFamiliares] (idEstudiante, fecha, hora, hogarCompleto, hogarDisfuncional, violenciaIntrafamiliar, tipoViolencia, farmaco, tipoFarmaco, enfermedad, tipoEnfermedad, diagnosticoPresuntivo, diagnosticoDefinitivo, recomendaciones) values (" + this.IdEstudiante.Id + ", '" + this.Fecha + "', '" + this.Hora + "', '" + this.HogarCompleto + "', '" + this.HogarDisfuncional + "', '" + this.ViolenciaIntrafamiliar + "', '" + this.TipoViolencia + "', '" + this.Farmaco + "', '" + this.TipoFarmaco + "', '" + this.Enfermedad + "', '" + this.TipoEnfermedad + "', '" + this.DiagnosticoPresuntivo + "', '" + this.DiagnosticoDefinitivo + "', '" + this.Recomendaciones + "')" + "SELECT SCOPE_IDENTITY()"));
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente familiar ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select (nombres+ ' ' +apellidos)as nombresCompletos, antecedentesFamiliares.fecha, antecedentesFamiliares.hora, hogarCompleto, hogarDisfuncional, violenciaIntrafamiliar, tipoViolencia, farmaco, tipoFarmaco, enfermedad, tipoEnfermedad, diagnosticoPresuntivo, diagnosticoDefinitivo, recomendaciones from estudiantes inner join antecedentesFamiliares on estudiantes.id=antecedentesFamiliares.idEstudiante " + datos + ";");
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
                baseDeDatos.ejecutarEscalar("Update antecedentesFamiliares set hogarCompleto='" + this.HogarCompleto + "', hogarDisfuncional='" + this.HogarDisfuncional + "', violenciaIntrafamiliar='" + this.ViolenciaIntrafamiliar + "', tipoViolencia='" + this.TipoViolencia + "', farmaco='" + this.Farmaco + "', tipoFarmaco='" + this.TipoFarmaco + "', enfermedad='" + this.Enfermedad + "', tipoEnfermedad='" + this.TipoEnfermedad + "', diagnosticoPresuntivo='" + this.DiagnosticoPresuntivo + "', diagnosticoDefinitivo='" + this.DiagnosticoDefinitivo + "', recomendaciones='" + this.Recomendaciones + "' where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente familiar editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                baseDeDatos.ejecutarEscalar("Delete from [antecedentesFamiliares] where (idEstudiante=" + this.IdEstudiante.Id + " and fecha='" + this.Fecha + "' and hora='" + this.Hora + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Antecedente familiar eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, hogarCompleto, hogarDisfuncional, violenciaIntrafamiliar, tipoViolencia, farmaco, tipoFarmaco, enfermedad, tipoEnfermedad, diagnosticoPresuntivo, diagnosticoDefinitivo, recomendaciones from antecedentesFamiliares inner join estudiantes on estudiantes.id=antecedentesFamiliares.idEstudiante where (fecha>='" + this.FechaDesde.ToString() + "' and fecha<='" + this.FechaHasta.ToString() + "')");
                this.Fecha = dtBuscar.Rows[0]["fecha"].ToString();
                this.Hora = dtBuscar.Rows[0]["hora"].ToString();
                this.IdEstudiante.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                this.IdEstudiante.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.HogarCompleto = dtBuscar.Rows[0]["hogarCompleto"].ToString();
                this.HogarDisfuncional = dtBuscar.Rows[0]["hogarDisfuncional"].ToString();
                this.ViolenciaIntrafamiliar = dtBuscar.Rows[0]["violenciaIntrafamiliar"].ToString();
                this.TipoViolencia = dtBuscar.Rows[0]["tipoViolencia"].ToString();
                this.Farmaco = dtBuscar.Rows[0]["farmaco"].ToString();
                this.TipoFarmaco = dtBuscar.Rows[0]["tipoFarmaco"].ToString();
                this.Enfermedad = dtBuscar.Rows[0]["enfermedad"].ToString();
                this.TipoEnfermedad = dtBuscar.Rows[0]["tipoEnfermedad"].ToString();
                this.DiagnosticoPresuntivo = dtBuscar.Rows[0]["diagnosticoPresuntivo"].ToString();
                this.DiagnosticoDefinitivo = dtBuscar.Rows[0]["diagnosticoDefinitivo"].ToString();
                this.Recomendaciones = dtBuscar.Rows[0]["recomendaciones"].ToString();
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
                DataTable tablaAntecedentesIndividual;
                tablaAntecedentesIndividual = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, hogarCompleto, hogarDisfuncional, violenciaIntrafamiliar, tipoViolencia, farmaco, tipoFarmaco, enfermedad, tipoEnfermedad, diagnosticoPresuntivo, diagnosticoDefinitivo, recomendaciones from estudiantes inner join antecedentesFamiliares on estudiantes.id=antecedentesFamiliares.idEstudiante where (nombres='" + IdEstudiante.Nombres + "' and apellidos='" + IdEstudiante.Apellidos + "' and antecedentesFamiliares.fecha>='" + this.FechaDesde + "' and antecedentesFamiliares.fecha<='" + this.FechaHasta + "')");
                baseDeDatos.confirmarTransaccion();
                return tablaAntecedentesIndividual;
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
