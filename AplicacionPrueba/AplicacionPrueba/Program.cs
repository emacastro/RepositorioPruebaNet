using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Como va?");
            Console.WriteLine("Diga su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola "+nombre + " !");
            Console.WriteLine("Nueva linea");
            Console.WriteLine("Cambio linea");
            Console.WriteLine("Ultimo cambio");

            Console.ReadKey();
        }
    }
}
