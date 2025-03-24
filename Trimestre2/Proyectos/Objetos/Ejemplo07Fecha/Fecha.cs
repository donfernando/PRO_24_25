public class Fecha {
    public int dia {get; private set;} =1;
    public int mes {get; private set;} = 1;
    public int anio {get; private set;} = 1970;

    // Array con las abreviaturas de los meses en español
    private static readonly string[] MESES = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

    // Constructor por defecto que inicializa la fecha al 1 de enero de 1970
    public Fecha() { }

    // Constructor para inicializar la fecha con valores específicos
    public Fecha(int dia, int mes, int anio) {
        if(EsValida(dia,mes, anio)){
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        } 
    }
    // Método para incrementar la fecha en un día
    public void Incrementar() {
             // Incrementa el día
            dia++;
            // Verifica si el día es mayor que el número de días del mes actual
            if (dia > DiasEnMes(mes, anio)) {
                // Pasa al siguiente mes
                dia = 1;
                mes++;
                // Si el mes es mayor que 12, pasa al siguiente año
                if (mes > 12) {
                    mes = 1;
                    anio++;
                    if (anio == 0)
                        anio=1;
                }
            }
   }

    // Método para incrementar la fecha en un número específico de días
    public void Incrementar(int dias) {
        for (int i = 0; i < dias; i++)
            Incrementar();
    }

    // override object.Equals
    public override bool Equals(object? obj) {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Fecha otra = (Fecha) obj;
        return dia==otra.dia && mes==otra.mes && anio==otra.anio ;
    }
    
    // override object.GetHashCode
    public override int GetHashCode() {
        return (dia,mes,anio).GetHashCode();
    }
   
    // ... para comparar dos fechas
    // public int CompareTo(Fecha f) {
    //     if (anio < f.anio) return -1;
    //     else if (anio > f.anio) return 1;
    //     else
    //     {
    //         if (mes < f.mes) return -1;
    //         else if (mes > f.mes) return 1;
    //         else
    //         {
    //             if (dia < f.dia) return -1;
    //             else if (dia > f.dia) return 1;
    //             else return 0;
    //         }
    //     }
    // }

    // Método para mostrar la fecha en formato "DD-MMM-AA"
    public override string ToString() {
        return $"{dia:D2}-{MESES[mes - 1]}-{anio % 100:D2}";
    }

    // Método auxiliar para obtener el número de días en el mes actual
    private static int DiasEnMes(int mes, int anio) {
        if (mes == 2) {
            // Verifica si el año es bisiesto
            if (EsBisiesto(anio))
                return 29;
            else
                return 28;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            return 30;
        else
            return 31;
    }

    // Método auxiliar para verificar si un año es bisiesto
    private static bool EsBisiesto(int anio)  {
        return anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0;
    }

    private static bool EsValida(int dia, int mes, int anio)  {
        return  mes >=1 && mes <= 12 && anio != 0 && dia>=1 && dia <= DiasEnMes(mes,anio);
    } 
}