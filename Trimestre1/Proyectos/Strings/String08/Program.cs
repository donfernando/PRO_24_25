using System;

class Programa
{
    static void Main(string[] arg)
    {
        const string CLAVE = "eureka";
        int intentosRestantes = 3;
        bool acertada;
        string claveIngresada;
        do {
            Console.Write("Introduce la clave: ");
            claveIngresada = Console.ReadLine();
            intentosRestantes--;
            acertada = claveIngresada == CLAVE;
            if (! acertada)
                Console.WriteLine($"Clave incorrecta. Te quedan {intentosRestantes} intentos.");

        } while (intentosRestantes > 0 && !acertada);
        if (acertada)
            Console.WriteLine("¡Clave correcta!");
        else
            Console.WriteLine("Has agotado los 3 intentos.");

    }
}