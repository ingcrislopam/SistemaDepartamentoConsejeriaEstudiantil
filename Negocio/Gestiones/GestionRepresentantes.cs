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
    public class GestionRepresentantes:representantes,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;
        Negocio.Gestiones.GestionEstudiantes gesEstudiantes;

        public GestionRepresentantes()
        {
            baseDeDatos = new BaseDeDatos.BaseDeDatos();
            gesEstudiantes = new GestionEstudiantes();
        }

        public void Nuevo()
        {
            this.FechaDesde = "";
            this.FechaHasta = "";
            this.Fecha = "";
            this.Hora = "";
            this.Estudiante = "";
            this.IdEstud = 0;
            this.CedulaRepresentante = "";
            this.NombresRepresentante = "";
            this.ApellidosRepresentante = "";
            this.ParentescoAlumno = "";
            this.Sexo = "";
            this.Telefono = "";
            this.LugarNacimiento = "";
            this.EstadoCivil = "";
            this.BytesFoto = "";
            this.DireccionDomiciliaria = "";
            this.Ocupacion = "";
            this.LugarTrabajo = "";
            this.Cargo = "";
            this.CorreoElectronico = "";
            this.StatusCorreo = "";
        }

        public void Agregar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                this.Id = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Insert into [representantes] (fecha, hora, estudiante, cedulaRepresentante, nombresRepresentante, apellidosRepresentante, parentescoAlumno, sexo, telefono, lugarNacimiento, estadoCivil, bytesFoto, direccionDomiciliaria, ocupacion, lugarTrabajo, cargo, correoElectronico, statusCorreo) values ('" + this.Fecha + "', '" + this.Hora + "', '" + this.Estudiante + "', '" + this.CedulaRepresentante + "', '" + this.NombresRepresentante + "', '" + this.ApellidosRepresentante + "', '" + this.ParentescoAlumno + "', '" + this.Sexo + "', '" + this.Telefono + "', '" + this.LugarNacimiento + "', '" + this.EstadoCivil + "', '" + this.BytesFoto + "', '" + this.DireccionDomiciliaria + "', '" + this.Ocupacion + "', '" + this.LugarTrabajo + "', '" + this.Cargo + "', '" + this.CorreoElectronico + "', '" + this.StatusCorreo + "')" + "SELECT SCOPE_IDENTITY()"));
                baseDeDatos.ejecutarEscalar("Insert into [estudiantesRepresentantes] (idEstudiantes, idRepresentantes) values (" + this.IdEstud + ", " + this.Id + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Representante agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtResultado = baseDeDatos.ejecutarDataTable("Select representantes.fecha, representantes.hora, (nombres+ ' ' +apellidos)as nombresCompletos, cedulaRepresentante, nombresRepresentante, apellidosRepresentante, parentescoAlumno, representantes.sexo, telefono, representantes.lugarNacimiento, estadoCivil, representantes.bytesFoto, direccionDomiciliaria, ocupacion, lugarTrabajo, cargo, representantes.correoElectronico, statusCorreo from representantes inner join estudiantesRepresentantes on representantes.id=estudiantesRepresentantes.idRepresentantes inner join estudiantes on estudiantes.id=estudiantesRepresentantes.idEstudiantes " + datos + ";");
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

        public DataTable BuscarRepresentantes(string datos) 
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtResultado;
                dtResultado = baseDeDatos.ejecutarDataTable("Select nombresRepresentante, apellidosRepresentante, correoElectronico from representantes " + datos + ";");
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

        public DataTable BuscarRepresen() 
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtResultado;
                dtResultado = baseDeDatos.ejecutarDataTable("Select representantes.fecha, representantes.hora, (nombres+ ' ' +apellidos)as nombresCompletos, cedulaRepresentante, nombresRepresentante, apellidosRepresentante, parentescoAlumno, representantes.sexo, telefono, representantes.lugarNacimiento, estadoCivil, representantes.bytesFoto, direccionDomiciliaria, ocupacion, lugarTrabajo, cargo, representantes.correoElectronico, statusCorreo from representantes inner join estudiantesRepresentantes on representantes.id=estudiantesRepresentantes.idRepresentantes inner join estudiantes on estudiantes.id=estudiantesRepresentantes.idEstudiantes");
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
                int id=0;
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                baseDeDatos.ejecutarEscalar("Update representantes set estudiante='" + this.Estudiante + "', nombresRepresentante='" + this.NombresRepresentante + "', apellidosRepresentante='" + this.ApellidosRepresentante + "', parentescoAlumno='" + this.ParentescoAlumno + "', sexo='" + this.Sexo + "', telefono='" + this.Telefono + "', lugarNacimiento='" + this.LugarNacimiento + "', estadoCivil='" + this.EstadoCivil + "', bytesFoto='" + this.BytesFoto + "', direccionDomiciliaria='" + this.DireccionDomiciliaria + "', ocupacion='" + this.Ocupacion + "', lugarTrabajo='" + this.LugarTrabajo + "', cargo='" + this.Cargo + "', correoElectronico='" + this.CorreoElectronico + "', statusCorreo='" + this.StatusCorreo + "' where (fecha='" + this.Fecha + "' and hora='" + this.Hora + "' and cedulaRepresentante='" + this.CedulaRepresentante + "')");
                id=Convert.ToInt32(baseDeDatos.ejecutarEscalar("Select id from representantes where (fecha='"+this.Fecha+"' and hora='"+this.Hora+"' and cedulaRepresentante='"+this.CedulaRepresentante+"')"));
                baseDeDatos.ejecutarEscalar("Update estudiantesRepresentantes set idEstudiantes=" + this.IdEstud + " where (idRepresentantes=" + id + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Representante editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int identificacion = 0;
                identificacion = Convert.ToInt32(baseDeDatos.ejecutarEscalar("Select id from representantes where (fecha='" + this.Fecha + "' and hora='" + this.Hora + "' and cedulaRepresentante='" + this.CedulaRepresentante + "')"));
                baseDeDatos.ejecutarEscalar("Delete from estudiantesRepresentantes where (idEstudiantes=" + this.IdEstud + " and idRepresentantes=" + identificacion + ")");
                baseDeDatos.ejecutarEscalar("Delete from representantes where (id=" + identificacion + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Representante eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable Exportar()
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtBuscar;
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fecha, hora, nombres, apellidos, cedulaRepresentante, nombresRepresentante, apellidosRepresentante, parentescoAlumno, representantes.sexo, telefono, representantes.lugarNacimiento, estadoCivil, direccionDomiciliaria, ocupacion, lugarTrabajo, cargo, representantes.correoElectronico, statusCorreo from representantes inner join estudiantesRepresentantes on representantes.id=estudiantesRepresentantes.idRepresentantes inner join estudiantes on estudiantes.id=estudiantesRepresentantes.idEstudiantes where (fecha>='" + this.FechaDesde.ToString() + "' and fecha<='" + this.FechaHasta.ToString() + "')");
                this.Fecha = dtBuscar.Rows[0]["fecha"].ToString();
                this.Hora = dtBuscar.Rows[0]["hora"].ToString();
                gesEstudiantes.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                gesEstudiantes.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.CedulaRepresentante = dtBuscar.Rows[0]["cedulaRepresentante"].ToString();
                this.NombresRepresentante = dtBuscar.Rows[0]["nombresRepresentante"].ToString();
                this.ApellidosRepresentante = dtBuscar.Rows[0]["apellidosRepresentante"].ToString();
                this.ParentescoAlumno = dtBuscar.Rows[0]["parentescoAlumno"].ToString();
                this.Sexo = dtBuscar.Rows[0]["sexo"].ToString();
                this.Telefono = dtBuscar.Rows[0]["telefono"].ToString();
                this.LugarNacimiento = dtBuscar.Rows[0]["lugarNacimiento"].ToString();
                this.EstadoCivil = dtBuscar.Rows[0]["estadoCivil"].ToString();
                this.DireccionDomiciliaria = dtBuscar.Rows[0]["direccionDomiciliaria"].ToString();
                this.Ocupacion = dtBuscar.Rows[0]["ocupacion"].ToString();
                this.LugarTrabajo = dtBuscar.Rows[0]["lugarTrabajo"].ToString();
                this.Cargo = dtBuscar.Rows[0]["cargo"].ToString();
                this.CorreoElectronico = dtBuscar.Rows[0]["correoElectronico"].ToString();
                this.StatusCorreo = dtBuscar.Rows[0]["statusCorreo"].ToString();
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
    }
}
