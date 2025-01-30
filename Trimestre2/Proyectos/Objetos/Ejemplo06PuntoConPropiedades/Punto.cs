class Punto
{
    public const int MAX_X = 80;
    public const int MIN_X = 1;
    private int _x = 1;
    public const int MAX_Y = 25;
    public const int MIN_Y = 1;
    private int _y = 1;

    public int x {
        get {
            return _x;
        }
        set {
            if(value>=MIN_X && value <= MAX_X)
                _x = value;
        }
    }
    public int y {
        get {
            return _y;
        }
        set {
            if(value>=MIN_Y && value <= MAX_Y)
                _y = value;
        }
    }

    public float distancia(Punto otro){
        int dX,dY;
        dX = _x - otro._x;
        dY = _y - otro._y;
        return (float)Math.Sqrt(dX*dX+dY*dY);
    }

    public override string ToString(){
        return "("+_x+","+_y+")";
    }
}