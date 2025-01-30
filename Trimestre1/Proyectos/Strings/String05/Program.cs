class Programa {
    public static void Main(string[] args) {
        char c;
        string cadena, encontradas = "";
        const string VOCALES = "aeiouAEIOU";
        int pos;

        Console.Write("Introduce una cadena: ");
        cadena = Console.ReadLine();
        for (int i = 0; i < cadena.Length; i++) {
            c = cadena[i];
            // BUSQUEDA LINEAL ESTANDARD
            pos = 0;
            while (pos < VOCALES.Length - 1 & VOCALES[pos] != c)
                pos++;
            if (VOCALES[pos] == c) {
                    // BUSQUEDA LINEAL CON && DE CORTE
                    pos = 0;
                    while (pos < encontradas.Length && encontradas[pos] != c)
                        pos++;
                    if (pos == encontradas.Length)
                        encontradas += c;
            }
        }
        Console.WriteLine("Vocales encontradas: " + encontradas);
    }
}