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
    public partial class cedula : TextBox
    {
        public cedula()
        {
            InitializeComponent();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            char[] vector = this.Text.ToArray();
            int sumatotal = 0;
            if (vector.Length == 10)
            {
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    int numero = Convert.ToInt32(vector[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        numero = Convert.ToInt32(vector[i].ToString()) * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                if (sumatotal > 9)
                {
                    if (vector[vector.Length - 1].ToString() != "0")
                    {
                        MessageBox.Show("Cédula incorrecta");
                        this.Clear();
                    }
                    MessageBox.Show("Cédula correcta");
                }
            }
            else
            {
                this.Clear();
            }
        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
