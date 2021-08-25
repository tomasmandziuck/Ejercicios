using System;

namespace Validacion
{
    public static class Validador
    {
        public static bool Validar(int valor, int max, int min)
        {
            return valor <= max && valor >= min;
        }
    }
}
