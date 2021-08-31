using System;
using Veterinaria;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[3];
            Mascota felix = new Mascota("Felix", new DateTime(1920, 01, 09),"Gato");
            Mascota salem = new Mascota("Salem", new DateTime(1990, 09, 21), "Gato");
            Mascota buddy = new Mascota("Buddy", new DateTime(1994, 12, 21), "Gato");

            mascotas[0] = felix;
            mascotas[1] = salem;
            mascotas[2] = buddy;

            mascotas[2].SetNombre("Badie");

            foreach(Mascota mascota in mascotas)
            {
                if (mascota != null)
                {
                    Console.WriteLine($"{mascota.GetNombre()} nacio el {mascota.GetFechaDeNacimiento()} y es un {mascota.GetEspecie()}");
                }
            }
           /// Console.WriteLine($"{felix.GetNombre()} nacio el {felix.GetFechaDeNacimiento()} y es un {felix.GetEspecie()}");
            
        }
    }
}
