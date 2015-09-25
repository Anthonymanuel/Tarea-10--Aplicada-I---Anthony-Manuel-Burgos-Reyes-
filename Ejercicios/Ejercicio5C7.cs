using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio5C7 : Form
    {
        ArrayList lista = new ArrayList();
        public Ejercicio5C7()
        {
            InitializeComponent();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            string nombre, telefono;
            nombre = NombreTextBox.Text;
            telefono = TelefonoTextBox.Text;
            lista.Add(nombre);
            lista.Add(telefono);
            AgendaRichTextBox.Text = "\n"+nombre+"\n"+ telefono;
            NombreTextBox.Clear();
            TelefonoTextBox.Clear();
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            AgendaRichTextBox.Clear();
            foreach (string n in lista)
            {
                AgendaRichTextBox.Text += "\n" + n;
            }
        }
    }
}
