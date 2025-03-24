public class Programa {
    public static void Main()
    {
        SopaLetras sopa = new SopaLetras(20, 20);

sopa.AñadirPalabra("Ilustracion");
sopa.AñadirPalabra("Razon");
sopa.AñadirPalabra("Progreso");
sopa.AñadirPalabra("Ciencia");
sopa.AñadirPalabra("Absolutismo");
sopa.AñadirPalabra("Despotismo");
sopa.AñadirPalabra("Voltaire");
sopa.AñadirPalabra("Montesquieu");
sopa.AñadirPalabra("Rousseau");
sopa.AñadirPalabra("Monarquia");
sopa.AñadirPalabra("Reforma");
sopa.AñadirPalabra("Comercio");
sopa.AñadirPalabra("Manufactura");
sopa.AñadirPalabra("Rococo");
sopa.AñadirPalabra("Neoclasico");
sopa.AñadirPalabra("Parlamento");
sopa.AñadirPalabra("Libertad");
sopa.AñadirPalabra("Educacion");
sopa.AñadirPalabra("Poder");
sopa.AñadirPalabra("Historia");
sopa.AñadirPalabra("Nación");
sopa.AñadirPalabra("Leyes");
sopa.AñadirPalabra("Sociedad");

        sopa.Completar();

        Console.WriteLine("Sopa de letras inicial:");
        Console.WriteLine(sopa);

        Console.WriteLine("\nDescubriendo 'llave':");
        sopa.Descubrir(3, 0, 3, 4);
        Console.WriteLine(sopa);

        Console.WriteLine("\nResolviendo toda la sopa:");
        sopa.Resolver();
        Console.WriteLine(sopa);
    }
}
