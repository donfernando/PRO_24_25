namespace mio;

public class Programa {
    public static void Main(string[] args) {
        char c;
        string cadena, encontradas = "";
        const string VOCALES = "aeiouAEIOU";

        Console.Write("Introduce una cadena: ");
        cadena = Console.ReadLine();
        for (int i = 0; i < cadena.Length; i++) {
            c = cadena[i];

            if (Funciones.BLineal(VOCALES,c)!=-1 && Funciones.BLineal(encontradas,c)==-1)
                    encontradas += c;
        }
        Console.WriteLine("Vocales encontradas: " + encontradas);
/*        string s = "Hola pedro.";
        Console.WriteLine("Frase: \"" + s + '"');
        Console.WriteLine(bLineal(s,'p'));
        Console.WriteLine(bLineal(s,' '));
        Console.WriteLine(bLineal(s,'.'));
        Console.WriteLine(bLineal(s,'H'));
        Console.WriteLine(bLineal(s,'F'));
        Console.WriteLine(bLineal(null,'p'));
        Console.WriteLine(bLineal("",'p'));
        Console.WriteLine(bLineal(s,'o'));
*/        
    }


}