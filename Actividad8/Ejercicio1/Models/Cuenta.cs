using System;

namespace Ejercicio1.Models
{
    public class Cuenta: IComparable
    {
        public Persona Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; }

        public Cuenta(int num,Persona cliente)
        {
            Numero = num;
            Fecha = DateTime.Today;
            Saldo = 0;
            Titular = cliente;
        }
        public Cuenta(int num, Persona cliente,double saldo,DateTime fecha)
        {
            Numero = num;
            Fecha = fecha;
            Saldo = saldo;
            Titular = cliente;
        }
        public int CompareTo(Object obj)
        {
            Cuenta cuenta = obj as Cuenta;
            if(cuenta != null) 
                return Numero.CompareTo(cuenta.Numero);
            return 1;
        }
    }
}
