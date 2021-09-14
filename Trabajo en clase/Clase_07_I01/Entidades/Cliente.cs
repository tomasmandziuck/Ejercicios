﻿using System;

namespace Entidades
{
    public class Cliente
    {
        private int numero;
        private string nombre;


        public Cliente(int numero)
        {
            this.numero = numero;
            
        }
        public Cliente(string nombre, int numero) :this(numero)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }


        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
