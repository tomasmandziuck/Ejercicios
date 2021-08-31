using System;
using Entidades;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";
            Cuenta c1 = new Cuenta("Tomas",2000);

            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(2000);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(500);
            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(0);
            Console.WriteLine(c1.Mostrar());
        }
    }
}
