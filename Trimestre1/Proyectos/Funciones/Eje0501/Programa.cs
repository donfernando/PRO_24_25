public class Programa
{
    public static void Main(string[] args)
    {
        const int OPCIONES = 6;
        int op;
        String MENSAJE = $"Elige cual de los {OPCIONES} ejercicio quieres probar ( 0 para salir ): ";
        Console.Write(MENSAJE);
        op = Convert.ToInt32(Console.ReadLine());
        while (op != 0)
        {
            switch (op)
            {
                case 1:
                    double celsius;
                    Console.Write("Grados celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fahrenheit: " + Ejercicio01.aFahrenheit(celsius));
                    Console.WriteLine("Kelvin: " + Ejercicio01.aKelvin(celsius));
                    break;
                case 2:
                    Console.WriteLine("34 ºC a Fahrenheit: " + Ejercicio02.aOtraEscala(34, 'F'));
                    break;
                case 3:
                    Console.WriteLine(Ejercicio03.letraEnFrase("Haola que tala", 'a'));
                    break;
                case 4:
                    Ejercicio04.Imprimir_1_100();
                    Console.WriteLine();
                    break;
                case 5:
                    int n = 45;
                    if (Ejercicio05.esPrimo(n))
                        Console.WriteLine(n + " esPrimo");
                    else
                        Console.WriteLine(n + " no esPrimo");
                    break;
                case 6:
                    Ejercicio06.f();
                    break;
                default:
                    Console.WriteLine("Pendiente de implementación");
                    break;
            }
            Console.Write(MENSAJE);
            op = Convert.ToInt32(Console.ReadLine());
        }
    }
}