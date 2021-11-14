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
    public class GestionEstudiantes:estudiantes,IGestion
    {
        BaseDeDatos.BaseDeDatos baseDeDatos;
        
        public DataTable TablaEstudiantes { get; set; }

        public GestionEstudiantes()
        {
            baseDeDatos = new BaseDeDatos.BaseDeDatos();
        }

        public void Nuevo()
        {
            this.FechaDesde = "";
            this.FechaHasta = "";
            this.FechaRegistro = "";
            this.Cedula = "";
            this.Nombres = "";
            this.Apellidos = "";
            this.Curso = 0;
            this.Paralelo = "";
            this.Especialidad = "";
            this.Edad = 0;
            this.Sexo = "";
            this.BytesFoto = "";
            this.Seccion = "";
            this.LugarNacimiento = "";
            this.CentroEducativoProviene = "";
            this.CorreoElectronico = "";
        }

        public void Agregar()
        {
            string cedula = "";
            baseDeDatos.conectar();
            baseDeDatos.comenzarTransaccion();
            cedula = Convert.ToString(baseDeDatos.ejecutarEscalar("Select cedula from estudiantes where cedula='" + this.Cedula + "'"));
            if (this.Cedula == cedula)
            {
                MessageBox.Show("Estudiante ya existe", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    baseDeDatos.ejecutarEscalar("Insert into [estudiantes] (fechaRegistro, cedula, nombres, apellidos, curso, paralelo, especialidad, edad, sexo, bytesFoto, seccion, lugarNacimiento, centroEducativoProviene, correoElectronico) values ('" + this.FechaRegistro + "', '" + this.Cedula + "', '" + this.Nombres + "', '" + this.Apellidos + "', " + this.Curso + ", '" + this.Paralelo + "', '" + this.Especialidad + "', " + this.Edad + ", '" + this.Sexo + "', '" + this.BytesFoto + "', '" + this.Seccion + "', '" + this.LugarNacimiento + "', '" + this.CentroEducativoProviene + "', '" + this.CorreoElectronico + "')");
                    baseDeDatos.confirmarTransaccion();
                    MessageBox.Show("Estudiante agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        public DataTable Buscar(string datos)
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtBuscar;
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fechaRegistro, cedula, nombres, apellidos, curso, paralelo, especialidad, edad, sexo, bytesFoto, seccion, lugarNacimiento, centroEducativoProviene, correoElectronico from [estudiantes] " + datos + ";");
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
                baseDeDatos.ejecutarEscalar("Update estudiantes set fechaRegistro='" + this.FechaRegistro + "', nombres='" + this.Nombres + "', apellidos='" + this.Apellidos + "', curso=" + this.Curso + ", paralelo='" + this.Paralelo + "', especialidad='" + this.Especialidad + "', edad=" + this.Edad + ", sexo='" + this.Sexo + "', bytesFoto='" + this.BytesFoto + "', seccion='" + this.Seccion + "', lugarNacimiento='" + this.LugarNacimiento + "', centroEducativoProviene='" + this.CentroEducativoProviene + "', correoElectronico='" + this.CorreoElectronico + "' where (cedula='" + this.Cedula + "')");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Estudiante editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string cedula = "";
            baseDeDatos.conectar();
            baseDeDatos.comenzarTransaccion();
            cedula = Convert.ToString(baseDeDatos.ejecutarEscalar("Select cedula from estudiantes where cedula='" + this.Cedula.ToString() + "'"));
            if (this.Cedula == cedula)
            {
                try
                {
                    baseDeDatos.ejecutarEscalar("Delete from [estudiantes] where (fechaRegistro='" + this.FechaRegistro + "') and (cedula='" + this.Cedula + "')");
                    baseDeDatos.confirmarTransaccion();
                    MessageBox.Show("Estudiante eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else 
            {
                MessageBox.Show("Estudiante no existe", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarEstudiantes() 
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                TablaEstudiantes = baseDeDatos.ejecutarDataTable("select id, (nombres+' '+apellidos) as nombresCompletos from estudiantes");
                baseDeDatos.confirmarTransaccion();
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
                dtBuscar = baseDeDatos.ejecutarDataTable("Select fechaRegistro, cedula, nombres, apellidos, curso, paralelo, especialidad, edad, sexo, seccion, lugarNacimiento, centroEducativoProviene, correoElectronico from estudiantes where (fechaRegistro>='" + this.FechaDesde.ToString() + "' and fechaRegistro<='" + this.FechaHasta.ToString() + "')");
                this.FechaRegistro = dtBuscar.Rows[0]["fechaRegistro"].ToString();
                this.Cedula = dtBuscar.Rows[0]["cedula"].ToString();
                this.Nombres = dtBuscar.Rows[0]["nombres"].ToString();
                this.Apellidos = dtBuscar.Rows[0]["apellidos"].ToString();
                this.Curso = Convert.ToInt32(dtBuscar.Rows[0]["curso"].ToString());
                this.Paralelo = dtBuscar.Rows[0]["paralelo"].ToString();
                this.Especialidad = dtBuscar.Rows[0]["especialidad"].ToString();
                this.Edad = Convert.ToInt32(dtBuscar.Rows[0]["edad"].ToString());
                this.Sexo = dtBuscar.Rows[0]["sexo"].ToString();
                this.Seccion = dtBuscar.Rows[0]["seccion"].ToString();
                this.LugarNacimiento = dtBuscar.Rows[0]["lugarNacimiento"].ToString();
                this.CentroEducativoProviene = dtBuscar.Rows[0]["centroEducativoProviene"].ToString();
                this.CorreoElectronico = dtBuscar.Rows[0]["correoElectronico"].ToString();
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

        public DataTable SoloNombres(string datos) 
        {
            try
            {
                baseDeDatos.conectar();
                baseDeDatos.comenzarTransaccion();
                DataTable dtNombres;
                dtNombres = baseDeDatos.ejecutarDataTable("Select nombres, apellidos from [estudiantes] " + datos + ";");
                baseDeDatos.confirmarTransaccion();
                return dtNombres;
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
