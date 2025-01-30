public class Ejercicio06
{
    public static int disparar(char[,] tablero, String coordDisparo)
    {
        int codSolucion;
        int f,c;
        const char AGUA = '·';
        const char DISPARADO = '*';
        const int COD_AGUA = 1;
        const int COD_TOCADO = 2;
        const int COD_REPETIDO = 3;

        extraerCoordenada(coordDisparo, out f, out c);
        if(tablero[f,c]==AGUA){
            tablero[f,c] = DISPARADO;
            codSolucion = COD_AGUA;
        }
        else if(tablero[f,c]==DISPARADO)
            codSolucion = COD_REPETIDO;
        else {
            codSolucion = COD_TOCADO;
            tablero[f,c] = DISPARADO;
        }
        return codSolucion;
    }
    public static void extraerCoordenada(String coordenada, out int fila, out int col)
    {
        char fCh;
        string cStr;
        fCh = Char.ToUpper(coordenada[0]);
        fila = fCh - 'A';
        cStr = coordenada.Substring(1);
        col = Convert.ToInt32(cStr) - 1;
    }
}