using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static Servicio servicio;
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables");
            Console.WriteLine("7- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarIniciarVariables()
        {
            servicio = new Servicio();
            Console.WriteLine("Variables reiniciadas.");
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(num);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            int num;
            Console.WriteLine("Ingrese VARIOS numeros, -1 para salir");
            num = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(num);
            while (num != -1)
            {
                Console.WriteLine("Ingrese VARIOS numeros, -1 para salir");
                num = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarValor(num);
            }
        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.WriteLine($"El numero maximo es {servicio.maximo} y el numero minimo es {servicio.minimo}");
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            double promedio = servicio.CalcularPromedio();
            Console.WriteLine($"El promedio de los numeros ingresados es {promedio}");
        }
        static void MostrarCantidadDeNumeros()
        {
            Console.WriteLine($"La cantidad de numeros ingresados es {servicio.contador}");
        }
        static void Main(string[] args)
        {
            servicio = new Servicio();
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarNumero(); break;
                    case 2: MostrarPantallaSolicitarVariosNumeros(); break;
                    case 3: MostrarPantallaMaximoYMinimo(); break;
                    case 4: MostrarPantallaCalcularYMostrarPromedio(); break;
                    case 5: MostrarCantidadDeNumeros(); break;
                    case 6: MostrarIniciarVariables(); break;
                    case 7: Console.WriteLine("Saliendo..."); break;
                }
            }
            while (opcion != 7);
        }

    }
}
