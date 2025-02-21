using System.Collections.Generic;
namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilas");

            Pilas pila = new Pilas(10);
            pila.Agregar("a");
            pila.Agregar("b");
            pila.Agregar("c");
            pila.Agregar("d");
            pila.Agregar("e");
            pila.Agregar("f");
            pila.Agregar("g");
            pila.Agregar("h");
            pila.Agregar("i");
            pila.Agregar("j");
            pila.Agregar("k");
            pila.Agregar("l");

            string datos = pila.Imprimir();
            Console.WriteLine(datos);

            pila.Eliminar();
            Console.WriteLine(pila.Imprimir());

            pila.Agregar("m");
            Console.WriteLine(pila.Imprimir());

            pila.Agregar("n");
            Console.WriteLine(pila.Imprimir());

            pila.Agregar("o");
            Console.WriteLine(pila.Imprimir());

            /*------------------------------------------------------------*/
            Console.WriteLine("\nColas");

            Colas cola = new Colas(1);
            cola.Agregar("a");
            cola.Agregar("b");
            cola.Agregar("c");
            cola.Agregar("d");
            cola.Agregar("e");
            cola.Agregar("f");
            cola.Agregar("g");
            cola.Agregar("h");
            cola.Agregar("i");
            cola.Agregar("j");
            cola.Agregar("k");
            cola.Agregar("l");

            string datos2 = cola.Imprimir();
            Console.WriteLine(datos);

            cola.Eliminar();
            Console.WriteLine(cola.Imprimir());

            cola.Agregar("m");
            Console.WriteLine(cola.Imprimir());

            cola.Eliminar();
            Console.WriteLine(cola.Imprimir());

            cola.Agregar("n");
            Console.WriteLine(cola.Imprimir());

            cola.Eliminar();
            Console.WriteLine(cola.Imprimir());

            cola.Agregar("o");
            Console.WriteLine(cola.Imprimir());
        }
    }
}

