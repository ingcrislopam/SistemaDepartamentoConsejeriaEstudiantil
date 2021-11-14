using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAntecedenteFamiliar
{
    public partial class FomularioEleccionAntecedenteFamiliar : Form
    {
        public FomularioEleccionAntecedenteFamiliar()
        {
            InitializeComponent();
        }

        private void btnPorEstudiante_Click(object sender, EventArgs e)
        {
            ExportarAntecedenteFamiliarIndividual exportarAntecedenteFamiliarIndividual = new ExportarAntecedenteFamiliarIndividual();
            exportarAntecedenteFamiliarIndividual.Show();
        }

        private void btnPorConjunto_Click(object sender, EventArgs e)
        {
            ExportarAntecedentesFamiliares exportarAntecedentesFamiliares = new ExportarAntecedentesFamiliares();
            exportarAntecedentesFamiliares.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
