public class ProgramaPruebaHucha {
    public static void Main(string[] args) {
        Console.Write("\n*************************************  ");
        Console.WriteLine("Creando una hucha con 50 euros...");
        Hucha miHucha = new Hucha(50);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Añadiendo 20 euros...");
        miHucha.Añadir(20);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando añadir una cantidad inválida (-10 euros)...");
        miHucha.Añadir(-10);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Sacando 30 euros...");
        miHucha.Sacar(30);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando sacar más dinero del que hay en la hucha (100 euros)...");
        miHucha.Sacar(100);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Vaciando la hucha...");
        miHucha.Vaciar();
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Intentando sacar dinero de una hucha vacía (10 euros)...");
        miHucha.Sacar(10);
        Console.WriteLine(miHucha);

        Console.Write("\n*************************************  ");
        Console.WriteLine("Terminamos metiendo dinero (2130 euros)...");
        miHucha.Añadir(2130);
        Console.WriteLine(miHucha);
    }
}