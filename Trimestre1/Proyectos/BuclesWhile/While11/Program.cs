using System;
public class Programa {
    static void Main(string[] arg) {
        int numero;
        int max,min;
        int suma=0;
        int conteo=0;
        max = int.MinValue;
        min = int.MaxValue;

        Console.Write("Introduce un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        while (numero!=0) {
            suma = suma + numero;
            conteo = conteo + 1;
            if(numero>max)
                max = numero;
            if(numero<min)
                min = numero;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
        } 
        if(conteo == 0)
            Console.WriteLine("No hay datos.");
        else {
            Console.WriteLine($"Máximo número: {max}");
            Console.WriteLine($"Mínimo número: {min}");
            Console.WriteLine($"Media: {suma/(float)conteo}");
        }

    }
}