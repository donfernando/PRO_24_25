public class Hora
{
    private int hora;
    private int minuto;

    public void IncrementaHora()
    {
        hora++;
        if (hora == 24)
            hora = 0;

    }
    public void IncrementaMin()
    {
        minuto++;
        if (minuto == 60)
        {
            minuto = 0;
            // Hora++;
            // if (Hora == 24)
            //     Hora = 0;
            IncrementaHora();
        }
    }
    public int GetHora(){
        return hora;
    }
    public int GetMin(){
        return minuto;
    }
    public override string ToString(){
        return $"{hora:d2}:{minuto:d2}";
    }
}