using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = 0,  num1 = 0,resultado;
            Console.WriteLine("digital su primer numero");
            num= Int32.Parse( Console.ReadLine());
            Console.WriteLine("digital su segundo numero");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("digital su primer numero");
            num = Int32.Parse(Console.ReadLine());
            resultado = num * num1;
            Console.WriteLine("el resultado de la multiplicacion es"+resultado);
        }
    }
}
