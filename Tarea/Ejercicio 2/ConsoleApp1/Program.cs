using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado, cubo;

            Console.WriteLine("Ingresar Numero");


            if (int.TryParse(Console.ReadLine(), out numero) && numero != 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);

                Console.WriteLine("Cuadrado:{0} \nCubo:{1}", cuadrado, cubo);
            }
            else
            {
                Console.WriteLine("Error numero invalido");
            }


        }
    }
}
