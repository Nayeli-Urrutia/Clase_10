using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.ClsConsola.ClaseHija
{
    internal class Xbox : ClsConsola
    {
       
            public string ModeloX { get; set; }
            public string MostrarDetallesBX()
            {
                MostrarDetalles();
                return $"Modelo de Xbox: {ModeloX}";
            }
        }
}
