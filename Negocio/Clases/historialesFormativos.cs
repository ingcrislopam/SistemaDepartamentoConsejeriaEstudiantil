using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class historialesFormativos:identificacion
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

        private double trabajoIndependiente;

        public double TrabajoIndependiente
        {
            get { return trabajoIndependiente; }
            set { trabajoIndependiente = value; }
        }

        private double actividadesIndividuales;

        public double ActividadesIndividuales
        {
            get { return actividadesIndividuales; }
            set { actividadesIndividuales = value; }
        }

        private double actividadesGrupales;

        public double ActividadesGrupales
        {
            get { return actividadesGrupales; }
            set { actividadesGrupales = value; }
        }

        private double lecciones;

        public double Lecciones
        {
            get { return lecciones; }
            set { lecciones = value; }
        }

        private double evaluacionSumativa;

        public double EvaluacionSumativa
        {
            get { return evaluacionSumativa; }
            set { evaluacionSumativa = value; }
        }

        public double Sumatoria(double valor1, double valor2, double valor3, double valor4) 
        {
            double EvaluacionSumativa = 0;
            EvaluacionSumativa = (valor1 + valor2 + valor3 + valor4)/4;
            return EvaluacionSumativa;
        }
    }
}
