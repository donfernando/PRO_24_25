
public class Programa
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Introduce un número entre 0 y 100: ");
        try{
            num = MiConsola.LeerNumeroEntero();
            Console.Write($"Número: {num}");
            Console.WriteLine((num%2!=0?" no ":" ")+"es par.");
        } catch(FormatException e) {
            Console.WriteLine("Formato de número incorrecto.\n"+e.Message);
        } catch(Exception) {
            Console.WriteLine("Número fuera de rango (0,100)");
        }
    }
}