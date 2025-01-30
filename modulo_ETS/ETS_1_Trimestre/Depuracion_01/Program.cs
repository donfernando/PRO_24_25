public class Program
{
    static void Main(string[] args)
    {
        int[] datos = { 15, 8, 12, 3, 9, 8, 6 };
        int[] filtrados = Ejercicio04.FiltrarDatos(datos, 8);
        foreach (int n in filtrados)
            Console.Write($"{n,6:0.00}");
        Console.WriteLine();
    }
}
