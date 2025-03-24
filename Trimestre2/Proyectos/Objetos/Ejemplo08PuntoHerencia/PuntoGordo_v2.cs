using servicios.dig.cesarmanrique;
using System.Text;

namespace mio_v2;
public class PuntoGordo : Punto, IComparable<PuntoGordo>
{
    protected int _radio;
    public override int x
    {
        set
        {
            if (value >= MIN_X + _radio && value <= MAX_X - _radio)
                _x = value;
        }
    }
    public override int y
    {
        set
        {
            if (value >= MIN_Y + _radio && value <= MAX_Y - _radio)
                _y = value;
        }
    }
    public virtual int r
    {
        get
        {
            return _radio;
        }
        set
        {
            if (value >= 0 &&
                _x - value >= MIN_X && _x + value <= MAX_X &&
                _y - value >= MIN_Y && _y + value <= MAX_Y)
                _radio = value;
        }
    }
    public PuntoGordo()
    {
        //_radio = 0;
    }
    public PuntoGordo(int x, int y, int r) : base(x, y)
    {
        // if(!( r>=0 &&
        //       x-r>=MIN_X && x+r <= MAX_X &&
        //       y-r>=MIN_Y && y+r <= MAX_Y ))
        if (r < 0 ||
            x - r < MIN_X || x + r > MAX_X ||
            y - r < MIN_Y || y + r > MAX_Y)
            throw new Exception();
        _radio = r;
    }

    public override float Distancia(Punto otro)
    {
        float d = base.Distancia(otro);
        int rOtro = 0;
        if (otro is PuntoGordo)
            rOtro = ((PuntoGordo)otro)._radio;
        d = d - _radio - rOtro;
        return d < 0 ? 0 : d;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.Insert(sb.Length - 1, ",R:" + _radio);
        return sb.ToString();

        // string orig = base.ToString();
        // return orig+"-R:"+_radio;

        // return base.ToString()+"-R:"+_radio;

        // return $"({_x},{_y},R:{_radio})";

        // return $"({_x},{_y})-R:{_radio}";
    }

    public override bool Equals(object? o)
    {
        if (o == null || o.GetType() != GetType())
            return false;
        PuntoGordo pOtro = (PuntoGordo)o;
        return _x == pOtro._x && _y == pOtro._y && _radio == pOtro._radio;
    }
    public override int GetHashCode()
    {
        return (_x, _y, _radio).GetHashCode();
    }
    public int CompareTo(PuntoGordo? pOtro)
    {
        if (pOtro == null)
            return 1; // Este objeto es mayor que null

        return _radio.CompareTo(pOtro._radio);
    }
}
