using System;

namespace Tareas_de_Fundamentos
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int num = 0;
            do {
                num = num + 1;
                Console.WriteLine(num);
            }
            while (num < 10);
            Console.WriteLine($"El numero final es: {num}");
        }
    }
}