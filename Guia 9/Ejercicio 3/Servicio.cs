using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Servicio
    {
        public string Nombre0;
        public int NumeroLibreta0;
        public string Nombre1;
        public int NumeroLibreta1;
        public string Nombre2;
        public int NumeroLibreta2;
        public int orden;
        public void RegistrarNombreYNumeroLibreta()
        {
            Console.WriteLine("Ingrese el nombre del alumno 1"); 
            Nombre0 = Console.ReadLine();
            Console.WriteLine("Ingrese el nro de libreta del alumno 1");
            NumeroLibreta0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del alumno 2");
            Nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nro de libreta del alumno 2");
            NumeroLibreta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del alumno 3");
            Nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese el nro de libreta del alumno 3");
            NumeroLibreta2 = Convert.ToInt32(Console.ReadLine());

        }
        public void RegistrarlistaOrdenNroLibreta()
        {
        }
    }
}
