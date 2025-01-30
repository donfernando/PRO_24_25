public class Ejercicio03{
    public static int letraEnFrase(String fr, char letra){
        int cont = 0;
        foreach (char ch in fr)
        {
            if(ch==letra)
                cont++;
        }
        return cont;
    }
}