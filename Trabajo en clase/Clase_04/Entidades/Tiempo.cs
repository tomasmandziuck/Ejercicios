using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tiempo
    {
        public int horas;
        public int minutos;
        public int segundos;
        string formato;


        public Tiempo() :this(0,0,0)
        { 

        }
        public Tiempo(int horas, int minutos,string formato)
            :this(horas,minutos,0)
        {
            this.formato = formato;
        }

        public Tiempo(int horas, int minutos, int segundos)
        {
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        /// <summary>
        /// sobrecarga de operadores
        /// </summary>
        public static bool operator == (Tiempo t1, Tiempo t2)
        {
            return t1.horas == t2.horas && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }

        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2 );
        }

        /// <summary>
        /// transforma todo objeto tiempo en segundos
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator int(Tiempo t)
        {
            return (((t.horas * 60)+ t.minutos)*60)+t.segundos;
        }
        /// <summary>
        /// tiempo t=(tiempo)"24:02:32"
        /// </summary>
        /// <param name="t"></param>
        public static explicit operator Tiempo(string t)
        {
            string[] tiempoStr = t.Split(':');
            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }
    }
}
