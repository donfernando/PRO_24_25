public class Program
{
    public static void Main(string[] args)
    {
        int n = 21;
        //Console.WriteLine($"Factorial({n})={FactorialRecurs(n)}");
        Console.WriteLine($"Factorial({n})={Factorial(n)}");
    }

    public static long FactorialRecurs(long n)
    {
        // Caso base: si n es 0 o 1, el factorial es 1
        if (n == 0)
            return 1;
        else
            return n * FactorialRecurs(n - 1);
    }
    public static long Factorial(int n) {    
        if (n < 0)
            throw new ArgumentException("El número debe ser no negativo.", nameof(n));
        long aux;
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            aux = resultado;
            resultado = resultado * i;
            if (resultado / i != aux)
                throw new OverflowException($"El calculo del factorial no puede ser calculado salvo hasta el {i-1}");
        }
        return resultado;
    }

}
