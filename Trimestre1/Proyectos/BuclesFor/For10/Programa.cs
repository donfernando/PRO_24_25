internal class Programa
{
    private static void Main(string[] args)
    {
        int num1, num2, aux;
        int suma;
        int incremento;
        Console.Write("Ingresa numero 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa numero 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if(num1>num2) 
            incremento=-1;
        else
            incremento=1;

        suma=num2;
        for (int i = num1; i != num2; i += incremento)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de todos los numeros enteros entre {num1} y {num2} es: {suma}");
    }
}
