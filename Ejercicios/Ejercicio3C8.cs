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
    public partial class Ejercicio3C8 : Form
    {
        public Ejercicio3C8()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
           

            FechaRichTextBox.Text = DateTime.Now.ToString("h:m tt\nyyyy/d/M");
        }
    }
}
