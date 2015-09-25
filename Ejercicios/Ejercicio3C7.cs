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
    public partial class Ejercicio3C7 : Form
    {
        ArrayList lista = new ArrayList();
        public Ejercicio3C7()
        {
            InitializeComponent();
        }
        int x = 0;

        void Imprimir (ArrayList list)
        {
            int y = 0;
            SalidaRichTextBox.Clear();
            foreach (string n in list)
            {
                y++;
                SalidaRichTextBox.Text += "\n" + y.ToString() + ". " + n;
            }
        }
        private void AbregarButton_Click(object sender, EventArgs e)
        {
            
            lista.Add(ClienteTextBox.Text);
            x++;
            EntradaRichTextBox.Text += "\n"+x.ToString()+". "+ClienteTextBox.Text;
            ClienteTextBox.Clear();
            
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Imprimir(lista);
        }
    }
}
