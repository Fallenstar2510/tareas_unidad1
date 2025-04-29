using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimir_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int numero =30; numero>0; numero--)
            {

                if (numero % 2 == 0)
                {

                    Console.WriteLine("el numero  " + numero + "  es par");
                }

            }


        }
    }
}
