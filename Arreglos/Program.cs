namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pila = new Pilas(10);
            pila.Agregar("a");
            pila.Agregar("b");
            pila.Agregar("c");
            pila.Agregar("d");
            pila.Agregar("e");
            //pila.Agregar("f");
            //pila.Agregar("g");
            //pila.Agregar("h");
            //pila.Agregar("i");
            //pila.Agregar("j");
            //pila.Agregar("k");
            //pila.Agregar("l");

          
            

            string datos = pila.Imprimir();
            Console.WriteLine(datos);

            pila.Eliminar();
            Console.WriteLine(pila.Imprimir());
        }
    }
}
