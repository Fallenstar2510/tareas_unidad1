using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calelndariob
{
    internal class Program
    {
        static void Main()
        {
           
            DateTime hoy = DateTime.Today;
            int year = hoy.Year;
            int month = hoy.Month;

           
            string mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            Console.WriteLine($"Calendario de {mes} {year}\n");

         
            Console.WriteLine("Do Lu Ma Mi Ju Vi Sá");

      
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

       
            for (int i = 0; i < startDayOfWeek; i++)
            {
                Console.Write("   ");
            }

  
            int daysInMonth = DateTime.DaysInMonth(year, month);

           
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2} ");

              
                if ((startDayOfWeek + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
