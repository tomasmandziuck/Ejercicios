using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int numero,j,i;
            bool llave;

            do
            {
                Console.WriteLine("ingrese un numero");
                dato = Console.ReadLine();
                llave = int.TryParse(dato, out numero);

                for (i = 2; i <= numero; i++)
                {
                    for (j = 2; j < numero; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                    }

                    if (i==j)
                    {
                        Console.WriteLine("Numero Primo {0}\n",i);
                    }
                }

            } while (llave == true && dato.ToLower() != "salir");
        }
    }
}
