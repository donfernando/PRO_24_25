using System;

public class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Introduce un número entero para calcular sus divisores:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Los divisores de " + numero + " son:");

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}