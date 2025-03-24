using servicios.dig.cesarmanrique;
//using mio;
using mio_v2;
public class Program
{
    public static void Main(string[] args)
    {
        Punto p = new Punto(14, 11);
        Punto q = new Punto(14, 21);
        Console.WriteLine($"dist({p},{q})={p.Distancia(q):f2}");
        Console.WriteLine(p.Equals(q));

        PuntoGordo p1 = new PuntoGordo(14, 10, 2);
        PuntoGordo q1 = new PuntoGordo(15, 20, 1);
        Console.WriteLine($"p1 = {p1}");
        Console.WriteLine($"q1 = {q1}");
        Console.WriteLine($"dist({p1},{q1})={p1.Distancia(q1):f2}");
        Console.WriteLine(p1.Equals(q1));

List<PuntoGordo> puntosGordos = new List<PuntoGordo>();
puntosGordos.Add(p1);
puntosGordos.Add(q1);
foreach(PuntoGordo x in puntosGordos)
    Console.WriteLine(x);
puntosGordos.Sort();
foreach(PuntoGordo x in puntosGordos)
    Console.WriteLine(x);


    }
}

