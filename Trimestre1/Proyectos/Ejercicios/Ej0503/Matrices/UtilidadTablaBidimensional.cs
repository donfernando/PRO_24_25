public class UtilidadTablaBidimensional
{
    public static double[,] RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int filas, int columnas)
    {
        // // Comprobamos si las coordenadas de inicio son válidas
        // if (inicioFila < 0 || inicioColumna < 0 || inicioFila >= filasOriginal || inicioColumna >= columnasOriginal)
        // {
        //     throw new ArgumentOutOfRangeException("Las coordenadas de inicio están fuera de los límites de la matriz original.");
        // }

        // // Comprobamos si el tamaño del trozo excede las dimensiones de la matriz original
        // if (inicioFila + filas > filasOriginal || inicioColumna + columnas > columnasOriginal)
        // {
        //     throw new ArgumentOutOfRangeException("El tamaño del trozo excede las dimensiones de la matriz original.");
        // }

        // Creamos la nueva matriz para el trozo
        double[,] matrizRecortada = new double[filas, columnas];

        // Copiamos los elementos de la matriz original a la nueva matriz
        for (int i = 0; i < matrizOriginal.GetLength(0); i++)
        {
            for (int j = 0; j < matrizOriginal.GetLength(1); j++)
            {
                matrizRecortada[i, j] = matrizOriginal[inicioFila + i, inicioColumna + j];
            }
        }

        return matrizRecortada;
    }
}