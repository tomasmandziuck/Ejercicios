using System;
using System.Collections.Generic;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> edades = new List<int>();

            edades.Add(20);
            edades.Add(21);
            edades.Add(25);
            edades.Add(28);

            edades.Insert(1,5);
            edades.RemoveAt(0);
            foreach(int item in edades)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(edades[2]);

            Console.WriteLine("----------------------");
            Dictionary<string, string> dicionario = new Dictionary<string, string>();
            dicionario.Add("taco", "mexico");
            dicionario.Add("burrito", "mexico");
            dicionario.Add("pizza", "italia");
            ///la key es unica 
            foreach(KeyValuePair<string,string> item in dicionario)
            {
                Console.WriteLine($"key: {item.Key} value: {item.Value}");
            }

            Console.WriteLine(dicionario.ContainsKey("pizza"));
            Console.WriteLine(dicionario.ContainsKey("pasta"));

            Console.WriteLine("----------------------");
            Queue<string> clientes = new Queue<string>();

            clientes.Enqueue("tomas");
            clientes.Enqueue("ana");
            clientes.Enqueue("gary");

            foreach(string item in clientes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(clientes.Dequeue());
            Console.WriteLine(clientes.Peek());//este te muestra el primero pero no lo saca

            Console.WriteLine("--");
            ///muestra la cola denuevo sin el primer elemento por el dequeue
            foreach (string item in clientes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Stack<string> paises = new Stack<string>();

            paises.Push("argentina");
            paises.Push("bolivia");
            paises.Push("peru");
            paises.Push("brazil");

            foreach (string item in paises)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");
            paises.Pop();

            foreach (string item in paises)
            {
                Console.WriteLine(item);
            }
        }
    }
}
