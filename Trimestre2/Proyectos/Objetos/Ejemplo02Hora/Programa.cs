public class Programa
{
    public static void Main(String[] arg)
    {
        Hora BigBen, TorreConcepcion;
        BigBen = new Hora();
        TorreConcepcion = new Hora();

        System.Console.WriteLine(BigBen);
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            for (int i = 1; i <= 25; i++)
            {
                BigBen.IncrementaMin();
            }
            System.Console.WriteLine(BigBen);
        }
    }
}