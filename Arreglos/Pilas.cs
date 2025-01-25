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
            _arreglo[_tope] = dato; 
            _tope++;
        }

        public void Eliminar()
        {
            _tope--;
            _arreglo[_tope] = null;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            foreach (string dato in _arreglo)
            {
                datos += $"{dato},";
            }
            return datos;
        }
    }
}
