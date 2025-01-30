public class Ejercicio1
{
    public static String Reproducir(char[] a, char[] b)
    {
        String result = "";
        Random r = new Random();
        for (int i = 0; i < a.Length; i++)
            if (r.Next(2) == 0)
                result += a[i];
            else
                result += b[i];

        return result;
/*
        String result = "";
        if ((a != null & b != null) && a.Length == b.Length)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
                if (r.Next(2) == 0)
                    result += a[i];
                else
                    result += b[i];
        }
        return result;
*/
    }
}

public class Ejercicio2
{
    public static String Ganador(double[] tiempos, String[] nombres, double[] penalizaciones, out double[] total)
    {
        int posMin = 0;
        total = new double[tiempos.Length];
        for (int i = 0; i < tiempos.Length; i++)
        {
            total[i] = tiempos[i] + penalizaciones[i];
            if (total[i] < total[posMin])
                posMin = i;
        }
        return nombres[posMin];
    }
}


public class Programa
{
    public static void Main(String[] args)
    {
        Console.WriteLine(Ejercicio1.Reproducir("acabb".ToCharArray(), "bcbca".ToCharArray()));
        //Console.WriteLine(Ejercicio1.Reproducir(null, "bcbca".ToCharArray()));

        double[] tiempos = { 1.50, 1.48, 2.06, 1.50, 1.69, 2.06, 1.88, 1.92 };
        double[] penalizaciones = { 0.10, 0.20, 0.00, 0.00, 0.00, 0.04, 0.00, 0.60 };
        String[] nombres = { "Aitor", "Felisa", "Jonay", "Ester", "Ángela", "Tomás", "Óscar", "Taida" };
        double[] totales;
        Console.WriteLine($"\nGANADOR/A: {Ejercicio2.Ganador(tiempos, nombres, penalizaciones, out totales)}\n");
        Console.WriteLine("TOTALES");
        for (int i = 0; i < totales.Length; i++)
            Console.WriteLine($"{totales[i],5:0.00}");
    }
}
