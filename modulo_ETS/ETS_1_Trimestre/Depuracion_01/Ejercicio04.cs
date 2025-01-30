public class Ejercicio04
{
    public static int[] FiltrarDatos(int[] array, int top)
    {
        int tam = 0;
        int[] nums;
        int i;
        foreach (double num in array)
            if (num > top)
                tam++;
        nums = new int[tam];
        i = 0;
        foreach (int num in array)
            if (num > top)
            {
                nums[i] = num;
                i++;
            }
        return nums; // Devolvemos el array filtrado
    }
}
