using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;


        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"La cuenta esta a nombre de {GetTitular()}");
            sb.Append($" con un balance actual de ${GetCantidad()}");
            return sb.ToString();   
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
                
            }
            else
            {
                Console.WriteLine("no se puede ingresar ese monto");
            }
        }

        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
            
        }
    }
}
