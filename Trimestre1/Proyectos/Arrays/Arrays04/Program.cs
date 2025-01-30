public class Programa
{
    public static void Main(string[] args)
    {
        decimal[] numeros = new decimal[100];
        int i;
        decimal suma = 0;

        Console.WriteLine("Dame un número");
        numeros[0] = Convert.ToDecimal(Console.ReadLine());
        i=0;
        while (numeros[i] != 0 && i < numeros.Length-1)
        {
            suma += numeros[i];
            i++;
            Console.WriteLine("Dame un número");
            numeros[i] = Convert.ToDecimal(Console.ReadLine());
        }
        if(numeros[i]!=0){
            suma += numeros[i];
            i++;
        }
        Console.WriteLine($"El numero de datos introducido es {i}\n y su suma es {suma}");
    }
}