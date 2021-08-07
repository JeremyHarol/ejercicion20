using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicion20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantidad.Text);

            int cdocientos = cantidad / 200;
            cantidad %= 200;
            int ccien = cantidad / 100;
            cantidad %= 100;
            int ccincuenta = cantidad / 50;
            cantidad %= 50;
            int cveinte = cantidad / 20;
            cantidad %= 20;
            int cdiez = cantidad / 10;
            cantidad %= 10;
            int ccinco = cantidad / 5;
            cantidad %= 5;
            int cdos = cantidad / 2;
            int cuno = cantidad / 1;

            txtDocientos.Text = "" + cdocientos;
            txtCien.Text = "" + ccien;
            txtCincuenta = "" + ccincuenta;
            txtVeinte = "" + cveinte;
            txtDiez.Text = "" + cdiez;
            txtDos.Text = "" + cdos;
            txtUno.Text = "" + cuno;
            
            


        }
    }
}
