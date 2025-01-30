using System;
public class Programa {
    public static void Main(string[] args) {
        int tabla, num, resultado;
        for (tabla = 4; tabla <= 9; tabla++){
            Console.WriteLine($"\nTabla del {tabla}");
            for (num=1; num <= 10; num++) {
                resultado = tabla * num;
                Console.Write($"{tabla} x {num,3} = {resultado,4} \n");
            }

        }

    }
}