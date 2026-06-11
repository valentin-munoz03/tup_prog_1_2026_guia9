using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Servicio
    {
        private int acumulador;
        public int contador;
        public int maximo;
        public int minimo; 
        public Servicio()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 9999;
        }
        public double CalcularPromedio()
        {
            int promedio;
            promedio = acumulador / contador; 
            return promedio;
        }
        public void RegistrarValor(int valor)
        {
           acumulador += valor;
            contador++; 
            if (valor>maximo)
            {
                maximo = valor;
            }
            if (valor<minimo)
            {
                minimo= valor;
            }
        }
    }
}
