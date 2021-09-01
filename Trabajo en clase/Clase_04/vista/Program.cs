using System;
using Entidades;

namespace vista
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado=0;
            float resultado2=0;
            resultado=Calculo.suma(2,3,4,5);
            resultado2=Calculo.suma(2,3);

            Tiempo t1 = new Tiempo(12,12,12);
            Tiempo t2 = new Tiempo(0,1,0);
            Tiempo t3 = new Tiempo(12,12,12);

            int segundos = t2;

            Tiempo tiempo = (Tiempo)"12:45:20";
            ///Console.WriteLine("{0}\n{1}",resultado,resultado2);
            Console.WriteLine(t1==t3);
            Console.WriteLine(segundos);
            Console.WriteLine($"hora:{tiempo.horas} minutos: {tiempo.minutos} segundos:{tiempo.segundos}");
        }
    }
}
