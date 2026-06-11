using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static Servicio servicio = new Servicio();
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int opcion;
            Console.WriteLine("1- Iniciar monto edad");
            Console.WriteLine("2- Solicitar edad por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("4- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            int monto;
            Console.WriteLine("Ingrese el monto a repartir");
            monto = Convert.ToInt32(Console.ReadLine());
            servicio.MontoARepartir(monto);
        }
        static void MostrarPantallaSolicitarEdadesDeLasNiñas()
        {
            servicio.RegistrarEdad();
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            servicio.CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"El monto de la niña con edad {servicio.edad0} es {servicio.monto0} y el porcentaje es {servicio.porcentaje0}%");
            Console.WriteLine($"El monto de la niña con edad {servicio.edad1} es {servicio.monto1} y el porcentaje es {servicio.porcentaje1}%");
            Console.WriteLine($"El monto de la niña con edad {servicio.edad2} es {servicio.monto2} y el porcentaje es {servicio.porcentaje2}%");
            Console.WriteLine($"El monto de la niña con edad {servicio.edad3} es {servicio.monto3} y el porcentaje es {servicio.porcentaje3}%");
        }

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarMontoARepartir(); break;
                    case 2: MostrarPantallaSolicitarEdadesDeLasNiñas(); break;
                    case 3: MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña(); break;
                    case 4: Console.WriteLine("SALIENDO"); break;
                }

            }
            while (opcion != 4);
        }
    }
}
