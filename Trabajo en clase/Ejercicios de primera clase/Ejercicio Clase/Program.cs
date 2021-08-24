using System;

namespace Ejercicio_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("ingrese edad");
            string edad = Console.ReadLine();

            int edadPeroNumero = int.Parse(edad);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine("Este Nombre {0}\nDe edad {1}", nombre,edadPeroNumero);
            
        }
    }
}
