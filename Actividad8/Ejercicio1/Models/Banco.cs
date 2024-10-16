using System;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class Banco
    {
        List<Persona> clientes = new List<Persona>();
        List<Cuenta> cuentas = new List<Cuenta>();

        public int CantClien
        {
            get
            {
                return clientes.Count;
            }
        }
        public int CantCuent
        {
            get
            {
                return cuentas.Count;
            }
        }
        public Cuenta this[int idx]
        {
            get
            {
                Cuenta c = null;
                if (idx > 0 && idx < CantCuent)
                {
                    c = cuentas[idx];
                }
                return c;
            }
        }

        public Cuenta AgregarCuenta(int num, int dni, string nom)
        {
            Persona cliente = VerClienteDNI(dni);
            Cuenta nueva = null;
            if (cliente == null)
            {
                cliente = new Persona(dni, nom);
                clientes.Add(cliente);
                nueva = new Cuenta(num, cliente);
                cuentas.Add(nueva);
            }
            else
            {
                nueva = new Cuenta(num, cliente);
                cuentas.Add(nueva);
            }
            return nueva;

        }
        public Persona VerClienteDNI(int dni)
        {
            Persona busq = new Persona(dni, null);
            clientes.Sort();
            int idx = clientes.BinarySearch(busq);
            Persona encontrada = clientes[idx];
            return encontrada;
        }
        public Cuenta VerCuentaNro(int numero)
        {
            Cuenta busq = new Cuenta(numero, null);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(busq);
            Cuenta encontrada = cuentas[idx];
            return encontrada;
        }
        public bool RestaurarCuenta(int num, double saldo, DateTime fecha, Persona titular)
        {
            Cuenta cuenta = VerCuentaNro(num);
            if (cuenta == null)
            {
                cuenta = new Cuenta(num, titular, saldo, fecha);
                cuentas.Add(cuenta);
                return true;
            }
            else
            {
                cuentas.Add(cuenta);
                return true;
            }
        }
    }
}
