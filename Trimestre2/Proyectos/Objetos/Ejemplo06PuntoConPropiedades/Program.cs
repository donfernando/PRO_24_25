public class Program
{
    public static void Main(string[] args)
    {
        Punto p = new Punto(14, 11);
        Console.WriteLine($"p = {p}");
        p.Mostrar('*');
        Console.WriteLine($"p = {p}");
    }
}

