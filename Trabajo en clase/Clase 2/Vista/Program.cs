using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        private static float temperaturaCelsius;
        private static float temperaturaKelvin;
        static void Main(string[] args)
        {
            temperaturaCelsius = 30;
            temperaturaKelvin = ConversorDeTemperatura.convertirCelciusAKelvin(temperaturaCelsius);

            MostrarTemperatura();

        }

        static void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura celcius {0}", temperaturaCelsius);
            Console.WriteLine("Temperatura kelvin {0}", temperaturaKelvin);
        }
    }
}
