using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        static Servicio servicio = new Servicio();
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int opcion;
            Console.WriteLine("1- Registrar el nombre y la nota de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("3- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            servicio.RegistrarNombreYNumeroLibreta();
        }
        static void MostrarListaOrdenada()
        {
            if (servicio.NumeroLibreta0 > servicio.NumeroLibreta1 && servicio.NumeroLibreta0 > servicio.NumeroLibreta2)
            {
                if (servicio.NumeroLibreta1 > servicio.NumeroLibreta2)
                {
                    Console.WriteLine(servicio.Nombre0 + " / " + servicio.NumeroLibreta0 + "\n" + servicio.Nombre1 + " / " + servicio.NumeroLibreta1 + "\n" + servicio.Nombre2 + " / " + servicio.NumeroLibreta2);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre0 + " / " + servicio.NumeroLibreta0 + "\n" + servicio.Nombre2 + " / " + servicio.NumeroLibreta2 + "\n" + servicio.Nombre1 + " / " + servicio.NumeroLibreta1);
                }
            }
            else if (servicio.NumeroLibreta1 > servicio.NumeroLibreta0 && servicio.NumeroLibreta1 > servicio.NumeroLibreta2)
            {
                if (servicio.NumeroLibreta0 > servicio.NumeroLibreta2)
                {
                    Console.WriteLine(servicio.Nombre1 + " / " + servicio.NumeroLibreta1 + "\n" + servicio.Nombre0 + " / " + servicio.NumeroLibreta0 + "\n" + servicio.Nombre2 + " / " + servicio.NumeroLibreta2);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre1 + " / " + servicio.NumeroLibreta1 + "\n" + servicio.Nombre2 + " / " + servicio.NumeroLibreta2 + "\n" + servicio.Nombre0 + " / " + servicio.NumeroLibreta0);
                }
            }
            else if (servicio.NumeroLibreta2 > servicio.NumeroLibreta0 && servicio.NumeroLibreta2 > servicio.NumeroLibreta1)
            {
                if (servicio.NumeroLibreta0 > servicio.NumeroLibreta1)
                {
                    Console.WriteLine(servicio.Nombre2 + " / " + servicio.NumeroLibreta2 + "\n" + servicio.Nombre0 + " / " + servicio.NumeroLibreta0 + "\n" + servicio.Nombre1 + " / " + servicio.NumeroLibreta1);
                }
                else
                {
                    Console.WriteLine(servicio.Nombre2 + " / " + servicio.NumeroLibreta2 + "\n" + servicio.Nombre1 + " / " + servicio.NumeroLibreta1 + "\n" + servicio.Nombre0 + " / " + servicio.NumeroLibreta0);
                }
            }
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: servicio.RegistrarNombreYNumeroLibreta(); break;
                    case 2: MostrarListaOrdenada(); break;
                    case 3: Console.WriteLine("Saliendo"); break;
                }
            }
            while (opcion != 3);
        }
    }
}
