using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1 para dal alta, 2 para mostrar detalles de un cliente, 3 anadir un cliente, 4 buscar un cliente, 5 dar salida 6 modificar cliente  ,7  eliminar un cliente,  8 imprimir lista de clientes, 9 salir");
            string nombre,apellido;
            string sexo,fecha;
            int edad;
            DateTime horadealta;



            List<client> listaclientes = new List<client>();

            client diego = new client("diego","Ramos","m",20, DateTime.Now);
            client luisa = new client("luisa", "rodriguez", "m",17, DateTime.Now);
            client jose = new client("jose", "sanchez", "m", 32, DateTime.Now);
            client laura = new client("laura", "perez",  "f",25, DateTime.Now);
            listaclientes.Add(diego);
            listaclientes.Add(luisa);
            listaclientes.Add(jose);
            listaclientes.Add(laura);
            foreach (client cliente in listaclientes)
            {


                Console.WriteLine(cliente.names +"____"+ cliente.apellido);
               
            }
            //Console.WriteLine("1 para dal alta, 2 para mostrar detalles de un cliente, 3 anadir un cliente, 4 buscar un cliente, 5 eliminar cliente 6 modificar cliente, 7salir");
            //client encontrado = listaclientes.Find(p => p.names == "Diego");
           // Console.WriteLine("nombre  " + encontrado.names+"  edad  " + encontrado.edad1);

            int x, y, opciones;
            double total;
            string letra;
            int[] opcioness = new int[8] { 1, 2, 3, 4, 5,6,7,8 };

            for (; ; )
            {

                Console.WriteLine("1 para dal alta, 2 para mostrar detalles de un cliente, 3 anadir un cliente, 4 buscar un cliente, 5 dar salida 6 modificar cliente  ,7  eliminar un cliente, 8 imprimir lista, 9  salir");
                opciones = Int32.Parse(Console.ReadLine());
                for (int i = opciones; i == 1;)
                {
                    Console.WriteLine("escribir nombre de cliente");
                 nombre= Console.ReadLine();
                    client encontrado = listaclientes.Find(p => p.names == nombre);
                    int cantidad = listaclientes.Count(p => p.names == nombre);
                    Console.WriteLine(cantidad);
                    if (cantidad > 0)

                    {
                        Console.WriteLine(encontrado.names);
                        Console.WriteLine("desea dar entrada al cliente  " + encontrado.names);
                        letra = Console.ReadLine();
                        if (letra == "n")
                            break;
                        Console.WriteLine("la entrada del cliente  " + encontrado.names + " inicia  " + encontrado.Horadealta);
                    }
                    else Console.WriteLine("no se ha encontrado este nombre");
                
                   
                    Console.WriteLine("Deseas dar otra entrada? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 2;)
                {
                    Console.WriteLine("escribir nombre de cliente");
                    nombre = Console.ReadLine();
                    client encontrado = listaclientes.Find(p => p.names == nombre);
                    int cantidad = listaclientes.Count(p => p.names == nombre);
                    Console.WriteLine(cantidad);
                    if (cantidad > 0)

                    {
                        Console.WriteLine(encontrado.names);
                        Console.WriteLine("desea ver los detalles del cliente  " + encontrado.names);
                        letra = Console.ReadLine();
                        if (letra == "n")
                            break;
                        Console.WriteLine("los datos del cliente son Nombre_______" + encontrado.names + " apellido______" + encontrado.apellido + " edad______" + encontrado.edad1 + " sexo______" + encontrado.Sexo);
                    }
                    else Console.WriteLine("no se ha encontrado el cliente buscado");
                    Console.WriteLine("Deseas ver detalles de otro cliente? (s/n):");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 3;)
                {
                    Console.WriteLine("escribir nombre del nuevo cliente");
                    nombre = Console.ReadLine();
                    Console.WriteLine("escribir appelido del nuevo cliente");
                    apellido = Console.ReadLine();
                    Console.WriteLine("escribir sexo del nuevo cliente ");
                    sexo = Console.ReadLine();
                    Console.WriteLine("escribir la edad del cliente");
                    edad = Int32.Parse(Console.ReadLine());
                    horadealta = DateTime.Parse("01-01-0001 00:00");
                    listaclientes.Add(new client(nombre, apellido,sexo,edad,horadealta));


                    Console.WriteLine("desea agregar otro cliente?");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;
                    
                    Console.WriteLine("");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }

                for (int i = opciones; i == 4;)
                {
                    Console.WriteLine("escribir nombre de cliente");
                    nombre = Console.ReadLine();
                    client encontrado = listaclientes.Find(p => p.names == nombre);
                    int cantidad = listaclientes.Count(p => p.names == nombre);
                    Console.WriteLine(cantidad);
                    if (cantidad > 0)

                    {
                        int posicion = listaclientes.IndexOf(encontrado);
                        Console.WriteLine("la posicion del cliente es  " + posicion, encontrado.names + encontrado.apellido + " edad______" + encontrado.edad1 + " sexo______" + encontrado.Sexo);

                    }
                    else Console.WriteLine("cliente no encontrado");
                    Console.WriteLine("desea buscar otro cliente?");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }

                for (int i = opciones; i == 5;)
                {
                    {
                        Console.WriteLine("escribir nombre de cliente");
                        nombre = Console.ReadLine();
                        client encontrado = listaclientes.Find(p => p.names == nombre);
                        int cantidad = listaclientes.Count(p => p.names == nombre);
                        Console.WriteLine(cantidad);
                        if (cantidad > 0)

                        {
                            Console.WriteLine(encontrado.names);
                            Console.WriteLine("desea dar salida al cliente  " + encontrado.names);
                            letra = Console.ReadLine();
                            if (letra == "n")
                                break;
                            int horaentrada = encontrado.Horadealta.Hour;
                            int horasalida = DateTime.Now.Hour;
                            Console.WriteLine("la salida del cliente ha sido a las  " + encontrado.Horadealta + " acabo a las  " + horasalida, "y duro un total de ", horasalida - horaentrada);
                        } else Console.WriteLine("cliente no encontrado");
                        Console.WriteLine("Deseas dar otra entrada? (s/n):");
                        letra = Console.ReadLine();
                        if (letra == "n")
                            break;

                    }

                }
                for (int i = opciones; i == 6;)
                {
                    {
                        Console.WriteLine("escribir nombre de cliente");
                        nombre = Console.ReadLine();
                        client encontrado = listaclientes.Find(p => p.names == nombre);
                        int cantidad = listaclientes.Count(p => p.names == nombre);
                        Console.WriteLine(cantidad);
                        if (cantidad > 0)

                        {
                            Console.WriteLine(encontrado.names);
                            Console.WriteLine("desea dar salida al cliente  " + encontrado.names);
                            letra = Console.ReadLine();
                            if (letra == "n")
                                break;
                            int horaentrada = encontrado.Horadealta.Hour;
                            int horasalida = DateTime.Now.Hour;
                            Console.WriteLine("la salida del cliente ha sido a las  " + encontrado.Horadealta + " acabo a las  " + horasalida, "y duro un total de ", horasalida - horaentrada);
                        }
                        else Console.WriteLine("cliente no encontrado");
                        Console.WriteLine("Deseas dar otra entrada? (s/n):");
                        letra = Console.ReadLine();
                        if (letra == "n")
                            break;

                    }

                }

                for (int i = opciones; i == 7;)
                {
                    Console.WriteLine("escribir nombre de cliente");
                    nombre = Console.ReadLine();
                    client encontrado = listaclientes.Find(p => p.names == nombre);
                    int posicion = listaclientes.IndexOf(encontrado);
                    int cantidad = listaclientes.Count(p => p.names == nombre);
                    Console.WriteLine(cantidad);
                    if (cantidad > 0)

                    {
                        Console.WriteLine("la posicion del cliente es  " + posicion, encontrado.names, encontrado.apellido + " edad______" + encontrado.edad1 + " sexo______" + encontrado.Sexo);

                        Console.WriteLine("desea eliminar cliente? s para si n para no");
                        letra = Console.ReadLine();
                        if (letra == "n")
                            break;
                        listaclientes.Remove(encontrado);
                    }
                    else Console.WriteLine("cliente no encontrado");
                    Console.WriteLine("desea eliminar a otro cliente?");
                    letra = Console.ReadLine();
                    if (letra == "n")
                        break;

                }
                for (int i = opciones; i == 8;)
                {
                    foreach (client cliente in listaclientes)
                    {


                        Console.WriteLine( listaclientes.IndexOf(cliente).ToString() + "____" +  cliente.names + "____" + cliente.apellido);
                     
                    }
                    break;
                }
                if (!opcioness.Contains(opciones))
                {
                    Console.WriteLine("esperemos que vuelvas pronto <3");
                    break;
                }

            }

        }

       

        public void crearcliente()
        {
            

        }

        class client
        {
            public string names { get; set; }
            public string apellido { get; set; }
            public int edad1 { get; set; }
            public string Sexo { get; set; }
            public DateTime Horadealta { get; set; }
            public client(string name, string lastname, string sexo,int edad, DateTime horadealta)
               
            {
                names = name;
                apellido = lastname;
                Sexo = sexo;
                edad1 = edad;
                Horadealta = horadealta;
            
            }

            public void pedro()
            {

                 

            }



        }
    }
}
