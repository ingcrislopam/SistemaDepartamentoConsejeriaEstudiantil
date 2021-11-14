using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class antecedentesFamiliares:identificacion
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

        private string hogarCompleto;

        public string HogarCompleto
        {
            get { return hogarCompleto; }
            set { hogarCompleto = value; }
        }

        private string hogarDisfuncional;

        public string HogarDisfuncional
        {
            get { return hogarDisfuncional; }
            set { hogarDisfuncional = value; }
        }

        private string violenciaIntrafamiliar;

        public string ViolenciaIntrafamiliar
        {
            get { return violenciaIntrafamiliar; }
            set { violenciaIntrafamiliar = value; }
        }

        private string tipoViolencia;

        public string TipoViolencia
        {
            get { return tipoViolencia; }
            set { tipoViolencia = value; }
        }
        
        private string farmaco;

        public string Farmaco
        {
            get { return farmaco; }
            set { farmaco = value; }
        }

        private string tipoFarmaco;

        public string TipoFarmaco
        {
            get { return tipoFarmaco; }
            set { tipoFarmaco = value; }
        }

        private string enfermedad;

        public string Enfermedad
        {
            get { return enfermedad; }
            set { enfermedad = value; }
        }

        private string tipoEnfermedad;

        public string TipoEnfermedad
        {
            get { return tipoEnfermedad; }
            set { tipoEnfermedad = value; }
        }

        private string diagnosticoPresuntivo;

        public string DiagnosticoPresuntivo
        {
            get { return diagnosticoPresuntivo; }
            set { diagnosticoPresuntivo = value; }
        }

        private string diagnosticoDefinitivo;

        public string DiagnosticoDefinitivo
        {
            get { return diagnosticoDefinitivo; }
            set { diagnosticoDefinitivo = value; }
        }

        private string recomendaciones;

        public string Recomendaciones
        {
            get { return recomendaciones; }
            set { recomendaciones = value; }
        }  
    }
}
