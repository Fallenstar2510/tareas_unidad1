using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, opciones;
            double total;
            string letra;
            int [] opcioness = new int[5] {1,2,3,4,5 };

            for (; ; )
            {
                Console.WriteLine("  Ingrese la opcion  deseada"  +"  1 = sumar, 2 = restar, 3 = multiplicar, 4 = dividir,5 = potencia:" +"  cualquier otra opcion cierra el programa");
                
                opciones = Int32.Parse(Console.ReadLine());
                for (int i = opciones; i == 1; )
                {
                    Console.WriteLine("ingresar el primer valor:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    y = int.Parse(Console.ReadLine());
                    total = sumar(x, y);
                    Console.WriteLine("El resultado de la suma es " + total);
                    Console.WriteLine("Deseas hacer otra suma? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 2;)
                {
                    Console.WriteLine("ingresar el primer valor:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    y = int.Parse(Console.ReadLine());
                    total = restar(x, y);
                    Console.WriteLine("El resultado de la resta es " + total);
                    Console.WriteLine("Deseas hacer otra resta? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 3;)
                {
                    Console.WriteLine("ingresar el primer valor:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    y = int.Parse(Console.ReadLine());
                    total = multiplicar(x, y);
                    Console.WriteLine("El resultado de la multiplicacion es " + total);
                    Console.WriteLine("Deseas hacer otra multiplicacion? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }

                for (int i = opciones; i == 4;)
                {
                    Console.WriteLine("ingresar el primer valor:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    y = int.Parse(Console.ReadLine());
                    total = dividir(x, y);
                    Console.WriteLine("El resultado de la division es " + total);
                    Console.WriteLine("Deseas hacer otra division? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 5;)
                {
                    Console.WriteLine("ingresar el primer valor:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    y = int.Parse(Console.ReadLine());
                    total = potencia(x, y);
                    Console.WriteLine("El resultado de la potencia es " + total);
                    Console.WriteLine("Deseas hacer otra potencia? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                if (!opcioness.Contains(opciones))
                {
                    Console.WriteLine("esperemos que vuelvas a utilizar esta calculadora pronto <3");
                    break;
                }

            }
        
        }

        static double sumar(int a, int b)
        {
            return a + b;
        }

        static double restar(int a, int b)
        {
            return a - b;
        }

        static double multiplicar(int a, int b)
        {
            return a * b;
        }

        static double dividir(int a, int b)
        {
            return a / b;
        }
        static double potencia(int a, int b)
        {

            return Math.Pow(a,b);
        }
    }
}
