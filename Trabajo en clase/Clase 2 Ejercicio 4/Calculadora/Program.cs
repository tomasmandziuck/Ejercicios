using System;
using Operaciones;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1=0, num2=0, resultado=0;
            char op = '+';
            Console.WriteLine("ingresar Primer Operando");
            while(!double.TryParse(Console.ReadLine(),out num1))
            {
                Console.WriteLine("numero no valido");
            }
            Console.WriteLine("ingresar Segundo Operando");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("numero no valido");
            }
            Console.WriteLine("ingresar Operador:+,-,*,/");
            op = char.Parse(Console.ReadLine());

            resultado = Operaciones.Operadores.Calcular(op, num1, num2);

            Console.WriteLine("Resultado{0}",resultado);
        }
    }
}
