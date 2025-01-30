using System;

class Programa {
    static void Main(string[] arg) {
        const string CLAVE = "eureka";
        int intentosRestantes = 3;
        string claveIngresada;

        Console.Write("Introduce la clave: ");
        claveIngresada = Console.ReadLine();
        while (intentosRestantes > 0 && claveIngresada != CLAVE) {
            intentosRestantes--;
            Console.WriteLine($"Clave incorrecta. Te quedan {intentosRestantes} intentos.");
            Console.Write("Introduce la clave: ");
            claveIngresada = Console.ReadLine();
        }
        if (claveIngresada == CLAVE)
            Console.WriteLine("¡Clave correcta!");
        else
            Console.WriteLine("Has agotado los 3 intentos.");
    }
}