public class Programa
{
    public static void Main(string[] arg)
    {
        int numero;
        int i;
        int cuantos;
        cuantos = 0;
        numero = Convert.ToInt32(Console.ReadLine());
        // i = 1;
        // while (i <= numero)
        // {
        //     if (i % 3 == 0)
        //     {
        //         Console.WriteLine(i);
        //         ++cuantos;
        //     }
        //     i++;
        // }

        i=3;
        while (i <= numero) {
            Console.WriteLine(i);
            cuantos++;
            i = i+3;
        }

        Console.WriteLine($"Fueron {cuantos} múltiplos de 3");

    }
}