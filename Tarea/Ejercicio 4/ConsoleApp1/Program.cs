using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elNumero=0, i, j,contador=0, suma=0;

            do 
            {
                elNumero++;
                suma = 0;
                for (i = 1; i < elNumero; i++)
                {
                    if (elNumero%i==0)
                    {
                        suma += i;
                    }
                    
                }
                if (suma == elNumero)
                {
                    Console.WriteLine("Numero perfecto{0}\n", elNumero);
                    contador++;
                }

            } while(contador<4);
           
        }
    }
}
