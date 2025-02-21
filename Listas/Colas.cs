namespace Listas
{
    internal class Colas
    {
        private List<string> lista;

        public Colas(int elementos)
        {
            lista = new List<string>();
        }
        public void Agregar(string dato)
        {
            lista.Add(dato);
        }
        private bool EstaVacia()
        {
            return lista.Count == 0;
        }
        public void Eliminar()
        {
            if (EstaVacia())
            {
                throw new Exception("La pila esta vacia");
            }
            lista.RemoveAt(0);
        }
        public string Imprimir()
        {
            string datos = string.Empty;

            for (int i = 0; i < lista.Count; i++)
            {
                string coma = (i == lista.Count - 1)
                    ? ""
                    : ",";

                datos += lista[i] + coma;
            }
            return datos;
        }
    }
}

