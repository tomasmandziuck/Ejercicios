using System;

namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaDeNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.especie = especie;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre.Trim();
        }

        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToShortDateString();
        }

        public string GetEspecie()
        {
            return especie;
        }
    }
}
