using System;
public class Programa {
    public static void Main(string[] args) {
        char caracter;
        int contador;
        contador = 0;        
        Console.WriteLine("Introduce un texto... ");
        caracter = Console.ReadKey().KeyChar;
        while(caracter != '.'){
            if(caracter == '\b'){
                contador--;
                Console.Write(" \b");
            }
            else {
                contador++;
                if(caracter=='\r')
                    Console.Write('\n');
            }
            caracter = Console.ReadKey().KeyChar;
        }
        Console.WriteLine($"Has leído {contador} caracteres"); 
    }
}
