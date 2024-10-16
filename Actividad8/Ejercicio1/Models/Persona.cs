using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            Persona cliente = obj as Persona;
            if (cliente != null) 
                return DNI.CompareTo(cliente.DNI);
            return 1;
        }
    }
}
