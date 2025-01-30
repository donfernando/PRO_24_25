using System;

public class Program {
    static void Main() {
        int numero;

        Console.WriteLine("Introduce un número menor que 100:");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0) {
            numero++;
        }
        while (numero <= 100) {
            Console.WriteLine(numero);
            numero += 2;
        }
    }
}