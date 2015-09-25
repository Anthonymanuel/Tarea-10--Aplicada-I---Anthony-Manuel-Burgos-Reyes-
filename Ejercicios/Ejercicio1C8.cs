using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio1C8 : Form
    {
        public Ejercicio1C8()
        {
            InitializeComponent();
        }

        private void PalabraButton_Click(object sender, EventArgs e)
        {
            string cadena;
            string[] separador = { ",", ".", "!", "?", ";", ":", " " };
            cadena = CadenaRichTextBox.Text;
            string[] palabras = cadena.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            CadenaRichTextBox.Clear();
            foreach (string n in palabras)
            {
                ResultadoRichTextBox.Text +="\n"+ n;

            }

        }
    }
}
