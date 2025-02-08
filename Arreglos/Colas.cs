using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arreglos
{
    internal class Colas
    {
        private string[] _arreglo;
        private int _final; 
        private int _inicio;

        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _final = 0;
            _inicio = 0;
        }

        public void Agregar(string dato)
        {
            try
            {
                if (_final >= _arreglo.Length )
                {
                    throw new Exception("La pila esta llena");
                }
                _arreglo[_final] = dato;
                _final++;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (_final == _inicio)
                {
                    throw new Exception("La cola está vacía");
                }
                _arreglo[_inicio] = null;
                _inicio++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            for (int i = _inicio; i < _final; i++)
            {
                string coma = (i == _final - 1) ? "" : ",";
                datos += _arreglo[i] + coma;
            }

            return datos;
        }
    }
}
