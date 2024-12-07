using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
           double DATOS = 0;
           int NDATO = 0;
           int CATIDADATOS = 1;
           double PROMEDIO = 0, ACUMULADOR = 0;

           Console.WriteLine("INGRESE NUMERO DE DATOS:");
           NDATO = Convert.ToInt32(Console.ReadLine());

          
           while (CATIDADATOS != NDATO + 1)
           {
               
                   Console.WriteLine("INGRESE DATOS:" + CATIDADATOS);
                   DATOS = Convert.ToDouble(Console.ReadLine());
                   ACUMULADOR = ACUMULADOR + DATOS;
                   CATIDADATOS++;
                   PROMEDIO = ACUMULADOR / NDATO;
                   Console.Clear();
                   
               
           }
           
           Console.WriteLine("TOTAL:" + ACUMULADOR);
           Console.WriteLine("DATOS :" + NDATO);
           Console.WriteLine("PROMEDIO:" + PROMEDIO);
           Console.WriteLine("GRACIAS POR USAR NUESTRO SISTEMA");
           Console.WriteLine("ADIOS");
           Console.ReadKey();
               
        }
       
    }
}
                
                