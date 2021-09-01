using System;

namespace Entidades
{
    public class Calculo
    {

        public static float suma(float num1, float num2, float num3, float num4)
        {
            return num1 + num2 + num3 + num4;
        }

        public static float suma(float num1, float num2)
        {
            return suma(num1,num2,0,0);
        }

        public static float suma(string num1, int num2)
        {
            return suma(float.Parse(num1), num2);
        }
    }
}
