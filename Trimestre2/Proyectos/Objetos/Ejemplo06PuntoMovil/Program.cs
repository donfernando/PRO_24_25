public class Program {
    static void Main(string[] args) {
        ConsoleKey c;
        Punto p = new Punto();
        Console.Clear();
        while((c = Console.ReadKey().Key) != ConsoleKey.Escape) {
            switch (c) {
                case ConsoleKey.UpArrow:
                    p.Subir();
                    break;
                case ConsoleKey.DownArrow:
                    p.Bajar();
                    break;
                case ConsoleKey.LeftArrow:
                    p.Izquierda();
                    break;
                case ConsoleKey.RightArrow:
                    p.Derecha();
                    break;
            }
            p.Mostrar('o');
        }
        Console.Clear();
    }
}