using System;

class DecimalMedia {
    static void Main(string[] args) {
        double media, suma = 0;
        double[] numeros = new double[10];
        int i;

        // Pido 10 números al usuario
        for (i = 0; i < 10; i++) {
            Console.Write($"Ingresa el número decimal {i + 1}: ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            suma += numeros[i];
        }

        // Calcula la media
        media = suma / 10;
        Console.WriteLine($"\nLa media de los números es: {media}");

        // Muestra los números que están por encima de la media
        Console.WriteLine("Números por encima de la media:");
        for (i = 0; i < 10; i++)
            if (numeros[i] > media)
                Console.WriteLine(numeros[i]);
    }
}