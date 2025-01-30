class Acumulador
{
    private int val;
    public void Add(int x) {
        if(x<0)
            throw new Exception();
        val += x; 
    }
    public void Quitar(int x)
    {
        val -= x;
        if (val < 0)
            val = 0;
    }
    public int Val() { return val; }
}