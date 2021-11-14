using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class estudiantes:clasePadre
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

        private string fechaRegistro;

        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string bytesFoto;

        public string BytesFoto
        {
            get { return bytesFoto; }
            set { bytesFoto = value; }
        }

        private string lugarNacimiento;

        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }

        private string centroEducativoProviene;

        public string CentroEducativoProviene
        {
            get { return centroEducativoProviene; }
            set { centroEducativoProviene = value; }
        }

        private string correoElectronico;

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
    }
}
