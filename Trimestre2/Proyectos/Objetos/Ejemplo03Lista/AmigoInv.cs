public class AmigoInv {
    public static ListaDeEnteros generaAsignaciones(int part){
        Random r = new Random();
        int i,pos;
        int aux;
        ListaDeEnteros datos = new ListaDeEnteros();
        for (i = 0; i < part; i++)
            datos.Add(i);
        for (i = 0; i <= part-3; i++) {
            pos = r.Next(i+1,part);
            //INTERCAMBIO
            aux= datos.Get(i);
            datos.Set(i,datos.Get(pos));
            datos.Set(pos,aux);
        }
        //INTERCAMBIO
        aux= datos.Get(i);
        datos.Set(i,datos.Get(i+1));
        datos.Set(i+1,aux);
        return datos;
    }
}