//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("algo");
            train.StartEngines();
            Console.WriteLine("Hello World!");

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");

            // t1 y t2 NO son iguales ya que son variables que almacenan objetos diferentes,lo msimo con t2 y t3, en otras palabras
            // cada variable apunta a un espacio de memoria diferente en el Heap.

            

            for (int i = 1; i < 10000000; i++)
            {
                Train TrenTest = new Train("chuchu");
                // Al querer crearse 10.000.000 o grandes cantidades de objetos, el runtime se encarga de "destruir" aquellos que no son utilizados
                // para liberar espacio en la memoria y así poder crear y almacenar otros nuevos.
                
            }
            
            Console.WriteLine(Train.Count);
        }
    }
}