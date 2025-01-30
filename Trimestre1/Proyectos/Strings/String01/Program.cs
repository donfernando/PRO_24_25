public class Programa {
    public static void Main(string[] args) {
        string? texto;
        // int contador = 0;
        Console.Write("Introduce una frase: ");
        texto = Console.ReadLine();
        Console.WriteLine($"Número de caracteres: {texto.Length}");
        // for (int i = 0; i < texto.Length; i++)
        //     contador++;
        // Console.WriteLine($"Número de caracteres: {contador}");
    }
}