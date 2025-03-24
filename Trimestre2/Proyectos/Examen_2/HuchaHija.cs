public class HuchaHija : Hucha {
    private static Random r = new Random();
    public HuchaHija():base(0){ }

    // public static Hucha Sorteo(Hucha[] huchas){
    //     Random r = new Random();
    //     Hucha[] l = new Hucha[huchas.Length];
    //     int cont=0;
    //     foreach (Hucha item in huchas)
    //         if(item.Saldo!=0)
    //             l[cont++]=item;
    //     return l[r.Next(cont)];
    // }
    public static Hucha Sorteo(Hucha[] huchas){
        List<Movimiento> l = new List<Movimiento>();
        foreach (Hucha item in huchas)
            if(item.Saldo!=0)
                l.Add(item);
        return l[r.Next(l.Count())];
    }
}