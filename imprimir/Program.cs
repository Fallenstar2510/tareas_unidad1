using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            char primera;

            Console.WriteLine("ingresar su nombre");
           nombre =  Console.ReadLine();
            if (nombre.Length < 0) 
            { 
             primera = nombre.First();
            Console.WriteLine(primera);
            }
            else Console.WriteLine("nombre incorrecto");


        }
    }
}
