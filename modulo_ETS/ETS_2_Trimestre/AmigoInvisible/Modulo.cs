public class Modulo {
    public static int[] generaAsignaciones(int tam)
    {
        Random r = new Random();
        int i, pos;
        int aux;
        int[] datos;
        datos = new int[tam];
        for (i = 0; i < tam; i++)
            datos[i] = i;
        for (i = 0; i < tam - 2; i++)
        {
            pos = r.Next(i + 1, tam);
            //INTERCAMBIO
            aux = datos[i];
            datos[i] = datos[pos];
            datos[pos] = aux;
        }
        //INTERCAMBIO
        aux = datos[tam-2];
        datos[tam-2] = datos[tam-1];
        datos[tam-1] = aux;
        return datos;
    }
}
