using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Refrase_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Aunque la cadena sea de oro, sirve para lo mismo.";

            string palabra1, palabra2, fraseFinal;

            Console.WriteLine("Ingresar una palabra que exista en la cadena: ");
            palabra1 = Console.ReadLine();

            Console.WriteLine("Ingresar una palabra para reemplazar: ");
            palabra2 = Console.ReadLine();

            Console.WriteLine(frase);

            fraseFinal = frase.Replace(palabra1, palabra2);

            Console.WriteLine(fraseFinal);
        }
    }
}
