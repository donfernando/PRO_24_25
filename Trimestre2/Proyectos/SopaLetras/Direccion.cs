public class Direccion
{
    public int X { get; }
    public int Y { get; }

    private Direccion(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static readonly Direccion Abajo = new Direccion(0, 1);
    public static readonly Direccion Arriba = new Direccion(0, -1);
    public static readonly Direccion Derecha = new Direccion(1, 0);
    public static readonly Direccion Izquierda = new Direccion(-1, 0);
    public static readonly Direccion DiagonalAbajoDerecha = new Direccion(1, 1);
    public static readonly Direccion DiagonalArribaDerecha = new Direccion(1, -1);
    public static readonly Direccion DiagonalAbajoIzquierda = new Direccion(-1, 1);
    public static readonly Direccion DiagonalArribaIzquierda = new Direccion(-1, -1);
    public static readonly Direccion[] dir = new Direccion[]{
        Abajo,Derecha,DiagonalAbajoDerecha,DiagonalArribaDerecha,
        DiagonalAbajoIzquierda,DiagonalArribaIzquierda,Arriba,Izquierda
    };

}
