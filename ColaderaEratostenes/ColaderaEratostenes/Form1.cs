using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaderaEratostenes
{
    public partial class Form1 : Form
    {
        NumerosPrimos primos = new NumerosPrimos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarPrimos_Click(object sender, EventArgs e)
        {
            int limite = int.Parse(txtHasta.Text);
            primos.obtener(limite);
            txtNumeros.Text = primos.ToString();
        }
    }
}
