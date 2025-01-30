public class Programa {
    public static void Main(string[] args) {
        decimal [] nums = new decimal[10];
        decimal busca;
        int i;
        for (i = 0; i < nums.Length; i++) {
            Console.Write("Dame un numero: ");
            nums[i] = Convert.ToDecimal(Console.ReadLine());
        }
        Console.Write("Dame el numero que quieres encontrar: ");
        busca = Convert.ToDecimal(Console.ReadLine());
        // BUSQUEDA LINEAL
        i=0;
        while (i < nums.Length-1 & nums[i] != busca)
            i++;
        if (nums[i] == busca)
            Console.WriteLine($"El número {busca} está en la posición {i}");
        else
            Console.WriteLine("El número no está");
    }
}