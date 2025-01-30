public class Programa
{
    public static void Main(String[] arg)
    {
        ConjuntoDeEnteros s = new ConjuntoDeEnteros();
        System.Console.WriteLine(s);
        s.Add(22);
        s.Add(-2);
        s.Add(5);
        s.Add(22);
        s.Add(-21);
        s.Add(15);
        s.Add(20);
        s.Add(-100);
        s.Add(5);
        System.Console.WriteLine(s);
        s.Delete(-21);
        System.Console.WriteLine(s);
    }
}
