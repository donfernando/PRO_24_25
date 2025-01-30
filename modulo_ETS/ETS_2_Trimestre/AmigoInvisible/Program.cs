
public class Programa
{
    public static void Main(String[] args)
    {
        int[] t;


        //t = Modulo.generaAsignaciones(5);


        //String[] n = { "Ana", "Blas", "Carlos", "Aday", "Ernesto" };
        //t = Modulo.generaAsignaciones(n.Length);
        //for (int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i] + " le regala a " + n[t[i]]);
        //}



        for (int vueltas = 0; vueltas < 1000; vueltas++)
        {
            t = Modulo.generaAsignaciones(5);
            for (int j = 0; j < 5; j++)
            {
                if (t[j] == j)
                    System.Console.WriteLine("Error en la prueba " + vueltas);
            }
        }


    }
}
