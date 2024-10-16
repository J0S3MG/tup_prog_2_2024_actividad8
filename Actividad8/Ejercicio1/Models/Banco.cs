using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class Banco
    {
        List<Persona> clientes = new List<Persona>();
        public List<Cuenta> cuentas = new List<Cuenta>();

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
                if(idx > 0 && idx < CantCuent)
                {
                    c = cuentas[idx];
                }
                return c;
            }
        }


    }
}
