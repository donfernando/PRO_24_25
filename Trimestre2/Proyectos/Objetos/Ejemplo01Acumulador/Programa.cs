public class Programa {
    public static void Main(string[] args) {
        Acumulador total = new Acumulador();
        total.Add(5);
        total.Add(3);
        total.Quitar(4);
        Console.WriteLine("Total: "+total.Val());
    }
}