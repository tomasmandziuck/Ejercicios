using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,aux, max=int.MinValue, min=int.MaxValue, promedio=0;
            string read;
            for (i=0; i<5; i++)
            {
                Console.WriteLine("ingrese numero");
                read= Console.ReadLine();
                int.TryParse(read,out aux);

                if (aux < min)
                {
                    min = aux;
                }

                if (aux > max)
                {
                    max = aux;
                }

                promedio += aux;
            }

            Console.WriteLine("Numero mayor:{0}\nNumero menor{1}\nPromedio{2}",max,min,promedio/5);
        }
    }
}
