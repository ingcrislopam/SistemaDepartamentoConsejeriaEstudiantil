using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistorialComportamental
{
    public partial class FormularioEleccionHistorialComportamental : Form
    {
        public FormularioEleccionHistorialComportamental()
        {
            InitializeComponent();
        }

        private void btnPorEstudiante_Click(object sender, EventArgs e)
        {
            ExportarHistorialComportamentalIndividual exportarHistorialComportamentalIndividual = new ExportarHistorialComportamentalIndividual();
            exportarHistorialComportamentalIndividual.Show();
        }

        private void btnPorConjunto_Click(object sender, EventArgs e)
        {
            ExportarHistorialesComportamentales exportarHistorialesComportamentales = new ExportarHistorialesComportamentales();
            exportarHistorialesComportamentales.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
