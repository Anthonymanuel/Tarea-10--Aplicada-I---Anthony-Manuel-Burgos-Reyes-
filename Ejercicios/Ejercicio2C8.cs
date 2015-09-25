using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio2C8 : Form
    {
        public Ejercicio2C8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena, resultado = "";
            int numero;
            cadena = CadenaTextBox.Text ;
            int.TryParse(NumeroTextBox.Text, out numero);
            if (DerechaRadioButton.Checked == true)
                resultado = cadena.PadLeft(numero);
            if (IzquierdaRadioButton.Checked == true)
                resultado = cadena.PadRight(numero);
              ResultadoTextBox.Text = resultado;
            CadenaTextBox.Clear();
            NumeroTextBox.Clear();

        }
    }
}
