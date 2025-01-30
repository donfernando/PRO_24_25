using System;
public class Arrays7
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        char[] letras = new char[100];
        char letra;

        for (int i = 0; i < letras.Length; i++)
            letras[i] = (char)random.Next('A', 'Z' + 1);
        Console.WriteLine("String generado: ");
        Console.WriteLine(letras);


        int[] contador = new int['Z'-'A'+1];


        for (int i = 0; i < letras.Length; i++)
            contador[letras[i]-'A']++;

        Console.WriteLine("\nFrecuencia de cada letra:");
        for (int i = 0; i < contador.Length; i++)
        {
            letra = (char)('A' + i);
            Console.WriteLine($"{letra}: {contador[i]} veces.");
        }
    }
}