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
    public partial class Ejercicio4C7 : Form
    {
        ArrayList lista = new ArrayList();
        public Ejercicio4C7()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            double gastos;
            double.TryParse(GastosTextBox.Text, out gastos);
            lista.Add(gastos);
            GastosRichTextBox.Text = "\n" + gastos.ToString();
            GastosTextBox.Clear();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            GastosRichTextBox.Clear();
            int x = 0;
            double suma = 0;
            lista.Sort();
            lista.Reverse();
            foreach (double n in lista)
            {
                x++;
                suma += n;
                GastosRichTextBox.Text +="\n"+n.ToString();
            }
            GastosRichTextBox.Text += "\nTotal: " + suma.ToString();
        }
    }
}
