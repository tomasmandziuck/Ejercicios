﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            caja1,caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        } 

        public bool Atender(Cliente cli)
        {
            if (cli.Numero >= 0)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
