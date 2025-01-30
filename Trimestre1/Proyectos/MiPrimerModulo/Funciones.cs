namespace mio;
public class Funciones{
     public static int BLineal(string texto, char ch){
        int pos;
        if(texto == null || texto.Length == 0 )
            pos = -1;
        else {
            pos=0;
            while(pos < texto.Length-1 & texto[pos]!=ch)
                pos++;
            if(texto[pos]!=ch)
                pos=-1;
        }
        return pos;
    }
}