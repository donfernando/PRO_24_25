public class Ejercicio05{
    public static bool esPrimo(int numero)
    {
        int i = 2;
        while(i<numero && numero % i != 0)
            i++;
        return i==numero;
    }
}