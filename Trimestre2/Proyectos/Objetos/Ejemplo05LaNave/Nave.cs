public class Nave
{
    private const int LIMITEVIDAMAX = 1000;
    private const int TAMAÑOMAX = 10;
    private const int DISPAROMAX = 10;
    private const int ESCUDOMAX = 10;
    private int _tamaño = 1;
    public int Tamaño
    {
        get
        {
            return _tamaño;
        }
        set
        {
            if (value >= 1 && value <= 10)
                _tamaño = value;
        }
    }

    //private int Vida = 100;
    public int Vida {get; private set;} = 100;
    private int LimiteVida = 100;
    private int Disparo = 1;
    public int Escudo = 0;

    private bool Destruida()
    {
        return Vida == 0;
    }

    public void AumentarVida10()
    {
        if (!Destruida())
        {
            Vida += 10;
            if (Vida > LimiteVida)
                Vida = LimiteVida;
        }
    }
    public void AumentarVida100()
    {
        if (!Destruida())
        {
            Vida += 100;
            if (Vida > LimiteVida)
                Vida = LimiteVida;
        }
    }

    public void MejorarEscudo()
    {
        if (!Destruida() && Escudo < ESCUDOMAX)
            Escudo++;
    }

    public void MejorarNave()
    {
        if (!Destruida() && Tamaño < TAMAÑOMAX)
        {
            Tamaño++;
            LimiteVida = Tamaño * 100;
        }
    }
    public void MejorarDisparo()
    {
        if (!Destruida() && Disparo < DISPAROMAX)
            Disparo++;
    }

    public void Atacar(int unitAtaque)
    {
        int escQuitados;
        //if (!(unitAtaque == 10 || unitAtaque == 100 || unitAtaque == 1000))
        if (Destruida())
            throw new Exception();
        if (unitAtaque != 10 && unitAtaque != 100 && unitAtaque != 1000)
            throw new ArgumentException();
        if (Escudo != 0) {
            escQuitados = unitAtaque / 10;
            if (escQuitados >= Escudo)
            {
                unitAtaque -= Escudo * 10;
                Escudo = 0;
            }
            else
            {
                Escudo -= escQuitados;
                unitAtaque = 0;
            }
        }
        Vida -= unitAtaque;
        if (Vida < 0)
            Vida = 0;
    }
}