using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaenvivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num3 = 0;
            Console.WriteLine("ingresar numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar numero 2");
            num2 = int.Parse(Console.ReadLine());
            // Este bucle se ejecutará 10 veces (desde i = 0 hasta i < 10)
            for (int i = 1; i <= num2; i++)
            {
                 
                num3 = num1 + num3;
                 
                if (i == num2)
                {
Console.WriteLine("su resultado es "+num3);
                }
                
            }

            Console.ReadKey();
         


    }
}
    

}
