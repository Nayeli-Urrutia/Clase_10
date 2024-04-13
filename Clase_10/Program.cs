using Clase_10.ClsConsola.ClaseHija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //NINTENDO
            Nintendo sw= new Nintendo();
            sw.EsPortatil = true;
            sw.AnioLanzamiento= 2017;
            sw.Marca = "Nintendo Switch";

            string resultado= sw.MostrarDetallesNintendo();
            Console.WriteLine(resultado);

            //PLAYSTATION
            PlayStation ps= new PlayStation();
           
            ps.AnioLanzamiento = 2015;
            ps.Marca = "Play Station 5";

            string resultado2 = ps.MostrarDetallesPS();
            Console.WriteLine(resultado2);

            //XBOX
            Xbox XB = new Xbox();
          
            XB.AnioLanzamiento = 2020;
            XB.Marca = "Xbox One s";
           

            string resultado3 = XB.MostrarDetallesBX();
            Console.WriteLine(resultado3);


            Console.ReadKey();


        }
    }
}
