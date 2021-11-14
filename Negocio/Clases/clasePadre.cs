using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class clasePadre:identificacion
    {
        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private int curso;

        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        private string paralelo;

        public string Paralelo
        {
            get { return paralelo; }
            set { paralelo = value; }
        }

        private string especialidad;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string seccion;

        public string Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }
    }
}
