using System;
public class Programa {
    public static void Main(string[] args) {
        char caracter;
        int contador;
        contador = 0;        
        Console.WriteLine("Introduce un texto... ");
        caracter = (char)Console.Read();
        while(caracter != '.'){
                contador++;
            caracter = (char)Console.Read();
        }
        Console.WriteLine($"Has leído {contador} caracteres"); 
    }
}
