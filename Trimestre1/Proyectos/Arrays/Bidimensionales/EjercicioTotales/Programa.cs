public class Programa {
    public static void Main(String[] args){
        double[,] datos = Ejercicio.CrearDatos(4,6);
        double[] tot;
        Ejercicio.Mostrar(datos);
        tot = Ejercicio.Totales(datos);
        foreach (double item in tot)        
        {
            Console.Write(item+" ");
        }
    }
}