using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class representantes:identificacion
    {
        private string fechaDesde;

        public string FechaDesde
        {
            get { return fechaDesde; }
            set { fechaDesde = value; }
        }

        private string fechaHasta;

        public string FechaHasta
        {
            get { return fechaHasta; }
            set { fechaHasta = value; }
        }
        
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private string estudiante;

        public string Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        private int idEstud;

        public int IdEstud
        {
            get { return idEstud; }
            set { idEstud = value; }
        }
        
        private string cedulaRepresentante;

        public string CedulaRepresentante
        {
            get { return cedulaRepresentante; }
            set { cedulaRepresentante = value; }
        }

        private string nombresRepresentante;

        public string NombresRepresentante
        {
            get { return nombresRepresentante; }
            set { nombresRepresentante = value; }
        }

        private string apellidosRepresentante;

        public string ApellidosRepresentante
        {
            get { return apellidosRepresentante; }
            set { apellidosRepresentante = value; }
        }

        private string parentescoAlumno;

        public string ParentescoAlumno
        {
            get { return parentescoAlumno; }
            set { parentescoAlumno = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string lugarNacimiento;

        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }

        private string estadoCivil;

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        private string bytesFoto;

        public string BytesFoto
        {
            get { return bytesFoto; }
            set { bytesFoto = value; }
        }

        private string direccionDomiciliaria;

        public string DireccionDomiciliaria
        {
            get { return direccionDomiciliaria; }
            set { direccionDomiciliaria = value; }
        }

        private string ocupacion;

        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }

        private string lugarTrabajo;

        public string LugarTrabajo
        {
            get { return lugarTrabajo; }
            set { lugarTrabajo = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private string correoElectronico;

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        private string statusCorreo;

        public string StatusCorreo
        {
            get { return statusCorreo; }
            set { statusCorreo = value; }
        }
    }
}
