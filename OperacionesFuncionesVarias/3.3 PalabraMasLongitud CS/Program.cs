using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_PalabraMasLongitud_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2, palabra3;

            ushort longitud1, longitud2, longitud3;

            Console.WriteLine("Ingresar una palabra: ");
            palabra1 = Console.ReadLine();

            Console.WriteLine("Ingresar una palabra: ");
            palabra2 = Console.ReadLine();

            Console.WriteLine("Ingresar una palabra: ");
            palabra3 = Console.ReadLine();

            longitud1 = Convert.ToUInt16(palabra1.Length);

            longitud2 = Convert.ToUInt16(palabra2.Length);

            longitud3 = Convert.ToUInt16(palabra3.Length);



            Console.WriteLine("La palabra de mayor longitud es: " + Math.Max(longitud1,Math.Max(longitud2,longitud3)));
        }
    }
}
