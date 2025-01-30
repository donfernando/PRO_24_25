public class Programa
{
    public static void Main(String[] arg)
    {
        ListaDeEnteros l = new ListaDeEnteros();
        System.Console.WriteLine("datos: " + l);
        l.Add(5);
        l.Add(-30);
        l.Add(51);
        l.Add(-3);
        System.Console.WriteLine("datos: " + l);
        l.Add(15);
        l.Add(23);
        l.Add(99);
        l.Add(0);
        l.Add(0);
        l.Add(-9);
        l.Add(1);
        l.Add(31);
        System.Console.WriteLine("datos: " + l);

        l.Add(1, 100);
        System.Console.WriteLine("datos: " + l);
        l.Delete(10);
        System.Console.WriteLine("datos: " + l);
    }
}