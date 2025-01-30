
class Programa
{
    static void Main(string[] args)
    {
        Coche miCoche;
        string estado;

        miCoche = new Coche();
        miCoche.Marca = "Citröen";
        miCoche.Modelo = "Picasso";
        miCoche.Color = "marrón";
        miCoche.CuentaKilometros = 50000;
        miCoche.Velocidad = 0;
        miCoche.NumeroDePuertas = 5;
        miCoche.Arrancado = false;

        //miCoche.Arrancar();

        estado = miCoche.Arrancado ? "en marcha" : "apagado";

        Console.WriteLine("\n******************************");
        Console.WriteLine(" Vehiculo: " + miCoche);
        Console.WriteLine($" Mi coche {miCoche.Color} está {estado}");
        Console.WriteLine("******************************");
    }
}