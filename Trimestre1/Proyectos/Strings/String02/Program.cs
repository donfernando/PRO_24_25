public class Programa {
    public static void Main(string[] args) {
        string cadena;
        char lBuscada;
        int i;
        int contado = 0;
        Console.WriteLine("Dime un frase: ");
        cadena = Console.ReadLine();
        Console.WriteLine("Dime una letra a encontrar en la frase: ");
        lBuscada = (char)Console.Read();
        for (i = 0; i < cadena.Length; i++)
            if (cadena[i] == lBuscada)
                contado++;
        Console.WriteLine($"La letra {lBuscada} se ha repetido {contado} veces.");
    }
}