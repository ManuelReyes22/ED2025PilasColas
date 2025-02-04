namespace Arreglos
{
    internal class Pilas
    {
        private string[] _arreglo;
        private int _tope;

        public Pilas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato)
        {
            try
            {
                if (_tope >= _arreglo.Length)
                {
                    throw new Exception("La pila esta llena");
                }

                _arreglo[_tope] = dato;
                _tope++;
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
                if (_tope <= 0)
                {
                    throw new Exception("ya no se pueden quitar mas elementos");
                }

                _tope--;
                _arreglo[_tope] = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            for (int i = 0; i < _tope; i++)
            {
                string coma = (i == _tope - 1)
                    ? ""
                    : ",";

                datos += _arreglo[i] + coma;
            }
            return datos;
        }
    }
}
