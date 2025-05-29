using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroprimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            float numero2;
            bool primo1, primo2, primo3;
            numero = Int32.Parse(Console.ReadLine());

            if (numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0 || numero % 7 == 0 || numero % 11 == 0 || numero == 1)
            {
                if (numero != 5 && numero != 7 && numero != 2 && numero != 3 || numero ==1) 
                { 
                
                Console.WriteLine("no es primo");
                }
                else Console.WriteLine(" es primo");

            }
            else Console.WriteLine(" es primo");



        }
    }
}
