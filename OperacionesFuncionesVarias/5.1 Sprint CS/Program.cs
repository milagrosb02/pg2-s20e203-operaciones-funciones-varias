using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Sprint_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;

            ushort hora;

            Console.WriteLine("Ingresar fecha: ");
            fecha = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("Ingresar una hora: ");
            hora = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Resultado: " + fecha.AddDays(hora));

        }
    }
}
