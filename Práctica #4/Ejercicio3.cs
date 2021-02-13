using System;

namespace Tareas_de_Fundamentos
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num = 10, pares = 0;
            num *= 10;
            do {
                num = num + 2;
                pares = num;
                Console.WriteLine($"Los pares son: {pares}");
            }
            while (num < 120);
            Console.WriteLine($"Los pares son: {pares}");
            Console.WriteLine("Fin.");
        }
    }
}