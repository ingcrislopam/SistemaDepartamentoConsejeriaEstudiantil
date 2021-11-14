using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class antecedentesPersonales:identificacion
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
        
        private estudiantes idEstudiante;

        public estudiantes IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
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

        private string fechaNacimiento;

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private string residencia;

        public string Residencia
        {
            get { return residencia; }
            set { residencia = value; }
        }

        private string religion;

        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string ocupacion;

        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }

        private int numeroHermanos;

        public int NumeroHermanos
        {
            get { return numeroHermanos; }
            set { numeroHermanos = value; }
        }

        private string motivosVisitaDepartamento;

        public string MotivosVisitaDepartamento
        {
            get { return motivosVisitaDepartamento; }
            set { motivosVisitaDepartamento = value; }
        }
    }
}
