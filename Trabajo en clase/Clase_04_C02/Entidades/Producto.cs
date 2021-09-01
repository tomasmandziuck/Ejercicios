using System;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"El producto de marca {p.marca}");
            sb.Append($" posee un costo de {p.precio}");
            sb.Append($" con del codigo de barras{p.codigoDeBarra}");
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    return true;
                }
            }


            return false;

        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
