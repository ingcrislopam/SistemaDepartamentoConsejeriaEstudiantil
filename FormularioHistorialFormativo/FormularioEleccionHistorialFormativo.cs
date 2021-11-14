using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHistorialFormativo
{
    public partial class FormularioEleccionHistorialFormativo : Form
    {
        public FormularioEleccionHistorialFormativo()
        {
            InitializeComponent();
        }

        private void btnPorEstudiante_Click(object sender, EventArgs e)
        {
            ExportarHistorialFormativoIndividual exportarHistorialFormativoIndividual = new ExportarHistorialFormativoIndividual();
            exportarHistorialFormativoIndividual.Show();
        }

        private void btnPorConjunto_Click(object sender, EventArgs e)
        {
            ExportarHistorialesFormativos exportarHistorialesFormativos = new ExportarHistorialesFormativos();
            exportarHistorialesFormativos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
