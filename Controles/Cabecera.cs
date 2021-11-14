using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Cabecera : Form
    {
        public Cabecera()
        {
            InitializeComponent();
        }

        public virtual void Nuevo() 
        {
        }

        public virtual void Agregar() 
        {
        }

        public virtual void Buscar() 
        {
        }

        public virtual void Editar() 
        { 
        }

        public virtual void Eliminar() 
        { 
        }

        public virtual void Salir() 
        { 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
