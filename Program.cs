using System;

namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            pila miPila = new pila(1);

            int opcion, valor, valorDev;
            bool verificador;

            bool a = true;
           
            while (a == true)
            {
                Console.WriteLine("     ");
                Console.WriteLine("-----------Proyecto Pilas-----------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("          1.- Cambiar Tamaño");
                Console.WriteLine("          2.- Push");
                Console.WriteLine("          3.- Pop");
                Console.WriteLine("          4.- Imprimir");
                Console.WriteLine("          5.- Salir");
                Console.WriteLine("      _____________________");
                Console.WriteLine("      Seleccionar Opción => ");

                string opc = Console.ReadLine();


                try
                {
                    opcion = Convert.ToInt32(opc);

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Insertar tamaño de la pila: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                             miPila = new pila(valor);

                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Valor a insertar en la pila: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            verificador = miPila.Push(valor);

                            if (verificador)
                            {
                                Console.WriteLine($"Se inserto el valor: {valor} correctamente");
                            }
                            else
                            {
                                Console.WriteLine($"Pila llena, no se inserto ningun valor");
                            }
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            valorDev = miPila.Pop();

                            if (valorDev == -1)
                            {
                                Console.WriteLine($"Pila vacia, no se elimino ningun valor");
                            }
                            else
                            {
                                Console.WriteLine($"Se elimino el valor {valorDev} de la pila");
                            }
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            miPila.PrintStack();
                            Console.ReadLine();
                            break;

                        case 5:
                            a = false;
                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }
                catch { Console.WriteLine("Opcion no valida");
                }
            }
        }
    }
}
