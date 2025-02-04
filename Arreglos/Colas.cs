using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arreglos
{
    internal class Colas
    {
        private string[] _arreglo;
        private int _tope;

        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato2)
        {
            try
            {
                if (_tope >= _arreglo.Length)
                {
                    throw new Exception("La pila esta llena");
                }
                _arreglo[_tope] = dato2;
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
                if (_tope == 0)
                {
                    throw new Exception("La cola está vacía");
                }
                for (int i = 0; i < _tope - 1; i++)
                {
                    _arreglo[i] = _arreglo[i + 1];
                }
                _tope--;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Imprimir()
        {
            string datos2 = string.Empty;

            for (int i = 0; i < _tope; i++)
            {
                string coma = (i == _tope - 1) ? "" : ",";
                datos2 += _arreglo[i] + coma;
            }

            return datos2;
        }
    }
}
