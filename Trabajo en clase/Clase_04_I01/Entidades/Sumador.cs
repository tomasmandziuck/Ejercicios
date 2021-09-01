using System;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadDeSumas;


        
        public Sumador():this(0)
        {
            
        }

        public Sumador(int cantidadDeSumas)
        {
            this.cantidadDeSumas = cantidadDeSumas;
        }

        public long Sumar(long a,long b)
        {
            this.cantidadDeSumas++;
            return a + b;
        }

        public string Sumar(string a,string b)
        {
            cantidadDeSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadDeSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadDeSumas + s2.cantidadDeSumas;
        }

        public static bool operator |(Sumador s1,Sumador s2)
        {
            if(s1.cantidadDeSumas == s2.cantidadDeSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
