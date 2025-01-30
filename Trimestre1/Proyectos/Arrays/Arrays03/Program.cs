using System;
public class Arrays3 {
    public static void Main(string[] args) {
        decimal[] datos = new decimal[10];
        decimal numero;
        int numLeidos, i;

        Console.Write($"Escribe el primer número: ");
        datos[0] = Convert.ToDecimal(Console.ReadLine());
        for (numLeidos = 1; numLeidos < datos.Length; numLeidos++) {
            do {
                Console.Write($"Escribe un número en la posición {numLeidos}: ");
                numero = Convert.ToDecimal(Console.ReadLine());
                i = 0;
                while(i<numLeidos-1 && numero != datos[i])
                    i++;
            } while(numero == datos[i]);
            datos[numLeidos] = numero;
        }
        Console.WriteLine("\nNúmeros introducidos: ");
        for (i = 0; i < datos.Length; i++) {
            Console.WriteLine(datos[i]);
        }
    }
}