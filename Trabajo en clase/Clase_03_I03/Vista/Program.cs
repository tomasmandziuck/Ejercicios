using System;
using Entidades;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[3];
            Estudiante e1 = new Estudiante("Mand","7789887","Tom");
            Estudiante e2 = new Estudiante("Campos", "7789989", "Guido");
            Estudiante e3 = new Estudiante("Proche", "7789666", "Agus");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(9);

            e2.SetNotaPrimerParcial(2);
            e2.SetNotaSegundoParcial(4);

            e3.SetNotaPrimerParcial(10);
            e3.SetNotaSegundoParcial(8);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

        }
    }
}
