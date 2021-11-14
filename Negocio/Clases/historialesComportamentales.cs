using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class historialesComportamentales:identificacion
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

        private string respetoEstudiantes;

        public string RespetoEstudiantes
        {
            get { return respetoEstudiantes; }
            set { respetoEstudiantes = value; }
        }

        private int calificaionRespeto;

        public int CalificacionRespeto
        {
            get { return calificaionRespeto; }
            set { calificaionRespeto = value; }
        }

        private string destrezasComunicacionales;

        public string DestrezasComunicacionales
        {
            get { return destrezasComunicacionales; }
            set { destrezasComunicacionales = value; }
        }

        private int calificacionDestrezas;

        public int CalificacionDestrezas
        {
            get { return calificacionDestrezas; }
            set { calificacionDestrezas = value; }
        }

        private string desafioIntelectual;

        public string DesafioIntelectual
        {
            get { return desafioIntelectual; }
            set { desafioIntelectual = value; }
        }

        private int calificacionDesafio;

        public int CalificacionDesafio
        {
            get { return calificacionDesafio; }
            set { calificacionDesafio = value; }
        }

        private string cumplimientoCompromisos;

        public string CumplimientoCompromisos
        {
            get { return cumplimientoCompromisos; }
            set { cumplimientoCompromisos = value; }
        }

        private int calificacionCumplimiento;

        public int CalificacionCumplimiento
        {
            get { return calificacionCumplimiento; }
            set { calificacionCumplimiento = value; }
        }

        private string puntualidad;

        public string Puntualidad
        {
            get { return puntualidad; }
            set { puntualidad = value; }
        }

        private int calificacionPuntualidad;

        public int CalificacionPuntualidad
        {
            get { return calificacionPuntualidad; }
            set { calificacionPuntualidad = value; }
        }

        private string asistencia;

        public string Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }

        private int calificacionAsistencia;

        public int CalificacionAsistencia
        {
            get { return calificacionAsistencia; }
            set { calificacionAsistencia = value; }
        }

        private string limpieza;

        public string Limpieza
        {
            get { return limpieza; }
            set { limpieza = value; }
        }

        private int calificacionLimpieza;

        public int CalificacionLimpieza
        {
            get { return calificacionLimpieza; }
            set { calificacionLimpieza = value; }
        }
    }
}
