using System;
using System.Collections;
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
    public partial class Ejercicio5C8 : Form
    {
        ArrayList lista = new ArrayList();
        public Ejercicio5C8()
        {
            InitializeComponent();
        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            string cadena1, cadena2;
            
            cadena1 = Cadena1TextBox.Text;
            cadena2 = Cadena2TextBox.Text;
            lista.Add(cadena1);
            lista.Add(cadena2);
            lista.Sort();
            foreach (string n in lista)
            {
                MostrarRichTextBox.Text += "  " + n;

            }
            Cadena1TextBox.Clear();
            Cadena2TextBox.Clear();





        }
    }
}
