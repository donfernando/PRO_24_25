internal class Programa {
    public static void Main(string[] args) {
        string frase;
        string palabra;
        int contador = 0;
        string nuevafrase = "";
        int ini, i;


        Console.WriteLine("Escriba la frase");
        frase = Console.ReadLine();
        Console.WriteLine("Escriba la palabra");
        palabra = Console.ReadLine();

        bool encontrada = false;
        for (ini = 0; ini <= frase.Length-palabra.Length; ini++) {

            i=0;
            while(i<palabra.Length-1 && ini+i < frase.Length-1 &&  palabra[i]==frase[ini+i])
                i++;
            if (palabra[i]==frase[ini+i] && i==palabra.Length-1)
            {
                contador++;
                ini += palabra.Length - 1;
            }
            else
            {
                nuevafrase += frase[ini];
            }
        }
        for (i=0 ;i<palabra.Length-1 ; i++,ini++) 
                nuevafrase += frase[ini];


        Console.WriteLine("la nueva frase es:" + nuevafrase);
        Console.WriteLine($"Se ha elimidado: {contador} veces");
    }
}