using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Ejercicios
{
    public partial class Ejercicio2C7 : Form
    {
        public Ejercicio2C7()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Hashtable diccionario = new Hashtable();
            string palabra;
            palabra=PalabraTextBox.Text;
            PalabraTextBox.Clear();
            DiccionarioRichTextBox.Clear();
            if(palabra == "Algoritmo") 
                 diccionario.Add(palabra, "Son los pasos necesarios para llevar cabo una acción.");
            if (palabra == "Arreglos")
                 diccionario.Add(palabra, "Son grupos de variables y estas variables serán referenciadas por el mismo nombre.");
            if (palabra == "Assembly")
                diccionario.Add(palabra, "Cuando tenemos un programa escrito en un lenguaje  de .NET y lo compilamos se genera el assembly. ");
            if(palabra == "Cadena") 
                diccionario.Add(palabra, "Es una colección de caracteres, es decir, letras, números y signos.");
            if(palabra == "Ciclo") 
                diccionario.Add(palabra, "Nos permiten repetir la ejecución de cierto código.");
            if (palabra == "CTS")
                diccionario.Add(palabra, "El CTS o sistema de tipos comunes es por medio de quien Framework de .Net define como van a funcionar los tipos en su entorno. ");
            if (palabra == "Constante")
                diccionario.Add(palabra, "es un dato cuyo valor no cambia durante la corrida de un programa.");
            if(palabra == "Funcion") 
                diccionario.Add(palabra, "Es un elemento del programa que contiene código y se puede ejecutar, es decir, lleva a cabo una operación.");
            if (palabra == "Jagged")
               diccionario.Add(palabra, "Es un arreglo de arreglos, son más flexibles que los arreglos tradicionales pero tenemos que ser más cuidadoso.");
            if (palabra == "Jittel")
                diccionario.Add(palabra, "Compilación justo a tiempo.");
            if (palabra == "Variable")
             diccionario.Add(palabra, "Son datos cuyo valor puede variar durante la corrida de un programa. ");
           
            foreach (DictionaryEntry n in diccionario)
            {
                DiccionarioRichTextBox.Clear();
                DiccionarioRichTextBox.Text+= n.Key +" "+ n.Value;
                
            }
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            DiccionarioRichTextBox.Text += "Algoritmo: Son los pasos necesarios para llevar cabo una acción.\n\nArreglos: Son grupos de variables y estas variables serán referenciadas por el mismo nombre.\n\n Assembly:Cuando tenemos un programa escrito en un lenguaje  de .NET y lo compilamos se genera el assembly.\n\nCadena: Es una colección de caracteres, es decir, letras, números y signos.\n\n Ciclo: Nos permiten repetir la ejecución de cierto código.\n\nCTS: El CTS o sistema de tipos comunes es por medio de quien Framework de .Net define como van a funcionar los tipos en su entorno.\n\nConstante: es un dato cuyo valor no cambia durante la corrida de un programa.\n\n Funcion:Es un elemento del programa que contiene código y se puede ejecutar, es decir, lleva a cabo una operación.\n\nJagged: Es un arreglo de arreglos, son más flexibles que los arreglos tradicionales pero tenemos que ser más cuidadoso.\n\n Jittel: Compilación justo a tiempo.\n\n Varible: Son datos cuyo valor puede variar durante la corrida de un programa. ";
        }

        private void PalabraTextBox_TextChanged(object sender, EventArgs e)
        {
           errorProvider1.SetError(PalabraTextBox, "La palabra comienzan con mayuscula");
        }
    }
}
