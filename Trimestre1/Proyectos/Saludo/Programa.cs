// See https://aka.ms/new-console-template for more information
public class HolaMundo {
    public static void Main(string[] arg){
        String nombre, saludo;
        Console.Write("Cómo te llamas: ");
        nombre = Console.ReadLine();
        Console.WriteLine("{1:5}Hola {0}, encantado.", nombre, " > ");

        saludo = $"Hola {nombre}, encantado.";
        Console.WriteLine(saludo);
    }
}