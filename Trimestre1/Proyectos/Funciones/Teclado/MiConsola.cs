
public class MiConsola
{
    public static int LeerNumeroEntero()
    {
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        if (num < 0 || num > 100)
            throw new Exception("El número debe estar entre 0 y 100.");
        return num;
    }
}