
public class Programa
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Introduce un número entre 0 y 100:");
        try
        {
            num = MiConsola.LeerNumeroEntero();
            Console.WriteLine($"Número: {num}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}