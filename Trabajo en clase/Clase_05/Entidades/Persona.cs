using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private decimal edad;

        public Persona(string nombre, decimal edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string mostrar()
        {
            
           
            return $"Nombre: {this.nombre} Edad: {this.edad}";
        }
    }
}
