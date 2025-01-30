using System;
public class Programa {
    public static void Main(string[] args) {
        /*Dada una cadena por teclado, y una segunda de comparación,
        mostrar por pantalla la cadena “Está” cuando encontremos la segunda cadena en cualquier posición de la primera.*/
        string fr;
        string pl;
        int desde, j, k;
        bool encontrado;
        Console.Write("Enter the main string: ");
        fr = Console.ReadLine();
        Console.Write("Enter the search string: ");
        pl = Console.ReadLine();
        desde = 0;
        do {
            j = desde;
            k = 0;
            while( k < pl.Length && j < fr.Length && fr[j]==pl[k]) {
                k++;
                j++;
            }
            desde++;
            encontrado = k == pl.Length;
        } while( desde <= fr.Length-pl.Length && !encontrado);
        if (encontrado)
            Console.WriteLine("Está");

    }
}