using System;
using Entidades;

namespace vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador(5);


            Console.WriteLine(s1.Sumar(5,5));
            //int cantidadSumas1 = (int)s1;
            //Console.WriteLine(cantidadSumas1);
            Console.WriteLine(s2.Sumar("hola", "mundo"));
            //int cantidadSumas2 = (int)s2;
            //Console.WriteLine(cantidadSumas2);
            Console.WriteLine(s1+s2);
            Console.WriteLine(s1|s2);
        }
    }
}
