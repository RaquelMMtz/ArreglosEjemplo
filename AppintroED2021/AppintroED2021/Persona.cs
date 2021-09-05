using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppintroED2021
{
    class Persona
    {
        int numero;
        string nombre;
        int edad;

        public int  Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public override string ToString()
        {
            return numero + "" + nombre;
        }
    }
}
