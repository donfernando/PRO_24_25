
using System.Net.Mail;

public class Programa
{
    public static void Main(string[] args)
    {
        double[] alturas = {1.4,2.09,1.67};
        double media;

        Mostrar(alturas);
        Console.WriteLine($"Media: {Matematicas.Media(alturas)}");

        Matematicas.Media(alturas, out media);
        Console.WriteLine($"Media: {media}");
    }

    private static void Mostrar(double[] alturas)
    {
        foreach(double alt in alturas)
            Console.Write($"[{alt,4:0.00}] ");
        Console.WriteLine();
    }
}
