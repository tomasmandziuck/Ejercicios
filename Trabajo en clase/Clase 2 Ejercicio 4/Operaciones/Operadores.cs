using System;

namespace Operaciones
{
    public static class Operadores
    {

        private static bool Validar(double numero)
        {
            bool llave=false;
            if (numero!=0)
            {
                llave = true;
            }
            return llave;
        }
        public static double Calcular(char operador, double numero1, double numero2)
        {
            double total = 0;

            switch (operador)
            {
                case '+':
                    total = numero1 + numero2;
                    break;
                case '-':
                    total = numero1 - numero2;
                    break;
                case '*':
                    total = numero1 * numero2;
                    break;
                case '/':
                    if (Validar(numero2))
                    {
                        total = numero1 / numero2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                        break;
                    }
                   
            }

            return total;
        }


    }
}
