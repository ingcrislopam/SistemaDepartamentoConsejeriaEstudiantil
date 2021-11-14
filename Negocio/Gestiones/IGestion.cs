using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestiones
{
    public interface IGestion
    {
        void Nuevo();
        void Agregar();
        DataTable Buscar(string datos);
        void Editar();
        void Eliminar();
    }
}
