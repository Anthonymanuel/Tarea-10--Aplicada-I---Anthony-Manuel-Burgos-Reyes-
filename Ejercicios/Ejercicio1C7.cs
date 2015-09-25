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
    public partial class Ejercicio1C7 : Form
    {
        ArrayList lista = new ArrayList();
        public Ejercicio1C7()
        {
            InitializeComponent();
        }

        
        private void AgregarButton_Click(object sender, EventArgs e)
        {

            float calificacion;
            float.TryParse(CalificacionTextBox.Text, out calificacion);
            lista.Add(calificacion);
            MostrarRichTextBox.Text += "  "+calificacion.ToString();
            CalificacionTextBox.Clear();

        }
        private void CaluclarButton_Click(object sender, EventArgs e)
        {
            float min = 999, max = 0, prom = 0, x = 0;
            foreach (float  n in lista)
            {
                prom += n;
                x++;
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                    
            }
            PromedioTextBox.Text = (prom/x).ToString();
            MaximoTextBox.Text = max.ToString();
            MinimoTextBox.Text = min.ToString();

        }

        
    }

    internal class intew
    {
    }
}
