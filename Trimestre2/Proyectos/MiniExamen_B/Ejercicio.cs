using System;
using System.ComponentModel;
class Ejercicio
{
    public static bool ComprobarPassword(string pass)
    { 
        bool esValida = false;
        int i=0;
        if (pass.Length >= 4 && pass.Length <= 6)
        {            
            while (i<pass.Length-1 & !char.IsDigit(pass[i]))
                i++;
            esValida=char.IsDigit(pass[i]);
            // if (char.IsDigit(pass[i]))
            //     esValida = true;
        }        
        return esValida;
    }
}