using System;
using System.Collections.Generic;
using System.Linq;

public class SopaLetras {

    Random random = new Random();

    private char[,] tablero;
    private List<Palabra> palabras = new List<Palabra>();
    private bool estaCompleto = false;

    public SopaLetras(int filas, int columnas) {
        filas = Math.Max(5, filas);
        columnas = Math.Max(5, columnas);
        tablero = new char[filas, columnas];
    }
    public bool AñadirPalabra(string palabra){
        //return AñadirPalabra(palabra, Direccion.dir[random.Next(8)]);

        // Direcciones básicas
        return AñadirPalabra(palabra, Direccion.dir[random.Next(4)]);
    }

    public bool AñadirPalabra(string palabra, int filaInicio, int columnaInicio, int filaFin, int columnaFin)
    {
        if (estaCompleto) return false;

        Palabra nuevaPalabra = new Palabra(
            palabra, 
            new Posicion(filaInicio, columnaInicio), 
            new Posicion(filaFin, columnaFin)
        );
        if (!EsPosicionValida(nuevaPalabra)) return false;

        palabras.Add(nuevaPalabra);
        ColocarPalabraEnTablero(nuevaPalabra);
        return true;
    }

public bool AñadirPalabra(string palabra, Direccion direccion)
{
    if (estaCompleto || string.IsNullOrEmpty(palabra))
        return false;
    int intentos = 0;
    const int maxIntentos = 1000;

    while (intentos < maxIntentos)
    {
        int filaInicio,columnaInicio;
        if(direccion.Y>0){
            filaInicio = random.Next(tablero.GetLength(0)/2);
        }
        else if(direccion.Y<0)
            filaInicio = random.Next(tablero.GetLength(0)/2)+tablero.GetLength(0)/2;
        else
            filaInicio = random.Next(tablero.GetLength(0));

        if(direccion.X>0){
            columnaInicio = random.Next(tablero.GetLength(0)/2);
        }
        else if(direccion.X<0)
            columnaInicio = random.Next(tablero.GetLength(0)/2)+tablero.GetLength(0)/2;
        else
            columnaInicio = random.Next(tablero.GetLength(0));

        int filaFin = filaInicio + direccion.Y * (palabra.Length - 1);
        int columnaFin = columnaInicio + direccion.X * (palabra.Length - 1);

        if (EsPosicionValida(filaInicio, columnaInicio, filaFin, columnaFin, palabra))
            return AñadirPalabra(palabra, filaInicio, columnaInicio, filaFin, columnaFin);
        intentos++;
    }
    Console.WriteLine($"{palabra} no se pudo colocar.");
    return false;
}

private bool EsPosicionValida(int filaInicio, int columnaInicio, int filaFin, int columnaFin, string palabra)
{
    if (filaFin < 0 || filaFin >= tablero.GetLength(0) ||
        columnaFin < 0 || columnaFin >= tablero.GetLength(1))
    {
        return false;
    }

    int deltaFila = Math.Sign(filaFin - filaInicio);
    int deltaColumna = Math.Sign(columnaFin - columnaInicio);

    int fila = filaInicio;
    int columna = columnaInicio;

    foreach (char letra in palabra)
    {
        if (fila < 0 || fila >= tablero.GetLength(0) ||
            columna < 0 || columna >= tablero.GetLength(1))
        {
            return false;
        }

        if (tablero[fila, columna] != '\0' && tablero[fila, columna] != letra)
        {
            return false;
        }

        fila += deltaFila;
        columna += deltaColumna;
    }

    return true;
}

    private bool EsPosicionValida(Palabra palabra) {
        // Implementar lógica para verificar si la posición es válida
        
        return true; // Placeholder
    }

    private void ColocarPalabraEnTablero(Palabra palabra) {
        int deltaFila = Math.Sign(palabra.Fin.Fila - palabra.Inicio.Fila);
        int deltaColumna = Math.Sign(palabra.Fin.Columna - palabra.Inicio.Columna);

        int fila = palabra.Inicio.Fila;
        int columna = palabra.Inicio.Columna;

        foreach (char letra in palabra.Texto) {
            tablero[fila, columna] = letra;
            fila += deltaFila;
            columna += deltaColumna;
        }
    }

    public void Completar() {
        if (estaCompleto) return;

        for (int f = 0; f < tablero.GetLength(0); f++)
            for (int c = 0; c < tablero.GetLength(1); c++)
                if (tablero[f, c] == '\0')
                    tablero[f, c] = (char)('a' + random.Next(26));
        estaCompleto = true;
    }

    public bool Descubrir(int filaInicio, int columnaInicio, int filaFin, int columnaFin) {
        Palabra palabraEncontrada = null;
        int i = 0;
        while (i < palabras.Count && palabraEncontrada == null) {
            Palabra palabra = palabras[i];
            if (palabra.Inicio.Fila == filaInicio && 
                palabra.Inicio.Columna == columnaInicio &&
                palabra.Fin.Fila == filaFin && 
                palabra.Fin.Columna == columnaFin)
            {
                palabraEncontrada = palabra;
            }
            i++;
        }
        if (palabraEncontrada == null) return false;
        int deltaFila = Math.Sign(filaFin - filaInicio);
        int deltaColumna = Math.Sign(columnaFin - columnaInicio);

        int fila = filaInicio;
        int columna = columnaInicio;

        do {
            tablero[fila, columna] = char.ToUpper(tablero[fila, columna]);
            fila += deltaFila;
            columna += deltaColumna;
        } while (fila != filaFin + deltaFila || columna != columnaFin + deltaColumna);
        return true;
    }

    public void Resolver() {
        foreach (Palabra palabra in palabras) {
            Descubrir(palabra.Inicio.Fila, palabra.Inicio.Columna, palabra.Fin.Fila, palabra.Fin.Columna);
        }
    }

    public override string ToString() {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int f = 0; f < tablero.GetLength(0); f++) {
            for (int c = 0; c < tablero.GetLength(1); c++) {
                sb.Append(tablero[f, c]).Append(' ');
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }

}
