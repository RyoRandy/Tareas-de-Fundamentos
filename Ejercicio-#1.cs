using System;

namespace Tareas_de_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0;
            do {
                Console.WriteLine("Introduzca una cantidad de números positivos, ingrese el número 0 cuando quiera el resultado.");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El numero es: {num}");
                suma = suma + num;
            }
            while(num != 0 && num > 0);
            Console.WriteLine($"La suma de los números da un total de: {suma}");
        }
    }
}
