using System;
public class Programa {
    public static void Main(string[] args) {
        int num,valor,resultado;

        Console.Write("¿Qué tabla desea ver? ");
        valor = Convert.ToInt32(Console.ReadLine());
        for (num = 1; num <= 10; num++) {
            resultado = valor*num;
            Console.WriteLine($"{valor} x {num,3} = {resultado,4}");
        }
    }
}