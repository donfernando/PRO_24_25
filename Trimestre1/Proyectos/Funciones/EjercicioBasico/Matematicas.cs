public class Matematicas{
    public static double Media(double[] dat){
        double media= 0.0;
        for (int i = 0; i < dat.Length; i++)
            media += dat[i];
        media /= dat.Length;
        return media;
    }
    public static void Media(double[] dat, out double media){
        media= 0.0;
        for (int i = 0; i < dat.Length; i++)
            media += dat[i];
        media /= dat.Length;
    }
}