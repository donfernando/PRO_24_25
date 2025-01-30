public class Ejercicio02{
    public static double aOtraEscala(double celsius, char escala){
        double solucion;
        if(escala=='K')
            solucion = 273.15 + celsius;
        else
         if(escala=='F')
            solucion = 1.8 * celsius + 32;
        else
            throw new ArgumentException("La escala solicitada sólo puede ser F o K");
        return solucion;
    }
}