using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_FinDeAño_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Today;

            long anio;

            DateTime fechaFinal;

            byte mes = 12;

            //int meses, semanas, horas;

            Console.WriteLine("Ingresar año: ");

            anio = Convert.ToInt64(Console.ReadLine());

            fechaFinal = DateTime.DateSerial(anio, mes + 1, 0);

            TimeSpan horas = (fechaActual - fechaFinal);


            long difmeses = Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Month, fechaActual, fechaFinal);

            long difsemanas = Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.WeekOfYear, fechaActual, fechaFinal);

            long difhoras = Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Hour, fechaActual, fechaFinal);

            Console.WriteLine("Faltan: " + meses + " " + "meses");
            Console.WriteLine("Faltan: " + semanas + " " + "semanas");
            Console.WriteLine("Faltan: " + horas + " " + "horas");
        }
    }
}
