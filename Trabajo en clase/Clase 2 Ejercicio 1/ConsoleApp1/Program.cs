using System;
using Validacion;
namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int contador = 0,aux,promedio=0;
            int max = int.MinValue, min = int.MaxValue;
            do
            {
                Console.WriteLine("ingresar numero");
                if (int.TryParse(Console.ReadLine(),out aux))
                {
                    if(Validador.Validar(aux, 100, -100))
                    {
                        if (aux < min)
                        {
                            min = aux;
                        }

                        if (aux > max)
                        {
                            max = aux;
                        }

                        promedio += aux;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("numero invalido");
                    }
                }


            } while (contador<10);

            Console.WriteLine("Numero mayor:{0}\nNumero menor:{1}\nPromedio:{2}", max, min, promedio / 10);
        }
    }
}
