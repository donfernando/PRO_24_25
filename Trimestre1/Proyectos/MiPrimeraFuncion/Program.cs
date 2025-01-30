class Programa {
    public static void Main(string[] args) {
        char c;
        string cadena, encontradas = "";
        const string VOCALES = "aeiouAEIOU";

        Console.Write("Introduce una cadena: ");
        cadena = Console.ReadLine();
        for (int i = 0; i < cadena.Length; i++) {
            c = cadena[i];

            if (bLineal(VOCALES,c)!=-1 && bLineal(encontradas,c)==-1)
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

    public static void  bLineal(string texto, char ch){
        int pos;
        if(texto == null || texto.Length == 0 )
            pos = -1;
        else {
            pos=0;
            while(pos < texto.Length-1 & texto[pos]!=ch)
                pos++;
            if(texto[pos]!=ch)
                pos=-1;
        }
        //FINAL
        return pos;
    }

}