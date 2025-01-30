public class Modulo {
    public static int[] generaAsignaciones(int part){
        Random r = new Random();
        int i,pos;
        int aux;
        int[] datos;
        datos = new int[part];
        for (i = 0; i < part; i++)
            datos[i] = i;
        for (i = 0; i <= part-3; i++) {
            pos = r.Next(i+1,part);
            //INTERCAMBIO
            aux= datos[i];
            datos[i] = datos[pos];
            datos[pos] = aux;
        }
        //INTERCAMBIO
        aux= datos[i];
        datos[i] = datos[i+1];
        datos[i+1] = aux;
        return datos;
    }
}