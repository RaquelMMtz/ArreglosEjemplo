using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppintroED2021
{
    public partial class Form1 : Form
    {
        string dato;
        int i = 0;
        //string [] arreglo = new string [10]
        Persona[] arreglo = new Persona[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arreglo[i] = new Persona();
            arreglo[i].Numero = i + 1;
            arreglo[i].Nombre = textBox1.Text;
            Random x = new Random();
            arreglo[i].Edad = x.Next(1, 99);
            textBox1.Clear();
            i++;
        }
    }
}
