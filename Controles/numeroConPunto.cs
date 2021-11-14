using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class numeroConPunto : TextBox
    {
        public numeroConPunto()
        {
            InitializeComponent();
        }

        private void numeroConPunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //numeroConPunto numero = new numeroConPunto();
            //if (numero.Text.Contains('.'))
            //{
            //    if (!char.IsDigit(e.KeyChar))
            //    {
            //        e.Handled = true;
            //    }
            //}
            //else
            //{
            //    if (!char.IsDigit(e.KeyChar))
            //    {
            //        e.Handled = true;
            //    }

            //    if (e.KeyChar == '.')
            //    {
            //        e.Handled = false;
            //    }
            //}
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar!= '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
