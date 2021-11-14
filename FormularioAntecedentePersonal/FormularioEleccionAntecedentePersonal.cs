using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAntecedentePersonal
{
    public partial class FormularioEleccionAntecedentePersonal : Form
    {
        public FormularioEleccionAntecedentePersonal()
        {
            InitializeComponent();
        }

        private void btnPorConjunto_Click(object sender, EventArgs e)
        {
            ExportarAntecedentesPersonales exportarAntecedentesPersonales = new ExportarAntecedentesPersonales();
            exportarAntecedentesPersonales.Show();
        }

        private void btnPorEstudiante_Click(object sender, EventArgs e)
        {
            ExportarAntecedentePersonalIndividual exportarAntecedentePersonalIndividual = new ExportarAntecedentePersonalIndividual();
            exportarAntecedentePersonalIndividual.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
