class Programa
{
    public static void Main(string[] args)
    {
        string cadena;
        char c;
        const string VOCALES = "aeiouAEIOU";
        bool[] vocalesEncontradas = new bool[VOCALES.Length];
        string encontradas = "";
        int i, pos;

        Console.Write("Introduce una cadena: ");
        cadena = Console.ReadLine();
        for (i = 0; i < cadena.Length; i++)
        {
            c = cadena[i];
            pos = 0;
            while(pos < VOCALES.Length-1 && c != VOCALES[pos])
                pos++;
            if (VOCALES[pos]==c && vocalesEncontradas[pos]==false) {
                    vocalesEncontradas[pos] = true;
                    encontradas += VOCALES[pos];
                }
        }
        Console.Write($"Vocales: {encontradas}");
    }
}