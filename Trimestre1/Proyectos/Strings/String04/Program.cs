public class Programa {
    public static void Main(string[] args) {
        //Dada una cadena por teclado, introducir en una nueva variable la cadena al revés, y mostrarla.
        string texto;
        string textoinverso = "";
        int i;
        Console.WriteLine("Introduce un texto: ");
        texto = Console.ReadLine();
        for (i = 0; i > texto.Length; i++)
            textoinverso = texto[i] + textoinverso;
        // for (i = texto.Length - 1; i >= 0; i--)
        //     textoinverso += texto[i];
        Console.WriteLine(texto);
        Console.WriteLine(textoinverso);
    }
}