using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.ClsConsola
{
    internal class ClsConsola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public string Juego { get; set; }
        public int Variedad { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca:{Marca}, AnioLanzamineto:{AnioLanzamiento}");
        }

      
    }
}
