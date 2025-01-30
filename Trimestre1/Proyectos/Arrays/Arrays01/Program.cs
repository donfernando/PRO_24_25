using System;
public class Programa
{
    public static void Main(string[] args) {
        // double[] numeros = new double[10];
        double suma = 0;
        double media;
        for (int i = 0; i < 10; i++) {
            Console.Write($"Ingrese el número {i + 1}º:");
            // numeros[i] = Convert.ToDouble(Console.ReadLine());
            // suma += numeros[i];
            suma += Convert.ToDouble(Console.ReadLine());
        }
        media = suma / 10;
        Console.WriteLine($"La media aritmética es: {media}");
    }
}