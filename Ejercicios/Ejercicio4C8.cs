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
    public partial class Ejercicio4C8 : Form
    {
        public Ejercicio4C8()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            int numero, numero2,resultado;
            int.TryParse(NumeroTextBox.Text, out numero);
            int.TryParse(Numero2TextBox.Text, out numero2);

            resultado = numero + numero2;
            Numero2TextBox.Clear();
            NumeroTextBox.Clear();
            if(resultado < 0)
            ResultadoRichTextBox.Text +="\n" +"("+resultado.ToString()+")";
            if(resultado > 0)
                ResultadoRichTextBox.Text +="\n"+ resultado.ToString() ;


        }
    }
}
