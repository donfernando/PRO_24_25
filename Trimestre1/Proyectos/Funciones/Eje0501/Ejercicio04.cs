public class Ejercicio04{
    public static void Imprimir_1_100_Iter(){
        for (int i = 1; i <= 100; i++)
            Console.Write(i + " ");
    }
    public static void Imprimir_1_100(){
        Imprimir(1);
    }
    private static void Imprimir(int n){
        Console.Write(n + " ");
        if(n<100)
            Imprimir(n+1);
        //Console.Write(n + " ");
    }
}