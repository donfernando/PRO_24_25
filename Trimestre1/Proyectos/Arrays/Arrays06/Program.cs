using System;
public class Arrays6
{
    public static void Main(string[] args)
    {
        string[] nombres = new string[10];
        double[] notas = new double[nombres.Length];
        double media, suma = 0;
        int i;
        Console.WriteLine("Ingrese el nombre y la nota de 10 alumnos:");
        for (i = 0; i < 10; i++) {
            Console.Write($"Nombre del alumno {i + 1}: ");
            nombres[i] = Console.ReadLine();
            Console.Write($"Nota de {nombres[i]}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            suma += notas[i];
        }

        media = suma / notas.Length;
        Console.WriteLine($"\nLa media de las notas es: {media}");

        Console.WriteLine("\nAlumnos con nota inferior a la media:");
        for (i = 0; i < notas.Length; i++)
            if (notas[i] < media)
                Console.WriteLine($"{nombres[i]} - Nota: {notas[i]}");
    }
}