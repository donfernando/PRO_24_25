
namespace mio;
public class Punto
{
    public const int MAX_X = 80;
    public const int MIN_X = 1;
    public const int MAX_Y = 25;
    public const int MIN_Y = 1;

    private int _x;
    private int _y;
    public int x
    {
        get
        {
            return _x;
        }
        set
        {
            if (value >= MIN_X && value <= MAX_X)
                _x = value;
        }
    }
    public int y
    {
        get
        {
            return _y;
        }
        set
        {
            if (value >= MIN_Y && value <= MAX_Y)
                _y = value;
        }
    }

    public Punto()
    {
        _x = _y = 1;
    }
    public Punto(int x, int y) : this()
    {
        this.x = x;
        this.y = y;
    }
    public Punto(int xy) : this(xy, xy)
    {
    }

    public float Distancia(Punto otro)
    {
        int dX, dY;
        dX = _x - otro._x;
        dY = _y - otro._y;
        return (float)Math.Sqrt(dX * dX + dY * dY);
    }

    public void Mostrar(char ch)
    {
        ValueTuple<int, int> pos;
        pos = Console.GetCursorPosition();
        Console.SetCursorPosition(_x, _y);
        Console.WriteLine(ch);
        Console.SetCursorPosition(pos.Item1, pos.Item2);
    }


    public override string ToString()
    {
        return $"({_x},{_y})";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Punto))
            return false;
        Punto other = obj as Punto;
        return x == other.x && y == other.y;
    }
    public override int GetHashCode()
    {
        return (x,y).GetHashCode();
    }
}
