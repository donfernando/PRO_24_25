public class PRO
{
    public static void Main(string[] args)
    {
        string texto;
        int i;
        Console.WriteLine("Introduce un texto: ");
        texto = Console.ReadLine();
        for (i = texto.Length - 1; i >= 0; i--)
            Console.Write(texto[i]);
        Console.WriteLine();
    }
}