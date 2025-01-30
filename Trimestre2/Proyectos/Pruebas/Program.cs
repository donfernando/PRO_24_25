public class Program
{
    public static void Main(string[] args)
    {
        List<int> l;
        l = new List<int>(15);
        l.Add(23);
        l.Add(12);
        l.Add(3);
        l.Add(-5);
        l.Add(-15);
        System.Console.WriteLine(l.Count+ " elementos.");
        System.Console.WriteLine(l.Capacity+ " espacios preparados.");
        foreach (int item in l)
            System.Console.WriteLine("  > "+item);
        System.Console.WriteLine("---------------");
        l.Insert(0,555);
        foreach (int item in l)
            System.Console.WriteLine("  > "+item);
        System.Console.WriteLine("---------------");
        l[1]=88;
        l[6]=88;
        foreach (int item in l)
            System.Console.WriteLine("  > "+item);
    }
}