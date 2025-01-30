public class Ejercicio {
    public static double[] Totales(double[,] tabla) {
        double[] tablaDeSumas = new double[tabla.GetLength(1)];
        for (int c = 0; c < tabla.GetLength(1); c++)
            for (int f = 0; f < tabla.GetLength(0); f++)
                tablaDeSumas[c] += tabla[f, c];
        return tablaDeSumas;
    }
    public static void Mostrar(double[,] tabla) {
        for (int f = 0; f < tabla.GetLength(0); f++) {
            Console.Write("|");
            for (int c = 0; c < tabla.GetLength(1); c++)
                Console.Write($" {tabla[f, c]:f2} |");
            Console.WriteLine();
        }
    }
    public static double[,] CrearDatos(int fil, int col) {
        Random r = new Random();
        double[,] nueva = new double[fil,col];
        for (int f = 0; f < nueva.GetLength(0); f++)
            for (int c = 0; c < nueva.GetLength(1); c++)
                nueva[f,c] = r.NextDouble()*9 +1;
        return nueva;
    }
}

