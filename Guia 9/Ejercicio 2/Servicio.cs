using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Servicio
    {
        public int edad0; 
        public int edad1;
        public int edad2;
        public int edad3;
        public double Monto;
        public double porcentaje0;
        public double porcentaje1;
        public double porcentaje2;
        public double porcentaje3;
        public double monto0;
        public double monto1;
        public double monto2;
        public double monto3;
        public void MontoARepartir(double monto)
        {
            Monto = monto;
        }
        public void RegistrarEdad()
        {
            Console.WriteLine("Ingrese la edad de la primer niña");
            edad0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la segunda niña");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la tercer niña");
            edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la cuarta niña");
            edad3 = Convert.ToInt32(Console.ReadLine());
        }
        public void CalcularMontosYPorcentajesARepartir()
        {
            int SumaEdades;
            SumaEdades = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (edad0 * 100) / SumaEdades;
            porcentaje1 = (edad1 * 100) / SumaEdades;
            porcentaje2 = (edad2 * 100) / SumaEdades;
            porcentaje3 = (edad3 * 100) / SumaEdades;
            monto0 = (Monto * porcentaje0) / 100;
            monto1 = (Monto * porcentaje1) / 100;
            monto2 = (Monto * porcentaje2) / 100;
            monto3 = (Monto * porcentaje3) / 100;
        }
    }
}
