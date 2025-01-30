public class ConjuntoDeEnteros
{
    private int[] datos = new int[10];
    private int nDatos;

    private void CrecerSiEsNecesario()
    {
        int[] aux;
        if (nDatos == datos.Length)
        {
            aux = new int[datos.Length + 10];
            for (int i = 0; i < datos.Length; i++)
                aux[i] = datos[i];
            datos = aux;
        }
    }
    private int IndexOf(int n){
        int pos=0;
        while(pos<nDatos && datos[pos]!=n)
            pos++;
        if(pos==nDatos)
            pos=-1;
        return pos;
    }
    public bool Contains(int n) {
        return IndexOf(n)!=-1;
    }
    public bool Add(int n)
    {
        bool noEstaba = !Contains(n);
        if (noEstaba) {
            CrecerSiEsNecesario();
            datos[nDatos] = n;
            nDatos++;
        }
        return noEstaba;
    }
    public int Length() {
        return nDatos;
    }
    public bool Delete(int n)
    {
        int pos = IndexOf(n);
        if(pos!= -1){
            datos[pos] = datos[nDatos-1];
            nDatos--;
        }
        return pos!=-1;
    }

    public override string ToString()
    {
        string lista = "{";
        for (int i = 0; i < nDatos - 1; i++)
            lista += $"{datos[i]}, ";
        if (nDatos != 0)
            lista += datos[nDatos - 1];
        lista += "}";
        return lista;
    }
}