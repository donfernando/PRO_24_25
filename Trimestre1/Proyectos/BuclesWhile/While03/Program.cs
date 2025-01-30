using System;

class Program
{
    static void Main() {
        // int counter = 1;
        // while (counter <= 100)
        // {
        //     if (counter % 2 == 0)
        //     {
        //         Console.WriteLine($"Número {counter}");
        //     }
        //     counter++;
        // }

        int number = 2; // Inicializa el contador
        while (number <= 100) {
            Console.WriteLine(number); // Muestra el número actual
            number += 2; // Incrementa el contador
        }
    }
}