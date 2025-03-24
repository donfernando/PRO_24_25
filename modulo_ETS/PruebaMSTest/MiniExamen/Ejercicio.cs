// Implementa una función:  public static bool estaOrdenada(int[] array) 
// … que devolverá true, si el array está ordenado de forma descendente.
namespace MiniExamen;
public class Ejercicio
{
    public static bool EstaOrdenado(int[]? array)
    {
        int i = 0;
        bool esDescendente = true;
        if (array.Length > 1)
        {
            while (i < array.Length - 2 & array[i] >= array[i + 1])
                i++;
            esDescendente = array[i] >= array[i + 1];
        }
        return esDescendente;
    }

    public static bool EstaOrdenado2(int[] array)
    {
        int i = 0;
        bool esDescendente;
        while (i < array.Length - 1 && array[i] >= array[i + 1])
            i++;
        esDescendente = (i == array.Length - 1);
        return esDescendente;
    }
}
