class Coche {
    public string Marca;
    public string Modelo;
    public string Color;
    public int CuentaKilometros;
    public int Velocidad;
    public int NumeroDePuertas;
    public bool Arrancado;

    public void Arrancar() {
        Arrancado = true;
    }

    public void Parar() {
        Arrancado = false;
    }

    public void Acelerar()
    {
        if(Arrancado)
            Velocidad += 1;
    }

    public void Frenar()
    {
        if (Velocidad!=0)
            Velocidad -= 1;
    }

    public int GetCuentaKilometros()
    {
        return CuentaKilometros;
    }

    public override string ToString()
    {
        // return string.Format("Coche {0}({1})\n\t{2} puertas\n\tcolor {3}\n\tcon {4} Km.", Marca, Modelo, NumeroDePuertas, Color, CuentaKilometros);
        return $"Coche {Marca}({Modelo})\n\t{NumeroDePuertas} puertas\n\tcolor {Color}\n\tcon {CuentaKilometros} Km.";
    }
}
