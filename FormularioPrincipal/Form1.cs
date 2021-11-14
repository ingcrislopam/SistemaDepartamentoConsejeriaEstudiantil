using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FormularioEstudiante.Form1 formuEstudiante = new FormularioEstudiante.Form1();
            formuEstudiante.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAntecedentesPersonales_Click(object sender, EventArgs e)
        {
            FormularioAntecedentePersonal.Form1 formuAntecedentePersonal = new FormularioAntecedentePersonal.Form1();
            formuAntecedentePersonal.Show();
        }

        private void btnAntecedentesFamiliares_Click(object sender, EventArgs e)
        {
            FormularioAntecedenteFamiliar.Form1 formuAntecedenteFamiliar = new FormularioAntecedenteFamiliar.Form1();
            formuAntecedenteFamiliar.Show();
        }

        private void btnHistorialesComportamentales_Click(object sender, EventArgs e)
        {
            HistorialComportamental.Form1 formuHistorialComportamental = new HistorialComportamental.Form1();
            formuHistorialComportamental.Show();
        }

        private void btnHistorialesFormativos_Click(object sender, EventArgs e)
        {
            FormularioHistorialFormativo.Form1 formuHistorialFormativo = new FormularioHistorialFormativo.Form1();
            formuHistorialFormativo.Show();
        }

        private void btnRepresentantes_Click(object sender, EventArgs e)
        {
            FormularioRepresentante.Form1 formuRepresentante = new FormularioRepresentante.Form1();
            formuRepresentante.Show();
        }

        private void btnMensajeria_Click(object sender, EventArgs e)
        {
            FormularioMensajeria.Form1 formuMensajeria = new FormularioMensajeria.Form1();
            formuMensajeria.Show();
        }
    }
}
