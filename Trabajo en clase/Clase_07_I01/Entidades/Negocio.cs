using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio (string nombre):this()
        {
            this.nombre=nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
        public static bool operator ==(Negocio n, Cliente cli)
        {
            foreach (Cliente item in n.clientes)
            {
                if (cli == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Negocio n, Cliente cli)
        {
            return !(n == cli);
        }

        public static bool operator +(Negocio n, Cliente cli)
        {
            if (n != cli)
            {
                n.clientes.Enqueue(cli);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0 )
            {
                n.caja.Atender(n.Cliente);
                return true;
            }
            return false;
        }


    }
}
