using System;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;


        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio(int nota1,int nota2)
        {
            return (nota1+nota2)/2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal;
            if (notaSegundoParcial >= 4 && notaPrimerParcial >=4)
            {
                notaFinal = random.Next(6, 11);
            }
            else
            {
                notaFinal = -1;
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El estudiante {nombre} {apellido} de legajo {legajo}");
            sb.AppendLine($"Tiene Nota de {notaPrimerParcial} en el primer parcial y {notaSegundoParcial} en el segundo");
            sb.AppendLine($"Con un promedio de {CalcularPromedio(notaPrimerParcial,notaSegundoParcial)}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota Final {CalcularNotaFinal()}");
            }
            else 
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            return sb.ToString();
        }
    }
}
