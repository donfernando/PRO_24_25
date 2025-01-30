class Fecha
{
    static void Main(string[] args)
    {
        int dd, mm, aa;
        int dds, mms, aas;
        int dias = 0;

        try
        {
            Console.Write("Introduzca Día: ");
            dd = leerDia();
            Console.Write("Introduzca Mes: ");
            mm = leerMes();
            Console.Write("Introduzca Año: ");
            aa = leerAño();
            comprueba(dd, mm, aa);
            Console.WriteLine();
            Console.Write("Fecha hoy:  ");
            Console.Write("{0}/{1}/{2}", dd, mm, aa);

            dds = dd + 1;
            mms = mm;
            aas = aa;
            switch (mm)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    dias = 31;
                    break;
                case 2:
                    if (bisiesto(aa))
                        dias = 29;
                    else
                        dias = 28;
                    break;
                default:
                    dias = 30;
                    break;
            }
            if (dds > dias)
            {
                dds = 1;
                mms++;
                if (mms == 13)
                {
                    mms = 1;
                    aas++;
                    if (aas == 0)
                        aas = 1;
                }
            }
            Console.WriteLine();
            Console.Write("Fecha mañana:  ");
            Console.Write("{0}/{1}/{2}", dds, mms, aas);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    static bool bisiesto(int aa)
    {
        return (aa % 4 == 0) && (aa % 100 != 0) || (aa % 400 == 0);
    }
    static int leerDia()
    {
        int d;
        d = Convert.ToInt32(Console.ReadLine());
        if (d < 1 | d > 31)
            throw new FormatException("El día tiene que ser un valor entre 1 y 31");
        return d;
    }
    static int leerMes()
    {
        int m;
        m = Convert.ToInt32(Console.ReadLine());
        if (m < 1 | m > 12)
            throw new FormatException("El mes tiene que ser un valor entre 1 y 12");
        return m;
    }
    static int leerAño()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
            throw new FormatException("El año no puede ser 0");
        return a;
    }

    static void comprueba(int dd, int mm, int aa)
    {
        int ddmax;
        if (mm == 2)
        {
            if (bisiesto(aa))
            {
                ddmax = 29;
            }
            else
            {
                ddmax = 28;
            }
        }
        else if ((mm == 4) || (mm == 6) || (mm == 9) || (mm == 11))
            ddmax = 30;
        else
            ddmax = 31;
        if (dd > ddmax)
            throw new Exception($"La fecha {dd}/{mm}/{aa} es incorrecta");
    }
}

