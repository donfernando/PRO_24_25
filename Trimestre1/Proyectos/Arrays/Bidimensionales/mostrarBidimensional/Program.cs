class Program
{
    static void Main()
    {
        // Definir una tabla de tablas de caracteres
        int filas = 3;  // número de filas
        int columnas = 4;  // número de columnas
        char[][] tabla = new char[filas][];  // Array de arrays de char

        // Inicializar cada fila con el número de columnas
        for (int i = 0; i < filas; i++)
        {
            tabla[i] = new char[columnas];  // Cada fila es un array de 'columnas' caracteres
        }

        // Llenar la tabla con datos
        char valor = 'A';  // Empezamos con la letra 'A'
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                // Asignar un valor de char a cada celda
                tabla[i][j] = valor;
                // Incrementar el valor para que cambie la letra
                valor++;
                if (valor > 'Z') // Si excede la letra 'Z', volvemos a la 'A'
                {
                    valor = 'A';
                }
            }
        }

        // Mostrar el contenido de la tabla en consola
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(tabla[i][j] + " ");
            }
            Console.WriteLine();  // Salto de línea después de cada fila
        }
    }
}