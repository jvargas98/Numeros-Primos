using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderaEratostenes
{
    class NumerosPrimos
    {
        private bool[] numeros;
        public bool[] Numeros { get { return numeros; } }

        public void obtener(int tamaño)
        {
            numeros = new bool[tamaño];
            for (int i = 0; i < numeros.Length-1; i++)
            {
                numeros[i] = true;
            }

            for (int i = 2; i < numeros.Length-1; i++)
            {
                for (int j = 2; i*j < numeros.Length; j++)
                {
                    numeros[i * j] = false;
                }
            }
        }
        public override string ToString()
        {
            string cadena = "";

            for (int i = 2; i < numeros.Length; i++)
            {
                if (numeros[i])
                {
                    cadena += i + ", ";
                }
            }
            return cadena;
        }
    }
}
