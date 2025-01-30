using System;
public class bucles_6
{
    static void Main(string[] arg)
    {
        int numero;
        int suma = 0;
        do {
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma += numero;
        } while (suma < 50);

        // int numero;
        // int suma=0;
        // while (suma < 50)
        // {
        //     Console.WriteLine("Introduce un número: ");
        //     numero = Convert.ToInt32(Console.ReadLine());
        //     suma += numero;
        // }


    }
}